using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int Damage)
    {
        currentHealth -= Damage;

        //hurt animation here

        if (currentHealth <= 0)
        {
            Die(enemy);
        }
    }

    void Die(GameObject enemy)
    {
        //disable die anim

        //disable enemy
        Destroy(enemy);
    }
}
