using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEN
{
    class Class1
    {   Loginscreen dataIn = new Loginscreen();
        DBConnect dataUse = new DBConnect();
        Userdatascreen dataOut = new Userdatascreen();

        private string username;
        private string permName;
        private int permNummber;
        private string truename;
        List<string> dataList = new List<string>();





        public void Valami()
        {
            dataUse.OpenConnection();

            username=dataIn.userName;
            permNummber= dataIn.permValue;

            switch(permNummber)
            {
                case 101: { permName = "administrator"; break;}
                case 102: { permName = "teacher";break; }
                case 103: { permName = "parent";break; }
                case 104: { permName = "student";break; }
            }
            
            
            MySqlCommand cmd = new MySqlCommand("aenUserDataSelect", dataUse.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_username", username);
            MySqlDataReader dr = cmd.ExecuteReader();



            /*MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da.Fill(dt);
            */



            string truename = dataOut.UserDataScreenNameTextBox;
            dataOut.UserDataScreenNameTextBox = (dr["name"].ToString());





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