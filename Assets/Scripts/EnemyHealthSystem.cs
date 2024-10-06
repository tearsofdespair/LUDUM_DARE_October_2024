using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemyHealthSystem : MonoBehaviour
{
    [SerializeField] private EnemySettings EnemySettings;
    private float ActualHealth;

    private void Awake()
    {
        ActualHealth = EnemySettings.HealthPoints;
    }

    public void Update()
    {
        if(ActualHealth <= 0)
            Destroy(gameObject);
    }

    public void FixedUpdate()
    {
        ActualHealth -= 2;
    }

}
