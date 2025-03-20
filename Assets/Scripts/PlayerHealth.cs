using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int points = 5;

    public Vector3 respawnPos;
    public TMP_Text healthText;
    public ScreenAnimation gameOverScreen;

    private void Start()
    {
        healthText.text = $"<b>Health:</b> {points}";
        respawnPos = transform.position;
       
    }

    public void OnTriggerEnter(Collider other)
    {

        // only destory if object collided has "Collectable" Tag
        if (other.CompareTag("Trap"))
        {
            damage(1);
            Debug.Log(points + "points left");
        }

        if (other.CompareTag("Checkpoint"))
        {
            respawnPos = other.transform.position;
            respawnPos.y = transform.position.y;

            Destroy(other.gameObject);
        }
    }

    //To remove some health points
    private void damage(int value)
    {
        
        points = points - value;
        respawn(); 
        healthText.text = $"<b>Health:</b> {points}";


        if (points < 1)
        {
            //Add a Respawn function (Resets player pos, Reset player Points) 
            gameOverScreen.StartFade();
           
            Destroy(gameObject);

        }

    }

    private void respawn()
    {

        transform.position = respawnPos;

    }




  


}
