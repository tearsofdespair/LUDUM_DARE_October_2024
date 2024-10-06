using UnityEngine;
using Zenject;


public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private float Speed = 1;
    private float _horizontalAxis;
    private float _verticalAxis;

    [Inject]
    public void Construct(PlayerConfig config)
    {
        rb = config.Rigidbody;
        Speed = config.Speed;
        Debug.Log("Zenject worked for Player");
    }

    private void Update()
    {
        HandleAxis();
        /*RotatePlayer();*/
        MovePlayer();
    }

    private void HandleAxis()
    {
        _horizontalAxis = Input.GetAxis("Horizontal");
        _verticalAxis = Input.GetAxis("Vertical");
    }

    private void RotatePlayer()
    {
        transform.Rotate(_verticalAxis, _horizontalAxis, 0);
    }

    private void MovePlayer()
    {
        Vector3 tempVec = new Vector3(_horizontalAxis, 0, _verticalAxis);
        tempVec = tempVec.normalized * Speed;
        rb.MovePosition(rb.position + tempVec * Time.fixedDeltaTime);
    }

}
