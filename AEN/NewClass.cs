using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AEN
{
    public partial class NewClass : Form
    {
            DBConnect dbConnect = new DBConnect();
            Classoperator classThing = new Classoperator();
            
            

        public NewClass()
        {   
            InitializeComponent();
            classThing.Numberfill(insertClassYearComboBox, insertStartNumberComboBox);
        }
 
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void ClassInsert()
        {

            string[] parsedata = new string[1];
            parsedata[0] = insertClassSignTextBox.Text;
                                        //TODO: sql stored proced.
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenClassInsert", dbConnect.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_insertSign", parsedata[0]);
            cmd.Parameters.AddWithValue("_insertYear", (insertClassYearComboBox.SelectedIndex+1));
            cmd.Parameters.AddWithValue("_insertStartNumer", (insertStartNumberComboBox.SelectedIndex+1));
            cmd.Parameters.AddWithValue("_insertStartDate", DateTime.Parse(insertStartDateTimePicker.Value.ToString()));
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            dbConnect.CloseConnection();

        }
     

        #region borderless form movable
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }



        #endregion

        private void ClassInsertButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Osztály felvéve.");
            ClassInsert();
            classThing.ClassFill();
            this.Close();
        }

    }
}
