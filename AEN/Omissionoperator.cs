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
    public partial class Omissionoperator : Form
    {
        DBConnect dataviwe = new DBConnect();
        Markoperator comboFill = new Markoperator();
        int startMarkGridRuningcount = 0;
        public List<string> studentID = new List<string>();
        
        public Omissionoperator()
        {
            InitializeComponent();

           
            comboFill.TeacherFill(actualTeacherComboBox);
            comboFill.ClassFill(classComboBox);
            comboFill.StudentFill(classComboBox,studenNameCombobox);
            StartOmissionGridFill();

            omissionDataGridView.ColumnHeadersVisible = false;
            if (Loginscreen.permValue == 103 || Loginscreen.permValue == 104)
            {
                deleteOmissionButton.Visible = false;
                updateOmissionbutton.Visible = false;
                newOmissionButton.Visible = false;
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

                            //omission fill 1.time method.
        public void StartOmissionGridFill()
        {
            KeyValuePair<string, int> selectedClass = (KeyValuePair<string, int>)classComboBox.SelectedItem;
            
            string selectClassSign;
            string nummerPlaceholder;
            int selectClassNummer;
            string selectTrueClass = selectedClass.Key;
            char[] charPlacehorder = new char[selectTrueClass.Length];
            charPlacehorder = selectTrueClass.ToCharArray();
            selectClassSign = charPlacehorder[1].ToString();
            nummerPlaceholder = charPlacehorder[0].ToString();
            selectClassNummer = Int32.Parse(nummerPlaceholder);
                
                
            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(" aenOmissionStartSelect", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_classNummer", selectClassNummer);
            cmd.Parameters.AddWithValue("_classSign", selectClassSign);
            MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd);
            DataTable dtOmission = new DataTable();
            sqlDa.Fill(dtOmission);
            omissionDataGridView.DataSource = dtOmission;
            omissionDataGridView.Columns["omission_id"].Visible = false;

            dataviwe.CloseConnection();

            DateTime parsedDate = DateTime.Parse(dtOmission.Rows[0][3].ToString());
            startDateTimePicker.Value = parsedDate;
            parsedDate = DateTime.Parse(dtOmission.Rows[dtOmission.Rows.Count - 1][3].ToString());
            endDateTimePicker.Value = parsedDate;
            
        }
                            //omission fill another time method.
        void RuningMarkGridFill()
        { 

            
                if (startDateTimePicker.Value > endDateTimePicker.Value)
                {
                    MessageBox.Show("a kezdő dátum később van mint a befejező dátum");
                }
                else
                {
                    KeyValuePair<string, int> selectedClass = (KeyValuePair<string, int>)classComboBox.SelectedItem;
                    KeyValuePair<string, int> selectedStudent = (KeyValuePair<string, int>)studenNameCombobox.SelectedItem;
                    string selectClassSign;
                    string nummerPlaceholder;
                    int selectClassNummer;
                    
                    string selectTrueClass = selectedClass.Key;
                    char[] charPlacehorder = new char[selectTrueClass.Length];
                    charPlacehorder = selectTrueClass.ToCharArray();
                    selectClassSign = charPlacehorder[1].ToString();
                    nummerPlaceholder = charPlacehorder[0].ToString();
                    selectClassNummer = Int32.Parse(nummerPlaceholder);

                    int parseNameValue = selectedStudent.Value;
                    
                    string parseName = selectedStudent.Key;


                if (parseNameValue == 400)parseName = "% %";
               
                    dataviwe.OpenConnection();
                    MySqlCommand cmd = new MySqlCommand("aenMarkRuningSelect", dataviwe.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_classNummer", selectClassNummer);
                    cmd.Parameters.AddWithValue("_classSign", selectClassSign);
                    cmd.Parameters.AddWithValue("_selectedStudent", parseName);
                    cmd.Parameters.AddWithValue("_startDate", DateTime.Parse(startDateTimePicker.Value.ToString()));
                    cmd.Parameters.AddWithValue("_endDate", DateTime.Parse(endDateTimePicker.Value.ToString()));
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd);
                    DataTable dtRunningMark = new DataTable();
                    sqlDa.Fill(dtRunningMark);
                    omissionDataGridView.DataSource = dtRunningMark;
                    omissionDataGridView.Columns["omission_id"].Visible = false;
                    dataviwe.CloseConnection();
                }
            
        }

        void UpdateMark()
        {
            KeyValuePair<string, int> updateStudent = (KeyValuePair<string, int>)actualStudentNameComboBox.SelectedItem;
            KeyValuePair<string, int> updateTeacher = (KeyValuePair<string, int>)actualTeacherComboBox.SelectedItem;

            DataGridViewRow selectedRows = omissionDataGridView.Rows[SelectedRowIndex];
            string updateMarkID = selectedRows.Cells["omission_id"].Value.ToString();

          //  string updateName = updateStudent.Key;

            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(" aenMarkUpdate", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_updateStudent", updateStudent.Key);
            cmd.Parameters.AddWithValue("_updateTeacher", updateTeacher.Key);
            cmd.Parameters.AddWithValue("_updateDescription", actualDescriptiontextBox.Text);
            cmd.Parameters.AddWithValue("_updateMarkDate", DateTime.Parse(actualMarkDateTimePicker.Value.ToString()));
            cmd.Parameters.AddWithValue("_updateMarkID", updateMarkID);
            cmd.ExecuteNonQuery();
            dataviwe.CloseConnection();
        }

        void DeleteMark()
        {
            DataGridViewRow selectedRows = omissionDataGridView.Rows[SelectedRowIndex];
            string deleteMarkID = selectedRows.Cells["omission_id"].Value.ToString();
            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenMarkDelete", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_mark_id", deleteMarkID);
            cmd.ExecuteNonQuery();
            dataviwe.CloseConnection();
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {    if (startMarkGridRuningcount > 1)
            {
                RuningMarkGridFill();
            }
            else startMarkGridRuningcount++;
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (startMarkGridRuningcount > 1)
            {
                RuningMarkGridFill();
            }
            else startMarkGridRuningcount++;
        }

        private void studenNameCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RuningMarkGridFill();
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

        private void markDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
                
                int index = e.RowIndex;
                SelectedRowIndex = index;
                DataGridViewRow selectedRows = omissionDataGridView.Rows[index];
                string description = selectedRows.Cells["description"].Value + string.Empty;

                actualDescriptiontextBox.Text = description;
                actualMarkDateTimePicker.Value = DateTime.Parse(selectedRows.Cells["mark_Date"].Value.ToString());
                actualStudentNameComboBox.SelectedIndex=actualStudentNameComboBox.FindStringExact(selectedRows.Cells["student"].Value.ToString());
                actualTeacherComboBox.SelectedIndex = actualTeacherComboBox.FindStringExact(selectedRows.Cells["teacher"].Value.ToString());

        }

        private void classComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboFill.StudentFill(classComboBox,studenNameCombobox);
            RuningMarkGridFill(); 
        }

        private void deleteMarkButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos törölni szeretnéd a jegyet?", "Megerősítés", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteMark();
                StartOmissionGridFill();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
 
        }

        private void updateMarkbutton_Click(object sender, EventArgs e)
        {
            UpdateMark();
            StartOmissionGridFill();
            MessageBox.Show("A jegy adatai frissítve");
        }

        private void newMarkButton_Click(object sender, EventArgs e)
        {
            NewMark jump = new NewMark();
            jump.Show();
        }
    }
}