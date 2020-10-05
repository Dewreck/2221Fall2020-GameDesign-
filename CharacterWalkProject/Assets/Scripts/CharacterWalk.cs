using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterWalk : MonoBehaviour
{
    private CharacterController controller;

    public float fastSpeed, walkSpeed, gravity = -10;
    private float yVar, speed;

    private Vector3 movement;

    private void Start()
    {
        speed = walkSpeed;
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Walk();
        
        

    }

    private void Walk()
    {
        float vInput = Input.GetAxis("Vertical") * speed;
        float hInput = Input.GetAxis("Horizontal") * speed;
        movement = transform.forward * vInput + transform.right * hInput;
        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }
}
