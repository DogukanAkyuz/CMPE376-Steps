using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFight : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    public Animator anim;
    bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        anim.SetTrigger("Hurt");

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Die animation
        //anim.SetBool("IsDead", true);

        //Disable the  enemy
        this.enabled = false;
        GetComponent<Collider2D>().enabled = false;
        isDead = true;

    }

    public bool CheckDead()
    {
        return isDead;
    }
    
}
