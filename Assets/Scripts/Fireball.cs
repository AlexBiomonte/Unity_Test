using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Rigidbody firball_RB;
    public float speed = 5;
    public float destroyTimer = 0.6f;
    void Start()
    {
        firball_RB.linearVelocity =  transform.forward * speed; 
        Destroy(gameObject,destroyTimer);
    }

 
}
