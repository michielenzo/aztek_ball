using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidBody;
    
    public float speed;
    public float jumpForce;
    private bool canJump = false;

    public void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        if (!canJump) return;
        canJump = false;
        _rigidBody.AddForce(Vector3.up * 1000);
    }

    public void Update()
    {
        Movement();
        Jump();
    }

    private void Jump()
    {
        if(Input.GetKeyDown("space")){
            //Debug.Log("Jump!");
            canJump = true;
        }
    }

    private void Movement()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");
        
        var movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        _rigidBody.AddForce(movement * speed);
    }
}
