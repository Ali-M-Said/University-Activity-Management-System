using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ClubMembershipStatusForm : Form
    {
        private void InitializeComponent()
        {
            this.lblClubMembershipStatus = new System.Windows.Forms.Label();
            this.dgvClubMemberships = new System.Windows.Forms.DataGridView();
            this.ClubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubMemberships)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClubMembershipStatus
            // 
            this.lblClubMembershipStatus.AutoSize = true;
            this.lblClubMembershipStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblClubMembershipStatus.Location = new System.Drawing.Point(20, 20);
            this.lblClubMembershipStatus.Name = "lblClubMembershipStatus";
            this.lblClubMembershipStatus.Size = new System.Drawing.Size(232, 24);
            this.lblClubMembershipStatus.TabIndex = 0;
            this.lblClubMembershipStatus.Text = "Current Club Memberships";
            // 
            // dgvClubMemberships
            // 
            this.dgvClubMemberships.AllowUserToAddRows = false;
            this.dgvClubMemberships.AllowUserToDeleteRows = false;
            this.dgvClubMemberships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClubMemberships.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClubName,
            this.JoinDate,
            this.MemStatus});
            this.dgvClubMemberships.Location = new System.Drawing.Point(20, 60);
            this.dgvClubMemberships.Name = "dgvClubMemberships";
            this.dgvClubMemberships.ReadOnly = true;
            this.dgvClubMemberships.RowHeadersWidth = 51;
            this.dgvClubMemberships.RowTemplate.Height = 24;
            this.dgvClubMemberships.Size = new System.Drawing.Size(540, 300);
            this.dgvClubMemberships.TabIndex = 1;
            // 
            // ClubName
            // 
            this.ClubName.HeaderText = "Club Name";
            this.ClubName.MinimumWidth = 6;
            this.ClubName.Name = "ClubName";
            this.ClubName.ReadOnly = true;
            this.ClubName.Width = 150;
            // 
            // JoinDate
            // 
            this.JoinDate.HeaderText = "Join Date";
            this.JoinDate.MinimumWidth = 6;
            this.JoinDate.Name = "JoinDate";
            this.JoinDate.ReadOnly = true;
            this.JoinDate.Width = 150;
            // 
            // MemStatus
            // 
            this.MemStatus.HeaderText = "Membership Status";
            this.MemStatus.MinimumWidth = 6;
            this.MemStatus.Name = "MemStatus";
            this.MemStatus.ReadOnly = true;
            this.MemStatus.Width = 200;
            // 
            // ClubMembershipStatusForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.dgvClubMemberships);
            this.Controls.Add(this.lblClubMembershipStatus);
            this.Name = "ClubMembershipStatusForm";
            this.Text = "Club Membership Status";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubMemberships)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Declare controls as private members
        private Label lblClubMembershipStatus;
        private DataGridView dgvClubMemberships;
        private DataGridViewTextBoxColumn ClubName;
        private DataGridViewTextBoxColumn JoinDate;
        private DataGridViewTextBoxColumn MemStatus;
    }
}
