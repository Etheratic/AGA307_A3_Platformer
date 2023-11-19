using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Singleton<PlayerMovement>
{


    public CharacterController controller;
    public float speed = 10f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public GameObject player;
    public float dashSpeed = 100;
    public float dashLength = 1;

    //know when we are touching the ground
    public Transform groundCheck;
    public Transform roofCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public Transform myChildObject;
    public bool detachChild;

    public Vector3 velocity;
    public bool isGrounded;
    public bool isRoof;

    

   

    private void Start()
    {
       // gameObject.tag = "player";
    }

    void Update()
    {
        //checks if we are touching the ground
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        isRoof = Physics.CheckSphere(roofCheck.position, groundDistance, groundMask);

        if ((isGrounded && velocity.y < 0) || (isRoof && velocity.y > 0))
        {
            velocity.y = -2f;

        }
           

        if(velocity.y < -50)
            velocity.y = -10f;

        //checks input for player
        float x = Input.GetAxis("Horizontal");

        //move the player
        Vector3 move = transform.right * x;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            Jump(jumpHeight);

        if (isGrounded == false)
            velocity.y += gravity * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Mouse1))
            StartCoroutine(Dash());


        
        controller.Move(velocity * Time.deltaTime);

       if(detachChild == true)
        {
            myChildObject.parent = null;
        }
            


    }

    public void Jump(float _jumpHeight)
    {
        velocity.y = Mathf.Sqrt(_jumpHeight * -2f * gravity);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "DropThroughPlatform")
        {
            print("collision");
            velocity.y = 0;
        }
    }

    IEnumerator Dash()
    {
        speed = speed * dashSpeed;
        yield return new WaitForSeconds(dashLength);
        speed = speed / dashSpeed;


    }

    public void KnockBack()
    {
        StartCoroutine(Back());
    }

    IEnumerator Back()
    {
        speed = speed * -dashSpeed;
        yield return new WaitForSeconds(dashLength);
        speed = speed / -dashSpeed;


    }



}

       
