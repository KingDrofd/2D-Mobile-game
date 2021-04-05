using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    
    public GameObject PauseMenuUI;
    
    public static bool isPaused = false;

    public void Resume()
    {
        Cursor.visible = false;
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    void Pause()
    {
        Cursor.visible = true;
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }    
   public void Quit()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Score.scoreValue = 0;
        isPaused = false;
        gameObject.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
                if (isPaused)
                {
                    Resume();
                }
                else if (!isPaused && GameOverScreen.isGOverScreen == false)
                {
                    Pause();
                }
            
        }
    }
}
