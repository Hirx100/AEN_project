namespace AEN
{
    partial class Classoperator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.actualStartNumberComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.actualClassYearComboBox = new System.Windows.Forms.ComboBox();
            this.userControl11 = new AEN.UserControl1();
            this.actualClassSignTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.newClassButton = new System.Windows.Forms.Button();
            this.actualStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateClassButton = new System.Windows.Forms.Button();
            this.deleteClassButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AllowUserToAddRows = false;
            this.studentDataGridView.AllowUserToDeleteRows = false;
            this.studentDataGridView.AllowUserToResizeColumns = false;
            this.studentDataGridView.AllowUserToResizeRows = false;
            this.studentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Location = new System.Drawing.Point(19, 50);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.ReadOnly = true;
            this.studentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentDataGridView.Size = new System.Drawing.Size(529, 287);
            this.studentDataGridView.TabIndex = 26;
            this.studentDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGridView_RowEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.actualStartNumberComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.actualClassYearComboBox);
            this.panel1.Controls.Add(this.userControl11);
            this.panel1.Controls.Add(this.actualClassSignTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.newClassButton);
            this.panel1.Controls.Add(this.actualStartDateTimePicker);
            this.panel1.Controls.Add(this.updateClassButton);
            this.panel1.Controls.Add(this.deleteClassButton);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(19, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 286);
            this.panel1.TabIndex = 27;
            this.panel1.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(75, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Kezdő Szám:";
            // 
            // actualStartNumberComboBox
            // 
            this.actualStartNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actualStartNumberComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualStartNumberComboBox.FormattingEnabled = true;
            this.actualStartNumberComboBox.Location = new System.Drawing.Point(209, 57);
            this.actualStartNumberComboBox.Name = "actualStartNumberComboBox";
            this.actualStartNumberComboBox.Size = new System.Drawing.Size(44, 28);
            this.actualStartNumberComboBox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(328, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Évfolyam: ";
            // 
            // actualClassYearComboBox
            // 
            this.actualClassYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actualClassYearComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualClassYearComboBox.FormattingEnabled = true;
            this.actualClassYearComboBox.Location = new System.Drawing.Point(421, 105);
            this.actualClassYearComboBox.Name = "actualClassYearComboBox";
            this.actualClassYearComboBox.Size = new System.Drawing.Size(35, 28);
            this.actualClassYearComboBox.TabIndex = 26;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(389, 194);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(136, 73);
            this.userControl11.TabIndex = 25;
            // 
            // actualClassSignTextBox
            // 
            this.actualClassSignTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.actualClassSignTextBox.Location = new System.Drawing.Point(421, 59);
            this.actualClassSignTextBox.MaxLength = 2;
            this.actualClassSignTextBox.Name = "actualClassSignTextBox";
            this.actualClassSignTextBox.Size = new System.Drawing.Size(35, 26);
            this.actualClassSignTextBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(75, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kezdő év:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(312, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Osztály Betűjele:";
            // 
            // newClassButton
            // 
            this.newClassButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newClassButton.Location = new System.Drawing.Point(260, 206);
            this.newClassButton.Name = "newClassButton";
            this.newClassButton.Size = new System.Drawing.Size(87, 42);
            this.newClassButton.TabIndex = 15;
            this.newClassButton.Text = "Új Osztály";
            this.newClassButton.UseVisualStyleBackColor = true;
            this.newClassButton.Click += new System.EventHandler(this.newStudentButton_Click);
            // 
            // actualStartDateTimePicker
            // 
            this.actualStartDateTimePicker.Location = new System.Drawing.Point(168, 102);
            this.actualStartDateTimePicker.Name = "actualStartDateTimePicker";
            this.actualStartDateTimePicker.Size = new System.Drawing.Size(130, 26);
            this.actualStartDateTimePicker.TabIndex = 5;
            // 
            // updateClassButton
            // 
            this.updateClassButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateClassButton.Location = new System.Drawing.Point(147, 206);
            this.updateClassButton.Name = "updateClassButton";
            this.updateClassButton.Size = new System.Drawing.Size(87, 42);
            this.updateClassButton.TabIndex = 14;
            this.updateClassButton.Text = "Modosítás";
            this.updateClassButton.UseVisualStyleBackColor = true;
            this.updateClassButton.Click += new System.EventHandler(this.updateStudentButton_Click);
            // 
            // deleteClassButton
            // 
            this.deleteClassButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteClassButton.Location = new System.Drawing.Point(29, 206);
            this.deleteClassButton.Name = "deleteClassButton";
            this.deleteClassButton.Size = new System.Drawing.Size(87, 42);
            this.deleteClassButton.TabIndex = 13;
            this.deleteClassButton.Text = "Törlés";
            this.deleteClassButton.UseVisualStyleBackColor = true;
            this.deleteClassButton.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Image = global::AEN.Properties.Resources.log_out_button;
            this.logOutButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logOutButton.Location = new System.Drawing.Point(440, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(32, 32);
            this.logOutButton.TabIndex = 25;
            this.logOutButton.TabStop = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Image = global::AEN.Properties.Resources.minimize_button;
            this.minimizeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimizeButton.Location = new System.Drawing.Point(478, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(32, 32);
            this.minimizeButton.TabIndex = 24;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Image = global::AEN.Properties.Resources.exit_button;
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitButton.Location = new System.Drawing.Point(516, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(32, 32);
            this.exitButton.TabIndex = 23;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Classoperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(560, 666);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Classoperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logOutButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker actualStartDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newClassButton;
        private System.Windows.Forms.Button updateClassButton;
        private System.Windows.Forms.Button deleteClassButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox actualClassSignTextBox;
        private UserControl1 userControl11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox actualClassYearComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox actualStartNumberComboBox;
    }
}