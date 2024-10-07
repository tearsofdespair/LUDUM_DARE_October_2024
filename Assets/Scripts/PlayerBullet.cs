using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float lifetime;
    [SerializeField] private LayerMask EnemyLayer;

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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == EnemyLayer)
        {
            other.GetComponent<EnemyHealthSystem>().TakeDamage(Damage);
            Destroy(gameObject);
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
