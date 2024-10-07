using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float Force;
    public float Attack;
    public Rigidbody Rigidbody;
    private Transform player;
    private float LifeTime;
    private Vector3 _direction;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        
         _direction = transform.position - player.transform.position;
        
    }

    private void Update()
    {
        Rigidbody.velocity = _direction.normalized * Force * Time.deltaTime;
    }
}
