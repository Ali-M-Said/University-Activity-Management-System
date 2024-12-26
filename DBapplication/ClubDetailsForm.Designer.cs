using System.Windows.Forms;

namespace DBapplication
{
    partial class ClubDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblClubName;
        private TextBox txtClubName;
        private Label lblClubDescription;
        private TextBox txtClubDescription;
        private Label lblStudentID;
        private TextBox txtTotalMembers;
        private DataGridView dgvClubMembers;
        private Button btnEditClubDetails;
        private Button btnRemoveMember;

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
            this.lblClubName = new System.Windows.Forms.Label();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.lblClubDescription = new System.Windows.Forms.Label();
            this.txtClubDescription = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtTotalMembers = new System.Windows.Forms.TextBox();
            this.dgvClubMembers = new System.Windows.Forms.DataGridView();
            this.btnEditClubDetails = new System.Windows.Forms.Button();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.ButtMemberships = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(19, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(152, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Club Details";
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
            // txtClubName
            // 
            this.txtClubName.Location = new System.Drawing.Point(134, 60);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.ReadOnly = true;
            this.txtClubName.Size = new System.Drawing.Size(200, 22);
            this.txtClubName.TabIndex = 2;
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
            // txtClubDescription
            // 
            this.txtClubDescription.Location = new System.Drawing.Point(134, 100);
            this.txtClubDescription.Multiline = true;
            this.txtClubDescription.Name = "txtClubDescription";
            this.txtClubDescription.ReadOnly = true;
            this.txtClubDescription.Size = new System.Drawing.Size(347, 60);
            this.txtClubDescription.TabIndex = 4;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(21, 413);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(68, 16);
            this.lblStudentID.TabIndex = 7;
            this.lblStudentID.Text = "Student ID";
            // 
            // txtTotalMembers
            // 
            this.txtTotalMembers.Location = new System.Drawing.Point(108, 410);
            this.txtTotalMembers.Name = "txtTotalMembers";
            this.txtTotalMembers.ReadOnly = true;
            this.txtTotalMembers.Size = new System.Drawing.Size(200, 22);
            this.txtTotalMembers.TabIndex = 8;
            // 
            // dgvClubMembers
            // 
            this.dgvClubMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClubMembers.Location = new System.Drawing.Point(23, 184);
            this.dgvClubMembers.Name = "dgvClubMembers";
            this.dgvClubMembers.RowHeadersWidth = 51;
            this.dgvClubMembers.Size = new System.Drawing.Size(586, 200);
            this.dgvClubMembers.TabIndex = 9;
            // 
            // btnEditClubDetails
            // 
            this.btnEditClubDetails.Location = new System.Drawing.Point(299, 464);
            this.btnEditClubDetails.Name = "btnEditClubDetails";
            this.btnEditClubDetails.Size = new System.Drawing.Size(150, 30);
            this.btnEditClubDetails.TabIndex = 10;
            this.btnEditClubDetails.Text = "Edit Club Details";
            this.btnEditClubDetails.UseVisualStyleBackColor = true;
            this.btnEditClubDetails.Click += new System.EventHandler(this.btnEditClubDetails_Click);
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Location = new System.Drawing.Point(459, 464);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(150, 30);
            this.btnRemoveMember.TabIndex = 11;
            this.btnRemoveMember.Text = "Remove Member";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            // 
            // ButtMemberships
            // 
            this.ButtMemberships.Location = new System.Drawing.Point(624, 464);
            this.ButtMemberships.Name = "ButtMemberships";
            this.ButtMemberships.Size = new System.Drawing.Size(150, 30);
            this.ButtMemberships.TabIndex = 12;
            this.ButtMemberships.Text = "Pending Memberships";
            this.ButtMemberships.UseVisualStyleBackColor = true;
            // 
            // ClubDetailsForm
            // 
            this.ClientSize = new System.Drawing.Size(807, 520);
            this.Controls.Add(this.ButtMemberships);
            this.Controls.Add(this.btnRemoveMember);
            this.Controls.Add(this.btnEditClubDetails);
            this.Controls.Add(this.dgvClubMembers);
            this.Controls.Add(this.txtTotalMembers);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtClubDescription);
            this.Controls.Add(this.lblClubDescription);
            this.Controls.Add(this.txtClubName);
            this.Controls.Add(this.lblClubName);
            this.Controls.Add(this.lblTitle);
            this.Name = "ClubDetailsForm";
            this.Text = "Club Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button ButtMemberships;
    }
}
