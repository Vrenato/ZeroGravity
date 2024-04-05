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
    //public TextMeshProUGUI playername;
    [SerializeField] TextMeshProUGUI playername;

    [SerializeField] TextMeshProUGUI playertime;
    
    public static string name;


    private void Start()
    {
        name = PlayerPrefs.GetString("name");

       

    }

    public static void StartChallange()
    {
        SceneManager.LoadScene(12);
    }


    public void GetData()
    {

        // Egy adott játékos(aki be van lépve) kilistázza az adatait.
        //query = "Select Nev, Ido FROM jatekos WHERE Nev LIKE('" + name + "')";

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

    public void DeleteData()
    {

        // Egy adott játékos(aki be van lépve) kilistázza az adatait.
        //query = "Select Nev, Ido FROM jatekos WHERE Nev LIKE('" + name + "')";

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

        Debug.Log("A best timeod: " + besttime);
    }


    /*
    public void connection()
    {
        ConnectionString = "Server = localhost ; Database = zerogravity ; User = root; Password = ; Charset = utf8;";
        MS_Connection = new MySqlConnection(ConnectionString);

        MS_Connection.Open();
    }
    */
}
