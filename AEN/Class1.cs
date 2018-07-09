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
        private string permName;
        private int permNummber;
        //public ArrayList dataOut = new ArrayList();
        public List<string> dataOut = new List<string>();






        public void Valami()
        {
            dataUse.OpenConnection();

            TextBox temporaryTextBox = Application.OpenForms["Loginscreen"].Controls["userNameTextBox"] as TextBox;

            
            permNummber = dataIn.permValue;
            username = temporaryTextBox.Text;

            switch(permNummber)
            {
                case 101:
                    { permName = "administrator"; break;

                    }
                case 102: { permName = "teacher";break; }
                case 103: { permName = "parent";break; }
                case 104: { permName = "student";break; }
            }

            MySqlCommand cmd = new MySqlCommand("aenTeacherDataSelect", dataUse.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_username", username);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            da.Fill(dt);
             
            foreach(DataRow row in dt.Rows)
            {
                dataOut.Add(row["teacher_id"].ToString());  //0
                dataOut.Add(row["name"].ToString());        //1.
                dataOut.Add(row["born_date"].ToString());   //2.
                dataOut.Add(row["user_name"].ToString());   //3
                dataOut.Add(row["password"].ToString());    //4.
                dataOut.Add(row["active"].ToString());      //5.
            }                                               
  
            dataUse.CloseConnection();

        }
    }
}

//MySqlDataReader dataReader = cmd.ExecuteReader();
//string[] userDataArray = new string[dataReader.FieldCount];    
            /* 
                while (dataReader.Read())
            {
                dataList[0].Add(dataReader["techer_id"] + "");
                dataList[1].Add(dataReader["name"] + "");
                dataList[2].Add(dataReader["born_date"] + "");
                dataList[3].Add(dataReader["user_name"] + "");
                dataList[4].Add(dataReader["password"] + "");
                dataList[5].Add(dataReader["active"] + "");
            }
            */

            //userDataArray[1] = da.ToString();
            /* DataRow row = dt.Rows[0];
            userDataArray[0] = row["name"].ToString();
            userDataArray[1] = row["born_date"].ToString();
            userDataArray[2] = row["user_name"].ToString();
            userDataArray[3] = row["password"].ToString();
            */