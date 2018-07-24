namespace AEN
{
    partial class Omissionoperator
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
            this.omissionDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.newOmissionButton = new System.Windows.Forms.Button();
            this.updateOmissionbutton = new System.Windows.Forms.Button();
            this.deleteOmissionButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.actualOmissionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.actualTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.actualStudentNameComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.studenNameCombobox = new System.Windows.Forms.ComboBox();
            this.actualDelayCheckBox = new System.Windows.Forms.CheckBox();
            this.actualCertifyCheckBox = new System.Windows.Forms.CheckBox();
            this.logOutButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.omissionDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // omissionDataGridView
            // 
            this.omissionDataGridView.AllowUserToAddRows = false;
            this.omissionDataGridView.AllowUserToDeleteRows = false;
            this.omissionDataGridView.AllowUserToResizeColumns = false;
            this.omissionDataGridView.AllowUserToResizeRows = false;
            this.omissionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.omissionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.omissionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.omissionDataGridView.Location = new System.Drawing.Point(12, 50);
            this.omissionDataGridView.Name = "omissionDataGridView";
            this.omissionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.omissionDataGridView.Size = new System.Drawing.Size(776, 287);
            this.omissionDataGridView.TabIndex = 26;
            this.omissionDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.omissionDataGridView_RowEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.actualCertifyCheckBox);
            this.panel1.Controls.Add(this.actualDelayCheckBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.newOmissionButton);
            this.panel1.Controls.Add(this.updateOmissionbutton);
            this.panel1.Controls.Add(this.deleteOmissionButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.actualOmissionDateTimePicker);
            this.panel1.Controls.Add(this.actualTeacherComboBox);
            this.panel1.Controls.Add(this.actualStudentNameComboBox);
            this.panel1.Location = new System.Drawing.Point(275, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 286);
            this.panel1.TabIndex = 27;
            this.panel1.Tag = "Aktuális jegy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(52, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Dátum:";
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
            // newOmissionButton
            // 
            this.newOmissionButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newOmissionButton.Location = new System.Drawing.Point(287, 218);
            this.newOmissionButton.Name = "newOmissionButton";
            this.newOmissionButton.Size = new System.Drawing.Size(87, 42);
            this.newOmissionButton.TabIndex = 15;
            this.newOmissionButton.Text = "Új Hiányzás";
            this.newOmissionButton.UseVisualStyleBackColor = true;
            this.newOmissionButton.Click += new System.EventHandler(this.newOmissionButton_Click);
            // 
            // updateOmissionbutton
            // 
            this.updateOmissionbutton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateOmissionbutton.Location = new System.Drawing.Point(174, 218);
            this.updateOmissionbutton.Name = "updateOmissionbutton";
            this.updateOmissionbutton.Size = new System.Drawing.Size(87, 42);
            this.updateOmissionbutton.TabIndex = 14;
            this.updateOmissionbutton.Text = "Modosítás";
            this.updateOmissionbutton.UseVisualStyleBackColor = true;
            this.updateOmissionbutton.Click += new System.EventHandler(this.updateOmissionkbutton_Click);
            // 
            // deleteOmissionButton
            // 
            this.deleteOmissionButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteOmissionButton.Location = new System.Drawing.Point(56, 218);
            this.deleteOmissionButton.Name = "deleteOmissionButton";
            this.deleteOmissionButton.Size = new System.Drawing.Size(87, 42);
            this.deleteOmissionButton.TabIndex = 13;
            this.deleteOmissionButton.Text = "Törlés";
            this.deleteOmissionButton.UseVisualStyleBackColor = true;
            this.deleteOmissionButton.Click += new System.EventHandler(this.deleteOmissionButton_Click);
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
            // actualOmissionDateTimePicker
            // 
            this.actualOmissionDateTimePicker.Location = new System.Drawing.Point(56, 76);
            this.actualOmissionDateTimePicker.Name = "actualOmissionDateTimePicker";
            this.actualOmissionDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.actualOmissionDateTimePicker.TabIndex = 11;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.endDateTimePicker);
            this.panel2.Controls.Add(this.startDateTimePicker);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.classComboBox);
            this.panel2.Controls.Add(this.studenNameCombobox);
            this.panel2.Location = new System.Drawing.Point(12, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 286);
            this.panel2.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(32, 199);
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
            this.label3.Location = new System.Drawing.Point(32, 158);
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
            this.endDateTimePicker.Location = new System.Drawing.Point(100, 199);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.endDateTimePicker.TabIndex = 6;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.endDateTimePicker_ValueChanged);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(100, 158);
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
            // actualDelayCheckBox
            // 
            this.actualDelayCheckBox.AutoSize = true;
            this.actualDelayCheckBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualDelayCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.actualDelayCheckBox.Location = new System.Drawing.Point(56, 111);
            this.actualDelayCheckBox.Name = "actualDelayCheckBox";
            this.actualDelayCheckBox.Size = new System.Drawing.Size(67, 24);
            this.actualDelayCheckBox.TabIndex = 19;
            this.actualDelayCheckBox.Text = "Késés";
            this.actualDelayCheckBox.UseVisualStyleBackColor = true;
            // 
            // actualCertifyCheckBox
            // 
            this.actualCertifyCheckBox.AutoSize = true;
            this.actualCertifyCheckBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualCertifyCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.actualCertifyCheckBox.Location = new System.Drawing.Point(56, 155);
            this.actualCertifyCheckBox.Name = "actualCertifyCheckBox";
            this.actualCertifyCheckBox.Size = new System.Drawing.Size(67, 24);
            this.actualCertifyCheckBox.TabIndex = 20;
            this.actualCertifyCheckBox.Text = "Igazolt";
            this.actualCertifyCheckBox.UseVisualStyleBackColor = true;
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
            // Omissionoperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 666);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.omissionDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Omissionoperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.omissionDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView omissionDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classComboBox;
        public System.Windows.Forms.ComboBox studenNameCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker actualOmissionDateTimePicker;
        private System.Windows.Forms.ComboBox actualTeacherComboBox;
        public System.Windows.Forms.ComboBox actualStudentNameComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button newOmissionButton;
        private System.Windows.Forms.Button updateOmissionbutton;
        private System.Windows.Forms.Button deleteOmissionButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox actualCertifyCheckBox;
        private System.Windows.Forms.CheckBox actualDelayCheckBox;
    }
}