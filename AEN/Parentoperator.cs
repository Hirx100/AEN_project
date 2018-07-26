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
    public partial class Parentoperator : Form
    {
        DBConnect dataviwe = new DBConnect();
        Markoperator teahcer = new Markoperator();
        public Parentoperator()
        {
            InitializeComponent();

            AllParentFill();
            teahcer.TeacherFill(actualTeachercomboBox);
            if (Loginscreen.permValue > 102)
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
        public void AllParentFill()
        {  
            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenParentSelect", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd);
            DataTable dtTeacher = new DataTable();
            sqlDa.Fill(dtTeacher);
            parentDataGridView.DataSource = dtTeacher;
            parentDataGridView.Columns["parent_id"].Visible = false;
            dataviwe.CloseConnection();
        }

        void UpdateParent()
        {
            DataGridViewRow selectedRows = parentDataGridView.Rows[SelectedRowIndex];
            string updateParentID = selectedRows.Cells["parent_id"].Value.ToString();

            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenTeacherUpdate", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_updateName", actualParentNameTextBox.Text);
            cmd.Parameters.AddWithValue("_updatePassword", actualPasswordtextBox.Text);
            cmd.Parameters.AddWithValue("_updateBornkDate", DateTime.Parse(actualBornDateTimePicker.Value.ToString()));
            cmd.Parameters.AddWithValue("_updateTeacherName", updateParentID);
            cmd.Parameters.AddWithValue("_updateParentID", updateParentID);
            cmd.ExecuteNonQuery();
            dataviwe.CloseConnection();
        }

        void DeleteTeacher()
        {
            DataGridViewRow selectedRows = parentDataGridView.Rows[SelectedRowIndex];
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
                DataGridViewRow selectedRows = parentDataGridView.Rows[index];
                string accName = selectedRows.Cells["user_name"].Value + string.Empty;

                actualAccountNametextBox.Text = accName;
                actualBornDateTimePicker.Value = DateTime.Parse(selectedRows.Cells["born_date"].Value.ToString());
                actualPasswordtextBox.Text=selectedRows.Cells["password"].Value.ToString();
                actualParentNameTextBox.Text = selectedRows.Cells["name"].Value.ToString();
   
        }

        private void deleteMarkButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos törölni szeretnéd a kiválasztott tanárt?", "Megerősítés", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteTeacher();
                AllParentFill();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
 
        }

        private void updateMarkbutton_Click(object sender, EventArgs e)
        {
            UpdateParent();
            AllParentFill();
            MessageBox.Show("A kiválasztott tanár adatai frissítve");
        }

        private void newMarkButton_Click(object sender, EventArgs e)
        {
            NewTeacher jump = new NewTeacher();
            jump.Show();
        }

    }
}
