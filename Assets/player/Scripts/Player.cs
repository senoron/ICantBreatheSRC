using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5f;
    private Vector2 movenment;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        InputAxis();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void InputAxis()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (moveInput.x < 0 && transform.localScale.x > 0) {transform.localScale = new Vector3(-1f, 1, 0);}
        else if(moveInput.x > 0 && transform.localScale.x < 0){transform.localScale = new Vector3(1f, 1, 0);}
        movenment = moveInput * playerSpeed;
    }
    
    void Move()
    {
        rb.MovePosition(rb.position + movenment * Time.deltaTime);
    }
}
