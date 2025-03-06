using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    private int score = 0;
    public TMP_Text scoreText;

    private void Start()
    {
        scoreText.text = $"<b>Score:</b> {score}";
    }
    public void OnTriggerEnter(Collider other)
    {
       
        // only destory if object collided has "Collectable" Tag
        if (other.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
            score++;
            scoreText.text = $"<b>Score:</b> {score}";
        }

    }
}
