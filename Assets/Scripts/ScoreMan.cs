using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMan : MonoBehaviour
{
    public Text scoreText;
    public GameObject player;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = player.gameObject.GetComponent<ScoreKeeper>().score;
        scoreText.text = "Score: " + score;
    }
}
