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
    public partial class Loginscreen : Form
    {
        public int permValue;
        public string userName;
        private void Loginscreen_Load(object sender, EventArgs e)
        {

            #region ComboBox list
            {
                permissionSelecterComboBox.Items.Add(new KeyValuePair<string, int>("-Válaszzon jogosúltságot-", 100));
                permissionSelecterComboBox.Items.Add(new KeyValuePair<string, int>("Rendszergazda", 101));
                permissionSelecterComboBox.Items.Add(new KeyValuePair<string, int>("Tanár", 102));
                permissionSelecterComboBox.Items.Add(new KeyValuePair<string, int>("Szülő", 103));
                permissionSelecterComboBox.Items.Add(new KeyValuePair<string, int>("Diák", 104));

                permissionSelecterComboBox.SelectedIndex = 0;

                permissionSelecterComboBox.DisplayMember = "key";
                permissionSelecterComboBox.ValueMember = "value";
            }
            #endregion


        }
        public Loginscreen()
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

        //login process trigger
        private void logInbutton_Click(object sender, EventArgs e)
        {

            DBConnect pass = new DBConnect();
            KeyValuePair<string, int> perm = (KeyValuePair<string, int>)permissionSelecterComboBox.SelectedItem;
            userName = userNameTextBox.Text;
            permValue = perm.Value;


            if (permValue < 101) // TODO: csinálni hiba ablakot.(jogosúltság)
                MessageBox.Show("Nem választottál jogusoltságot.");
            else
            {
                if (pass.LoginPasswordCheck(userNameTextBox.Text, passwordTextBox.Text, permValue) == true)
                {
                    this.Hide();
                    Main mainJump = new Main();
                    mainJump.Show();

                }
                else
                {   // TODO: csinálni hiba ablakot.(hibás login)
                    MessageBox.Show("Hibás felhasználónév vagy jelszó.");
                }
            }

        }

        /*login process start with enter key press
        (just works when the passwordtextbox active)*/
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

        public string Username
        {
            get { return userNameTextBox.Text; }
            set { userNameTextBox.Text = value; }
        }
    }
}
