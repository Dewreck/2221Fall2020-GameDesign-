using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public float walkSpeed = 20f, runSpeed = 50f;
    private float speed;

    public Rigidbody rBody;
    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = runSpeed;
        }
        else
        {
            speed = walkSpeed;
        }
        
        float lateralMove = Input.GetAxis("Horizontal");
        float vertMove = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(lateralMove, 0, vertMove) * (speed * Time.fixedDeltaTime);
        rBody.MovePosition(transform.position + movement);
    }
}
