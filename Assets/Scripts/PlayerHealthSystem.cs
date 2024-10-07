using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthSystem : MonoBehaviour
{
    [SerializeField] private PlayerSettings PlayerSettings;
    private float ActualHealth;

    private void Awake()
    {
        ActualHealth = PlayerSettings.HealthPoints;
    }


    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == PlayerBulletsLayer)
        {
            ActualHealth -= collision.gameObject.GetComponent<Bullet>().Damage;
            Destroy(collision.gameObject);
        }
    }*/

    public void TakeDamage(int damage)
    {
        ActualHealth -= damage;
        Debug.Log(ActualHealth);
        if (ActualHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}

