﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    
   public void QuitGame()
    {
        Debug.Log("Debug");
        Application.Quit();
    }
}
