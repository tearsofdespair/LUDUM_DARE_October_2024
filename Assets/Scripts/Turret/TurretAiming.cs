using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAiming : MonoBehaviour
{
    [SerializeField] public Transform target { get; private set; }
    [SerializeField] private float rotationSpeed;

    private void Update()
    {
        if (target != null)
        {
            AimAtTarget();
        }
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    private void AimAtTarget()
    {
        Vector3 direction = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);
    }
}