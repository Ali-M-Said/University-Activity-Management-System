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
        private TextBox txtFacultySupervisor;
        private Button btnSave;
        private Button btnCancel;
        private Label lblClubName;
        private Label lblClubDescription;
        private Label lblFacultySupervisor;

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
            // Instantiate controls
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.txtClubDescription = new System.Windows.Forms.TextBox();
            this.txtFacultySupervisor = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblClubName = new System.Windows.Forms.Label();
            this.lblClubDescription = new System.Windows.Forms.Label();
            this.lblFacultySupervisor = new System.Windows.Forms.Label();

            // Initialize Form Components
            this.SuspendLayout();

            // Title Label
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Update Club Details";

            // Club Name
            this.lblClubName.AutoSize = true;
            this.lblClubName.Location = new System.Drawing.Point(20, 60);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(65, 13);
            this.lblClubName.TabIndex = 1;
            this.lblClubName.Text = "Club Name:";

            this.txtClubName.Location = new System.Drawing.Point(100, 60);
            this.txtClubName.Size = new System.Drawing.Size(200, 20);
            this.txtClubName.TabIndex = 2;

            // Club Description
            this.lblClubDescription.AutoSize = true;
            this.lblClubDescription.Location = new System.Drawing.Point(20, 100);
            this.lblClubDescription.Name = "lblClubDescription";
            this.lblClubDescription.Size = new System.Drawing.Size(94, 13);
            this.lblClubDescription.TabIndex = 3;
            this.lblClubDescription.Text = "Club Description:";

            this.txtClubDescription.Location = new System.Drawing.Point(120, 100);
            this.txtClubDescription.Multiline = true;
            this.txtClubDescription.Size = new System.Drawing.Size(200, 60);
            this.txtClubDescription.TabIndex = 4;

            // Faculty Supervisor
            this.lblFacultySupervisor.AutoSize = true;
            this.lblFacultySupervisor.Location = new System.Drawing.Point(20, 180);
            this.lblFacultySupervisor.Name = "lblFacultySupervisor";
            this.lblFacultySupervisor.Size = new System.Drawing.Size(105, 13);
            this.lblFacultySupervisor.TabIndex = 5;
            this.lblFacultySupervisor.Text = "Faculty Supervisor:";

            this.txtFacultySupervisor.Location = new System.Drawing.Point(120, 180);
            this.txtFacultySupervisor.Size = new System.Drawing.Size(200, 20);
            this.txtFacultySupervisor.TabIndex = 6;

            // Save Button
            this.btnSave.Location = new System.Drawing.Point(100, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;

            // Cancel Button
            this.btnCancel.Location = new System.Drawing.Point(220, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;

            // Finalize form layout
            this.ClientSize = new System.Drawing.Size(350, 270);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFacultySupervisor);
            this.Controls.Add(this.lblFacultySupervisor);
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
