using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed;
    public float StoppingDistance;
    public float RetreatDistance;
    public float PlayerYPosition;
    public EnemySettings settings;
    private Transform Player;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        Vector3 vector;

        if(Vector3.Distance(transform.position, Player.transform.position) > StoppingDistance)
        {
            vector = Vector3.MoveTowards(transform.position, Player.position, Speed * Time.deltaTime);
            vector.y = PlayerYPosition;
            transform.position = vector;
        } 
        else if(Vector3.Distance(transform.position, Player.transform.position) < StoppingDistance 
            && Vector3.Distance(transform.position, Player.transform.position) > RetreatDistance)
        {
            transform.position = this.transform.position;
        } 
        else if (Vector3.Distance(transform.position, Player.transform.position) < RetreatDistance)
        {
            vector = Vector3.MoveTowards(transform.position, Player.position, -Speed * Time.deltaTime);
            vector.y = PlayerYPosition;
            transform.position = vector;
        }
    }
}
