using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 20f;
        public Rigidbody2D rb;
    void Start()
    {
       // rb = GetComponent<Rigidbody2D>(); 
    
        
    }

    
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
    rb.MovePosition(rb.position + Vector2.right * moveX * Time.deltaTime);
    
        
    }
}
