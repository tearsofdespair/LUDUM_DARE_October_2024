using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunRotation : MonoBehaviour
{
    [SerializeField] public Camera mainCamera;
    [SerializeField] private HandGunBulletPool pool;

    void FixedUpdate()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, transform.position);

        float hitDistance;
        if (plane.Raycast(ray, out hitDistance))
        {
            Vector3 mousePosition = ray.GetPoint(hitDistance);
            Vector3 direction = mousePosition - transform.position;
            pool.direction = direction;
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = lookRotation;
        }
    }
}
