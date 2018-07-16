namespace AEN.UserControls
{
    partial class MarkControlPanels
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.studenNameCombobox = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.endDateTimePicker);
            this.panel2.Controls.Add(this.startDateTimePicker);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.activeCheckBox);
            this.panel2.Controls.Add(this.classComboBox);
            this.panel2.Controls.Add(this.studenNameCombobox);
            this.panel2.Location = new System.Drawing.Point(77, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 286);
            this.panel2.TabIndex = 29;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(85, 248);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.endDateTimePicker.TabIndex = 6;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(82, 207);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.startDateTimePicker.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(82, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tanuló:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Location = new System.Drawing.Point(135, 110);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(78, 17);
            this.activeCheckBox.TabIndex = 2;
            this.activeCheckBox.Text = "Csak aktív";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(17, 108);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(44, 21);
            this.classComboBox.TabIndex = 1;
            // 
            // studenNameCombobox
            // 
            this.studenNameCombobox.FormattingEnabled = true;
            this.studenNameCombobox.Location = new System.Drawing.Point(17, 61);
            this.studenNameCombobox.Name = "studenNameCombobox";
            this.studenNameCombobox.Size = new System.Drawing.Size(198, 21);
            this.studenNameCombobox.TabIndex = 0;
            // 
            // MarkControlPanels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "MarkControlPanels";
            this.Size = new System.Drawing.Size(900, 670);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox studenNameCombobox;
    }
}
