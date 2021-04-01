﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class CharacterController : MonoBehaviour
{
    //Variables
    
    public Vector3 touchPosition;
    public Vector3 moveDirection;

   public float moveSpeed = 20f;

    public Rigidbody2D ship;

    private void Start()
    {
        ship = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            touchPosition.y = 0;
            moveDirection = (touchPosition - transform.position);
            ship.velocity = new Vector2(moveDirection.x, 0) * moveSpeed;
            if (touch.phase == TouchPhase.Ended)
            {
                ship.velocity = Vector2.zero;
            }
        }
    }
}
