using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //f�men�be val� kil�p�s
    public void fomenu()
    {
        SceneManager.LoadScene(1);
    }

    //szint �jrakezd�se
    public void Retry()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);

    }

}
