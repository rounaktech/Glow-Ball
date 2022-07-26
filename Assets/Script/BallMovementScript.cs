using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementScript : MonoBehaviour
{
    private Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;
    public float speed = 10.0f;
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        horizontalInput = joystick.Horizontal;
        verticalInput = Input.GetAxisRaw("Vertical");
        verticalInput = joystick.Vertical;
    }

    private void FixedUpdate()
    {
        //rb.AddForce(Vector3.right);
        rb.AddForce(new Vector3(horizontalInput, 0.0f, verticalInput) * speed );
    }
}