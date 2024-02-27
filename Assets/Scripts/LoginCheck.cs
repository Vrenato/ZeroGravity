using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginCheck : MonoBehaviour
{

    /*
    // Start is called before the first frame update
    void Start()
    {

        // check if user logged
        if (Logged_in())
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

        bool Logged_in()
        {
            bool isLogged = false;
            string data = PlayerPrefs.GetString("isLogged");

            if (data == "yes")
            {
                isLogged = true;
            }

            return isLogged;
        } 

    bool Logged_in()
    {
        bool isLogged = false;
        if (PlayerPrefs.HasKey("isLogged"))
        {
            string data = PlayerPrefs.GetString("isLogged");
            if (data == "yes")
            {
                isLogged = true;
            }
        }
        return isLogged;
    }

    */

    public void login()
{
        

    Debug.Log("Start method called.");
    
    if (IsLoggedIn())
    {
        Debug.Log("User is logged in. Loading Scene 1.");
        SceneManager.LoadScene(1);

    }
    else
    {
        Debug.Log("User is not logged in. Loading Scene 0.");
        SceneManager.LoadScene(0);
    }
}

 bool IsLoggedIn()
{
    Debug.Log("IsLoggedIn method called.");

    if (PlayerPrefs.HasKey("isLogged"))
    {
        string data = PlayerPrefs.GetString("isLogged");

        if (data == "yes")
        {
            return true;
        }
    }

    return false;
}



}






