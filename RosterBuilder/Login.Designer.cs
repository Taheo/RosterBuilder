namespace RosterBuilder
{
    partial class Login
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
            this.loginlabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.logintext = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginlabel.Location = new System.Drawing.Point(124, 126);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(48, 20);
            this.loginlabel.TabIndex = 0;
            this.loginlabel.Text = "Login";
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passlabel.Location = new System.Drawing.Point(124, 166);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(78, 20);
            this.passlabel.TabIndex = 1;
            this.passlabel.Text = "Password";
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginbtn.Location = new System.Drawing.Point(128, 207);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(200, 50);
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Text = "Sign In";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // logintext
            // 
            this.logintext.Location = new System.Drawing.Point(215, 126);
            this.logintext.Name = "logintext";
            this.logintext.Size = new System.Drawing.Size(113, 20);
            this.logintext.TabIndex = 3;
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(215, 166);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.PasswordChar = '*';
            this.passwordtext.Size = new System.Drawing.Size(113, 20);
            this.passwordtext.TabIndex = 4;
            // 
            // registerbtn
            // 
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerbtn.Location = new System.Drawing.Point(128, 263);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(200, 50);
            this.registerbtn.TabIndex = 5;
            this.registerbtn.Text = "Sign Up";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(504, 481);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.logintext);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.loginlabel);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox logintext;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.Button registerbtn;
    }
}