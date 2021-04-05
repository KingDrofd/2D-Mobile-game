using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster GM;

    private void Awake()
    {
        if (GM == null)
        {
            GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        }


        
    }
   
    
    public static void KillPlayer(CharacterController Player)
    {
        Destroy(Player.gameObject);
    }

    
    public static void KillEnemy(EnemyController Enemy)
    {
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
