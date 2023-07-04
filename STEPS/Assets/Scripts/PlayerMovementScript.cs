using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementScript : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;
    public Transform feet;
    public LayerMask groundLayers;
    public AudioSource footstep;
    public AudioSource giggles;

    [HideInInspector] public bool isFacingRigt = true;

    public Animator Adam;

    public float jumpForce = 20f;

    float moveX;
    bool isGrounded;

    private void Start()
    {
        Adam = GetComponent<Animator>();
        giggles = GetComponent<AudioSource>();
        footstep = GetComponent<AudioSource>();
    }

    private void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        
            
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            // Adam.setTrigger("Jump");
            Jump();
        }

        // check for motion
        if (Mathf.Abs(moveX) > 0.05)
        {
            Adam.SetBool("isRunning", true);
            Adam.SetFloat("moveX", moveX);
        }
        else
        {
            Adam.SetBool("isRunning", false);
    
        }

        if(moveX > 0f)
        {
            isFacingRigt = true;
        }

        else if(moveX < 0f)
        {
            isFacingRigt = false;
        }

        Adam.SetBool("isGrounded", IsGrounded());

    }

    private void FixedUpdate()
    {
        
        Vector2 movement = new Vector2(moveX * movementSpeed, rb.velocity.y);
        rb.velocity = movement;
    }  

    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);
        rb.velocity = movement;
    }

    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

        if(groundCheck != null)
        {
            return true;
        }

        return false;
    }
    private void Footstep()
    {
        footstep.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Giggles")
            giggles.Play();
        else if(collision.tag == "Out")
            SceneManager.LoadScene("End");
    }
}
