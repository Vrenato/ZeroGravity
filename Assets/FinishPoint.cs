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
            //menü megjelenítése, vissza a menübe, újrakezdés, tovább
            Pause();
        }
    }

    void UnlockNewLevel()
    {
        //todo
    }

}
