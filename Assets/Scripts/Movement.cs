using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed = 1;
    private bool gotInput = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(1, 0, 0) * Speed * Time.deltaTime, ForceMode.VelocityChange);
            gotInput = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-1, 0, 0) * Speed * Time.deltaTime, ForceMode.VelocityChange);
            gotInput = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, 0, 1) * Speed * Time.deltaTime, ForceMode.VelocityChange);
            gotInput = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(0, 0, -1) * Speed * Time.deltaTime, ForceMode.VelocityChange);
            gotInput = true;
        }

        if (!gotInput)
        {
            rb.velocity = Vector3.zero;
        }
    }
}
