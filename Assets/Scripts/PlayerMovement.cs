using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //Vars go before Methods
    // int ( Whole Numbers),float (decimal), string (Text), bool (T/f)


    public float speed = 4.5f; //float vars have to be followed with f
    public float jumpForce = 5f;
    public string hero = "Jimbo"; // gotta use "" for String


    //XYZ Coordinates
    public Vector3 direction;
    public Rigidbody playerRb;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is " + hero + " and i got " + " 1 health");
    }

    // Physics Loop
    void FixedUpdate()
    {
        //Dot (.) is there to access the a funciontality of "transfrom" 

        Vector3 velocity = direction * speed;
        velocity.y = playerRb.linearVelocity.y;

        playerRb.linearVelocity = velocity;

    }


    private void OnMove(InputValue value)
    {
        //asks the input system what keys are being pressed
        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(inputValue.x, 0, inputValue.y);

    }


    private void OnJump(InputValue value)
    {
        // Physcics.Raycast will Raycast a line down that can hit other colliders; 
        //If it hits a collider is there it returns true; If not, Returns False
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.6f);

        if (isGrounded)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        }

        }

    }
