using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroler : MonoBehaviour
{
    public float speed;

    public int positionOfPatrol;
    public Transform point;
    bool moveingRight;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, point.position) < positionOfPatrol)
        {
            Chill();
        }
    }
    void Chill()
    {
        if (transform.position.x > point.position.x + positionOfPatrol)
        {
            moveingRight = true;
        }
        else if (transform.position.x < point.position.x + - positionOfPatrol)
        {
            moveingRight = false;
        }

        if (moveingRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }

    }
    void Angry()
    {

    }
    void GoBack()
    {

    }
}
