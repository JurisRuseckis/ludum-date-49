using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Update is called once per frame
    private float waitTime = 2.0f;
    private float timer = 0.0f;
    private bool gameFinished = false; 
    public GameObject victoryPanel;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(string.Format("Co-ords of mouse is [X: {0} Y: {0}]", pos.x, pos.y));
            
        }
        
        timer += Time.deltaTime;

        if(timer > waitTime && !gameFinished) {
        
            victoryPanel.SetActive(true);
            gameFinished = true;  
        }

        // check if all winning conditions are met (if deathmatch then there is no winning conditions only losing)
        // pause game/show winning screen
        // back/next level
        // check if single losing condition is met 
        // pause game show losing screen 
        // back/restart
    }
    void EndGame()
    {
        Debug.Log("Game");
    }
}
