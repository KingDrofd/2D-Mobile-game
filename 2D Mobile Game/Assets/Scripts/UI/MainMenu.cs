using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{


    public void PlayGame()
    {
        SceneManager.LoadScene("Level_Easy");
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
