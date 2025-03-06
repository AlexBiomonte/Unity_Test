using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    // Gets player/Objects Transform Data and puts it into target Var
    public Transform target;
    public float transitionSpeed;

    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        offset = target.position -  transform.position;    
    }

    // Update is called once per frame
    void Update()
    {

        //check if player exists
        if (target == null)
        {

            enabled = false;
            return; 

        }

        //Var that shows where to camera should go
        Vector3 targetPosition = target.position - offset;
        transform.position = Vector3.Lerp(transform.position,targetPosition,transitionSpeed*Time.deltaTime);
        
    }
}
