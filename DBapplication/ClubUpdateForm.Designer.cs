using System;
using System.Windows.Forms; // Added necessary namespace

namespace DBapplication
{
    partial class ClubUpdateForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private TextBox txtClubName;
        private TextBox txtClubDescription;
        private Button btnSave;
        private Button btnCancel;
        private Label lblClubName;
        private Label lblClubDescription;

        // Correcting namespace issues (add the appropriate namespaces at the top)
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.txtClubDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblClubName = new System.Windows.Forms.Label();
            this.lblClubDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Update Club Details";
            // 
            // txtClubName
            // 
            this.txtClubName.Location = new System.Drawing.Point(100, 60);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.Size = new System.Drawing.Size(200, 22);
            this.txtClubName.TabIndex = 2;
            // 
            // txtClubDescription
            // 
            this.txtClubDescription.Location = new System.Drawing.Point(134, 100);
            this.txtClubDescription.Multiline = true;
            this.txtClubDescription.Name = "txtClubDescription";
            this.txtClubDescription.Size = new System.Drawing.Size(200, 60);
            this.txtClubDescription.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(220, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblClubName
            // 
            this.lblClubName.AutoSize = true;
            this.lblClubName.Location = new System.Drawing.Point(20, 60);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(77, 16);
            this.lblClubName.TabIndex = 1;
            this.lblClubName.Text = "Club Name:";
            // 
            // lblClubDescription
            // 
            this.lblClubDescription.AutoSize = true;
            this.lblClubDescription.Location = new System.Drawing.Point(20, 100);
            this.lblClubDescription.Name = "lblClubDescription";
            this.lblClubDescription.Size = new System.Drawing.Size(108, 16);
            this.lblClubDescription.TabIndex = 3;
            this.lblClubDescription.Text = "Club Description:";
            // 
            // ClubUpdateForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 270);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtClubDescription);
            this.Controls.Add(this.lblClubDescription);
            this.Controls.Add(this.txtClubName);
            this.Controls.Add(this.lblClubName);
            this.Controls.Add(this.lblTitle);
            this.Name = "ClubUpdateForm";
            this.Text = "Update Club Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
