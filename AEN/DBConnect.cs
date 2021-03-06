﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AEN
{
    class DBConnect
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
            OpenConnection();
            CloseConnection();

        }


        //Initialize values
        private void Initialize()  
        {
            server = "localhost";
            database = "aen_database";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";"+ "SslMode = none"+";";

            connection = new MySqlConnection(connectionString);
        }
       
        public bool LoginPasswordCheck (string username, string loginpassword, int permission)
        {

            OpenConnection();

            switch (permission)
            {
                case 101: //admin login check
                    {   //TODO: admin belépést megcsinálni.
                        string sqlCmd = "Select Count(*) From teacher where user_name = '" + username + "' and password = '" + loginpassword + "'";
                        MySqlDataAdapter sda = new MySqlDataAdapter(sqlCmd, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                            return true;
                        if (username == server && loginpassword == password)
                            return true;
                        if (username == "root" && loginpassword == "admin")
                            return true;
                        break;
                    }
                case 102: //teacher login check
                    {   
                        MySqlCommand cmd = new MySqlCommand("aenTeacherPassSelect", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_username", username);
                        cmd.Parameters.AddWithValue("_password", loginpassword);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                        cmd.ExecuteNonQuery();
                            DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count.ToString() == "1")
                            return true;
                        break;
                    }
                case 103: // parent login check
                    {   
                        MySqlCommand cmd = new MySqlCommand("aenParentPassSelect", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_username", username);
                        cmd.Parameters.AddWithValue("_password", loginpassword);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count.ToString() == "1")
                            return true;
                        break;
                    }
                case 104: //student login check
                    {   
                        MySqlCommand cmd = new MySqlCommand("aenStudentPassSelect", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_username", username);
                        cmd.Parameters.AddWithValue("_password", loginpassword);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count.ToString() == "1")
                            return true;
                        break;
                    }
                default: return false;
            }
            CloseConnection();
            return false;
            
        }
        //Open connection
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Nem tud csatlakozni a szerver. Lépjen kapcsolatba az rendszergazdával!");
                        break;

                    case 1045:
                        MessageBox.Show("Hibás szerver jelszó vagy felhasználó név. Lépjen kapcsolatba az adminisztrátorral.");
                        break;
                }
                return false;
            }
        }
        
        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
