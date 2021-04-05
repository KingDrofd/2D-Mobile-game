using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 20f;
    protected Rigidbody2D enemyRb;
    Vector2 moveDirection;

    public int ScoreValue = 10;
    public int enemyHp;
    public int dmg = 1;
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        
        enemyRb.velocity = -transform.up * moveSpeed;

        Destroy(gameObject, 10);
    }

    public void DamageEnemy(int Damage)
    {
        enemyHp -= Damage;
        if(enemyHp <= 0)
        {
            GameMaster.KillEnemy(this);
            Score.scoreValue += ScoreValue;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        CharacterController player = collision.collider.GetComponent<CharacterController>();
        if (player != null)
        {
            Destroy(this.gameObject);
            player.DamagePlayer(1);
            if (player.maxLives == 0)
            {
                Debug.Log("dead");
            }
        }
        
    }
}
