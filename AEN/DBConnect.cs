using System;
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
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //https://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        public void Initialize()
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

        public bool Password(string username, string loginpassword, int permission)
        {

            OpenConnection();


            switch (permission)
            {
                case 101:
                    {
                        string sqlCmd = "Select Count(*) From teacher where user_name = '" + username + "' and password = '" + loginpassword + "'";
                        MySqlDataAdapter sda = new MySqlDataAdapter(sqlCmd, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                            return true;
                        break;
                    }
                case 102:
                    {
                        
                        MySqlCommand cmd = new MySqlCommand("teacher_passCheak", connection);
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
                case 103:
                    {
                        string sqlCmd = "Select Count(*) From parent where user_name = '" + username + "' and password = '" + loginpassword + "'";
                        MySqlDataAdapter sda = new MySqlDataAdapter(sqlCmd, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                            return true;
                        break;
                    }
                case 104:
                    {
                        string sqlCmd = "Select Count(*) From student where user_name = '" + username + "' and password = '" + loginpassword + "'";
                        MySqlDataAdapter sda = new MySqlDataAdapter(sqlCmd, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                            return true;
                        break;
                    }
                default: return false;
            }
                    return false;
            
        }
        private bool OpenConnection()
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
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
    }
}
