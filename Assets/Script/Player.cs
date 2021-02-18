using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 200f;
        public Rigidbody2D rb;

    private bool faceRight = true;
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

        if (moveX > 0 && !faceRight)
            flip();
        else if (moveX < 0 && faceRight)
            flip();
    }
      void flip ()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
