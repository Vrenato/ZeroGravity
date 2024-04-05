using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BekeresKezelo : MonoBehaviour
{
    [SerializeField] InputField bekeres;
    [SerializeField] Text errorMessage;
    public static bool elfogadotte = true;
    
    

    public void NevEllenorzes()
    {
        string input = bekeres.text;

        if (input.Length > 10 || input.Length < 4)
        {
            errorMessage.text = "A játékosneved nem felel meg a követelményeknek!";
            errorMessage.color = Color.red;
            elfogadotte = false;


            StartCoroutine(DisplayErrorMessageForSeconds(2));
        } 
        
        else
        {
            /*bekertszoveg.text = "Megfelel!";
            bekertszoveg.color = Color.green; */
            errorMessage.text = "";
            PlayerPrefs.SetString("isLogged", "yes");
            elfogadotte = true;


        }

    }

    private IEnumerator DisplayErrorMessageForSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds); 

        errorMessage.text = ""; 
    }


}
