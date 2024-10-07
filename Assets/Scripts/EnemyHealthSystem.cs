using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemyHealthSystem : MonoBehaviour
{
    [SerializeField] private EnemySettings EnemySettings;
    [SerializeField] private LootBag LootBag;
    private float ActualHealth;

    private void Awake()
    {
        ActualHealth = EnemySettings.HealthPoints;
    }

    public void Update()
    {
        if (ActualHealth <= 0)
        {
            Die();
        }
            
    }
    
    private void Die()
    {
        LootBag.InstantiateLoot(transform.position);
        Destroy(gameObject);
    }

    public void FixedUpdate()
    {
        ActualHealth -= 2;
    }

}
