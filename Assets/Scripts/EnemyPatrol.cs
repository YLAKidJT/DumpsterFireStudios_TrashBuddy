using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    private float speed;
    public float distance, patrolSpeed, chaseSpeed, recycleTime;
    private bool movingRight = true;
    public Transform groundDetection;
    public BoxCollider2D triggerCol;

    // Start is called before the first frame update
    void Start()
    {
        speed = patrolSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        /*RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);

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
        }*/
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "patLimit")
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

        if (col.gameObject.tag == "Projectile")
        {
            speed = 0;
            triggerCol.enabled = false;
            StartCoroutine(RecycleDelay());
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
            speed = chaseSpeed;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
            speed = patrolSpeed;
    }

    IEnumerator RecycleDelay()
    {
        yield return new WaitForSeconds(recycleTime);
        speed = patrolSpeed;
        triggerCol.enabled = true;
    }
}
