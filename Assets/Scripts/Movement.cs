using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed = 1;
    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 tempVec = new Vector3(h, v, 0);
        tempVec = tempVec.normalized * Speed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVec);
    }
}
