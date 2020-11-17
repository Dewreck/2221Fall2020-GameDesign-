using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMoveBehavior : MonoBehaviour
{
    private CharacterController controller;
            private Vector3 velocity;
            public float gravity = 10f, jumpPower = 10f, maxJumpCount = 2f, walkSpeed = 5f, fastSpeed = 10f;
            private float yVar, jumpCount, speed;
        
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
