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
    public partial class NewSubject : Form
    {
            DBConnect dbConnect = new DBConnect();
            Subjectoperator subjectThings = new Subjectoperator();

        public NewSubject()
        {   
            InitializeComponent();
            
        }
 
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void Subjectinsert()
        {

            string[] parsedata = new string[1];
            parsedata[0] = insertSubjectTextBox.Text;                        
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("aenSubjectInsert", dbConnect.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_insertSubject", parsedata[0]);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            dbConnect.CloseConnection();

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

        private void SubjectInsertButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tantárgy felvéve.");
            Subjectinsert();
            subjectThings.SubjectFill();
            this.Close();
        }

    }
}
