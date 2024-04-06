using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using MySql.Data.MySqlClient;
using TMPro;
using System;


public class Challange : MonoBehaviour
{
    private string ConnectionString;
    private MySqlConnection MS_Connection;
    private MySqlCommand MS_Command;
    private MySqlDataReader Ms_Reader;
    string query;
    public static int besttime;
    [SerializeField] TextMeshProUGUI playername;

    [SerializeField] TextMeshProUGUI playertime;
    
    public static string name;

    //indul�skor megkapja a j�t�kosnevet
    private void Start()
    {
        name = PlayerPrefs.GetString("name");

       

    }

    //elind�tja a kih�v�s j�t�km�dot
    public static void StartChallange()
    {
        SceneManager.LoadScene(12);
    }

    //bet�lti az adatokat a list�ba(csak a 999 m�sodpercn�l kisebbeket)
    public void GetData()
    {


        query = "SELECT Nev, Ido FROM jatekos WHERE IDO < 999 ORDER BY Ido ASC LIMIT 10";
        ConnectionString = "Server = localhost; Database = zerogravity ; User = root; Password =; Charset = utf8;";
        MS_Connection = new MySqlConnection(ConnectionString);

        MS_Connection.Open();

        MS_Command = new MySqlCommand(query, MS_Connection);

        Ms_Reader = MS_Command.ExecuteReader();
        while (Ms_Reader.Read())
        {
            playername.text += Ms_Reader[0] + "\n";
            playername.text += "\n";

            playertime.text += Ms_Reader[1] + "\n";
            playertime.text += "\n";
            
        }
        Ms_Reader.Close();
    }

    //vissza gombra nyom�skor az adatok t�rl�dnek a toplist�b�l
    public void DeleteData()
    {


        query = "SELECT Nev, Ido FROM jatekos  ORDER BY Ido DESC LIMIT 10";
        ConnectionString = "Server = localhost; Database = zerogravity ; User = root; Password =; Charset = utf8;";
        MS_Connection = new MySqlConnection(ConnectionString);

        MS_Connection.Open();

        MS_Command = new MySqlCommand(query, MS_Connection);

        Ms_Reader = MS_Command.ExecuteReader();
        while (Ms_Reader.Read())
        {
            playername.text = Ms_Reader[0] + "\n";
            playername.text = "\n";

            playertime.text = Ms_Reader[1] + "\n";
            playertime.text = "\n";

        }
        Ms_Reader.Close();
    }

    //j�t�kos legjobb idej�nek kisz�m�t�sa
    public void BestTime()
    {
        query = "Select Nev, Ido FROM jatekos WHERE Nev LIKE('" + name + "')";
        ConnectionString = "Server = localhost; Database = zerogravity ; User = root; Password =; Charset = utf8;";
        MS_Connection = new MySqlConnection(ConnectionString);

        MS_Connection.Open();

        MS_Command = new MySqlCommand(query, MS_Connection);

        Ms_Reader = MS_Command.ExecuteReader();
        while (Ms_Reader.Read())
        {
            besttime = Convert.ToInt32(Ms_Reader[1]);
            

        }
        Ms_Reader.Close();

    }

}
