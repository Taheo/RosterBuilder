namespace RosterBuilder
{
    partial class RosterView
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.totalbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backbtn = new System.Windows.Forms.Button();
            this.unitnamebox = new System.Windows.Forms.TextBox();
            this.unittypebox = new System.Windows.Forms.TextBox();
            this.modelcostbox = new System.Windows.Forms.TextBox();
            this.armylist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rosterlist = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 283);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(14, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Model Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(267, 489);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(218, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Roster";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(37, 364);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(79, 30);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "Add To Army";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(564, 477);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(90, 55);
            this.savebtn.TabIndex = 14;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            // 
            // totalbox
            // 
            this.totalbox.Location = new System.Drawing.Point(330, 495);
            this.totalbox.Name = "totalbox";
            this.totalbox.Size = new System.Drawing.Size(80, 20);
            this.totalbox.TabIndex = 16;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(882, 477);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(90, 55);
            this.backbtn.TabIndex = 17;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // unitnamebox
            // 
            this.unitnamebox.Location = new System.Drawing.Point(77, 258);
            this.unitnamebox.Name = "unitnamebox";
            this.unitnamebox.Size = new System.Drawing.Size(115, 20);
            this.unitnamebox.TabIndex = 18;
            // 
            // unittypebox
            // 
            this.unittypebox.Location = new System.Drawing.Point(77, 280);
            this.unittypebox.Name = "unittypebox";
            this.unittypebox.Size = new System.Drawing.Size(115, 20);
            this.unittypebox.TabIndex = 19;
            // 
            // modelcostbox
            // 
            this.modelcostbox.Location = new System.Drawing.Point(92, 311);
            this.modelcostbox.Name = "modelcostbox";
            this.modelcostbox.Size = new System.Drawing.Size(100, 20);
            this.modelcostbox.TabIndex = 20;
            // 
            // armylist
            // 
            this.armylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.armylist.Location = new System.Drawing.Point(221, 29);
            this.armylist.Name = "armylist";
            this.armylist.Size = new System.Drawing.Size(751, 198);
            this.armylist.TabIndex = 21;
            this.armylist.UseCompatibleStateImageBehavior = false;
            this.armylist.View = System.Windows.Forms.View.Details;
            this.armylist.ItemActivate += new System.EventHandler(this.armylist_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Unit Nick";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cost";
            // 
            // rosterlist
            // 
            this.rosterlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.rosterlist.Location = new System.Drawing.Point(221, 273);
            this.rosterlist.Name = "rosterlist";
            this.rosterlist.Size = new System.Drawing.Size(751, 198);
            this.rosterlist.TabIndex = 22;
            this.rosterlist.UseCompatibleStateImageBehavior = false;
            this.rosterlist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unit Nick";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Type";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cost";
            // 
            // countbtn
            // 
            this.countbtn.Location = new System.Drawing.Point(468, 477);
            this.countbtn.Name = "countbtn";
            this.countbtn.Size = new System.Drawing.Size(90, 55);
            this.countbtn.TabIndex = 23;
            this.countbtn.Text = "Count";
            this.countbtn.UseVisualStyleBackColor = true;
            this.countbtn.Click += new System.EventHandler(this.countbtn_Click);
            // 
            // RosterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 606);
            this.Controls.Add(this.countbtn);
            this.Controls.Add(this.rosterlist);
            this.Controls.Add(this.armylist);
            this.Controls.Add(this.modelcostbox);
            this.Controls.Add(this.unittypebox);
            this.Controls.Add(this.unitnamebox);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.totalbox);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RosterView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roster Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RosterView_FormClosing);
            this.Load += new System.EventHandler(this.RosterView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox totalbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox unitnamebox;
        private System.Windows.Forms.TextBox unittypebox;
        private System.Windows.Forms.TextBox modelcostbox;
        private System.Windows.Forms.ListView armylist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView rosterlist;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button countbtn;
    }
}

