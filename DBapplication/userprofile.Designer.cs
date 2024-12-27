namespace DBapplication
{
    partial class userprofile
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
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.firstnametxt = new System.Windows.Forms.MaskedTextBox();
            this.emailtxt = new System.Windows.Forms.MaskedTextBox();
            this.deptxt = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.historydatagrid = new System.Windows.Forms.DataGridView();
            this.usertypebox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yeartxt = new System.Windows.Forms.MaskedTextBox();
            this.yearlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.historydatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lastnametxt
            // 
            this.lastnametxt.Location = new System.Drawing.Point(423, 82);
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(100, 22);
            this.lastnametxt.TabIndex = 0;
            // 
            // firstnametxt
            // 
            this.firstnametxt.Location = new System.Drawing.Point(423, 54);
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(100, 22);
            this.firstnametxt.TabIndex = 1;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(423, 138);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(100, 22);
            this.emailtxt.TabIndex = 2;
            // 
            // deptxt
            // 
            this.deptxt.Location = new System.Drawing.Point(423, 188);
            this.deptxt.Name = "deptxt";
            this.deptxt.Size = new System.Drawing.Size(100, 22);
            this.deptxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // historydatagrid
            // 
            this.historydatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historydatagrid.Location = new System.Drawing.Point(12, 339);
            this.historydatagrid.Name = "historydatagrid";
            this.historydatagrid.RowHeadersWidth = 51;
            this.historydatagrid.RowTemplate.Height = 24;
            this.historydatagrid.Size = new System.Drawing.Size(240, 99);
            this.historydatagrid.TabIndex = 9;
            // 
            // usertypebox
            // 
            this.usertypebox.FormattingEnabled = true;
            this.usertypebox.Location = new System.Drawing.Point(402, 216);
            this.usertypebox.Name = "usertypebox";
            this.usertypebox.Size = new System.Drawing.Size(121, 24);
            this.usertypebox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type";
            // 
            // yeartxt
            // 
            this.yeartxt.Location = new System.Drawing.Point(423, 110);
            this.yeartxt.Name = "yeartxt";
            this.yeartxt.Size = new System.Drawing.Size(100, 22);
            this.yeartxt.TabIndex = 12;
            // 
            // yearlbl
            // 
            this.yearlbl.AutoSize = true;
            this.yearlbl.Location = new System.Drawing.Point(307, 116);
            this.yearlbl.Name = "yearlbl";
            this.yearlbl.Size = new System.Drawing.Size(36, 16);
            this.yearlbl.TabIndex = 13;
            this.yearlbl.Text = "Year";
            // 
            // userprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yearlbl);
            this.Controls.Add(this.yeartxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usertypebox);
            this.Controls.Add(this.historydatagrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deptxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.firstnametxt);
            this.Controls.Add(this.lastnametxt);
            this.Name = "userprofile";
            this.Text = "userprofile";
            this.Load += new System.EventHandler(this.userprofile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historydatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.MaskedTextBox firstnametxt;
        private System.Windows.Forms.MaskedTextBox emailtxt;
        private System.Windows.Forms.MaskedTextBox deptxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView historydatagrid;
        private System.Windows.Forms.ComboBox usertypebox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox yeartxt;
        private System.Windows.Forms.Label yearlbl;
    }
}