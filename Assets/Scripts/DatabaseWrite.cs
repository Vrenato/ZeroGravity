using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MySql.Data.MySqlClient;
using System;


public class DatabaseWrite : MonoBehaviour
{
    [SerializeField] Text playername;
    [SerializeField] Text errormessage2;
    public int namecount;
    private string ConnectionString;
    private MySqlConnection MS_Connection;
    private MySqlCommand MS_Command;
    private MySqlDataReader Ms_Reader;
    string query;
    public static bool engedelyezett = true;
    
    
    //csatlakozik az adatbázishoz és ellenőrzi hogy a regisztrálni kívánt név szerepel-e már az adatbázisban
    public void CheckInfo()
    {
        connection();

        query = "SELECT COUNT(Nev) FROM `jatekos` WHERE Nev LIKE('" + playername.text + "')"; 
        MS_Command = new MySqlCommand(query, MS_Connection);

        Ms_Reader = MS_Command.ExecuteReader();
        while (Ms_Reader.Read())
        {
            namecount += Convert.ToInt32(Ms_Reader[0]);
           
        }
        Ms_Reader.Close();


        if (namecount > 0)
        {
            errormessage2.text = "A játékosnév már szerepel az adatbázisban!";
            errormessage2.color = Color.red;
            engedelyezett = false;
            namecount = 0;

            StartCoroutine(DisplayErrorMessageForSeconds(2));

        }
        else if(namecount == 0)
        {
            engedelyezett = true;
            errormessage2.text = "";
        }

    }

    //ha minden kritérium megfelel, akkor felveszi az datnázisba a nevet
    public void sendInfo()
    {
        if (BekeresKezelo.elfogadotte == true && engedelyezett == true)
        {
           
            query = "INSERT INTO jatekos(Nev, Ido) VALUES ('" + playername.text + "','999')";
            MS_Command = new MySqlCommand(query, MS_Connection);
            MS_Command.ExecuteNonQuery();
            MS_Connection.Close();
        }

        

    }

    //csatlakozás az adatbázishoz
    public void connection()
    {
        ConnectionString = "Server = localhost; Database = zerogravity ; User = root; Password =; Charset = utf8;";
        MS_Connection = new MySqlConnection(ConnectionString);

        MS_Connection.Open();
    }

    //megjeleníti a hibaüzenetet adott másodpercig
    private IEnumerator DisplayErrorMessageForSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds); 

        errormessage2.text = ""; 
    }

}
