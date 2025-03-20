using System.Collections;
using UnityEngine;

public class FireballShooter : MonoBehaviour
{
    public GameObject fbPrefab;
    public float spawnTimer = 1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        StartCoroutine(SpawnFireballRoutine());


    }

    private IEnumerator SpawnFireballRoutine()
    {

        while (true)
        {

            yield return new WaitForSeconds(spawnTimer);

            Instantiate(fbPrefab,transform.position,transform.rotation);

        }





    }


}
