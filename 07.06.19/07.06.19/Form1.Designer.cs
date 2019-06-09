namespace _07._06._19
{
    partial class Form1
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
            System.Windows.Forms.Button btnLogIn;
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUseName = new System.Windows.Forms.TextBox();
            this.ttxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.chcBox = new System.Windows.Forms.CheckBox();
            btnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = System.Drawing.Color.Transparent;
            btnLogIn.BackgroundImage = global::_07._06._19.Properties.Resources._0;
            btnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnLogIn.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLogIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnLogIn.Location = new System.Drawing.Point(364, 315);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new System.Drawing.Size(200, 125);
            btnLogIn.TabIndex = 4;
            btnLogIn.Text = "Log In";
            btnLogIn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(34, 315);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(106, 25);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User-name";
            // 
            // txtUseName
            // 
            this.txtUseName.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUseName.Location = new System.Drawing.Point(39, 363);
            this.txtUseName.Name = "txtUseName";
            this.txtUseName.Size = new System.Drawing.Size(292, 33);
            this.txtUseName.TabIndex = 1;
            // 
            // ttxPassword
            // 
            this.ttxPassword.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttxPassword.Location = new System.Drawing.Point(39, 457);
            this.ttxPassword.Name = "ttxPassword";
            this.ttxPassword.Size = new System.Drawing.Size(292, 33);
            this.ttxPassword.TabIndex = 3;
            this.ttxPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(34, 415);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password ";
            // 
            // chcBox
            // 
            this.chcBox.AutoSize = true;
            this.chcBox.BackColor = System.Drawing.Color.Transparent;
            this.chcBox.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chcBox.Location = new System.Drawing.Point(375, 457);
            this.chcBox.Name = "chcBox";
            this.chcBox.Size = new System.Drawing.Size(165, 29);
            this.chcBox.TabIndex = 5;
            this.chcBox.Text = "Show-password";
            this.chcBox.UseVisualStyleBackColor = false;
            this.chcBox.CheckedChanged += new System.EventHandler(this.chcBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::_07._06._19.Properties.Resources.ffcfc068_adc6_45dc_b633_61103d7d1db6_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 502);
            this.Controls.Add(this.chcBox);
            this.Controls.Add(btnLogIn);
            this.Controls.Add(this.ttxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUseName);
            this.Controls.Add(this.lblUserName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUseName;
        private System.Windows.Forms.TextBox ttxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chcBox;
    }
}

