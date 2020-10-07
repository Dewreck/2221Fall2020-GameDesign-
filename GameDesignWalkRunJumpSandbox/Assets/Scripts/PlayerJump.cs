using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

[RequireComponent(typeof(CharacterController))]
public class PlayerJump : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 velocity;
    public float gravity = 10f, jumpPower = 10f, maxJumpCount = 2f;
    private float yVar, jumpCount;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (!controller.isGrounded)
        {
            velocity.y -= gravity * Time.deltaTime;
        }
        
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && jumpCount<maxJumpCount)
        {
            jumpCount++;
            velocity.y = jumpPower;
        }

        if (controller.isGrounded)
        {
            jumpCount = 1f;
        }
    }
}
