using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public static bool isGOverScreen = false;
    public void Setup()
    {
        
        Cursor.visible = true;
        FindObjectOfType<SoundManager>().Stop("in Game");
        Time.timeScale = 0;
        
        gameObject.SetActive(true);
        isGOverScreen = true;
    }
    public void Quit()
    {
        Application.Quit();
    }
 
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Score.scoreValue = 0;
        isGOverScreen = false;
        gameObject.SetActive(false);
    }
    public void Retry()
    {
        SceneManager.LoadScene("Level_easy");
        
        Time.timeScale = 1f;
        Score.scoreValue = 0;
        isGOverScreen = false;
        gameObject.SetActive(false);
        
        //Score.livesValue = 3;


    }
    
}
