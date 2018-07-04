namespace AEN
{
    partial class Loginscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginscreen));
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.permissionSelecterComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.Image = global::AEN.Properties.Resources.minimize_button;
            resources.ApplyResources(this.minimizeButton, "minimizeButton");
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Image = global::AEN.Properties.Resources.exit_button;
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // userNameLabel
            // 
            resources.ApplyResources(this.userNameLabel, "userNameLabel");
            this.userNameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.userNameLabel.Name = "userNameLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordLabel.Name = "passwordLabel";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.userNameTextBox, "userNameTextBox");
            this.userNameTextBox.Name = "userNameTextBox";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // logInButton
            // 
            resources.ApplyResources(this.logInButton, "logInButton");
            this.logInButton.Name = "logInButton";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInbutton_Click);
            // 
            // permissionSelecterComboBox
            // 
            this.permissionSelecterComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.permissionSelecterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.permissionSelecterComboBox, "permissionSelecterComboBox");
            this.permissionSelecterComboBox.FormattingEnabled = true;
            this.permissionSelecterComboBox.Name = "permissionSelecterComboBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // Loginscreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label1);
            this.Controls.Add(this.permissionSelecterComboBox);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Loginscreen";
            this.Load += new System.EventHandler(this.Loginscreen_Load);
            this.DoubleClick += new System.EventHandler(this.minimizeButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.ComboBox permissionSelecterComboBox;
        private System.Windows.Forms.Label label1;
    }
}

