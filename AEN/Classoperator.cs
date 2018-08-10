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
    public partial class Classoperator : Form
    {
        DBConnect dataviwe = new DBConnect();
        
        public Classoperator()
        {
            InitializeComponent();


            if (Loginscreen.permValue > 102)
            {
                deleteClassButton.Visible = false;
                updateClassButton.Visible = false;
                newClassButton.Visible = false;

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

        public void ClassFill()
        {
            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenClassSelect", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd);
            DataTable dtParent = new DataTable();
            sqlDa.Fill(dtParent);
            studentDataGridView.DataSource = dtParent;
            studentDataGridView.Columns["class_id"].Visible = false;
            dataviwe.CloseConnection();
        }

        void UpdateClass()
        {
            DataGridViewRow selectedRows = studentDataGridView.Rows[SelectedRowIndex];
            string updateClassId = selectedRows.Cells["class_id"].Value.ToString();

            
           // KeyValuePair<string, int> selectedParent = (KeyValuePair<string, int>)actualParentComboBox.SelectedItem;

            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenClassUpdate", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_updateClassSign", actualClassSignTextBox.Text);
            cmd.Parameters.AddWithValue("_startDate", DateTime.Parse(actualStartDateTimePicker.Value.ToString()));
            cmd.Parameters.AddWithValue("_updateClassID", updateClassId);
            cmd.Parameters.AddWithValue("_updateClassNumber", (actualStartNumberComboBox.SelectedIndex + 1));
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
                actualStartDateTimePicker.Value = DateTime.Parse(selectedRows.Cells["born_date"].Value.ToString());
                actualPasswordtextBox.Text=selectedRows.Cells["password"].Value.ToString();
                actualClassSignTextBox.Text = selectedRows.Cells["name"].Value.ToString();
                actualTeachercomboBox.SelectedIndex = actualTeachercomboBox.FindStringExact(selectedRows.Cells["head teacher"].Value.ToString());
                actualClassYearComboBox.SelectedIndex = actualClassYearComboBox.FindStringExact(selectedRows.Cells["parent"].Value.ToString());
                actualStartNumberComboBox.SelectedIndex = ((Int16.Parse(selectedRows.Cells["class_id"].Value.ToString()))-1);
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos törölni szeretnéd a kiválasztott szülőt?", "Megerősítés", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteStudent();
                ClassFill();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
 
        }

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            UpdateClass();
            ClassFill();
            MessageBox.Show("A kiválasztott szülő adatai frissítve");
        }

        private void newStudentButton_Click(object sender, EventArgs e)
        {
            NewStudent jump = new NewStudent();
            jump.Show();
        }

    }
}
