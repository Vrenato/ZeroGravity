using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayLevel : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene(2);
        PlayerPrefs.SetInt("FirstTime", SceneManager.GetActiveScene().buildIndex);
    }

    public void Starting()
    {
        SceneManager.LoadScene(2);
        
    }

}

    
