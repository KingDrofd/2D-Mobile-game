using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float moveSpeed = 2f;
    public float thrust = 600f;
    protected Rigidbody2D rb;
    public Joystick joystick;
    Vector2 rbMovement;
    public GameObject isGrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        rbMovement.x = joystick.Horizontal;
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(transform.up * thrust);
        }

        rb.velocity = new Vector2(rbMovement.x * moveSpeed, 0);
    }
}
