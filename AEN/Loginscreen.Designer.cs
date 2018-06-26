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
            this.minimize_button = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button)).BeginInit();
            this.SuspendLayout();
            // 
            // minimize_button
            // 
            this.minimize_button.Image = global::AEN.Properties.Resources.minimize_button;
            this.minimize_button.Location = new System.Drawing.Point(380, 12);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(32, 32);
            this.minimize_button.TabIndex = 1;
            this.minimize_button.TabStop = false;
            this.minimize_button.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // exit_button
            // 
            this.exit_button.Image = global::AEN.Properties.Resources.exit_button;
            this.exit_button.Location = new System.Drawing.Point(418, 12);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(32, 32);
            this.exit_button.TabIndex = 0;
            this.exit_button.TabStop = false;
            this.exit_button.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Loginscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(462, 441);
            this.Controls.Add(this.minimize_button);
            this.Controls.Add(this.exit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loginscreen";
            this.Text = "AEN Login";
            ((System.ComponentModel.ISupportInitialize)(this.minimize_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox exit_button;
        private System.Windows.Forms.PictureBox minimize_button;
    }
}

