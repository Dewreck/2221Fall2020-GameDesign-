using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class PlayerJump : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 velocity;
    public float gravity = 10f, jumpPower = 10f;
    private float yVar;

    private void Update()
    {
        if (!controller.isGrounded)
        {
            velocity.y -= gravity * Time.deltaTime;
        }
        
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            velocity.y = jumpPower;
        }
    }
}
