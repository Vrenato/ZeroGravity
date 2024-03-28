using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPointLevel10 : MonoBehaviour
{
    [SerializeField] GameObject finishMenu;

    public AudioClip finishmusic;
    public AudioClip defaultmusic;
    public AudioSource audioSource1;
    public AudioSource audioSource2;




    private void Start()
    {


        //audioSource1 = GetComponent<AudioSource>();
        //audioSource2 = GetComponent<AudioSource>();

    }


    public void Pause()
    {
        finishMenu.SetActive(true);
    }



    public void Retry()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);

    }

    public void ToMainMenu()
    {

        SceneManager.LoadScene(1);

    }



    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            stopdefaultmusic();
            playfinishmusic();
            UnlockNewLevel();
            Pause();
        }
    }

    void UnlockNewLevel()
    {



        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {

            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("FirstTime", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedLevel", PlayerPrefs.GetInt("UnlockedLevel", 1) + 1);
            PlayerPrefs.Save();

        }
    }

    public void playfinishmusic()
    {
        audioSource1.clip = finishmusic;
        audioSource1.Play();
    }
    public void stopdefaultmusic()
    {
        audioSource2.clip = defaultmusic;
        audioSource2.Stop();
    }




}
