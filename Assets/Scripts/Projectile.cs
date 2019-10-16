using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projSpawn, banana;
    public float launchSpeed;
    private float vx, vy;
    public Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        vx = Input.GetAxisRaw("Horizontal");
        vy = rigidbody.velocity.y;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clone;

            clone = Instantiate(banana, transform.position, transform.rotation);
            clone.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(vx + launchSpeed, vy + launchSpeed, 0);
        }
    }
}
