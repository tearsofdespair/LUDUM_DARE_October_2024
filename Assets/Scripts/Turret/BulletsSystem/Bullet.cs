using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float lifetime;

    [HideInInspector] public Vector3 vectorBetweenPoints { get; set; }
    [HideInInspector] public int Damage { private get; set; }
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
        DestroyBullet();
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