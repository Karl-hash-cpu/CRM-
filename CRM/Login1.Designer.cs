namespace CRM
{
    partial class Login1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login1));
            this.pictureBoxloginLogo = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.Passwordlabelsignup = new System.Windows.Forms.Label();
            this.Namelabelsignup = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxloginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxloginLogo
            // 
            this.pictureBoxloginLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxloginLogo.BackgroundImage")));
            this.pictureBoxloginLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxloginLogo.Location = new System.Drawing.Point(85, 12);
            this.pictureBoxloginLogo.Name = "pictureBoxloginLogo";
            this.pictureBoxloginLogo.Size = new System.Drawing.Size(145, 122);
            this.pictureBoxloginLogo.TabIndex = 2;
            this.pictureBoxloginLogo.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(85, 204);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(145, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(85, 159);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(145, 20);
            this.txtUsername.TabIndex = 11;
            // 
            // Passwordlabelsignup
            // 
            this.Passwordlabelsignup.AutoSize = true;
            this.Passwordlabelsignup.Location = new System.Drawing.Point(82, 188);
            this.Passwordlabelsignup.Name = "Passwordlabelsignup";
            this.Passwordlabelsignup.Size = new System.Drawing.Size(56, 13);
            this.Passwordlabelsignup.TabIndex = 10;
            this.Passwordlabelsignup.Text = "Password ";
            // 
            // Namelabelsignup
            // 
            this.Namelabelsignup.AutoSize = true;
            this.Namelabelsignup.Location = new System.Drawing.Point(82, 143);
            this.Namelabelsignup.Name = "Namelabelsignup";
            this.Namelabelsignup.Size = new System.Drawing.Size(55, 13);
            this.Namelabelsignup.TabIndex = 9;
            this.Namelabelsignup.Text = "Username";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(85, 290);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(145, 33);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(85, 240);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(145, 33);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 372);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Passwordlabelsignup);
            this.Controls.Add(this.Namelabelsignup);
            this.Controls.Add(this.pictureBoxloginLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login1";
            this.Text = "Login1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxloginLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxloginLogo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label Passwordlabelsignup;
        private System.Windows.Forms.Label Namelabelsignup;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogin;
    }
}