using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MySql.Data.MySqlClient;

public class DatabaseWrite : MonoBehaviour
{
    public Text playername;
    private string ConnectionString;
    private MySqlConnection MS_Connection;
    private MySqlCommand MS_Command;
    string query;

    public void sendInfo()
    {
        if (BekeresKezelo.elfogadotte == true)
        {
            connection();
            query = "insert into jatekos(Nev) values('" + playername.text + "');";
            MS_Command = new MySqlCommand(query, MS_Connection);
            MS_Command.ExecuteNonQuery();
            MS_Connection.Close();
        }

        

    }

    public void connection()
    {
        ConnectionString = "Server = localhost ; Database = zerogravity ; User = root; Password = ; Charset = utf8;";
        MS_Connection = new MySqlConnection(ConnectionString);

        MS_Connection.Open();
    }

}
