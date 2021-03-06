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
    public partial class Studentoperator : Form
    {
        DBConnect dataviwe = new DBConnect();
        Markoperator markThings = new Markoperator();
        
        public Studentoperator()
        {
            InitializeComponent();

            markThings.ClassFill(actualClassComboBox);
            markThings.TeacherFill(actualTeachercomboBox);
            StudentFill();
            ParentFill(actualParentComboBox);

            if (Loginscreen.permValue > 102)
            {
                deleteStudentButton.Visible = false;
                updateStudentButton.Visible = false;
                newStudentButton.Visible = false;
                actualAccountNametextBox.ReadOnly= true;
                actualAccountNametextBox.BackColor = Color.DarkGray;
            }
            
        }
        int SelectedRowIndex { get; set; }
        string StudentID { get; set; }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Loginscreen logJump = new Loginscreen();
            logJump.Show();
        }

        public void StudentFill()
        {
            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenStudentSelect", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd);
            DataTable dtParent = new DataTable();
            sqlDa.Fill(dtParent);
            studentDataGridView.DataSource = dtParent;
            studentDataGridView.Columns["student_id"].Visible = false;
            dataviwe.CloseConnection();
        }

        public void ParentFill(ComboBox parentComboBox)
        {
            dataviwe.OpenConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("aenParentNameSelect", dataviwe.connection);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtParent = new DataTable();
            sqlDa.Fill(dtParent);
            string[] allParent = new string[dtParent.Rows.Count];
            for (int i = 0; i < allParent.Length; i++)
            {
                allParent[i] = dtParent.Rows[i][0].ToString();
            }
            for (int i = 0; i < allParent.Length; i++)
            {
                parentComboBox.Items.Add(new KeyValuePair<string, int>(allParent[i], i + 500));
            }
            parentComboBox.SelectedIndex = 0;
            parentComboBox.DisplayMember = "key";
            parentComboBox.ValueMember = "value";


            dataviwe.CloseConnection();

        }

        void UpdateStudent()
        {
            DataGridViewRow selectedRows = studentDataGridView.Rows[SelectedRowIndex];
            string updateStudenID = selectedRows.Cells["student_id"].Value.ToString();

            KeyValuePair<string, int> selectedTeacher = (KeyValuePair<string, int>)actualTeachercomboBox.SelectedItem;
            KeyValuePair<string, int> selectedParent = (KeyValuePair<string, int>)actualParentComboBox.SelectedItem;

            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenStudentUpdate", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_updateName", actualStudentNameTextBox.Text);
            cmd.Parameters.AddWithValue("_updatePassword", actualPasswordtextBox.Text);
            cmd.Parameters.AddWithValue("_updateBornDate", DateTime.Parse(actualBornDateTimePicker.Value.ToString()));
            cmd.Parameters.AddWithValue("_updateTeacherName", selectedTeacher.Key);
            cmd.Parameters.AddWithValue("_updateStudentID", updateStudenID);
            cmd.Parameters.AddWithValue("_updateParentName", selectedParent.Key);
            cmd.Parameters.AddWithValue("_updateClass", (actualClassComboBox.SelectedIndex + 1));
            cmd.ExecuteNonQuery();
            dataviwe.CloseConnection();
        }

        void DeleteStudent()
        {
            DataGridViewRow selectedRows = studentDataGridView.Rows[SelectedRowIndex];
            string deleteParentID = selectedRows.Cells["student_id"].Value.ToString();
            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenStudentDelete", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_student_id", deleteParentID);
            cmd.ExecuteNonQuery();
            dataviwe.CloseConnection();
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


        private void studentDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
                int index = e.RowIndex;
                SelectedRowIndex = index;
                DataGridViewRow selectedRows = studentDataGridView.Rows[index];
                string accName = selectedRows.Cells["user_name"].Value + string.Empty;

                actualAccountNametextBox.Text = accName;
                actualBornDateTimePicker.Value = DateTime.Parse(selectedRows.Cells["born_date"].Value.ToString());
                actualPasswordtextBox.Text=selectedRows.Cells["password"].Value.ToString();
                actualStudentNameTextBox.Text = selectedRows.Cells["name"].Value.ToString();
                actualTeachercomboBox.SelectedIndex = actualTeachercomboBox.FindStringExact(selectedRows.Cells["head teacher"].Value.ToString());
                actualParentComboBox.SelectedIndex = actualParentComboBox.FindStringExact(selectedRows.Cells["parent"].Value.ToString());
                actualClassComboBox.SelectedIndex = ((Int16.Parse(selectedRows.Cells["class_id"].Value.ToString()))-1);
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos törölni szeretnéd a kiválasztott szülőt?", "Megerősítés", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteStudent();
                StudentFill();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
 
        }

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            UpdateStudent();
            StudentFill();
            MessageBox.Show("A kiválasztott szülő adatai frissítve");
        }

        private void newStudentButton_Click(object sender, EventArgs e)
        {
            NewStudent jump = new NewStudent();
            jump.Show();
        }

    }
}
