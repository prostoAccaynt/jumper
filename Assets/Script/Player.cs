using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public float speed = 200f;
        public Rigidbody2D rb;
    private Animation anim;
    private float moveInput;
    public bool facingRight = true;

    private bool isGrounded;

    
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        healthBar.SetHealth(maxHealth);
        
    }

    private void FixedUpdate()
    {
        
    }
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
    rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(Vector2.up * 10000);

        if (moveX > 0 && !faceRight)
            flip();
        else if (moveX < 0 && faceRight)
            flip();
        if (moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }
    }
      void flip ()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
