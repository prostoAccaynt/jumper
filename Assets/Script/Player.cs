﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 200f;
        public Rigidbody2D rb;
    private Animation anim;
    public bool faceRight = true;
    public  flip;

    public float jampForce;
    private float moveInput;

    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIGround;
    

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    //anim = GetComponent<Animator>();
     //   rb = GetComponent<Rigidbody2D>();
        
       // healthBar.SetHealth(maxHealth);







    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void fixedUpdate()
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
      //  else
      // /{
      //   anim.SetBool("isRunning", true);
      //  }


         //moveInput = Input.GetAxis("Horizontal");
        //rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
    private void Update()
    {
        
    }
     // void flip ()
   // {
    //    facingRight = !facingRight;
     //   Vector3 Scaler = transform.localScale;
    //   Scaler.x *= -1;
        //transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    

     void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

}








//isGrounded = Phisics2D.OverlapCircle(feetPos.position, checkedRadius, whatIGround);

//if (isGrounded == true && moveInput.GetKeyDown(KeyCode.Space))
//{
   // rb.velocity = Vector2.up * jampForce;
//}



//float moveX = Input.GetAxis("Horizontal");
//rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);


//if (Input.GetKeyDown(KeyCode.Space))
//  rb.AddForce(Vector2.up * 10000);

//if (moveX > 0 && !faceRight)
//   flip();
//else if (moveX < 0 && faceRight)
//   flip();
//if (moveInput == 0)
//{
//   anim.SetBool("isRunning", false);
//}
//else
//{
// anim.SetBool("isRunning", true);
//}
//  }




// if (Input.GetKeyDown(KeyCode.Space))
//    rb.AddForce(Vector2.up * 10000);

// if (moveX > 0 && !faceRight)
//    flip();
// else if (moveX < 0 && faceRight)
//    flip();
// if (moveInput == 0)
// {
//  anim.SetBool("isRunning", false);
//}
//else
//{
//   anim.SetBool("isRunning", true);
//}