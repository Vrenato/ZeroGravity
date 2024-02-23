using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NevMentes : MonoBehaviour
{
    public InputField textBox;

   public void clickSaveButton()
    {
        PlayerPrefs.SetString("name", textBox.text);
        Debug.Log("A neved: " + PlayerPrefs.GetString("name"));


    }
}
