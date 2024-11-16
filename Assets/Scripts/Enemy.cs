using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int attackRange = 1.5; // Range in which the enemy can attack
    public int attackDamage = 10; // Damage dealt to the player
    public int attackCooldown = 1; // Time between attacks
    private int lastAttackTime = 0;

    private Transform player; // Reference to the player
    private bool isPlayerInRange = false;

    private void Start()
    {
        // Find the player by tag
        player = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        // Check if the player is in range
        if (Vector2.Distance(transform.position, player.position) <= attackRange)
        {
            isPlayerInRange = true;

            // Attack the player if cooldown is over
            if (Time.time >= lastAttackTime + attackCooldown)
            {
                AttackPlayer();
                lastAttackTime = Time.time;
            }
        }
        else
        {
            isPlayerInRange = false;
        }
    }

    private void AttackPlayer()
    {
        Debug.Log("Enemy attacks the player!");
        Player playerScript = player.GetComponent<Player>();

        if (playerScript != null)
        {
            playerScript.TakeDamage(attackDamage);
        }
    }
}
