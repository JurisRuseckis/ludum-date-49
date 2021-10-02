using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameDialog : MonoBehaviour
{
    public string nextLevel;
    void Start()
    {
        var btnBackToMenu = GameObject.Find("BtnMenu").GetComponent<Button>();
        btnBackToMenu.onClick.AddListener(BackToMenu);
    }
    void BackToMenu(){
        SceneManager.LoadScene("main_menu");
    }
}
