using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed, distance, sideDistance, chaseSpeedMod;
    private bool movingRight = true;
    public Transform groundDetection, playerRef;

    // Start is called before the first frame update
    void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float chaseSpeed;
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        RaycastHit2D rightInfo = Physics2D.Raycast(transform.position, Vector2.right, sideDistance);

        if (groundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }

        if(rightInfo.collider.gameObject.tag == "Player")
        {
            chaseSpeed = chaseSpeedMod;
            Debug.Log("Chasing");
        }
        else
        {
            chaseSpeed = 1;
        }

        transform.Translate(Vector2.right * speed * chaseSpeed * Time.deltaTime);
    }
}
