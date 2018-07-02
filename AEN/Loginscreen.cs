﻿using MySql.Data.MySqlClient;
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
            
            DBConnect pass= new DBConnect();
            
            string a = "a";
            string b = "1";

            if (pass.Password(userNameTextBox.Text, passwordTextBox.Text) ==true)
            {
                this.Hide();
                Main jump = new Main();
                jump.Show();
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó.");
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
