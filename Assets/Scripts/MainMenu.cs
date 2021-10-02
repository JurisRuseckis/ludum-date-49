using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var btnStartStoryMode = GameObject.Find("BtnStartStory").GetComponent<Button>();
        Debug.Log(btnStartStoryMode);
        btnStartStoryMode.onClick.AddListener(StartStoryMode);
    }

    void StartStoryMode()
    {
        Debug.Log("starting story mode");
        SceneManager.LoadScene("level_01");
    }
}
