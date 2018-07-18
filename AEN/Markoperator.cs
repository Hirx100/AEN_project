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
    public partial class Markoperator : Form
    {
        DBConnect dataviwe = new DBConnect();
        int startMarkGridRuningcount = 0;

        public Markoperator()
        {
            InitializeComponent();
            
            ClassFill();
            SubjectFill();
            StartMarkGridFill();

            if (markDataGridView.SelectedRows.Count > 0)
            {
                string description = markDataGridView.SelectedRows[0].Cells[1].Value + string.Empty;
                actualDescriptiontextBox.Text = description;

            }
        }

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

        void ClassFill()
        {   
            dataviwe.OpenConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("aenClassSelect", dataviwe.connection);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dTClass = new DataTable();
            sqlDa.Fill(dTClass);
            string[] allClass = new string[dTClass.Rows.Count];
            for (int i = 0; i < allClass.Length; i++)
            {   int startNumber;
                int classYear;
                int trueYear;
                startNumber= int.Parse(dTClass.Rows[i][2].ToString());
                classYear= int.Parse(dTClass.Rows[i][4].ToString());
                trueYear = startNumber + (classYear - 1);
                allClass[i] = trueYear.ToString()+ dTClass.Rows[i][3].ToString();
            }
            for (int i = 0; i < allClass.Length; i++)
            {
                classComboBox.Items.Add(new KeyValuePair<string, int>(allClass[i], i+200));
            }
                classComboBox.SelectedIndex = 0;
                classComboBox.DisplayMember = "key";
                classComboBox.ValueMember = "value";


            dataviwe.CloseConnection();
        }

        void SubjectFill()
        {
            dataviwe.OpenConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("aenSubjectSelect", dataviwe.connection);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtSubject = new DataTable();
            sqlDa.Fill(dtSubject);
            string[] allSubject = new string[dtSubject.Rows.Count];
            for (int i = 0; i < allSubject.Length; i++)
            {
                allSubject[i]= dtSubject.Rows[i][1].ToString();
            }
            for (int i = 0; i < allSubject.Length; i++)
            {
                subjectComboBox.Items.Add(new KeyValuePair<string, int>(allSubject[i], i + 300));
                actualSubjectcomboBox.Items.Add(new KeyValuePair<string, int>(allSubject[i], i + 300));
            }
            subjectComboBox.SelectedIndex = 0;
            subjectComboBox.DisplayMember = "key";
            subjectComboBox.ValueMember = "value";


            dataviwe.CloseConnection();
        }

                            //markgrid fill 1.time method.
        void StartMarkGridFill()
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
            MySqlCommand cmd = new MySqlCommand("aenMarkStartSelect", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_classNummer", selectClassNummer);
            cmd.Parameters.AddWithValue("_classSign", selectClassSign);
            MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd);
            DataTable dTClass = new DataTable();
            sqlDa.Fill(dTClass);
            markDataGridView.DataSource = dTClass;

            string[] allStudent = new string[dTClass.Rows.Count];
            for (int i = 0; i < allStudent.Length; i++)
            {
                allStudent[i] = dTClass.Rows[i][3].ToString();
            }

            studenNameCombobox.Items.Add(new KeyValuePair<string, int>("Mind", 400));
            for (int i = 0; i < allStudent.Length; i++)
            {
                studenNameCombobox.Items.Add(new KeyValuePair<string, int>(allStudent[i], (i+1) + 400));
                actualStudentNameComboBox.Items.Add(new KeyValuePair<string, int>(allStudent[i], (i + 1) + 400));
            }
            studenNameCombobox.SelectedIndex = 0;
            studenNameCombobox.DisplayMember = "key";
            studenNameCombobox.ValueMember = "value";
            dataviwe.CloseConnection();

            DateTime parsedDate = DateTime.Parse(dTClass.Rows[0][4].ToString());
            startDateTimePicker.Value = parsedDate;
            parsedDate = DateTime.Parse(dTClass.Rows[dTClass.Rows.Count - 1][4].ToString());
            endDateTimePicker.Value = parsedDate;
            
        }

                            //markgrid fill another time method.
        void RuningMarkGridFill()
        { 

            if (startMarkGridRuningcount > 2)
            {
                if (startDateTimePicker.Value > endDateTimePicker.Value)
                {
                    MessageBox.Show("a kezdő dátum később van mint a befejező dátum");
                }
                else
                {
                    KeyValuePair<string, int> selectedClass = (KeyValuePair<string, int>)classComboBox.SelectedItem;
                    KeyValuePair<string, int> selectedStudent = (KeyValuePair<string, int>)studenNameCombobox.SelectedItem;
                    KeyValuePair<string, int> selectedSubject = (KeyValuePair<string, int>)subjectComboBox.SelectedItem;
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

                    if (parseNameValue == 400)
                    {
                        parseName = "%%";
                    }
                    
                    dataviwe.OpenConnection();
                    MySqlCommand cmd = new MySqlCommand("aenMarkRuningSelect", dataviwe.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_classNummer", selectClassNummer);
                    cmd.Parameters.AddWithValue("_classSign", selectClassSign);
                    cmd.Parameters.AddWithValue("_selectedStudent", parseName);
                    cmd.Parameters.AddWithValue("_selectedSubject", selectedSubject);
                    cmd.Parameters.AddWithValue("_startDate", DateTime.Parse(startDateTimePicker.Value.ToString()));
                    cmd.Parameters.AddWithValue("_endDate", DateTime.Parse(endDateTimePicker.Value.ToString()));
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd);
                    DataTable dTClass = new DataTable();
                    sqlDa.Fill(dTClass);
                    markDataGridView.DataSource = dTClass;
                    dataviwe.CloseConnection();
                }
            }
            else startMarkGridRuningcount++;
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RuningMarkGridFill();
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RuningMarkGridFill();
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

        private void subjectComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RuningMarkGridFill();
        }

    }
}
