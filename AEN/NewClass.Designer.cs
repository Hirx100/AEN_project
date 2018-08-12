namespace AEN
{
    partial class NewClass
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
            this.label6 = new System.Windows.Forms.Label();
            this.insertStartNumberComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insertClassYearComboBox = new System.Windows.Forms.ComboBox();
            this.insertClassSignTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.insertStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.teacherInsertButton.Location = new System.Drawing.Point(67, 253);
            this.teacherInsertButton.Name = "teacherInsertButton";
            this.teacherInsertButton.Size = new System.Drawing.Size(137, 34);
            this.teacherInsertButton.TabIndex = 16;
            this.teacherInsertButton.Text = "Felvétel";
            this.teacherInsertButton.UseVisualStyleBackColor = true;
            this.teacherInsertButton.Click += new System.EventHandler(this.ClassInsertButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(26, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Kezdő Szám:";
            // 
            // insertStartNumberComboBox
            // 
            this.insertStartNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.insertStartNumberComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.insertStartNumberComboBox.FormattingEnabled = true;
            this.insertStartNumberComboBox.Location = new System.Drawing.Point(160, 155);
            this.insertStartNumberComboBox.Name = "insertStartNumberComboBox";
            this.insertStartNumberComboBox.Size = new System.Drawing.Size(44, 28);
            this.insertStartNumberComboBox.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(70, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Évfolyam: ";
            // 
            // insertClassYearComboBox
            // 
            this.insertClassYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.insertClassYearComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.insertClassYearComboBox.FormattingEnabled = true;
            this.insertClassYearComboBox.Location = new System.Drawing.Point(163, 111);
            this.insertClassYearComboBox.Name = "insertClassYearComboBox";
            this.insertClassYearComboBox.Size = new System.Drawing.Size(35, 28);
            this.insertClassYearComboBox.TabIndex = 37;
            // 
            // insertClassSignTextBox
            // 
            this.insertClassSignTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.insertClassSignTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.insertClassSignTextBox.Location = new System.Drawing.Point(163, 65);
            this.insertClassSignTextBox.MaxLength = 2;
            this.insertClassSignTextBox.Name = "insertClassSignTextBox";
            this.insertClassSignTextBox.Size = new System.Drawing.Size(35, 26);
            this.insertClassSignTextBox.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(26, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Kezdő év:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(54, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Osztály Betűjele:";
            // 
            // insertStartDateTimePicker
            // 
            this.insertStartDateTimePicker.Location = new System.Drawing.Point(119, 200);
            this.insertStartDateTimePicker.Name = "insertStartDateTimePicker";
            this.insertStartDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.insertStartDateTimePicker.TabIndex = 33;
            // 
            // NewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(263, 329);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.insertStartNumberComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insertClassYearComboBox);
            this.Controls.Add(this.insertClassSignTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.insertStartDateTimePicker);
            this.Controls.Add(this.teacherInsertButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewClass";
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox insertStartNumberComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox insertClassYearComboBox;
        private System.Windows.Forms.TextBox insertClassSignTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker insertStartDateTimePicker;
    }
}