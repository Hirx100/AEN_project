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
    public partial class Userdatascreen : Form
    {       DBConnect dataConnect = new DBConnect ();
            Class1 userDataClaim= new Class1();



        public Userdatascreen()
        {   
            InitializeComponent();
            userDataClaim.Valami();
            DateTime parsedDate = DateTime.Parse(userDataClaim.dataOut[2]);

            userDataScreenNameTextBox.Text = userDataClaim.dataOut[1];
            userDataScreenUserNameTextBox.Text = userDataClaim.dataOut[3];
            userDataScreenBornDateTextBox.Value = parsedDate;
           
        }
 
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
