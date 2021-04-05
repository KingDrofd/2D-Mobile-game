using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    private void Start()
    {
        
        FindObjectOfType<SoundManager>().Stop("in Game");
        FindObjectOfType<SoundManager>().Play("Main Menu");
        
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Level_Easy");
        FindObjectOfType<SoundManager>().Play("in Game");

        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
