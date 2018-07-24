namespace AEN
{
    partial class Markoperator
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
            this.markDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.newMarkButton = new System.Windows.Forms.Button();
            this.updateMarkbutton = new System.Windows.Forms.Button();
            this.deleteMarkButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.actualMarkcomboBox = new System.Windows.Forms.ComboBox();
            this.actualMarkDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.actualTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.actualSubjectcomboBox = new System.Windows.Forms.ComboBox();
            this.actualStudentNameComboBox = new System.Windows.Forms.ComboBox();
            this.actualDescriptiontextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.studenNameCombobox = new System.Windows.Forms.ComboBox();
            this.logOutButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.markDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // markDataGridView
            // 
            this.markDataGridView.AllowUserToAddRows = false;
            this.markDataGridView.AllowUserToDeleteRows = false;
            this.markDataGridView.AllowUserToResizeColumns = false;
            this.markDataGridView.AllowUserToResizeRows = false;
            this.markDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.markDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.markDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.markDataGridView.Location = new System.Drawing.Point(12, 50);
            this.markDataGridView.Name = "markDataGridView";
            this.markDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.markDataGridView.Size = new System.Drawing.Size(776, 287);
            this.markDataGridView.TabIndex = 26;
            this.markDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.markDataGridView_RowEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.newMarkButton);
            this.panel1.Controls.Add(this.updateMarkbutton);
            this.panel1.Controls.Add(this.deleteMarkButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.actualMarkcomboBox);
            this.panel1.Controls.Add(this.actualMarkDateTimePicker);
            this.panel1.Controls.Add(this.actualTeacherComboBox);
            this.panel1.Controls.Add(this.actualSubjectcomboBox);
            this.panel1.Controls.Add(this.actualStudentNameComboBox);
            this.panel1.Controls.Add(this.actualDescriptiontextBox);
            this.panel1.Location = new System.Drawing.Point(275, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 286);
            this.panel1.TabIndex = 27;
            this.panel1.Tag = "Aktuális jegy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(52, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Leírás:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(52, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Dátum:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(52, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Jegy:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(219, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tanár:";
            // 
            // newMarkButton
            // 
            this.newMarkButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newMarkButton.Location = new System.Drawing.Point(287, 218);
            this.newMarkButton.Name = "newMarkButton";
            this.newMarkButton.Size = new System.Drawing.Size(87, 42);
            this.newMarkButton.TabIndex = 15;
            this.newMarkButton.Text = "Új jegy";
            this.newMarkButton.UseVisualStyleBackColor = true;
            this.newMarkButton.Click += new System.EventHandler(this.newMarkButton_Click);
            // 
            // updateMarkbutton
            // 
            this.updateMarkbutton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateMarkbutton.Location = new System.Drawing.Point(174, 218);
            this.updateMarkbutton.Name = "updateMarkbutton";
            this.updateMarkbutton.Size = new System.Drawing.Size(87, 42);
            this.updateMarkbutton.TabIndex = 14;
            this.updateMarkbutton.Text = "Modosítás";
            this.updateMarkbutton.UseVisualStyleBackColor = true;
            this.updateMarkbutton.Click += new System.EventHandler(this.updateMarkbutton_Click);
            // 
            // deleteMarkButton
            // 
            this.deleteMarkButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteMarkButton.Location = new System.Drawing.Point(56, 218);
            this.deleteMarkButton.Name = "deleteMarkButton";
            this.deleteMarkButton.Size = new System.Drawing.Size(87, 42);
            this.deleteMarkButton.TabIndex = 13;
            this.deleteMarkButton.Text = "Törlés";
            this.deleteMarkButton.UseVisualStyleBackColor = true;
            this.deleteMarkButton.Click += new System.EventHandler(this.deleteMarkButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(208, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tantárgy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(219, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tanuló:";
            // 
            // actualMarkcomboBox
            // 
            this.actualMarkcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actualMarkcomboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualMarkcomboBox.FormattingEnabled = true;
            this.actualMarkcomboBox.Location = new System.Drawing.Point(56, 53);
            this.actualMarkcomboBox.Name = "actualMarkcomboBox";
            this.actualMarkcomboBox.Size = new System.Drawing.Size(44, 28);
            this.actualMarkcomboBox.TabIndex = 11;
            // 
            // actualMarkDateTimePicker
            // 
            this.actualMarkDateTimePicker.Location = new System.Drawing.Point(56, 107);
            this.actualMarkDateTimePicker.Name = "actualMarkDateTimePicker";
            this.actualMarkDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.actualMarkDateTimePicker.TabIndex = 11;
            // 
            // actualTeacherComboBox
            // 
            this.actualTeacherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actualTeacherComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualTeacherComboBox.FormattingEnabled = true;
            this.actualTeacherComboBox.Location = new System.Drawing.Point(277, 107);
            this.actualTeacherComboBox.Name = "actualTeacherComboBox";
            this.actualTeacherComboBox.Size = new System.Drawing.Size(198, 28);
            this.actualTeacherComboBox.TabIndex = 11;
            // 
            // actualSubjectcomboBox
            // 
            this.actualSubjectcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actualSubjectcomboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualSubjectcomboBox.FormattingEnabled = true;
            this.actualSubjectcomboBox.Location = new System.Drawing.Point(277, 157);
            this.actualSubjectcomboBox.Name = "actualSubjectcomboBox";
            this.actualSubjectcomboBox.Size = new System.Drawing.Size(198, 28);
            this.actualSubjectcomboBox.TabIndex = 12;
            // 
            // actualStudentNameComboBox
            // 
            this.actualStudentNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actualStudentNameComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualStudentNameComboBox.FormattingEnabled = true;
            this.actualStudentNameComboBox.Location = new System.Drawing.Point(277, 56);
            this.actualStudentNameComboBox.Name = "actualStudentNameComboBox";
            this.actualStudentNameComboBox.Size = new System.Drawing.Size(198, 28);
            this.actualStudentNameComboBox.TabIndex = 11;
            // 
            // actualDescriptiontextBox
            // 
            this.actualDescriptiontextBox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.actualDescriptiontextBox.Location = new System.Drawing.Point(56, 159);
            this.actualDescriptiontextBox.Name = "actualDescriptiontextBox";
            this.actualDescriptiontextBox.Size = new System.Drawing.Size(108, 26);
            this.actualDescriptiontextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.endDateTimePicker);
            this.panel2.Controls.Add(this.startDateTimePicker);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.subjectComboBox);
            this.panel2.Controls.Add(this.classComboBox);
            this.panel2.Controls.Add(this.studenNameCombobox);
            this.panel2.Location = new System.Drawing.Point(12, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 286);
            this.panel2.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(100, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tantárgy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(31, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Eddig:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(31, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ettől:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(103, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Osztály:";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(99, 239);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.endDateTimePicker.TabIndex = 6;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.endDateTimePicker_ValueChanged);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(99, 198);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.startDateTimePicker.TabIndex = 5;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(105, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tanuló:";
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(49, 156);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(164, 28);
            this.subjectComboBox.TabIndex = 3;
            this.subjectComboBox.SelectionChangeCommitted += new System.EventHandler(this.subjectComboBox_SelectionChangeCommitted);
            // 
            // classComboBox
            // 
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(109, 106);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(44, 28);
            this.classComboBox.TabIndex = 1;
            this.classComboBox.SelectionChangeCommitted += new System.EventHandler(this.classComboBox_SelectionChangeCommitted);
            // 
            // studenNameCombobox
            // 
            this.studenNameCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studenNameCombobox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studenNameCombobox.FormattingEnabled = true;
            this.studenNameCombobox.Location = new System.Drawing.Point(32, 52);
            this.studenNameCombobox.Name = "studenNameCombobox";
            this.studenNameCombobox.Size = new System.Drawing.Size(198, 28);
            this.studenNameCombobox.TabIndex = 0;
            this.studenNameCombobox.SelectionChangeCommitted += new System.EventHandler(this.studenNameCombobox_SelectionChangeCommitted);
            // 
            // logOutButton
            // 
            this.logOutButton.Image = global::AEN.Properties.Resources.log_out_button;
            this.logOutButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logOutButton.Location = new System.Drawing.Point(680, 12);
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
            this.minimizeButton.Location = new System.Drawing.Point(718, 12);
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
            this.exitButton.Location = new System.Drawing.Point(756, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(32, 32);
            this.exitButton.TabIndex = 23;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Markoperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 666);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.markDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Markoperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.markDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logOutButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.DataGridView markDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.ComboBox classComboBox;
        public System.Windows.Forms.ComboBox studenNameCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox actualDescriptiontextBox;
        private System.Windows.Forms.ComboBox actualMarkcomboBox;
        private System.Windows.Forms.DateTimePicker actualMarkDateTimePicker;
        private System.Windows.Forms.ComboBox actualTeacherComboBox;
        public System.Windows.Forms.ComboBox actualSubjectcomboBox;
        public System.Windows.Forms.ComboBox actualStudentNameComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button newMarkButton;
        private System.Windows.Forms.Button updateMarkbutton;
        private System.Windows.Forms.Button deleteMarkButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}