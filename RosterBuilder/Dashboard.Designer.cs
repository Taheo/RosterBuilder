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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.welcomelabel = new System.Windows.Forms.Label();
            this.nicklabel = new System.Windows.Forms.Label();
            this.addnewbtn = new System.Windows.Forms.Button();
            this.rulesbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(672, 224);
            this.textBox1.TabIndex = 0;
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Location = new System.Drawing.Point(16, 26);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(52, 13);
            this.welcomelabel.TabIndex = 2;
            this.welcomelabel.Text = "Welcome";
            // 
            // nicklabel
            // 
            this.nicklabel.AutoSize = true;
            this.nicklabel.Location = new System.Drawing.Point(72, 26);
            this.nicklabel.Name = "nicklabel";
            this.nicklabel.Size = new System.Drawing.Size(35, 13);
            this.nicklabel.TabIndex = 3;
            this.nicklabel.Text = "label2";
            // 
            // addnewbtn
            // 
            this.addnewbtn.Location = new System.Drawing.Point(712, 355);
            this.addnewbtn.Name = "addnewbtn";
            this.addnewbtn.Size = new System.Drawing.Size(90, 55);
            this.addnewbtn.TabIndex = 4;
            this.addnewbtn.Text = "New  Roster";
            this.addnewbtn.UseVisualStyleBackColor = true;
            this.addnewbtn.Click += new System.EventHandler(this.addnewbtn_Click);
            // 
            // rulesbtn
            // 
            this.rulesbtn.Location = new System.Drawing.Point(712, 416);
            this.rulesbtn.Name = "rulesbtn";
            this.rulesbtn.Size = new System.Drawing.Size(90, 55);
            this.rulesbtn.TabIndex = 5;
            this.rulesbtn.Text = "Rules";
            this.rulesbtn.UseVisualStyleBackColor = true;
            this.rulesbtn.Click += new System.EventHandler(this.rulesbtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 606);
            this.Controls.Add(this.rulesbtn);
            this.Controls.Add(this.addnewbtn);
            this.Controls.Add(this.nicklabel);
            this.Controls.Add(this.welcomelabel);
            this.Controls.Add(this.textBox1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.Label nicklabel;
        private System.Windows.Forms.Button addnewbtn;
        private System.Windows.Forms.Button rulesbtn;
    }
}