﻿namespace RosterBuilder
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
            this.SuspendLayout();
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(208, 302);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(100, 55);
            this.registerbtn.TabIndex = 0;
            this.registerbtn.Text = "Sign Up";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(156, 221);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(200, 20);
            this.passwordtext.TabIndex = 5;
            // 
            // logintext
            // 
            this.logintext.Location = new System.Drawing.Point(156, 195);
            this.logintext.Name = "logintext";
            this.logintext.Size = new System.Drawing.Size(200, 20);
            this.logintext.TabIndex = 6;
            // 
            // reglogin
            // 
            this.reglogin.AutoSize = true;
            this.reglogin.Location = new System.Drawing.Point(90, 202);
            this.reglogin.Name = "reglogin";
            this.reglogin.Size = new System.Drawing.Size(33, 13);
            this.reglogin.TabIndex = 7;
            this.reglogin.Text = "Login";
            // 
            // regpass
            // 
            this.regpass.AutoSize = true;
            this.regpass.Location = new System.Drawing.Point(90, 228);
            this.regpass.Name = "regpass";
            this.regpass.Size = new System.Drawing.Size(53, 13);
            this.regpass.TabIndex = 8;
            this.regpass.Text = "Password";
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(156, 247);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(200, 20);
            this.emailtext.TabIndex = 10;
            // 
            // regemail
            // 
            this.regemail.AutoSize = true;
            this.regemail.Location = new System.Drawing.Point(90, 252);
            this.regemail.Name = "regemail";
            this.regemail.Size = new System.Drawing.Size(32, 13);
            this.regemail.TabIndex = 11;
            this.regemail.Text = "Email";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(504, 481);
            this.Controls.Add(this.regemail);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.regpass);
            this.Controls.Add(this.reglogin);
            this.Controls.Add(this.logintext);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.registerbtn);
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
    }
}