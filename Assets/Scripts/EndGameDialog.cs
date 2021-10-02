using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameDialog : MonoBehaviour
{
    public string nextLevel;
    public string curentLevel;
    public Button btnBackToMenuWin;
    public Button btnNextLevelWin;
    public Button btnBackToMenuLose;
    public Button btnRestartLose;
    void Start()
    {
        btnBackToMenuWin.onClick.AddListener(BackToMenu);
        btnNextLevelWin.onClick.AddListener(NextLevel);
        btnBackToMenuLose.onClick.AddListener(BackToMenu);
        btnRestartLose.onClick.AddListener(RestartLevel);
    }
    void BackToMenu()
    {
        SceneManager.LoadScene("main_menu");
    }

    void NextLevel()
    {
        if(string.IsNullOrEmpty(nextLevel)){
            return;
        }

        SceneManager.LoadScene(nextLevel);
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(curentLevel);
    }
}
