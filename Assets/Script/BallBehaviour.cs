using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] float initialForce = 2f;
    [SerializeField] float maxRangeForDirection = 20f;
    [SerializeField] Vector3 initialDirection = Vector3.forward;
    [SerializeField] Vector2 afterBounceVelocityminmax;
    [SerializeField] float upwardsBounceForce = 10f;
    
    public Rigidbody rb;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = FindObjectOfType<Transform>();
        initialDirection = new Vector3(Random.Range(1f, maxRangeForDirection), Random.Range(1f, maxRangeForDirection), Random.Range(1f, maxRangeForDirection));
        rb.AddForce(initialDirection.normalized * initialForce);
    }

    
    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Wall"))
        {
            rb.velocity = (player.transform.position - transform.position).normalized * Random.Range(afterBounceVelocityminmax.x, afterBounceVelocityminmax.y);
        }
        if(collision.gameObject.CompareTag("Ground"))
        {
            rb.AddForce(transform.up * upwardsBounceForce);
        }
    }
}