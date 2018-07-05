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

        private string username;
        private string permName;
        private int permNummber;
        public string[] userDataArray = new string[4];
         
        
        

        public string[] Valami()
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
            dataUse.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenUserDataSelect");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_role", ("'"+permName+"'"));
            cmd.Parameters.AddWithValue("_username", username);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow row = dt.Rows[0];
            userDataArray[0] = row["name"].ToString();
            userDataArray[1] = row["born_date"].ToString();
            userDataArray[2] = row["user_name"].ToString();
            userDataArray[3] = row["password"].ToString();

            return userDataArray;
        }
    }
}
