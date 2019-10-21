using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projSpawn, banana;
    public float launchSpeed;
    private float vx, vy;
    public Rigidbody2D rigidbody;
    public float maxProjNum;

    // Start is called before the first frame update
    void Start()
    {

    }

    void destroyProjectile()
    {
        Destroy(gameObject, 3);
        maxProjNum -= 1;
    }

    // Update is called once per frame
    void Update()
    {
        vx = Input.GetAxisRaw("Horizontal");
        vy = rigidbody.velocity.y;

        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.J))
        {
            GameObject clone;

            clone = Instantiate(banana, transform.position, transform.rotation);
            clone.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(vx + launchSpeed, vy + launchSpeed, 0);
            
        }
    }
}
