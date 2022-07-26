using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public
class PlayerMovement : MonoBehaviour
{
    public CharacterController CC;
    public float speed = 8f;
    public float g = 2;
    public Vector3 velocity;

    public LayerMask ground;
    public bool onGround;
    public Transform CSPos;
    public float CSRadius;
    public float jumpHeight;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocity.y = jumpHeight;
        }
        onGround = Physics.CheckSphere(CSPos.position, CSRadius, ground);
        if (onGround == true)
        {
            velocity.y = -1;
        }
        else
        {
            velocity.y -= g * Time.deltaTime;
        }

        CC.Move(velocity);

        float horizontal = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float Vertical = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        CC.Move(transform.forward * horizontal);
        CC.Move(transform.right * Vertical);



    }
}

