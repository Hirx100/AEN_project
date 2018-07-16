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

        void GridFill()
        {

            dataviwe.OpenConnection();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("tetelek_view", dataviwe.connection);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtblTetel = new DataTable();
            sqlDa.Fill(dtblTetel);
            markDataGridView.DataSource = dtblTetel;
            markDataGridView.Columns[6].Visible = false;


        }
    }
}
