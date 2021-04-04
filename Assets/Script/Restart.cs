using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public void RestartLevel()
    {
        MoneyText.Coin = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
    


}
