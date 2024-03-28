using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MySql.Data.MySqlClient;
using System;

public class FinishChallange : MonoBehaviour
{
    [SerializeField] GameObject finishMenu2;
    private string ConnectionString;
    private MySqlConnection MS_Connection;
    private MySqlCommand MS_Command;
    private MySqlDataReader Ms_Reader;
    string query;
    public static int besttime;
   



    public void Retry()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);

    }

    public void ToMainMenu()
    {

        SceneManager.LoadScene(1);

    }

    public void End()
    {
        finishMenu2.SetActive(true);
    }

    
    
        private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
           
            connection();

            PlayerPrefs.SetFloat("LevelTime", Timer2.elapsedTime);
            PlayerPrefs.Save();

    /*
            query = "UPDATE jatekos SET Ido='" + PlayerPrefs.GetFloat("LevelTime") + "' WHERE Nev LIKE('" + PlayerPrefs.GetString("name") + "')";
            MS_Command = new MySqlCommand(query, MS_Connection);
            MS_Command.ExecuteNonQuery();
            MS_Connection.Close();
            Debug.Log("Az idõ: " + PlayerPrefs.GetFloat("LevelTime"));
            End();

            
      */      


            

            Debug.Log("Besttime: " + Challange.besttime);


            
            if (Challange.besttime > PlayerPrefs.GetFloat("LevelTime"))
            {
                query = "UPDATE jatekos SET Ido='" + PlayerPrefs.GetFloat("LevelTime") + "' WHERE Nev LIKE('" + PlayerPrefs.GetString("name") + "')";
                MS_Command = new MySqlCommand(query, MS_Connection);
                MS_Command.ExecuteNonQuery();
                MS_Connection.Close();
                Debug.Log("Az idõ: " + PlayerPrefs.GetFloat("LevelTime"));
                End();
            }
            else
            {
                End();
            }
            
        }

        
    }
    
    


    public void connection()
    {
        ConnectionString = "Server = localhost ; Database = zerogravity ; User = root; Password = ; Charset = utf8;";
        MS_Connection = new MySqlConnection(ConnectionString);

        MS_Connection.Open();
    }


   

}


