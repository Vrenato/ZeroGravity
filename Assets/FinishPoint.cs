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
            //men� megjelen�t�se, vissza a men�be, �jrakezd�s, tov�bb
        }
    }

    void UnlockNewLevel()
    {
        //todo
    }

}
