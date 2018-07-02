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
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //login process trigger
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
        //login process start with enter key press(just works when the passwordtextbox active)
        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                logInButton.PerformClick();

            }
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
    }
}
