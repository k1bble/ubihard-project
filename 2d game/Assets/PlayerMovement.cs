using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float movementSpeed = 40f;
    float horizontalMove;
    public bool lockMovement = false;
    bool jump = false;
   

    void Update()
    {
        if (!lockMovement)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * movementSpeed;
        }
        else
        {
            horizontalMove = 0f;
        }

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        
    }
    void FixedUpdate()
    {

        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);

        jump = false;
    }


}
