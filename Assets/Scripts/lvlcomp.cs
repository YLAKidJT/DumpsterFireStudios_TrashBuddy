using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvlcomp : MonoBehaviour
{
    public GameObject lvlCompUI;

    // Start is called before the first frame update
    void Start()
    {
        lvlCompUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        lvlCompUI.SetActive(true);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void lvlSel()
    {
        SceneManager.LoadScene(1);
    }
}
