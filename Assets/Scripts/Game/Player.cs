using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float force = 5;

    public UnityEvent moveRightEvent;
    public UnityEvent moveLeftEvent;
    public UnityEvent deathEvent;

    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private bool isRight = true;

    public void MoveRight()
    {
        isRight = true;
        rb.AddForce(Vector2.right * force,ForceMode2D.Impulse);
        moveRightEvent?.Invoke();
    }
    
    public void MoveLeft()
    {
        isRight = false;
        rb.AddForce(Vector2.left * force,ForceMode2D.Impulse);
        moveLeftEvent?.Invoke();
    }
    
    public void SwitchDirection()
    {
        if (isRight) MoveLeft();
        else MoveRight();
    }

   

    
}
