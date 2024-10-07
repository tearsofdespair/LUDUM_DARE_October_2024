using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunShooting : MonoBehaviour
{
    [SerializeField] private HandGunBulletPool bulletPool;

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        bulletPool.GetBullet();
    }
}
