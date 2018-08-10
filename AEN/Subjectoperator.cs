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
    public partial class Subjectoperator : Form
    {
        DBConnect dataviwe = new DBConnect();
        
        public Subjectoperator()
        {
            InitializeComponent();
            SubjectFill();

            if (Loginscreen.permValue > 102)
            {
                deleteClassButton.Visible = false;
                updateClassButton.Visible = false;
                newClassButton.Visible = false;
                actualSubjectTextBox.ReadOnly = true;
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

        public void SubjectFill()
        {
            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenSubjectSelect", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd);
            DataTable dtClass = new DataTable();
            sqlDa.Fill(dtClass);
            classDataGridView.DataSource = dtClass;
            classDataGridView.Columns["subject_id"].Visible = false;
            dataviwe.CloseConnection();
        }

        void UpdateSubject()
        {
            DataGridViewRow selectedRows = classDataGridView.Rows[SelectedRowIndex];
            string updateClassId = selectedRows.Cells["subjcet_id"].Value.ToString();

            
           // KeyValuePair<string, int> selectedParent = (KeyValuePair<string, int>)actualParentComboBox.SelectedItem;

            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenSubjcetUpdate", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_updateSubjectName", actualSubjectTextBox.Text);
            cmd.ExecuteNonQuery();
            dataviwe.CloseConnection();
        }

        void DeleteSubject()
        {
            DataGridViewRow selectedRows = classDataGridView.Rows[SelectedRowIndex];
            string deleteClassID = selectedRows.Cells["subject_id"].Value.ToString();
            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenSubjectDelete", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_subject_id", deleteClassID);
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


        private void classDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
                int index = e.RowIndex;
                SelectedRowIndex = index;
                DataGridViewRow selectedRows = classDataGridView.Rows[index];

                actualSubjectTextBox.Text = selectedRows.Cells["subject_name"].Value.ToString();

        }

        private void deleteSubjectButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos törölni szeretnéd a kiválasztott tangyárgyat?", "Megerősítés", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteSubject();
                SubjectFill();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
 
        }

        private void updateSubjectButton_Click(object sender, EventArgs e)
        {
            UpdateSubject();
            SubjectFill();
            MessageBox.Show("A kiválasztott tantárgy adatai frissítve");
        }

        private void newStudentButton_Click(object sender, EventArgs e)
        {
            NewStudent jump = new NewStudent();
            jump.Show();
        }

    }
}
