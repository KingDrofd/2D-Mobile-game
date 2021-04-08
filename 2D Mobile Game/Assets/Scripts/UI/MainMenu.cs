using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    private void Start()
    {
        FindObjectOfType<SoundManager>().Play("MenuMusic");
        
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Level_Easy");
        FindObjectOfType<SoundManager>().Stop("MenuMusic");
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
