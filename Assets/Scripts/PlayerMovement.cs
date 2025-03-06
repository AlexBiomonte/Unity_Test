using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //Vars go before Methods
    // int ( Whole Numbers),float (decimal), string (Text), bool (T/f)

    public int health = 100;
    public float speed = 4.5f; //float vars have to be followed with f
    public string hero = "Jimbo"; // gotta use "" for String
    public bool isAlive = true;

    //XYZ Coordinates
    public Vector3 direction;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is " + hero + " and i got " + health + " health");
    }

    // Update is called once per frame
    void Update()
    {
        //Dot (.) is there to access the a funciontality of "transfrom" 

        transform.Translate(direction * Time.deltaTime * speed);

    }


    private void OnMove(InputValue value)
    {
        //asks the input system what keys are being pressed
        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(inputValue.x , 0 , inputValue.y); 

    }


}
