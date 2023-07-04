using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    int brainCount;

    private void Start()
    {
        brainCount = 8;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("WildGhost"))
        {
            //brainCount--;
            // destroy a brain
            Destroy(gameObject);
            LevelManager.instance.Respawn();
        }

        else if (collision.gameObject.CompareTag("Ghost"))
        {
            Destroy(gameObject);
            LevelManager.instance.Respawn();
        }

        else if (collision.gameObject.CompareTag("Boss"))
        {
            brainCount--;
        }

        else if (collision.gameObject.CompareTag("DieSon"))
        {
            Destroy(gameObject);
            LevelManager.instance.Respawn();
        }
    }


    private void Update()
    {
        /*   FOR RESPAWNING
         *   Destroy(gameObject);
         *   LevelManager.instance.Respawn();
         */

        if (brainCount <= 0)
        {
                SceneManager.LoadScene("PlayerDeath");
        }
    }

}
