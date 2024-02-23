using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BekeresKezelo : MonoBehaviour
{
    [SerializeField] InputField bekeres;
    [SerializeField] Text bekertszoveg;

    

    public void NevEllenorzes()
    {
        string input = bekeres.text;

        if (input.Length > 16 || input.Length < 2)
        {
            bekertszoveg.text = "A játékosneved nem felel meg a követelményeknek!";
            bekertszoveg.color = Color.red;
            
        }
        else
        {
            bekertszoveg.text = "Megfelel!";
            bekertszoveg.color = Color.green;
           


        }

    }


}
