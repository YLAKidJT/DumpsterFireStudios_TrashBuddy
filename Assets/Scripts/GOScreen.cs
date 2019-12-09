using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void lvlSelect()
    {
        SceneManager.LoadScene(1);
    }
}
