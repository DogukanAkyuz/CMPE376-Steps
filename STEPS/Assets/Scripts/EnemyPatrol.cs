using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody2D rb; // for velocity
    public LayerMask groundLayers;

    public AudioSource sound;

    public Transform groundCheck;

    bool isFacingRight = true;

    RaycastHit2D hit;

    public Animator myAnim;

    private void Start()
    {
        myAnim = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
        InvokeRepeating("Speak", 0.5f, 6.0f);
    }

    // Update is called once per frame
    private void Update()
    {
        
        hit = Physics2D.Raycast(groundCheck.position, -transform.up, 1f, groundLayers);
    }

    private void FixedUpdate()
    {
        if(hit.collider != false)
        {
            if (isFacingRight)
            {
                myAnim.SetTrigger("goingRight");
                rb.velocity = new Vector2(speed, rb.velocity.y);             
            }
            else
            {
                myAnim.SetTrigger("goingLeft");
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
        }
        else
        {
            isFacingRight = !isFacingRight;
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, 1f);
            
        }

    }

    private void Speak()
    {
        sound.Play();
    }

}
