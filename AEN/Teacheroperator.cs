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
    public partial class Teacheroperator : Form
    {
        DBConnect dataviwe = new DBConnect();
        int startMarkGridRuningcount = 0;
        public List<string> studentID = new List<string>();
        public Teacheroperator()
        {
            InitializeComponent();

            AllTeacherFill();

            if (Loginscreen.permValue > 101)
            {
                deleteTeacherButton.Visible = false;
                updateTeacherbutton.Visible = false;
                newTeacherButton.Visible = false;
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

        //markgrid fill 1.time method.
        public void AllTeacherFill()
        {  
            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenTeachersSelect", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd);
            DataTable dtTeacher = new DataTable();
            sqlDa.Fill(dtTeacher);
            markDataGridView.DataSource = dtTeacher;
            markDataGridView.Columns["teacher_id"].Visible = false;
            dataviwe.CloseConnection();
        }

        void UpdateTeacher()
        {
            DataGridViewRow selectedRows = markDataGridView.Rows[SelectedRowIndex];
            string updateTeacherID = selectedRows.Cells["teacher_id"].Value.ToString();

            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenTeacherUpdate", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_updateName", actualTeacherNameTextBox.Text);
            cmd.Parameters.AddWithValue("_updatePassword", actualPasswordtextBox);
            cmd.Parameters.AddWithValue("_updateMarkDate", DateTime.Parse(bornDateTimePicker.Value.ToString()));
            cmd.Parameters.AddWithValue("_updateTeacherID", updateTeacherID);
            cmd.ExecuteNonQuery();
            dataviwe.CloseConnection();
        }

        void DeleteTeacher()
        {
            DataGridViewRow selectedRows = markDataGridView.Rows[SelectedRowIndex];
            string deleteMarkID = selectedRows.Cells["teacher_id"].Value.ToString();
            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenTeacherDelete", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_teacher_id", deleteMarkID);
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


        private void markDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
                int index = e.RowIndex;
                SelectedRowIndex = index;
                DataGridViewRow selectedRows = markDataGridView.Rows[index];
                string accName = selectedRows.Cells["user_name"].Value + string.Empty;

                actualAccountNametextBox.Text = accName;
                bornDateTimePicker.Value = DateTime.Parse(selectedRows.Cells["born_date"].Value.ToString());
                actualPasswordtextBox.Text=selectedRows.Cells["password"].Value.ToString();
                actualTeacherNameTextBox.Text = selectedRows.Cells["name"].Value.ToString();
   
        }

        private void deleteMarkButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos törölni szeretnéd a kiválasztott tanárt?", "Megerősítés", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteTeacher();
                AllTeacherFill();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
 
        }

        private void updateMarkbutton_Click(object sender, EventArgs e)
        {
            UpdateTeacher();
            AllTeacherFill();
            MessageBox.Show("A kiválasztott tanár adatai frissítve");
        }

        private void newMarkButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
