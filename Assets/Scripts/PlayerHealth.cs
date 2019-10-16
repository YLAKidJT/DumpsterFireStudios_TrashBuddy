using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int lives;
    public GameObject playerSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            lives -= 1;
            gameObject.transform.position = playerSpawn.transform.position;
            gameObject.transform.rotation = playerSpawn.transform.rotation;
        }
    }
}
