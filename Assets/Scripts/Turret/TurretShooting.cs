using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float shootInterval;
    [SerializeField] private TurretBulletPool bulletPool;

    private float lastShootTime;

    public void Shoot()
    {
        if (Time.time >= lastShootTime + shootInterval)
        {
            bulletPool.GetBullet();
            lastShootTime = Time.time;
        }
    }
}
