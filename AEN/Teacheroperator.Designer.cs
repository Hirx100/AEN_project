namespace AEN
{
    partial class Teacheroperator
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
            this.teacherDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.actualPasswordtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.actualTeacherNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.newTeacherButton = new System.Windows.Forms.Button();
            this.actualBornDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateTeacherbutton = new System.Windows.Forms.Button();
            this.deleteTeacherButton = new System.Windows.Forms.Button();
            this.actualAccountNametextBox = new System.Windows.Forms.TextBox();
            this.logOutButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.userControl11 = new AEN.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherDataGridView
            // 
            this.teacherDataGridView.AllowUserToAddRows = false;
            this.teacherDataGridView.AllowUserToDeleteRows = false;
            this.teacherDataGridView.AllowUserToResizeColumns = false;
            this.teacherDataGridView.AllowUserToResizeRows = false;
            this.teacherDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teacherDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.teacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDataGridView.Location = new System.Drawing.Point(12, 50);
            this.teacherDataGridView.Name = "teacherDataGridView";
            this.teacherDataGridView.ReadOnly = true;
            this.teacherDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teacherDataGridView.Size = new System.Drawing.Size(776, 287);
            this.teacherDataGridView.TabIndex = 26;
            this.teacherDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.markDataGridView_RowEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControl11);
            this.panel1.Controls.Add(this.actualPasswordtextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.actualTeacherNameTextBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.newTeacherButton);
            this.panel1.Controls.Add(this.actualBornDateTimePicker);
            this.panel1.Controls.Add(this.updateTeacherbutton);
            this.panel1.Controls.Add(this.deleteTeacherButton);
            this.panel1.Controls.Add(this.actualAccountNametextBox);
            this.panel1.Location = new System.Drawing.Point(12, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 286);
            this.panel1.TabIndex = 27;
            this.panel1.Tag = "Aktuális jegy";
            // 
            // actualPasswordtextBox
            // 
            this.actualPasswordtextBox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.actualPasswordtextBox.Location = new System.Drawing.Point(509, 123);
            this.actualPasswordtextBox.Name = "actualPasswordtextBox";
            this.actualPasswordtextBox.Size = new System.Drawing.Size(108, 26);
            this.actualPasswordtextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(450, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Jelszó:";
            // 
            // actualTeacherNameTextBox
            // 
            this.actualTeacherNameTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.actualTeacherNameTextBox.Location = new System.Drawing.Point(251, 74);
            this.actualTeacherNameTextBox.Name = "actualTeacherNameTextBox";
            this.actualTeacherNameTextBox.Size = new System.Drawing.Size(108, 26);
            this.actualTeacherNameTextBox.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(396, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Felhasználónév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(161, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Születési év:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(161, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tanár neve:";
            // 
            // newTeacherButton
            // 
            this.newTeacherButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newTeacherButton.Location = new System.Drawing.Point(328, 214);
            this.newTeacherButton.Name = "newTeacherButton";
            this.newTeacherButton.Size = new System.Drawing.Size(87, 42);
            this.newTeacherButton.TabIndex = 15;
            this.newTeacherButton.Text = "Új tanár";
            this.newTeacherButton.UseVisualStyleBackColor = true;
            this.newTeacherButton.Click += new System.EventHandler(this.newMarkButton_Click);
            // 
            // actualBornDateTimePicker
            // 
            this.actualBornDateTimePicker.Location = new System.Drawing.Point(254, 129);
            this.actualBornDateTimePicker.Name = "actualBornDateTimePicker";
            this.actualBornDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.actualBornDateTimePicker.TabIndex = 5;
            // 
            // updateTeacherbutton
            // 
            this.updateTeacherbutton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateTeacherbutton.Location = new System.Drawing.Point(215, 214);
            this.updateTeacherbutton.Name = "updateTeacherbutton";
            this.updateTeacherbutton.Size = new System.Drawing.Size(87, 42);
            this.updateTeacherbutton.TabIndex = 14;
            this.updateTeacherbutton.Text = "Modosítás";
            this.updateTeacherbutton.UseVisualStyleBackColor = true;
            this.updateTeacherbutton.Click += new System.EventHandler(this.updateMarkbutton_Click);
            // 
            // deleteTeacherButton
            // 
            this.deleteTeacherButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteTeacherButton.Location = new System.Drawing.Point(97, 214);
            this.deleteTeacherButton.Name = "deleteTeacherButton";
            this.deleteTeacherButton.Size = new System.Drawing.Size(87, 42);
            this.deleteTeacherButton.TabIndex = 13;
            this.deleteTeacherButton.Text = "Törlés";
            this.deleteTeacherButton.UseVisualStyleBackColor = true;
            this.deleteTeacherButton.Click += new System.EventHandler(this.deleteMarkButton_Click);
            // 
            // actualAccountNametextBox
            // 
            this.actualAccountNametextBox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.actualAccountNametextBox.Location = new System.Drawing.Point(509, 74);
            this.actualAccountNametextBox.Name = "actualAccountNametextBox";
            this.actualAccountNametextBox.ReadOnly = true;
            this.actualAccountNametextBox.Size = new System.Drawing.Size(108, 26);
            this.actualAccountNametextBox.TabIndex = 0;
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
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(509, 214);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(104, 42);
            this.userControl11.TabIndex = 23;
            // 
            // Teacheroperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 666);
            this.Controls.Add(this.teacherDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teacheroperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView teacherDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker actualBornDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox actualAccountNametextBox;
        private System.Windows.Forms.Button newTeacherButton;
        private System.Windows.Forms.Button updateTeacherbutton;
        private System.Windows.Forms.Button deleteTeacherButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox actualPasswordtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox actualTeacherNameTextBox;
        private UserControl1 userControl11;
    }
}