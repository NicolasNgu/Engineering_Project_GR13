using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data;
using MySql.Data.MySqlClient;

public class Mysql_connection : MonoBehaviour
{
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;
    
     void Start () {
        Connect ();
    }
    
    // Update is called once per frame
    void Update () {
    
    }

    void Connect()
    {
        server = "localhost";
        database = "engineering_project";
        uid = "root";
        password = "18-Juin-2000";

        string connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);

         try {
            connection.Open();
            Debug.Log("Connected to database");
        } catch (MySqlException ex) {
            Debug.Log("Error: " + ex.ToString());
        }
    }

    void Close() {
        if (connection != null) {
            connection.Close();
            Debug.Log("Disconnected from database");
        }
    }


}
