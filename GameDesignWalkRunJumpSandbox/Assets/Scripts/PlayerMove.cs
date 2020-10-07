using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour
{
    private CharacterController controller;
    
    public float walkSpeed, fastSpeed;
    private float speed;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = fastSpeed;
        }
        else
        {
            speed = walkSpeed;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * (Time.deltaTime * speed));

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        
    }
}
