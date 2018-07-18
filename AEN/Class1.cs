using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEN
{
    class Class1
    {   Loginscreen dataIn = new Loginscreen();
        DBConnect dataUse = new DBConnect();
        

        public string username;
        private static string permName;
        //private int permNummber= Loginscreen.permValue;
        public List<string> dataOut = new List<string>();






        public void UserDataSelecter()
        {
            dataUse.OpenConnection();

            TextBox temporaryTextBox = Application.OpenForms["Loginscreen"].Controls["userNameTextBox"] as TextBox;
            username = temporaryTextBox.Text;

            switch(Loginscreen.permValue)
            {
                case 101:
                    { permName = "administrator";
                        break;
                    }
                case 102:   //teacher data 
                    { permName = "teacher";
                        MySqlCommand cmd = new MySqlCommand("aenTeacherDataSelect", dataUse.connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_username", username);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            dataOut.Add(row["teacher_id"].ToString());  //0
                            dataOut.Add(row["name"].ToString());        //1.
                            dataOut.Add(row["born_date"].ToString());   //2.
                            dataOut.Add(row["user_name"].ToString());   //3.
                            dataOut.Add(row["password"].ToString());    //4.
                        }
                        break;
                    }
                case 103:   //parent data
                    { permName = "parent";
                        MySqlCommand cmd = new MySqlCommand("aenParentDataSelect", dataUse.connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_username", username);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            dataOut.Add(row["parent_id"].ToString());   //0
                            dataOut.Add(row["name"].ToString());        //1.
                            dataOut.Add(row["born_date"].ToString());   //2. 
                            dataOut.Add(row["user_name"].ToString());   //3.
                            dataOut.Add(row["password"].ToString());    //4.
                            dataOut.Add(row["teacher_id"].ToString());  //5. 
                        }
                        break;
                    }
                case 104:   //student data
                    { permName = "student";
                        MySqlCommand cmd = new MySqlCommand("aenStudentDataSelect", dataUse.connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_username", username);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            dataOut.Add(row["student_id"].ToString());  //0
                            dataOut.Add(row["name"].ToString());        //1.
                            dataOut.Add(row["born_date"].ToString());   //2.
                            dataOut.Add(row["user_name"].ToString());   //3.
                            dataOut.Add(row["password"].ToString());    //4.
                            dataOut.Add(row["parent_id"].ToString());   //5.
                            dataOut.Add(row["teacher_id"].ToString());  //6.
                        }
                        break;
                    }
            }


  
            dataUse.CloseConnection();

        }
                            //TODO: kód egyszerűsítés
        public void UserDataupdater()
        {
            dataUse.OpenConnection();

            switch (Loginscreen.permValue)
            {
                case 101: { break; }

                case 102:   //Teacher data update.
                    {
                            MySqlCommand cmd = new MySqlCommand("aenTeacherDataUpdate", dataUse.connection);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("_username", username);
                            cmd.Parameters.AddWithValue("_name", dataOut[1]);
                            cmd.Parameters.AddWithValue("_borndate", dataOut[2]);
                            cmd.Parameters.AddWithValue("_password", dataOut[4]);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            cmd.ExecuteNonQuery();
                        break;
                    }
                case 103:   //Parent data update.
                    {
                        MySqlCommand cmd = new MySqlCommand("aenParentDataUpdate", dataUse.connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_username", username);
                        cmd.Parameters.AddWithValue("_name", dataOut[1]);
                        cmd.Parameters.AddWithValue("_borndate", dataOut[2]);
                        cmd.Parameters.AddWithValue("_password", dataOut[4]);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                        break;
                    }
                case 104:   //Student data update.
                    {
                        MySqlCommand cmd = new MySqlCommand("aenStudentDataUpdate", dataUse.connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_username", username);
                        cmd.Parameters.AddWithValue("_name", dataOut[1]);
                        cmd.Parameters.AddWithValue("_borndate", dataOut[2]);
                        cmd.Parameters.AddWithValue("_password", dataOut[4]);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                        break;
                    }
            }



            dataUse.CloseConnection();
        }
    }
}

    //TODO: kitörölni ezeket 
/*  MySqlDataReader dataReader = cmd.ExecuteReader();
    string[] userDataArray = new string[dataReader.FieldCount];   
               
        while (dataReader.Read())
            {
                dataList[0].Add(dataReader["techer_id"] + "");
                dataList[1].Add(dataReader["name"] + "");
                dataList[2].Add(dataReader["born_date"] + "");
                dataList[3].Add(dataReader["user_name"] + "");
                dataList[4].Add(dataReader["password"] + "");
                dataList[5].Add(dataReader["active"] + "");
            }
            

            //userDataArray[1] = da.ToString();
            /* DataRow row = dt.Rows[0];
            userDataArray[0] = row["name"].ToString();
            userDataArray[1] = row["born_date"].ToString();
            userDataArray[2] = row["user_name"].ToString();
            userDataArray[3] = row["password"].ToString();
            */