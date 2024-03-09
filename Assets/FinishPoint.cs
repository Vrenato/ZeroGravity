using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] GameObject finishMenu;
    public void Pause()
    {
        finishMenu.SetActive(true);
    }

    public void NextLevel()
    {
        //load the next level
    }

    public void Retry()
    {
        SceneManager.LoadScene(2);
    }

    public void LevelSelector()
    {
        //levelselector setactive
    }



    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            //men� megjelen�t�se, vissza a men�be, �jrakezd�s, tov�bb
            Pause();
        }
    }

    void UnlockNewLevel()
    {
        //todo
    }

}
