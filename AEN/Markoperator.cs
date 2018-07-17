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
        public Markoperator()
        {
            InitializeComponent();
            MarkGridFill();
            ClassFill();
            Subject();
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
        void Subject()
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
            }
            subjectComboBox.SelectedIndex = 0;
            subjectComboBox.DisplayMember = "key";
            subjectComboBox.ValueMember = "value";


            dataviwe.CloseConnection();
        }
        void MarkGridFill()
        {

            dataviwe.OpenConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("aenClassSelect", dataviwe.connection);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dTClass = new DataTable();
            sqlDa.Fill(dTClass);
            markDataGridView.DataSource = dTClass;

            //markDataGridView.Columns["teacher_ID"].Visible = false;
            //markDataGridView.Columns["mark_ID"].Visible = false;
            //markDataGridView.Columns["teacher_ID"].Visible = false;

            dataviwe.CloseConnection();
        }
    }
}
