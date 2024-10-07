using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float lifetime;
    [SerializeField] private LayerMask EnemyLayer;
    [SerializeField] private LayerMask PlayerLayer;
    [HideInInspector] public Vector3 vectorBetweenPoints { get; set; }
    public int Damage;
    private float currentLifeTime;

    void Start()
    {
        currentLifeTime = lifetime;
    }

    void Update()
    {
        Vector3 currentPosition = transform.position;
        Vector3 newPosition = currentPosition + vectorBetweenPoints.normalized * speed * Time.deltaTime;

        transform.position = newPosition;

        currentLifeTime -= Time.deltaTime;

        if (currentLifeTime <= 0)
        {
            DestroyBullet();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == EnemyLayer)
        {
            collision.gameObject.GetComponent<EnemyHealthSystem>().TakeDamage(Damage);
        }
        DestroyBullet();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (((1 << other.gameObject.layer) & EnemyLayer) != 0)
        {
            other.gameObject.GetComponent<EnemyHealthSystem>().TakeDamage(Damage);
            DestroyBullet();
        }
        else if (((1 << other.gameObject.layer) & PlayerLayer) != 0 && other.gameObject != gameObject)
        {
            other.gameObject.GetComponent<PlayerHealthSystem>().TakeDamage(Damage);
            DestroyBullet();
        }

    }

    public void DestroyBullet()
    {
        ResetLifeTime();
        gameObject.SetActive(false);
    }

    public void ResetLifeTime()
    {
        currentLifeTime = lifetime;
    }
}