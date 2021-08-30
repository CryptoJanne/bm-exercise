using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Animator _anim;
    private Rigidbody2D _rb2d;
    private Vector2 lastMoveDir;
    [SerializeField] private int speed;

    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = +1f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveX = +1f;
        }

        Vector3 direction = new Vector3(moveX, moveY).normalized;
        bool IsIdle = moveX == 0 && moveY == 0;
        if (IsIdle)
        {
            //idle
            _anim.SetBool("IsMoving", false);
            _rb2d.velocity = Vector2.zero;
        }
        else
        {
            //moving
            _anim.SetBool("IsMoving", true);
            _anim.SetFloat("Horizontal", direction.x);
            _rb2d.velocity = direction * speed;
        }
        //transform.position += direction * speed * Time.deltaTime;
    }
}
