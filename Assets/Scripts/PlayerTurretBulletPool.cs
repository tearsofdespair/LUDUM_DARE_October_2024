using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurretBulletPool : MonoBehaviour
{
    [SerializeField] private PlayerBullet bulletPrefab;
    [SerializeField] private int poolSize;
    [SerializeField] public int damageBullet;
    [SerializeField] public Transform firePoint;
    [SerializeField] public TurretAiming turretAiming;

    private List<PlayerBullet> pool = new List<PlayerBullet>();

    public void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            InstantiateBullet(firePoint.transform.position);
        }
    }

    public PlayerBullet InstantiateBullet(Vector2 position)
    {
        PlayerBullet newBulletObject = Instantiate(bulletPrefab, position, transform.rotation);
        newBulletObject.gameObject.SetActive(false);
        pool.Add(newBulletObject);
        return newBulletObject;
    }

    public PlayerBullet GetBullet()
    {
        foreach (PlayerBullet bullet in pool)
        {
            if (!bullet.gameObject.activeInHierarchy)
            {
                bullet.gameObject.transform.position = firePoint.position;
                bullet.gameObject.SetActive(true);
                bullet.Damage = damageBullet;
                bullet.vectorBetweenPoints = turretAiming.target.position - firePoint.position;
                bullet.vectorBetweenPoints.Normalize();
                return bullet;
            }
        }
        return InstantiateBullet(Vector2.zero);
    }
}
