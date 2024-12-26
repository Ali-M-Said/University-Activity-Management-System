using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class PersonalScheduleForm : Form
    {
        private void InitializeComponent()
        {
            this.lblPersonalSchedule = new System.Windows.Forms.Label();
            this.dgvPersonalSchedule = new System.Windows.Forms.DataGridView();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationOrClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersonalSchedule
            // 
            this.lblPersonalSchedule.AutoSize = true;
            this.lblPersonalSchedule.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPersonalSchedule.Location = new System.Drawing.Point(20, 20);
            this.lblPersonalSchedule.Name = "lblPersonalSchedule";
            this.lblPersonalSchedule.Size = new System.Drawing.Size(236, 24);
            this.lblPersonalSchedule.TabIndex = 0;
            this.lblPersonalSchedule.Text = "Your Personal Schedule";
            // 
            // dgvPersonalSchedule
            // 
            this.dgvPersonalSchedule.AllowUserToAddRows = false;
            this.dgvPersonalSchedule.AllowUserToDeleteRows = false;
            this.dgvPersonalSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonalSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventName,
            this.ScheduleDate,
            this.ScheduleTime,
            this.LocationOrClub});
            this.dgvPersonalSchedule.Location = new System.Drawing.Point(20, 60);
            this.dgvPersonalSchedule.Name = "dgvPersonalSchedule";
            this.dgvPersonalSchedule.ReadOnly = true;
            this.dgvPersonalSchedule.RowHeadersWidth = 51;
            this.dgvPersonalSchedule.RowTemplate.Height = 24;
            this.dgvPersonalSchedule.Size = new System.Drawing.Size(691, 300);
            this.dgvPersonalSchedule.TabIndex = 1;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Event/Reservation Name";
            this.EventName.MinimumWidth = 6;
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            this.EventName.Width = 200;
            // 
            // ScheduleDate
            // 
            this.ScheduleDate.HeaderText = "Date";
            this.ScheduleDate.MinimumWidth = 6;
            this.ScheduleDate.Name = "ScheduleDate";
            this.ScheduleDate.ReadOnly = true;
            this.ScheduleDate.Width = 150;
            // 
            // ScheduleTime
            // 
            this.ScheduleTime.HeaderText = "Time";
            this.ScheduleTime.MinimumWidth = 6;
            this.ScheduleTime.Name = "ScheduleTime";
            this.ScheduleTime.ReadOnly = true;
            this.ScheduleTime.Width = 150;
            // 
            // LocationOrClub
            // 
            this.LocationOrClub.HeaderText = "Location/Club";
            this.LocationOrClub.MinimumWidth = 6;
            this.LocationOrClub.Name = "LocationOrClub";
            this.LocationOrClub.ReadOnly = true;
            this.LocationOrClub.Width = 200;
            // 
            // PersonalScheduleForm
            // 
            this.ClientSize = new System.Drawing.Size(766, 414);
            this.Controls.Add(this.dgvPersonalSchedule);
            this.Controls.Add(this.lblPersonalSchedule);
            this.Name = "PersonalScheduleForm";
            this.Text = "Personal Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Declare controls as private members
        private Label lblPersonalSchedule;
        private DataGridView dgvPersonalSchedule;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn ScheduleDate;
        private DataGridViewTextBoxColumn ScheduleTime;
        private DataGridViewTextBoxColumn LocationOrClub;
    }
}
