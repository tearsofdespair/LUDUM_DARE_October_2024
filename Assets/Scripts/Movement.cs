using UnityEngine;


public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed = 1;
    private float _horizontalAxis;
    private float _verticalAxis;

    private void Update()
    {
        HandleAxis();
        MovePlayer();
    }

    private void HandleAxis()
    {
        _horizontalAxis = Input.GetAxis("Horizontal");
        _verticalAxis = Input.GetAxis("Vertical");
    }

    private void MovePlayer()
    {
        Vector3 tempVec = new Vector3(_horizontalAxis, 0, _verticalAxis);
        tempVec = tempVec.normalized * Speed;
        rb.MovePosition(rb.position + tempVec * Time.fixedDeltaTime);
    }

}
