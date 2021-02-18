using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public GameObject Чел;
    void Start()
    {
        
    }

  
    void Update()
    {
        transform.position = new Vector3(Чел.transform.position.x,Чел.transform.position.y, -10f);
    }
    
        
    
}
