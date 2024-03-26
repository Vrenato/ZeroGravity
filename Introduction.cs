using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Introduction : MonoBehaviour
{
    [SerializeField] GameObject intro;

    public void IntroductionField()
    {
        if (SceneManager.GetActiveScene().buildIndex == PlayerPrefs.GetInt("FirstTime") + 1)

        {
            intro.SetActive(true);
        }
    }

}
