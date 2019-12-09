using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAlpha : MonoBehaviour
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
            Color tmp = gameObject.GetComponent<SpriteRenderer>().color;
            tmp.a = 0.45f;
            gameObject.GetComponent<SpriteRenderer>().color = tmp;
        }
    }

    void OnTriggerExit2D (Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Color tmp = gameObject.GetComponent<SpriteRenderer>().color;
            tmp.a = 1.0f;
            gameObject.GetComponent<SpriteRenderer>().color = tmp;
        }
    }
}
