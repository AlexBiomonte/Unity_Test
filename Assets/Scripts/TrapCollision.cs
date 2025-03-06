using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCollision : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {

        Debug.Log("hit");
        //Destroy(other.gameObject);


    }
}
