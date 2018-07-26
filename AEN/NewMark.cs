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
    public partial class NewMark : Form
    {
            DBConnect dbConnect = new DBConnect();
            Login userDataClaim= new Login();
            Markoperator markThings = new Markoperator();

        public NewMark()
        {   
            InitializeComponent();
            markThings.ClassFill(this.classComboBox);
            markThings.MarkFill(this.markComboBox);
            markThings.SubjectFill(this.subjectComboBox);
            markThings.TeacherFill(this.teacherComboBox);

            studenNameCombobox.Items.Add(new KeyValuePair<string, int>("Válasszon osztályt elősször!", 400));
            studenNameCombobox.SelectedIndex = 0;
            studenNameCombobox.DisplayMember = "key";
            studenNameCombobox.ValueMember = "value";

            subjectComboBox.Items.RemoveAt(0);
            classComboBox.SelectedIndex = -1;
            
        }
 
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void MarkInsert()
        {
            KeyValuePair<string, int> selectedClass = (KeyValuePair<string, int>)classComboBox.SelectedItem;
            KeyValuePair<string, int> selectedStudent = (KeyValuePair<string, int>)studenNameCombobox.SelectedItem;
            KeyValuePair<string, int> selectedTeacher = (KeyValuePair<string, int>)teacherComboBox.SelectedItem;
            KeyValuePair<string, int> selectedMark = (KeyValuePair<string, int>)markComboBox.SelectedItem;
            KeyValuePair<string, int> selectedSubject = (KeyValuePair<string, int>)subjectComboBox.SelectedItem;

            string[] parsedata = new string[6];
            parsedata[0] = selectedClass.Key;
            parsedata[1] = selectedStudent.Key;
            parsedata[2] = selectedTeacher.Key;
            parsedata[3] = selectedMark.Key;
            parsedata[4] = selectedSubject.Key;
            parsedata[5] = descriptionTextBox.Text;


            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenMarkInstert", dbConnect.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_studentName", parsedata[1]);
            cmd.Parameters.AddWithValue("_teacherName", parsedata[2]);
            cmd.Parameters.AddWithValue("_subjectName", parsedata[4]);
            cmd.Parameters.AddWithValue("_markNumber",  Int32.Parse(parsedata[3]));
            cmd.Parameters.AddWithValue("_description", parsedata[5]);
            cmd.Parameters.AddWithValue("_markDate",    DateTime.Parse(markDateTimePicker.Value.ToString()));
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
            MessageBox.Show("Új jegy felvéve.");
            MarkInsert();
            markThings.StartMarkGridFill();
            this.Close();
        }
    }
}
