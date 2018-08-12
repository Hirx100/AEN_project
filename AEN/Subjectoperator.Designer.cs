namespace AEN
{
    partial class Subjectoperator
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
            this.subjectDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControl11 = new AEN.UserControl1();
            this.actualSubjectTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.newSubjectButton = new System.Windows.Forms.Button();
            this.updateSubjectButton = new System.Windows.Forms.Button();
            this.deleteSubjcetButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectDataGridView
            // 
            this.subjectDataGridView.AllowUserToAddRows = false;
            this.subjectDataGridView.AllowUserToDeleteRows = false;
            this.subjectDataGridView.AllowUserToResizeColumns = false;
            this.subjectDataGridView.AllowUserToResizeRows = false;
            this.subjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subjectDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.subjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectDataGridView.Location = new System.Drawing.Point(19, 50);
            this.subjectDataGridView.Name = "subjectDataGridView";
            this.subjectDataGridView.ReadOnly = true;
            this.subjectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectDataGridView.Size = new System.Drawing.Size(529, 287);
            this.subjectDataGridView.TabIndex = 26;
            this.subjectDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.classDataGridView_RowEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControl11);
            this.panel1.Controls.Add(this.actualSubjectTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.newSubjectButton);
            this.panel1.Controls.Add(this.updateSubjectButton);
            this.panel1.Controls.Add(this.deleteSubjcetButton);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(19, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 286);
            this.panel1.TabIndex = 27;
            this.panel1.Tag = "";
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(387, 198);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(138, 83);
            this.userControl11.TabIndex = 21;
            // 
            // actualSubjectTextBox
            // 
            this.actualSubjectTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.actualSubjectTextBox.Location = new System.Drawing.Point(260, 98);
            this.actualSubjectTextBox.MaxLength = 2;
            this.actualSubjectTextBox.Name = "actualSubjectTextBox";
            this.actualSubjectTextBox.Size = new System.Drawing.Size(121, 26);
            this.actualSubjectTextBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(124, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tantárgy neve:";
            // 
            // newSubjectButton
            // 
            this.newSubjectButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newSubjectButton.Location = new System.Drawing.Point(260, 206);
            this.newSubjectButton.Name = "newSubjectButton";
            this.newSubjectButton.Size = new System.Drawing.Size(87, 42);
            this.newSubjectButton.TabIndex = 15;
            this.newSubjectButton.Text = "Új Tantárgy";
            this.newSubjectButton.UseVisualStyleBackColor = true;
            this.newSubjectButton.Click += new System.EventHandler(this.newStudentButton_Click);
            // 
            // updateSubjectButton
            // 
            this.updateSubjectButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateSubjectButton.Location = new System.Drawing.Point(147, 206);
            this.updateSubjectButton.Name = "updateSubjectButton";
            this.updateSubjectButton.Size = new System.Drawing.Size(87, 42);
            this.updateSubjectButton.TabIndex = 14;
            this.updateSubjectButton.Text = "Modosítás";
            this.updateSubjectButton.UseVisualStyleBackColor = true;
            this.updateSubjectButton.Click += new System.EventHandler(this.updateSubjectButton_Click);
            // 
            // deleteSubjcetButton
            // 
            this.deleteSubjcetButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteSubjcetButton.Location = new System.Drawing.Point(29, 206);
            this.deleteSubjcetButton.Name = "deleteSubjcetButton";
            this.deleteSubjcetButton.Size = new System.Drawing.Size(87, 42);
            this.deleteSubjcetButton.TabIndex = 13;
            this.deleteSubjcetButton.Text = "Törlés";
            this.deleteSubjcetButton.UseVisualStyleBackColor = true;
            this.deleteSubjcetButton.Click += new System.EventHandler(this.deleteSubjectButton_Click);
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
            // Subjectoperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(560, 666);
            this.Controls.Add(this.subjectDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Subjectoperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView subjectDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newSubjectButton;
        private System.Windows.Forms.Button updateSubjectButton;
        private System.Windows.Forms.Button deleteSubjcetButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox actualSubjectTextBox;
        private UserControl1 userControl11;
    }
}