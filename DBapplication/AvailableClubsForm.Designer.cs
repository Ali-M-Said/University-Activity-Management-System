using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AvailableClubsForm : Form
    {
      

        private void InitializeComponent()
        {
            this.lblAvailableClubs = new System.Windows.Forms.Label();
            this.grpAvailableClubs = new System.Windows.Forms.GroupBox();
            this.dgvClubsList = new System.Windows.Forms.DataGridView();
            this.colClubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnJoinClub = new System.Windows.Forms.Button();
            this.grpAvailableClubs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubsList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvailableClubs
            // 
            this.lblAvailableClubs.AutoSize = true;
            this.lblAvailableClubs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAvailableClubs.Location = new System.Drawing.Point(20, 20);
            this.lblAvailableClubs.Name = "lblAvailableClubs";
            this.lblAvailableClubs.Size = new System.Drawing.Size(153, 24);
            this.lblAvailableClubs.TabIndex = 0;
            this.lblAvailableClubs.Text = "Available Clubs";
            // 
            // grpAvailableClubs
            // 
            this.grpAvailableClubs.Controls.Add(this.dgvClubsList);
            this.grpAvailableClubs.Location = new System.Drawing.Point(20, 60);
            this.grpAvailableClubs.Name = "grpAvailableClubs";
            this.grpAvailableClubs.Size = new System.Drawing.Size(600, 300);
            this.grpAvailableClubs.TabIndex = 1;
            this.grpAvailableClubs.TabStop = false;
            this.grpAvailableClubs.Text = "Clubs List";
            // 
            // dgvClubsList
            // 
            this.dgvClubsList.AllowUserToAddRows = false;
            this.dgvClubsList.AllowUserToDeleteRows = false;
            this.dgvClubsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClubsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClubName,
            this.colDescription,
            this.colSupervisor});
            this.dgvClubsList.Location = new System.Drawing.Point(20, 30);
            this.dgvClubsList.Name = "dgvClubsList";
            this.dgvClubsList.ReadOnly = true;
            this.dgvClubsList.RowHeadersWidth = 51;
            this.dgvClubsList.RowTemplate.Height = 24;
            this.dgvClubsList.Size = new System.Drawing.Size(523, 240);
            this.dgvClubsList.TabIndex = 0;
            // 
            // colClubName
            // 
            this.colClubName.HeaderText = "Club Name";
            this.colClubName.MinimumWidth = 6;
            this.colClubName.Name = "colClubName";
            this.colClubName.ReadOnly = true;
            this.colClubName.Width = 150;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.MinimumWidth = 6;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 200;
            // 
            // colSupervisor
            // 
            this.colSupervisor.HeaderText = "Supervisor";
            this.colSupervisor.MinimumWidth = 6;
            this.colSupervisor.Name = "colSupervisor";
            this.colSupervisor.ReadOnly = true;
            this.colSupervisor.Width = 120;
            // 
            // btnJoinClub
            // 
            this.btnJoinClub.Location = new System.Drawing.Point(20, 380);
            this.btnJoinClub.Name = "btnJoinClub";
            this.btnJoinClub.Size = new System.Drawing.Size(120, 30);
            this.btnJoinClub.TabIndex = 2;
            this.btnJoinClub.Text = "Join Club";
            this.btnJoinClub.UseVisualStyleBackColor = true;
            // 
            // AvailableClubsForm
            // 
            this.ClientSize = new System.Drawing.Size(640, 430);
            this.Controls.Add(this.btnJoinClub);
            this.Controls.Add(this.grpAvailableClubs);
            this.Controls.Add(this.lblAvailableClubs);
            this.Name = "AvailableClubsForm";
            this.Text = "Available Clubs";
            this.grpAvailableClubs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Declare controls as private members
        private Label lblAvailableClubs;
        private GroupBox grpAvailableClubs;
        private DataGridView dgvClubsList;
        private DataGridViewTextBoxColumn colClubName;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewTextBoxColumn colSupervisor;
        private Button btnJoinClub;
    }
}
