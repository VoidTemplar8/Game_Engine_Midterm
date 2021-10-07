using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 direction;
    public float speed = 8;

    public float jumpForce = 10;
    public Transform groundDetect;
    public float gravity = -30;
    public LayerMask ground;

    private bool BoolGravity = true;

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        direction.x = hInput * speed; //x axis movement
        direction.y += gravity * Time.deltaTime; //gravity

        if (BoolGravity == true) //gravity toggle
        {
            gravity = -30;
        }
        else
        {
            gravity = 0;
        }


        bool onGround = Physics.CheckSphere(groundDetect.position, 0.15f, ground);
        if(onGround) // if on the ground, and if w is pressed, jump.
        {
          if (Input.GetKeyDown("space")) //jump
          {
             direction.y = jumpForce;
          }

        }
        controller.Move(direction * Time.deltaTime);  
    }

    public void ToggleGravity()
    {
        if (BoolGravity == true)
        {
            BoolGravity = false;
            return;
        }
        
        if(BoolGravity == false)
        {
            BoolGravity = true;
            return;
        }
    }
}
