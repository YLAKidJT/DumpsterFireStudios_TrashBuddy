using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject enemy = GameObject.Find("Enemy");
            EnemyPatrol patrolScript = enemy.GetComponent<EnemyPatrol>();
            patrolScript.speed = patrolScript.chaseSpeed;
        }
    }

    void OnTriggerExit2D (Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject enemy = GameObject.Find("Enemy");
            EnemyPatrol patrolScript = enemy.GetComponent<EnemyPatrol>();
            patrolScript.speed = patrolScript.patrolSpeed;
        }
    }
}
