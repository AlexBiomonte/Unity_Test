using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rotateSpeed = 45;
    void Update()
    {

        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
