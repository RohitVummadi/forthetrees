using UnityEngine;

public class Player : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(float damage)
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
}
