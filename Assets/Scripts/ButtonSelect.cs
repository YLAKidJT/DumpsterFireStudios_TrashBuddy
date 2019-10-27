using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSelect : MonoBehaviour
{
    public Button levelOne;
    public Button levelTwo;
    public Button levelThree;

    public void start()
    {
        levelOne = GetComponent<Button>();
        levelOne.onClick.AddListener(Level_One);
        levelTwo = GetComponent<Button>();
        levelTwo.onClick.AddListener(Level_Two);
        levelThree = GetComponent<Button>();
        levelThree.onClick.AddListener(Level_Three);
    }

    public void Level_One()
    {
        SceneManager.LoadScene(2);
    }
    public void Level_Two()
    {
        SceneManager.LoadScene(3);
    }
    public void Level_Three()
    {
        SceneManager.LoadScene(4);
    }
}
