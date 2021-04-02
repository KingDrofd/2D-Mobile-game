using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileMovement : MonoBehaviour
{
    public Rigidbody2D projectileRb;
  

    public float projectileSpeed = 10f;
    void Start()
    {
        projectileRb = GetComponent<Rigidbody2D>();

        projectileRb.velocity = transform.up * projectileSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        EnemyController enemy = collision.collider.GetComponent<EnemyController>();
        if (enemy != null)
        {
            enemy.DamageEnemy(1);
        }
        
    }
    void Update()
    {
        
    }
}
