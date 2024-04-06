using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SetUserName : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI username;
    
    //beállítja a játékosnevet

    private void Start()
    {
        username.text = PlayerPrefs.GetString("name");
    }
}
