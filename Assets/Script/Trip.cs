using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trip : MonoBehaviour
{


    private Player ;

    void Start()
    {
        павпапапапапап = GameObject.FindGameObjectWithTag("Chel").GetComponent<Player>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Chel"))
        {
            павпапапапапап.Damage(30);
        }
    }









}


