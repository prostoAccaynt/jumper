using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 200f;
        public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    
        
    }

    
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
    rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(Vector2.up * 10000);
    }
}
