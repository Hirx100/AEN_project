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
        public List<string> studentID = new List<string>();
        public Markoperator()
        {
            InitializeComponent();

           
            TeacherFill(actualTeacherComboBox);
            MarkFill(actualMarkcomboBox);
            ClassFill(classComboBox);
            SubjectFill(subjectComboBox);
            StudentFill(classComboBox,studenNameCombobox);
            StartMarkGridFill();

            if (Loginscreen.permValue == 103 || Loginscreen.permValue == 104)
            {
                deleteMarkButton.Visible = false;
                updateMarkbutton.Visible = false;
                newMarkButton.Visible = false;
                actualDescriptiontextBox.ReadOnly= true;
                actualDescriptiontextBox.BackColor = Color.DarkGray;
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

        public void MarkFill(ComboBox MarkcomboBox)
        {
            string[] mark = new string[4];

            for (int i = 0; i < 4; i++)
            {
                mark[i]= (5 - i).ToString();
            }
            for (int i = 0; i < 4; i++)
            {
                MarkcomboBox.Items.Add(new KeyValuePair<string, int>(mark[i], i + 1));
            }
            MarkcomboBox.SelectedIndex = 0;
            MarkcomboBox.DisplayMember = "key";
            MarkcomboBox.ValueMember = "value";
        }

        public void TeacherFill(ComboBox teacherComboBox)
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
                teacherComboBox.Items.Add(new KeyValuePair<string, int>(allTeacher[i], i + 500));
            }
            teacherComboBox.SelectedIndex = 0;
            teacherComboBox.DisplayMember = "key";
            teacherComboBox.ValueMember = "value";


            dataviwe.CloseConnection();
        }

        public void ClassFill(ComboBox classComboBox)
        {   
            dataviwe.OpenConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("aenClassSelect", dataviwe.connection);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dTClass = new DataTable();
            sqlDa.Fill(dTClass);
            string[] allClass = new string[dTClass.Rows.Count];

                int startNumber;
                int classYear;
                int trueYear;
            for (int i = 0; i < allClass.Length; i++)
            {   
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

        public void SubjectFill(ComboBox subjectComboBox)
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
            subjectComboBox.Items.Add(new KeyValuePair<string, int>("Összes", 399));
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

        public void StudentFill(ComboBox classComboBox, ComboBox studenNameCombobox)
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
            MySqlCommand cmd = new MySqlCommand("aenStudentsSelect", dataviwe.connection);
            cmd.Parameters.AddWithValue("_classNummer", selectClassNummer);
            cmd.Parameters.AddWithValue("_classSign", selectClassSign);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd);
            DataTable dtStudent = new DataTable();
            sqlDa.Fill(dtStudent);

            studentID.Clear();
            foreach(DataRow row in dtStudent.Rows)
            { 
                studentID.Add(row["student_id"].ToString());
                studentID.Add(row["name"].ToString());
            }

            studenNameCombobox.Items.Clear();
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
        public void StartMarkGridFill()
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
            markDataGridView.Columns["mark_id"].Visible = false;

            dataviwe.CloseConnection();

            DateTime parsedDate = DateTime.Parse(dtMark.Rows[0][4].ToString());
            startDateTimePicker.Value = parsedDate;
            parsedDate = DateTime.Parse(dtMark.Rows[dtMark.Rows.Count - 1][4].ToString());
            endDateTimePicker.Value = parsedDate;
            
        }
                            //markgrid fill another time method.
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
                    KeyValuePair<string, int> selectedSubject = (KeyValuePair<string, int>)subjectComboBox.SelectedItem;
                    string selectClassSign;
                    string nummerPlaceholder;
                    int selectClassNummer;
                    
                    string parseSubject = selectedSubject.Key;
                    string selectTrueClass = selectedClass.Key;
                    char[] charPlacehorder = new char[selectTrueClass.Length];
                    charPlacehorder = selectTrueClass.ToCharArray();
                    selectClassSign = charPlacehorder[1].ToString();
                    nummerPlaceholder = charPlacehorder[0].ToString();
                    selectClassNummer = Int32.Parse(nummerPlaceholder);

                    int parseSubjectValue = selectedSubject.Value;
                    int parseNameValue = selectedStudent.Value;
                    
                    string parseName = selectedStudent.Key;

                if (parseSubjectValue == 399) parseSubject = "%%";

                if (parseNameValue == 400)parseName = "% %";
               
                    dataviwe.OpenConnection();
                    MySqlCommand cmd = new MySqlCommand("aenMarkRuningSelect", dataviwe.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_classNummer", selectClassNummer);
                    cmd.Parameters.AddWithValue("_classSign", selectClassSign);
                    cmd.Parameters.AddWithValue("_selectedStudent", parseName);
                    cmd.Parameters.AddWithValue("_selectedSubject", parseSubject);
                    cmd.Parameters.AddWithValue("_startDate", DateTime.Parse(startDateTimePicker.Value.ToString()));
                    cmd.Parameters.AddWithValue("_endDate", DateTime.Parse(endDateTimePicker.Value.ToString()));
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd);
                    DataTable dtRunningMark = new DataTable();
                    sqlDa.Fill(dtRunningMark);
                    markDataGridView.DataSource = dtRunningMark;
                    markDataGridView.Columns["mark_id"].Visible = false;
                    dataviwe.CloseConnection();
                }
            
        }

        void UpdateMark()
        {
            KeyValuePair<string, int> updateStudent = (KeyValuePair<string, int>)actualStudentNameComboBox.SelectedItem;
            KeyValuePair<string, int> updateTeacher = (KeyValuePair<string, int>)actualTeacherComboBox.SelectedItem;
            KeyValuePair<string, int> updateSubject = (KeyValuePair<string, int>)actualSubjectcomboBox.SelectedItem;
            KeyValuePair<string, int> updateMarkNummer = (KeyValuePair<string, int>)actualMarkcomboBox.SelectedItem;
            DataGridViewRow selectedRows = markDataGridView.Rows[SelectedRowIndex];
            string updateMarkID = selectedRows.Cells["mark_id"].Value.ToString();

          //  string updateName = updateStudent.Key;

            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(" aenMarkUpdate", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_updateStudent", updateStudent.Key);
            cmd.Parameters.AddWithValue("_updateTeacher", updateTeacher.Key);
            cmd.Parameters.AddWithValue("_updateSubject", updateSubject.Key);
            cmd.Parameters.AddWithValue("_updateMarkNummer", updateMarkNummer.Key);
            cmd.Parameters.AddWithValue("_updateDescription", actualDescriptiontextBox.Text);
            cmd.Parameters.AddWithValue("_updateMarkDate", DateTime.Parse(actualMarkDateTimePicker.Value.ToString()));
            cmd.Parameters.AddWithValue("_updateMarkID", updateMarkID);
            cmd.ExecuteNonQuery();
            dataviwe.CloseConnection();
        }

        void DeleteMark()
        {
            DataGridViewRow selectedRows = markDataGridView.Rows[SelectedRowIndex];
            string deleteMarkID = selectedRows.Cells["mark_id"].Value.ToString();
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

        private void subjectComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            KeyValuePair<string, int> pickSubject = (KeyValuePair<string, int>)subjectComboBox.SelectedItem;
            if (pickSubject.Value == 399) StartMarkGridFill();
            else RuningMarkGridFill();
        }

        private void markDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
                
                int index = e.RowIndex;
                SelectedRowIndex = index;
                DataGridViewRow selectedRows = markDataGridView.Rows[index];
                string description = selectedRows.Cells["description"].Value + string.Empty;

                actualDescriptiontextBox.Text = description;
                actualMarkDateTimePicker.Value = DateTime.Parse(selectedRows.Cells["mark_Date"].Value.ToString());
                actualStudentNameComboBox.SelectedIndex=actualStudentNameComboBox.FindStringExact(selectedRows.Cells["student"].Value.ToString());
                actualSubjectcomboBox.SelectedIndex = actualSubjectcomboBox.FindStringExact(selectedRows.Cells["subject_name"].Value.ToString());
                actualTeacherComboBox.SelectedIndex = actualTeacherComboBox.FindStringExact(selectedRows.Cells["teacher"].Value.ToString());
                actualMarkcomboBox.SelectedIndex = actualMarkcomboBox.FindStringExact(selectedRows.Cells["mark_number"].Value.ToString());

        }

        private void classComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            StudentFill(classComboBox,studenNameCombobox);
            RuningMarkGridFill(); 
        }

        private void deleteMarkButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos törölni szeretnéd a jegyet?", "Megerősítés", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteMark();
                StartMarkGridFill();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
 
        }

        private void updateMarkbutton_Click(object sender, EventArgs e)
        {
            UpdateMark();
            StartMarkGridFill();
            MessageBox.Show("A jegy adatai frissítve");
        }

        private void newMarkButton_Click(object sender, EventArgs e)
        {
            NewMark jump = new NewMark();
            jump.Show();
        }
    }
}
