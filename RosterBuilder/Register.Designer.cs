namespace RosterBuilder
{
    partial class Register
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
            this.registerbtn = new System.Windows.Forms.Button();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.logintext = new System.Windows.Forms.TextBox();
            this.reglogin = new System.Windows.Forms.Label();
            this.regpass = new System.Windows.Forms.Label();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.regemail = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerbtn
            // 
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerbtn.Location = new System.Drawing.Point(294, 260);
            this.registerbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(150, 40);
            this.registerbtn.TabIndex = 0;
            this.registerbtn.Text = "Sign Up";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(223, 145);
            this.passwordtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.PasswordChar = '*';
            this.passwordtext.Size = new System.Drawing.Size(298, 26);
            this.passwordtext.TabIndex = 5;
            // 
            // logintext
            // 
            this.logintext.Location = new System.Drawing.Point(223, 105);
            this.logintext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logintext.Name = "logintext";
            this.logintext.Size = new System.Drawing.Size(298, 26);
            this.logintext.TabIndex = 6;
            // 
            // reglogin
            // 
            this.reglogin.AutoSize = true;
            this.reglogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reglogin.Location = new System.Drawing.Point(124, 116);
            this.reglogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reglogin.Name = "reglogin";
            this.reglogin.Size = new System.Drawing.Size(48, 20);
            this.reglogin.TabIndex = 7;
            this.reglogin.Text = "Login";
            // 
            // regpass
            // 
            this.regpass.AutoSize = true;
            this.regpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.regpass.Location = new System.Drawing.Point(124, 156);
            this.regpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.regpass.Name = "regpass";
            this.regpass.Size = new System.Drawing.Size(78, 20);
            this.regpass.TabIndex = 8;
            this.regpass.Text = "Password";
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(223, 185);
            this.emailtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(298, 26);
            this.emailtext.TabIndex = 10;
            // 
            // regemail
            // 
            this.regemail.AutoSize = true;
            this.regemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.regemail.Location = new System.Drawing.Point(124, 193);
            this.regemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.regemail.Name = "regemail";
            this.regemail.Size = new System.Drawing.Size(48, 20);
            this.regemail.TabIndex = 11;
            this.regemail.Text = "Email";
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backbtn.Location = new System.Drawing.Point(294, 310);
            this.backbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(150, 40);
            this.backbtn.TabIndex = 12;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(756, 526);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.regemail);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.regpass);
            this.Controls.Add(this.reglogin);
            this.Controls.Add(this.logintext);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.registerbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.TextBox logintext;
        private System.Windows.Forms.Label reglogin;
        private System.Windows.Forms.Label regpass;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.Label regemail;
        private System.Windows.Forms.Button backbtn;
    }
}