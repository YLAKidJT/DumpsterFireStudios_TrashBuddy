using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float lives;
    public GameObject playerSpawn;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        {
            SceneManager.LoadScene(4);
        }
    }

    /* void OnCollisionEnter2D (Collision2D col)
     {
         if (col.gameObject.tag == "Enemy")
         {
             lives -= 1;
             gameObject.transform.position = playerSpawn.transform.position;
             gameObject.transform.rotation = playerSpawn.transform.rotation;
         } 
     }*/
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag=="playerDetect")
        {
            lives -= 0.5f;
            gameObject.transform.position = playerSpawn.transform.position;
            gameObject.transform.rotation = playerSpawn.transform.rotation;
        }
    }
}
