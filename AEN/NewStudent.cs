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
    public partial class NewStudent : Form
    {
            DBConnect dbConnect = new DBConnect();
            Login userDataClaim= new Login();
            Markoperator markThings = new Markoperator();
            Studentoperator studentThings = new Studentoperator();
            

        public NewStudent()
        {   
            InitializeComponent();
            markThings.TeacherFill(teacherComboBox);
            studentThings.ParentFill(parentComboBox);
            markThings.ClassFill(actualClassComboBox);
        }
 
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void StudentInstert()
        {
            KeyValuePair<string, int> selectedTeacher = (KeyValuePair<string, int>)teacherComboBox.SelectedItem;
            KeyValuePair<string, int> selectedParent = (KeyValuePair<string, int>)parentComboBox.SelectedItem;

            string[] parsedata = new string[6];
            parsedata[0] = studentNameTextBox.Text;
            parsedata[1] = accountNametextBox.Text;
            parsedata[2] = PasswordtextBox.Text;
            parsedata[3] = selectedTeacher.Key;
            parsedata[4] = selectedParent.Key;
                                        
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenStudentInsert", dbConnect.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_studentName", parsedata[0]);
            cmd.Parameters.AddWithValue("_accName", parsedata[1]);
            cmd.Parameters.AddWithValue("_password", parsedata[2]);
            cmd.Parameters.AddWithValue("_teacherName", parsedata[3]);
            cmd.Parameters.AddWithValue("_parentName", parsedata[4]);
            cmd.Parameters.AddWithValue("_classID", actualClassComboBox.SelectedIndex);
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

        private void TeacherInsertButton_Click(object sender, EventArgs e)
        {

                MessageBox.Show("Diák felvéve.");
                StudentInstert();
                studentThings.StudentFill();
                this.Close();

        }

        private void StudentNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string parseAccname;

                string[] parseName = studentNameTextBox.Text.Split(' ');
            if (parseName[0].Length > 2)
            {   string sufix;
                string prefix = parseName[0].Remove(2,(parseName[0].Length-2));
                if (parseName.Count() > 1 && parseName[1].Length>2)
                {
                    sufix = parseName[1].Remove(2, parseName[1].Length-2);
                    parseAccname = prefix + sufix;
                    accountNametextBox.Text = parseAccname;
                }

            }
            

           
        }
    }
}
