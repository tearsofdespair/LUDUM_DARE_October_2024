using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConfig
{
    public float Speed;
    public Rigidbody Rigidbody;

    public PlayerConfig(float speed, Rigidbody rigidbody)
    {
        Speed = speed;
        Rigidbody = rigidbody;
    }
}
