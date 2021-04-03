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
    void Start()
    {
        
    }
    public static void KillPlayer(CharacterController Player)
    {
        Destroy(Player.gameObject);
    }

    
    public static void KillEnemy(EnemyController Enemy)
    {
        Destroy(Enemy.gameObject);
    }
}
