namespace CRM
{
    partial class Signupform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signupform));
            this.pictureBoxsignupLogo = new System.Windows.Forms.PictureBox();
            this.btnSignUp1 = new System.Windows.Forms.Button();
            this.Namelabelsignup = new System.Windows.Forms.Label();
            this.Emailaddresslabelsignup = new System.Windows.Forms.Label();
            this.Passwordlabelsignup = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsignupLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxsignupLogo
            // 
            this.pictureBoxsignupLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxsignupLogo.BackgroundImage")));
            this.pictureBoxsignupLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxsignupLogo.Location = new System.Drawing.Point(101, 12);
            this.pictureBoxsignupLogo.Name = "pictureBoxsignupLogo";
            this.pictureBoxsignupLogo.Size = new System.Drawing.Size(145, 122);
            this.pictureBoxsignupLogo.TabIndex = 1;
            this.pictureBoxsignupLogo.TabStop = false;
            // 
            // btnSignUp1
            // 
            this.btnSignUp1.Location = new System.Drawing.Point(101, 328);
            this.btnSignUp1.Name = "btnSignUp1";
            this.btnSignUp1.Size = new System.Drawing.Size(145, 31);
            this.btnSignUp1.TabIndex = 2;
            this.btnSignUp1.Text = "Sign up";
            this.btnSignUp1.UseVisualStyleBackColor = true;
            // 
            // Namelabelsignup
            // 
            this.Namelabelsignup.AutoSize = true;
            this.Namelabelsignup.Location = new System.Drawing.Point(98, 166);
            this.Namelabelsignup.Name = "Namelabelsignup";
            this.Namelabelsignup.Size = new System.Drawing.Size(38, 13);
            this.Namelabelsignup.TabIndex = 3;
            this.Namelabelsignup.Text = "Name ";
            // 
            // Emailaddresslabelsignup
            // 
            this.Emailaddresslabelsignup.AutoSize = true;
            this.Emailaddresslabelsignup.Location = new System.Drawing.Point(98, 210);
            this.Emailaddresslabelsignup.Name = "Emailaddresslabelsignup";
            this.Emailaddresslabelsignup.Size = new System.Drawing.Size(73, 13);
            this.Emailaddresslabelsignup.TabIndex = 4;
            this.Emailaddresslabelsignup.Text = "Email Address";
            // 
            // Passwordlabelsignup
            // 
            this.Passwordlabelsignup.AutoSize = true;
            this.Passwordlabelsignup.Location = new System.Drawing.Point(98, 261);
            this.Passwordlabelsignup.Name = "Passwordlabelsignup";
            this.Passwordlabelsignup.Size = new System.Drawing.Size(56, 13);
            this.Passwordlabelsignup.TabIndex = 5;
            this.Passwordlabelsignup.Text = "Password ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 226);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 277);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 20);
            this.textBox3.TabIndex = 8;
            // 
            // Signupform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 411);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Passwordlabelsignup);
            this.Controls.Add(this.Emailaddresslabelsignup);
            this.Controls.Add(this.Namelabelsignup);
            this.Controls.Add(this.btnSignUp1);
            this.Controls.Add(this.pictureBoxsignupLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signupform";
            this.Text = "Signupform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsignupLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxsignupLogo;
        private System.Windows.Forms.Button btnSignUp1;
        private System.Windows.Forms.Label Namelabelsignup;
        private System.Windows.Forms.Label Emailaddresslabelsignup;
        private System.Windows.Forms.Label Passwordlabelsignup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}