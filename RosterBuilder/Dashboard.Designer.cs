namespace RosterBuilder
{
    partial class Dashboard
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
            this.welcomelabel = new System.Windows.Forms.Label();
            this.addnewbtn = new System.Windows.Forms.Button();
            this.rulesbtn = new System.Windows.Forms.Button();
            this.infolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomelabel.Location = new System.Drawing.Point(42, 32);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(104, 26);
            this.welcomelabel.TabIndex = 2;
            this.welcomelabel.Text = "Welcome";
            // 
            // addnewbtn
            // 
            this.addnewbtn.Location = new System.Drawing.Point(376, 64);
            this.addnewbtn.Name = "addnewbtn";
            this.addnewbtn.Size = new System.Drawing.Size(179, 87);
            this.addnewbtn.TabIndex = 4;
            this.addnewbtn.Text = "New  Roster";
            this.addnewbtn.UseVisualStyleBackColor = true;
            this.addnewbtn.Click += new System.EventHandler(this.addnewbtn_Click);
            // 
            // rulesbtn
            // 
            this.rulesbtn.Location = new System.Drawing.Point(376, 177);
            this.rulesbtn.Name = "rulesbtn";
            this.rulesbtn.Size = new System.Drawing.Size(179, 87);
            this.rulesbtn.TabIndex = 5;
            this.rulesbtn.Text = "Rules";
            this.rulesbtn.UseVisualStyleBackColor = true;
            this.rulesbtn.Click += new System.EventHandler(this.rulesbtn_Click);
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infolabel.Location = new System.Drawing.Point(43, 136);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(270, 60);
            this.infolabel.TabIndex = 6;
            this.infolabel.Text = "Here you can start create new roster \r\nor \r\nlook for Mordheim rules";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 606);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.rulesbtn);
            this.Controls.Add(this.addnewbtn);
            this.Controls.Add(this.welcomelabel);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.Button addnewbtn;
        private System.Windows.Forms.Button rulesbtn;
        private System.Windows.Forms.Label infolabel;
    }
}