using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public Rigidbody2D projectileRb;
    public int Damage;
    [HideInInspector]
    SoundManager sound;


    public float projectileSpeed = 10f;
    void Start()
    {
        sound = FindObjectOfType<SoundManager>();
        Debug.LogWarning("Shot", gameObject);
        sound.Play("Shot");
        projectileRb = GetComponent<Rigidbody2D>();
        projectileRb.velocity = transform.up * projectileSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(gameObject);
        EnemyController enemy = collision.collider.GetComponent<EnemyController>();
        if (enemy != null)
        {
            enemy.DamageEnemy(Damage);
            sound.Play("EnemyHit");
        }
        
    }
   
}
