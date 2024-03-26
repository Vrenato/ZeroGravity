using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void Start()
    {
        //Cursor.lockState = CursorLockMode.None;
        //Cursor.visible = true;
    }

    public void fomenu()
    {
        SceneManager.LoadScene(1);
    }

    public void Retry()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);

    }

}
