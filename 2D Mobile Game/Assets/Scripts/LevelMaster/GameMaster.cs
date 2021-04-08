using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster GM;
    [HideInInspector]
    public static SoundManager sound;

    private void Awake()
    {
        if (GM == null)
        {
            GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        }


        
    }
    private void Start()
    {
        sound = FindObjectOfType<SoundManager>();
        sound.Stop("Menu");
        sound.Play("In Game");
        
    }

    public static void KillPlayer(CharacterController Player)
    {
        sound.Play("Death");
        Destroy(Player.gameObject);
    }

    
    public static void KillEnemy(EnemyController Enemy)
    {
        sound.Play("Death");
        Destroy(Enemy.gameObject);
       

    }
    public static bool CanPause()
    {
        if (PauseMenu.isPaused == false && GameOverScreen.isGOverScreen == true)
        {
            return false;
        }
        else
        {
            return true;
        }

    }
}
