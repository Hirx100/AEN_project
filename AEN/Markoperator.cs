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
            StudentFill();
            TeacherFill();

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

        void TeacherFill()
        {
            dataviwe.OpenConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("aenTeachersSelect", dataviwe.connection);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtTeacher = new DataTable();
            sqlDa.Fill(dtTeacher);
            string[] allTeacher = new string[dtTeacher.Rows.Count];
            for (int i = 0; i < allTeacher.Length; i++)
            {
                   allTeacher[i] = dtTeacher.Rows[i][1].ToString();
            }
            for (int i = 0; i < allTeacher.Length; i++)
            {
                actualTeacherComboBox.Items.Add(new KeyValuePair<string, int>(allTeacher[i], i + 500));
            }
            actualTeacherComboBox.SelectedIndex = 0;
            actualTeacherComboBox.DisplayMember = "key";
            actualTeacherComboBox.ValueMember = "value";


            dataviwe.CloseConnection();
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
            actualSubjectcomboBox.SelectedIndex = 0;
            actualSubjectcomboBox.DisplayMember = "key";
            actualSubjectcomboBox.ValueMember = "value";

            dataviwe.CloseConnection();
        }

        void StudentFill()
        {
            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenStudentsSelect", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd);
            DataTable dtStudent = new DataTable();
            sqlDa.Fill(dtStudent);

            string[] allStudent = new string[dtStudent.Rows.Count];
            for (int i = 0; i < allStudent.Length; i++)
            {
                allStudent[i] = dtStudent.Rows[i][1].ToString();
            }

            studenNameCombobox.Items.Add(new KeyValuePair<string, int>("Mind", 400));

            for (int i = 0; i < allStudent.Length; i++)
            {
                studenNameCombobox.Items.Add(new KeyValuePair<string, int>(allStudent[i], (i + 1) + 400));
                actualStudentNameComboBox.Items.Add(new KeyValuePair<string, int>(allStudent[i], i + 400));
            }

            studenNameCombobox.SelectedIndex = 0;
            studenNameCombobox.DisplayMember = "key";
            studenNameCombobox.ValueMember = "value";
            actualStudentNameComboBox.SelectedIndex = 0;
            actualStudentNameComboBox.DisplayMember = "key";
            actualStudentNameComboBox.ValueMember = "value";

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
            DataTable dtMark = new DataTable();
            sqlDa.Fill(dtMark);
            markDataGridView.DataSource = dtMark;

        /*    string[] allStudent = new string[dtMark.Rows.Count];
            for (int i = 0; i < allStudent.Length; i++)
            {
                allStudent[i] = dtMark.Rows[i][3].ToString();
            }

            studenNameCombobox.Items.Add(new KeyValuePair<string, int>("Mind", 400));
            
            for (int i = 0; i < allStudent.Length; i++)
            {
                studenNameCombobox.Items.Add(new KeyValuePair<string, int>(allStudent[i], (i+1) + 400));
                actualStudentNameComboBox.Items.Add(new KeyValuePair<string, int>(allStudent[i], i + 400));
            }

            studenNameCombobox.SelectedIndex = 0;
            studenNameCombobox.DisplayMember = "key";
            studenNameCombobox.ValueMember = "value";
            actualStudentNameComboBox.SelectedIndex = 0;
            actualStudentNameComboBox.DisplayMember = "key";
            actualStudentNameComboBox.ValueMember = "value"; */

            dataviwe.CloseConnection();

            DateTime parsedDate = DateTime.Parse(dtMark.Rows[0][4].ToString());
            startDateTimePicker.Value = parsedDate;
            parsedDate = DateTime.Parse(dtMark.Rows[dtMark.Rows.Count - 1][4].ToString());
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
                    DataTable dtRunningMark = new DataTable();
                    sqlDa.Fill(dtRunningMark);
                    markDataGridView.DataSource = dtRunningMark;
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

        private void markDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
          /*    KeyValuePair<string, int> selectedStudent = (KeyValuePair<string, int>)actualStudentNameComboBox.SelectedItem;
                KeyValuePair<string, int> selectedSubject = (KeyValuePair<string, int>)actualSubjectcomboBox.SelectedItem;
                KeyValuePair<string, int> selectedTeacher = (KeyValuePair<string, int>)actualTeacherComboBox.SelectedItem;
          */
                int index = e.RowIndex;
                DataGridViewRow selectedRows = markDataGridView.Rows[index];
                string description = selectedRows.Cells["description"].Value + string.Empty;

                actualDescriptiontextBox.Text = description;
                actualMarkDateTimePicker.Value = DateTime.Parse(selectedRows.Cells["mark_Date"].Value.ToString());
                actualStudentNameComboBox.SelectedIndex=actualStudentNameComboBox.FindStringExact(selectedRows.Cells["student"].Value.ToString());
                actualSubjectcomboBox.SelectedIndex = actualSubjectcomboBox.FindStringExact(selectedRows.Cells["subject_name"].Value.ToString());
                actualTeacherComboBox.SelectedIndex = actualTeacherComboBox.FindStringExact(selectedRows.Cells["teacher"].Value.ToString());

        }

        private void classComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RuningMarkGridFill(); 
        }
    }
}
