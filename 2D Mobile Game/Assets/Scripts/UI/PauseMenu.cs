using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [HideInInspector]
    SoundManager sound;

    public GameObject PauseMenuUI;
    
    public static bool isPaused = false;
    private void Start()
    {
        sound = FindObjectOfType<SoundManager>();
    }
    public void Resume()
    {
        
        
        Cursor.visible = false;
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void Pause()
    {
        sound.Stop("In Game");
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
        gameObject.SetActive(false);
        isPaused = false;
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
