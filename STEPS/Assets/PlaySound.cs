using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    public AudioSource my;
    // Start is called before the first frame update
    void Start()
    {
        my = GetComponent<AudioSource>();
    }

 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            my.Play();
        }
    }
}
