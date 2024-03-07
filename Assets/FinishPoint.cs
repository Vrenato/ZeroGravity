using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            //menü megjelenítése, vissza a menübe, újrakezdés, tovább
        }
    }

    void UnlockNewLevel()
    {
        //todo
    }

}
