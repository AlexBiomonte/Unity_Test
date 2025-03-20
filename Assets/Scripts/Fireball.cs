using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Rigidbody firball_RB;
    public float speed = 5;
    public float destroyTimer = 1.5f;
    void Start()
    {
        firball_RB.linearVelocity =  transform.forward * speed; 
        Destroy(gameObject,destroyTimer);
    }

 
}
