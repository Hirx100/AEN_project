﻿using System;
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
    public partial class Main : Form
    {


        public Main()
        {
            InitializeComponent();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Loginscreen logJump = new Loginscreen();
            logJump.Show();
        }

        private void userDataButton_Click(object sender, EventArgs e)
        {
            Userdatascreen userJump = new Userdatascreen();
            userJump.Show();
        }

        private void markOperatorButton_Click(object sender, EventArgs e)
        {
            Markoperator markJump = new Markoperator();
            markJump.Show();
            this.Close();
        }

        private void omissionOperatorButton_Click(object sender, EventArgs e)
        {
            Omissionoperator omissionJump = new Omissionoperator();
            omissionJump.Show();
            this.Close();
        }

        private void teacherOperatorButton_Click(object sender, EventArgs e)
        {
            if (Loginscreen.permValue < 103)
            {
                Teacheroperator teacherJump = new Teacheroperator();
                teacherJump.Show();
                this.Close();
            }
        }

        private void parentOperatorButton_Click(object sender, EventArgs e)
        {
            if (Loginscreen.permValue < 102)
            {
                Parentoperator parentJump = new Parentoperator();
                parentJump.Show();
                this.Close();
            }
        }

        private void studentOperatorButton_Click(object sender, EventArgs e)
        {
            if (Loginscreen.permValue < 103)
            {
                Studentoperator studentjump = new Studentoperator();
                studentjump.Show();
                this.Close();
            }
        }

        private void classOperatorButton_Click(object sender, EventArgs e)
        {
            if (Loginscreen.permValue < 102)
            {
                Classoperator classjump = new Classoperator();
                classjump.Show();
                this.Close();
            }
        }

        private void subjectOperatorButton_Click(object sender, EventArgs e)
        {
            if (Loginscreen.permValue < 102)
            {
                Subjectoperator subjectJump = new Subjectoperator();
                subjectJump.Show();
                this.Close();
            }
        }
    }
}
