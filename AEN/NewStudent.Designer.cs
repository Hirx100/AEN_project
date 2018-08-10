namespace AEN
{
    partial class NewStudent
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
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.teacherInsertButton = new System.Windows.Forms.Button();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BornDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.accountNametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teacherComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.parentComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.actualClassComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Image = global::AEN.Properties.Resources.exit_button;
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitButton.Location = new System.Drawing.Point(219, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(32, 32);
            this.exitButton.TabIndex = 4;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Image = global::AEN.Properties.Resources.minimize_button;
            this.minimizeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimizeButton.Location = new System.Drawing.Point(181, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(32, 32);
            this.minimizeButton.TabIndex = 5;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // teacherInsertButton
            // 
            this.teacherInsertButton.Location = new System.Drawing.Point(67, 387);
            this.teacherInsertButton.Name = "teacherInsertButton";
            this.teacherInsertButton.Size = new System.Drawing.Size(137, 34);
            this.teacherInsertButton.TabIndex = 16;
            this.teacherInsertButton.Text = "Felvétel";
            this.teacherInsertButton.UseVisualStyleBackColor = true;
            this.teacherInsertButton.Click += new System.EventHandler(this.TeacherInsertButton_Click);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.PasswordtextBox.Location = new System.Drawing.Point(130, 205);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(110, 26);
            this.PasswordtextBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(63, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Jelszó:";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.studentNameTextBox.Location = new System.Drawing.Point(130, 73);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(110, 26);
            this.studentNameTextBox.TabIndex = 29;
            this.studentNameTextBox.TextChanged += new System.EventHandler(this.StudentNameTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(9, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Felhasználónév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(14, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Születési év:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(0, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Szülő neve:";
            // 
            // BornDateTimePicker
            // 
            this.BornDateTimePicker.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BornDateTimePicker.Location = new System.Drawing.Point(119, 118);
            this.BornDateTimePicker.Name = "BornDateTimePicker";
            this.BornDateTimePicker.Size = new System.Drawing.Size(130, 26);
            this.BornDateTimePicker.TabIndex = 25;
            // 
            // accountNametextBox
            // 
            this.accountNametextBox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.accountNametextBox.Location = new System.Drawing.Point(130, 161);
            this.accountNametextBox.Name = "accountNametextBox";
            this.accountNametextBox.ReadOnly = true;
            this.accountNametextBox.Size = new System.Drawing.Size(110, 26);
            this.accountNametextBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(0, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Osztályfőnök: ";
            // 
            // teacherComboBox
            // 
            this.teacherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teacherComboBox.FormattingEnabled = true;
            this.teacherComboBox.Location = new System.Drawing.Point(107, 280);
            this.teacherComboBox.Name = "teacherComboBox";
            this.teacherComboBox.Size = new System.Drawing.Size(142, 28);
            this.teacherComboBox.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(43, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Diák neve:";
            // 
            // parentComboBox
            // 
            this.parentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parentComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parentComboBox.FormattingEnabled = true;
            this.parentComboBox.Location = new System.Drawing.Point(107, 246);
            this.parentComboBox.Name = "parentComboBox";
            this.parentComboBox.Size = new System.Drawing.Size(142, 28);
            this.parentComboBox.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(59, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Osztály:";
            // 
            // actualClassComboBox
            // 
            this.actualClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actualClassComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualClassComboBox.FormattingEnabled = true;
            this.actualClassComboBox.Location = new System.Drawing.Point(145, 327);
            this.actualClassComboBox.Name = "actualClassComboBox";
            this.actualClassComboBox.Size = new System.Drawing.Size(44, 28);
            this.actualClassComboBox.TabIndex = 37;
            // 
            // NewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(263, 433);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.actualClassComboBox);
            this.Controls.Add(this.parentComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teacherComboBox);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BornDateTimePicker);
            this.Controls.Add(this.accountNametextBox);
            this.Controls.Add(this.teacherInsertButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTeacher";
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.Button teacherInsertButton;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker BornDateTimePicker;
        private System.Windows.Forms.TextBox accountNametextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox teacherComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox parentComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox actualClassComboBox;
    }
}