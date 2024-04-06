using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer2 : MonoBehaviour
{



    [SerializeField] TextMeshProUGUI timerText;
    public static float elapsedTime;





    void Update()
    {
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
    //visszaállítja az idõzítõt nullára
    public void ResetTimer()
    {
        elapsedTime = 0f;
        timerText.text = "00:00";
    }


}
