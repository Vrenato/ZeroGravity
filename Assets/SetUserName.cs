using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SetUserName : MonoBehaviour
{
    [SerializeField] Text username;
    
    

    private void Start()
    {
        username.text = PlayerPrefs.GetString("name");
    }
}
