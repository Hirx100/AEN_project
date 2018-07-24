﻿using MySql.Data.MySqlClient;
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
    public partial class NewTeacher : Form
    {
            DBConnect dbConnect = new DBConnect();
            Class1 userDataClaim= new Class1();
            Markoperator markThings = new Markoperator();
            

        public NewTeacher()
        {   
            InitializeComponent();
        }
 
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void TeahcerInsert()
        {

            string[] parsedata = new string[4];
            parsedata[0] = TeacherNameTextBox.Text;
            parsedata[1] = AccountNametextBox.Text;
            parsedata[2] = PasswordtextBox.Text;
                                        //TODO: sql stored proced.
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenTeacherInsert", dbConnect.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_teacherName", parsedata[0]);
            cmd.Parameters.AddWithValue("_accName", parsedata[1]);
            cmd.Parameters.AddWithValue("_password", parsedata[2]);
            cmd.Parameters.AddWithValue("_bornDate", DateTime.Parse(BornDateTimePicker.Value.ToString()));
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

        private void classComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            studenNameCombobox.Items.Clear();
            markThings.StudentFill(this.classComboBox, this.studenNameCombobox);
            studenNameCombobox.Items.RemoveAt(0);
            studenNameCombobox.SelectedIndex = 0;
        }

        private void markInsertButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Késés felvéve.");
            TeahcerInsert();
            markThings.StartMarkGridFill();
            this.Close();
        }

        private void NewOmission_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <8; i++)
            {
                hourComboBox.Items.Add(new KeyValuePair<string, int>(i.ToString(), i+1));
                hourComboBox.DisplayMember = "key";
                hourComboBox.ValueMember = "value";
            }
        }
    }
}