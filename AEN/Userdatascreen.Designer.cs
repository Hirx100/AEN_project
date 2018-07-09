namespace AEN
{
    partial class Userdatascreen
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
            this.userDataScreenUserNameTextBox = new System.Windows.Forms.TextBox();
            this.userDataScreenNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userDataScreenBornDateTextBox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userDataScreenNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userDataScreenNewPasswordAgainTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            // userDataScreenUserNameTextBox
            // 
            this.userDataScreenUserNameTextBox.Location = new System.Drawing.Point(84, 144);
            this.userDataScreenUserNameTextBox.Name = "userDataScreenUserNameTextBox";
            this.userDataScreenUserNameTextBox.ReadOnly = true;
            this.userDataScreenUserNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.userDataScreenUserNameTextBox.TabIndex = 6;
            // 
            // userDataScreenNewPasswordTextBox
            // 
            this.userDataScreenNewPasswordTextBox.Location = new System.Drawing.Point(84, 251);
            this.userDataScreenNewPasswordTextBox.Name = "userDataScreenNewPasswordTextBox";
            this.userDataScreenNewPasswordTextBox.Size = new System.Drawing.Size(104, 20);
            this.userDataScreenNewPasswordTextBox.TabIndex = 7;
            // 
            // userDataScreenBornDateTextBox
            // 
            this.userDataScreenBornDateTextBox.Location = new System.Drawing.Point(68, 195);
            this.userDataScreenBornDateTextBox.Name = "userDataScreenBornDateTextBox";
            this.userDataScreenBornDateTextBox.Size = new System.Drawing.Size(136, 20);
            this.userDataScreenBornDateTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(74, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Felhasználónév:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(69, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Jelszó módósítás:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(73, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Születési dátum:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userDataScreenNameTextBox
            // 
            this.userDataScreenNameTextBox.Location = new System.Drawing.Point(84, 83);
            this.userDataScreenNameTextBox.Name = "userDataScreenNameTextBox";
            this.userDataScreenNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.userDataScreenNameTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(116, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Név:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(76, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Jelszó ismétlés:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userDataScreenNewPasswordAgainTextBox
            // 
            this.userDataScreenNewPasswordAgainTextBox.Location = new System.Drawing.Point(84, 302);
            this.userDataScreenNewPasswordAgainTextBox.Name = "userDataScreenNewPasswordAgainTextBox";
            this.userDataScreenNewPasswordAgainTextBox.Size = new System.Drawing.Size(104, 20);
            this.userDataScreenNewPasswordAgainTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Userdatascreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(263, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userDataScreenNewPasswordAgainTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userDataScreenNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userDataScreenBornDateTextBox);
            this.Controls.Add(this.userDataScreenNewPasswordTextBox);
            this.Controls.Add(this.userDataScreenUserNameTextBox);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Userdatascreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Userdatascreen";
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.TextBox userDataScreenUserNameTextBox;
        private System.Windows.Forms.TextBox userDataScreenNewPasswordTextBox;
        private System.Windows.Forms.DateTimePicker userDataScreenBornDateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userDataScreenNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userDataScreenNewPasswordAgainTextBox;
        private System.Windows.Forms.Button button1;
    }
}