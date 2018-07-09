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
            userDataClaim.UserDataSelecter();
            DateTime parsedDate = DateTime.Parse(userDataClaim.dataOut[2]);

            userDataScreenFullNameTextBox.Text = userDataClaim.dataOut[1];
            userDataScreenUserNameTextBox.Text = userDataClaim.dataOut[3];
            userDataScreenBornDatePicker.Value = parsedDate;
           
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

        private void userDataScreenDataChangeButton_Click(object sender, EventArgs e)
        {
            DateTime PickedDateCheck = DateTime.Parse(userDataClaim.dataOut[2]);
            string parsedString;

            if (userDataScreenFullNameTextBox.Text != userDataClaim.dataOut[1] ||
                userDataScreenBornDatePicker.Value != PickedDateCheck ||
                userDataScreenNewPasswordTextBox.Text != userDataClaim.dataOut[4] &&
                userDataScreenCurrentPasswordTextBox.Text == userDataClaim.dataOut[4])
            {
                userDataClaim.dataOut[1] = userDataScreenFullNameTextBox.Text;
                parsedString = userDataScreenBornDatePicker.Value.ToString();
                userDataClaim.dataOut[2] = parsedString;
                userDataClaim.dataOut[4]= userDataScreenNewPasswordTextBox.Text;

                userDataClaim.UserDataupdater();
                this.Hide();
            }
            else
            {                   //TODO: csinálni hiba ablakot.(adatmodosítás megerősítés)
                MessageBox.Show("Hibás jelenlegi jelszó vagy nem történt változás az adatokban");
            }
        }

        private void userDataScreenCurrentPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                userDataScreenDataChangeButton.PerformClick();

            }
        }

        private void userDataScreenNewPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (userDataScreenCurrentPasswordTextBox.Text != null)
                userDataScreenDataChangeButton.PerformClick();
                //TODO csinálni hiba ablakot.(userdatapass check) 
            else MessageBox.Show("Nem adtad meg az aktuális jelszabad");
        }
    }
}
