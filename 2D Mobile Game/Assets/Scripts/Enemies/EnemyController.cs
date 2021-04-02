using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 20f;
    protected Rigidbody2D enemyRb;
    Vector2 moveDirection;
    public int enemyHp = 1;
    public int dmg = 1;
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        
        enemyRb.velocity = -transform.up * moveSpeed;
    }

    public void DamageEnemy(int Damage)
    {
        enemyHp -= enemyHp;
        if(enemyHp <= 0)
        {
            GameMaster.KillEnemy(this);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        CharacterController player = collision.collider.GetComponent<CharacterController>();
        if (player != null)
        {
            player.DamagePlayer(1);
            Debug.Log("dead");
        }
        
    }
}
