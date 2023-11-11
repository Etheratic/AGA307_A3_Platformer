using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : GameBehaviour
{


    public CharacterController controller;
    public float speed = 10f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public GameObject player;

    //know when we are touching the ground
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private Vector3 velocity;
    private bool isGrounded;

   

    private void Start()
    {
        
    }

    void Update()
    {
        //checks if we are touching the ground
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
            velocity.y = -2f;

        //checks input for player
        float x = Input.GetAxis("Horizontal");

        //move the player
        Vector3 move = transform.right * x;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

       
            


    }

    //triying to get the drop through panels working

    //private void OnCollisionStay(Collision collision)
    //{

    //    if(collision.gameObject.CompareTag("DropThroughPlatform") && (Input.GetKeyDown(KeyCode.S)))
    //    {
    //        collision.gameObject.GetComponent<Collider>().enabled = false;
    //    }

        
    //}
}

       
