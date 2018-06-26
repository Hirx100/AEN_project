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
    public partial class Loginscreen : Form
    {
        public Loginscreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "a";
            string b = "1";

            if (userNameTextBox.Text.Equals(a) && passwordTextBox.Text.Equals(b))
            {
                this.Hide();
                Main jump = new Main();
                jump.Show();
            }
            else
            {
                MessageBox.Show("Hibás felhasználó név vagy jelszó.");
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                logInButton.PerformClick();
                
            }
        }
    }
}
