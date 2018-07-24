namespace AEN
{
    partial class NewOmission
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
            this.omissionInsertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.studenNameCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.omissionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.teacherComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hourComboBox = new System.Windows.Forms.ComboBox();
            this.actualCertifyCheckBox = new System.Windows.Forms.CheckBox();
            this.actualDelayCheckBox = new System.Windows.Forms.CheckBox();
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
            // omissionInsertButton
            // 
            this.omissionInsertButton.Location = new System.Drawing.Point(57, 414);
            this.omissionInsertButton.Name = "omissionInsertButton";
            this.omissionInsertButton.Size = new System.Drawing.Size(137, 34);
            this.omissionInsertButton.TabIndex = 16;
            this.omissionInsertButton.Text = "Felvétel";
            this.omissionInsertButton.UseVisualStyleBackColor = true;
            this.omissionInsertButton.Click += new System.EventHandler(this.markInsertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(108, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tanuló:";
            // 
            // studenNameCombobox
            // 
            this.studenNameCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studenNameCombobox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studenNameCombobox.FormattingEnabled = true;
            this.studenNameCombobox.Location = new System.Drawing.Point(35, 126);
            this.studenNameCombobox.Name = "studenNameCombobox";
            this.studenNameCombobox.Size = new System.Drawing.Size(198, 28);
            this.studenNameCombobox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(103, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Dátum";
            // 
            // omissionDateTimePicker
            // 
            this.omissionDateTimePicker.Location = new System.Drawing.Point(61, 382);
            this.omissionDateTimePicker.Name = "omissionDateTimePicker";
            this.omissionDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.omissionDateTimePicker.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(108, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Tanár:";
            // 
            // teacherComboBox
            // 
            this.teacherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teacherComboBox.FormattingEnabled = true;
            this.teacherComboBox.Location = new System.Drawing.Point(35, 180);
            this.teacherComboBox.Name = "teacherComboBox";
            this.teacherComboBox.Size = new System.Drawing.Size(198, 28);
            this.teacherComboBox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(103, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Osztály:";
            // 
            // classComboBox
            // 
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(109, 72);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(44, 28);
            this.classComboBox.TabIndex = 29;
            this.classComboBox.SelectionChangeCommitted += new System.EventHandler(this.classComboBox_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(42, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Óra";
            // 
            // hourComboBox
            // 
            this.hourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hourComboBox.FormattingEnabled = true;
            this.hourComboBox.Location = new System.Drawing.Point(37, 254);
            this.hourComboBox.Name = "hourComboBox";
            this.hourComboBox.Size = new System.Drawing.Size(44, 28);
            this.hourComboBox.TabIndex = 31;
            // 
            // actualCertifyCheckBox
            // 
            this.actualCertifyCheckBox.AutoSize = true;
            this.actualCertifyCheckBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualCertifyCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.actualCertifyCheckBox.Location = new System.Drawing.Point(146, 275);
            this.actualCertifyCheckBox.Name = "actualCertifyCheckBox";
            this.actualCertifyCheckBox.Size = new System.Drawing.Size(67, 24);
            this.actualCertifyCheckBox.TabIndex = 34;
            this.actualCertifyCheckBox.Text = "Igazolt";
            this.actualCertifyCheckBox.UseVisualStyleBackColor = true;
            // 
            // actualDelayCheckBox
            // 
            this.actualDelayCheckBox.AutoSize = true;
            this.actualDelayCheckBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualDelayCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.actualDelayCheckBox.Location = new System.Drawing.Point(146, 231);
            this.actualDelayCheckBox.Name = "actualDelayCheckBox";
            this.actualDelayCheckBox.Size = new System.Drawing.Size(67, 24);
            this.actualDelayCheckBox.TabIndex = 33;
            this.actualDelayCheckBox.Text = "Késés";
            this.actualDelayCheckBox.UseVisualStyleBackColor = true;
            // 
            // NewOmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(263, 460);
            this.Controls.Add(this.actualCertifyCheckBox);
            this.Controls.Add(this.actualDelayCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hourComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.teacherComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.omissionDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studenNameCombobox);
            this.Controls.Add(this.omissionInsertButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewOmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Userdatascreen";
            this.Load += new System.EventHandler(this.NewOmission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.Button omissionInsertButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox studenNameCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker omissionDateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox teacherComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox hourComboBox;
        private System.Windows.Forms.CheckBox actualCertifyCheckBox;
        private System.Windows.Forms.CheckBox actualDelayCheckBox;
    }
}