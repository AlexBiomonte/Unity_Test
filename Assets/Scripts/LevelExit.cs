using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    public ScreenAnimation winScreen;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Deactivates object that collided with
            other.gameObject.SetActive(false);
            winScreen.StartFade();
           
        }


    }

        
}
