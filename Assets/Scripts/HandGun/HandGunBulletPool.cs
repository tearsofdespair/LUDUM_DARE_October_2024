using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject.SpaceFighter;

public class HandGunBulletPool : MonoBehaviour
{
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] private int poolSize;
    [SerializeField] public int damageBullet;
    [SerializeField] public Transform firePoint;

    private List<Bullet> pool = new List<Bullet>();
    public Vector3 direction { private get; set; }

    public void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            InstantiateBullet(firePoint.transform.position);
        }
    }

    public Bullet InstantiateBullet(Vector2 position)
    {
        Bullet newBulletObject = Instantiate(bulletPrefab, position, transform.rotation);
        newBulletObject.gameObject.SetActive(false);
        pool.Add(newBulletObject);
        return newBulletObject;
    }

    public Bullet GetBullet()
    {
        foreach (Bullet bullet in pool)
        {
            if (!bullet.gameObject.activeInHierarchy)
            {
                bullet.gameObject.transform.position = firePoint.position;
                bullet.gameObject.SetActive(true);
                bullet.Damage = damageBullet;
                bullet.vectorBetweenPoints = direction;
                bullet.vectorBetweenPoints.Normalize();
                return bullet;
            }
        }

        Bullet newBullet = InstantiateBullet(Vector2.zero);
        newBullet.gameObject.transform.position = firePoint.position;
        newBullet.gameObject.SetActive(true);
        newBullet.Damage = damageBullet;
        newBullet.vectorBetweenPoints = direction;
        newBullet.vectorBetweenPoints.Normalize();
        return newBullet;
    }
}
