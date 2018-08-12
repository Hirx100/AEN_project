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
            ClassFill();
            Numberfill(actualClassYearComboBox, actualStartNumberComboBox);

            if (Loginscreen.permValue > 102)
            {
                deleteClassButton.Visible = false;
                updateClassButton.Visible = false;
                newClassButton.Visible = false;
                actualClassSignTextBox.ReadOnly = true;
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
            DataTable dtClass = new DataTable();
            sqlDa.Fill(dtClass);
            classDataGridView.DataSource = dtClass;
            classDataGridView.Columns["class_id"].Visible = false;
            dataviwe.CloseConnection();
        }

        void UpdateClass()
        {
            DataGridViewRow selectedRows = classDataGridView.Rows[SelectedRowIndex];
            string updateClassId = selectedRows.Cells["class_id"].Value.ToString();

            
           // KeyValuePair<string, int> selectedParent = (KeyValuePair<string, int>)actualParentComboBox.SelectedItem;

            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenClassUpdate", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_updateClassSign", actualClassSignTextBox.Text);
            cmd.Parameters.AddWithValue("_startDate", DateTime.Parse(startDateTimePicker.Value.ToString()));
            cmd.Parameters.AddWithValue("_updateClassID", updateClassId);
            cmd.Parameters.AddWithValue("_updateStartClassNumber", (actualStartNumberComboBox.SelectedIndex + 1));
            cmd.Parameters.AddWithValue("_updateClassYear", (actualClassYearComboBox.SelectedIndex + 1));
            cmd.ExecuteNonQuery();
            dataviwe.CloseConnection();
        }

        void DeleteClass()
        {
            DataGridViewRow selectedRows = classDataGridView.Rows[SelectedRowIndex];
            string deleteClassID = selectedRows.Cells["class_id"].Value.ToString();
            dataviwe.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenClassDelete", dataviwe.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_class_id", deleteClassID);
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

                startDateTimePicker.Value = DateTime.Parse(selectedRows.Cells["class_start"].Value.ToString());
                actualClassSignTextBox.Text = selectedRows.Cells["character_sign"].Value.ToString();
                actualClassYearComboBox.SelectedIndex = actualClassYearComboBox.FindStringExact(selectedRows.Cells["class_year"].Value.ToString());
                actualStartNumberComboBox.SelectedIndex = actualStartNumberComboBox.FindStringExact(selectedRows.Cells["start_number"].Value.ToString());
        }

        private void deleteClassButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos törölni szeretnéd a kiválasztott osztályt?", "Megerősítés", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteClass();
                ClassFill();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
 
        }

        private void updateClassButton_Click(object sender, EventArgs e)
        {
            UpdateClass();
            ClassFill();
            MessageBox.Show("A kiválasztott osztály adatai frissítve");
        }

        private void newClassButton_Click(object sender, EventArgs e)
        {
            NewClass jump = new NewClass();
            jump.Show();
        }

        public void Numberfill(ComboBox classYearComboBox,ComboBox startNumberComboBox)
        {
            for (int i = 1; i < 13; i++)
            {
                classYearComboBox.Items.Add(new KeyValuePair<string, int>(i.ToString(), 800));
                startNumberComboBox.Items.Add(new KeyValuePair<string, int>(i.ToString(), 100));

                classYearComboBox.SelectedIndex = 0;
                startNumberComboBox.SelectedIndex = 0;

                classYearComboBox.DisplayMember = "key";
                classYearComboBox.ValueMember = "value";

                startNumberComboBox.DisplayMember = "key";
                startNumberComboBox.ValueMember = "value";
            }
        }
    }
}
