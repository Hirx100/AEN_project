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
    public partial class Testform : Form
    {
        public Testform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login test;
            //test.UserDataSelecter();
            string[] testarray = new string[5];
            MessageBox.Show(testarray[2]);
        }
    }
}
