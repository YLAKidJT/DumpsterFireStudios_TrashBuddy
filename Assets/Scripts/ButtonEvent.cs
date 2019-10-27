using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
    public Button quitButton;
    public Button playButton;

    public void start()
    {
        quitButton = GetComponent<Button>();
        quitButton.onClick.AddListener(QuitGame);
        playButton = GetComponent<Button>();
        playButton.onClick.AddListener(PlayBtn);
    }

    public void PlayBtn()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
