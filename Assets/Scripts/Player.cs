using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//TO DO: PLAYER DAMADGE, Health Bar, Movement, Camera movement maybe

public class Player : MonoBehaviour
{
    public int health = 100;
    public int moveSpeed;
    public Rigidbody2D rb2d;
    private Vector2 moveInput;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Player Health: " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Player has died!");
        // Add death behavior, such as restarting the level
    }

    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Nomalize();

        rb2d.velocity = moveInput * moveSpeed;
    }
}
