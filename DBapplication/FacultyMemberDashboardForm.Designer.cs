using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class FacultyMemberDashboardForm : Form
    {
      

        private void InitializeComponent()
        {
            this.lblTotalEvents = new System.Windows.Forms.Label();
            this.lblUpcomingEvents = new System.Windows.Forms.Label();
            this.lblTotalClubs = new System.Windows.Forms.Label();
            this.lblPendingMembershipRequests = new System.Windows.Forms.Label();
            this.lblFeedbackPendingResponse = new System.Windows.Forms.Label();
            this.grpEventManagement = new System.Windows.Forms.GroupBox();
            this.ViewFeedback = new System.Windows.Forms.Button();
            this.btnCreateNewEvent = new System.Windows.Forms.Button();
            this.btnManageEvents = new System.Windows.Forms.Button();
            this.btnViewFeedbackAttendance = new System.Windows.Forms.Button();
            this.grpClubManagement = new System.Windows.Forms.GroupBox();
            this.btnViewClubs = new System.Windows.Forms.Button();
            this.btnApproveMembershipRequests = new System.Windows.Forms.Button();
            this.btnAddUpdateClubs = new System.Windows.Forms.Button();
            this.grpReporting = new System.Windows.Forms.GroupBox();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpEventManagement.SuspendLayout();
            this.grpClubManagement.SuspendLayout();
            this.grpReporting.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalEvents
            // 
            this.lblTotalEvents.AutoSize = true;
            this.lblTotalEvents.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalEvents.Location = new System.Drawing.Point(20, 20);
            this.lblTotalEvents.Name = "lblTotalEvents";
            this.lblTotalEvents.Size = new System.Drawing.Size(101, 16);
            this.lblTotalEvents.TabIndex = 0;
            this.lblTotalEvents.Text = "Total Events: ";
            // 
            // lblUpcomingEvents
            // 
            this.lblUpcomingEvents.AutoSize = true;
            this.lblUpcomingEvents.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblUpcomingEvents.Location = new System.Drawing.Point(20, 50);
            this.lblUpcomingEvents.Name = "lblUpcomingEvents";
            this.lblUpcomingEvents.Size = new System.Drawing.Size(138, 16);
            this.lblUpcomingEvents.TabIndex = 1;
            this.lblUpcomingEvents.Text = "Upcoming Events: ";
            // 
            // lblTotalClubs
            // 
            this.lblTotalClubs.AutoSize = true;
            this.lblTotalClubs.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalClubs.Location = new System.Drawing.Point(20, 80);
            this.lblTotalClubs.Name = "lblTotalClubs";
            this.lblTotalClubs.Size = new System.Drawing.Size(92, 16);
            this.lblTotalClubs.TabIndex = 2;
            this.lblTotalClubs.Text = "Total Clubs: ";
            // 
            // lblPendingMembershipRequests
            // 
            this.lblPendingMembershipRequests.AutoSize = true;
            this.lblPendingMembershipRequests.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblPendingMembershipRequests.Location = new System.Drawing.Point(20, 110);
            this.lblPendingMembershipRequests.Name = "lblPendingMembershipRequests";
            this.lblPendingMembershipRequests.Size = new System.Drawing.Size(236, 16);
            this.lblPendingMembershipRequests.TabIndex = 3;
            this.lblPendingMembershipRequests.Text = "Pending Membership Requests: ";
            // 
            // lblFeedbackPendingResponse
            // 
            this.lblFeedbackPendingResponse.AutoSize = true;
            this.lblFeedbackPendingResponse.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblFeedbackPendingResponse.Location = new System.Drawing.Point(20, 140);
            this.lblFeedbackPendingResponse.Name = "lblFeedbackPendingResponse";
            this.lblFeedbackPendingResponse.Size = new System.Drawing.Size(221, 16);
            this.lblFeedbackPendingResponse.TabIndex = 4;
            this.lblFeedbackPendingResponse.Text = "Feedback Pending Response: ";
            // 
            // grpEventManagement
            // 
            this.grpEventManagement.Controls.Add(this.button1);
            this.grpEventManagement.Controls.Add(this.ViewFeedback);
            this.grpEventManagement.Controls.Add(this.btnCreateNewEvent);
            this.grpEventManagement.Controls.Add(this.btnManageEvents);
            this.grpEventManagement.Controls.Add(this.btnViewFeedbackAttendance);
            this.grpEventManagement.Location = new System.Drawing.Point(20, 180);
            this.grpEventManagement.Name = "grpEventManagement";
            this.grpEventManagement.Size = new System.Drawing.Size(254, 221);
            this.grpEventManagement.TabIndex = 5;
            this.grpEventManagement.TabStop = false;
            this.grpEventManagement.Text = "Event Management";
            // 
            // ViewFeedback
            // 
            this.ViewFeedback.Location = new System.Drawing.Point(20, 185);
            this.ViewFeedback.Name = "ViewFeedback";
            this.ViewFeedback.Size = new System.Drawing.Size(200, 30);
            this.ViewFeedback.TabIndex = 3;
            this.ViewFeedback.Text = "View Feedback";
            this.ViewFeedback.UseVisualStyleBackColor = true;
            this.ViewFeedback.Click += new System.EventHandler(this.ViewFeedback_Click);
            // 
            // btnCreateNewEvent
            // 
            this.btnCreateNewEvent.Location = new System.Drawing.Point(20, 30);
            this.btnCreateNewEvent.Name = "btnCreateNewEvent";
            this.btnCreateNewEvent.Size = new System.Drawing.Size(200, 30);
            this.btnCreateNewEvent.TabIndex = 0;
            this.btnCreateNewEvent.Text = "Create New Event";
            this.btnCreateNewEvent.UseVisualStyleBackColor = true;
            this.btnCreateNewEvent.Click += new System.EventHandler(this.btnCreateNewEvent_Click);
            // 
            // btnManageEvents
            // 
            this.btnManageEvents.Location = new System.Drawing.Point(20, 70);
            this.btnManageEvents.Name = "btnManageEvents";
            this.btnManageEvents.Size = new System.Drawing.Size(200, 30);
            this.btnManageEvents.TabIndex = 1;
            this.btnManageEvents.Text = "Manage Events";
            this.btnManageEvents.UseVisualStyleBackColor = true;
            this.btnManageEvents.Click += new System.EventHandler(this.btnManageEvents_Click);
            // 
            // btnViewFeedbackAttendance
            // 
            this.btnViewFeedbackAttendance.Location = new System.Drawing.Point(20, 149);
            this.btnViewFeedbackAttendance.Name = "btnViewFeedbackAttendance";
            this.btnViewFeedbackAttendance.Size = new System.Drawing.Size(200, 30);
            this.btnViewFeedbackAttendance.TabIndex = 2;
            this.btnViewFeedbackAttendance.Text = "View Attendance";
            this.btnViewFeedbackAttendance.UseVisualStyleBackColor = true;
            this.btnViewFeedbackAttendance.Click += new System.EventHandler(this.btnViewFeedbackAttendance_Click);
            // 
            // grpClubManagement
            // 
            this.grpClubManagement.Controls.Add(this.btnViewClubs);
            this.grpClubManagement.Controls.Add(this.btnApproveMembershipRequests);
            this.grpClubManagement.Controls.Add(this.btnAddUpdateClubs);
            this.grpClubManagement.Location = new System.Drawing.Point(280, 180);
            this.grpClubManagement.Name = "grpClubManagement";
            this.grpClubManagement.Size = new System.Drawing.Size(250, 150);
            this.grpClubManagement.TabIndex = 6;
            this.grpClubManagement.TabStop = false;
            this.grpClubManagement.Text = "Club Management";
            // 
            // btnViewClubs
            // 
            this.btnViewClubs.Location = new System.Drawing.Point(20, 30);
            this.btnViewClubs.Name = "btnViewClubs";
            this.btnViewClubs.Size = new System.Drawing.Size(200, 30);
            this.btnViewClubs.TabIndex = 0;
            this.btnViewClubs.Text = "View Clubs";
            this.btnViewClubs.UseVisualStyleBackColor = true;
            this.btnViewClubs.Click += new System.EventHandler(this.btnViewClubs_Click);
            // 
            // btnApproveMembershipRequests
            // 
            this.btnApproveMembershipRequests.Location = new System.Drawing.Point(20, 70);
            this.btnApproveMembershipRequests.Name = "btnApproveMembershipRequests";
            this.btnApproveMembershipRequests.Size = new System.Drawing.Size(200, 30);
            this.btnApproveMembershipRequests.TabIndex = 1;
            this.btnApproveMembershipRequests.Text = "Approve Membership Requests";
            this.btnApproveMembershipRequests.UseVisualStyleBackColor = true;
            this.btnApproveMembershipRequests.Click += new System.EventHandler(this.btnApproveMembershipRequests_Click);
            // 
            // btnAddUpdateClubs
            // 
            this.btnAddUpdateClubs.Location = new System.Drawing.Point(20, 110);
            this.btnAddUpdateClubs.Name = "btnAddUpdateClubs";
            this.btnAddUpdateClubs.Size = new System.Drawing.Size(200, 30);
            this.btnAddUpdateClubs.TabIndex = 2;
            this.btnAddUpdateClubs.Text = "Add Club";
            this.btnAddUpdateClubs.UseVisualStyleBackColor = true;
            this.btnAddUpdateClubs.Click += new System.EventHandler(this.btnAddUpdateClubs_Click);
            // 
            // grpReporting
            // 
            this.grpReporting.Controls.Add(this.btnGenerateReports);
            this.grpReporting.Location = new System.Drawing.Point(23, 407);
            this.grpReporting.Name = "grpReporting";
            this.grpReporting.Size = new System.Drawing.Size(244, 73);
            this.grpReporting.TabIndex = 8;
            this.grpReporting.TabStop = false;
            this.grpReporting.Text = "Reporting";
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.Location = new System.Drawing.Point(20, 30);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(200, 30);
            this.btnGenerateReports.TabIndex = 0;
            this.btnGenerateReports.Text = "Generate Reports";
            this.btnGenerateReports.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(430, 450);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Take Attendance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FacultyMemberDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(550, 500);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpReporting);
            this.Controls.Add(this.grpClubManagement);
            this.Controls.Add(this.grpEventManagement);
            this.Controls.Add(this.lblFeedbackPendingResponse);
            this.Controls.Add(this.lblPendingMembershipRequests);
            this.Controls.Add(this.lblTotalClubs);
            this.Controls.Add(this.lblUpcomingEvents);
            this.Controls.Add(this.lblTotalEvents);
            this.Name = "FacultyMemberDashboardForm";
            this.Text = "Faculty Dashboard";
            this.grpEventManagement.ResumeLayout(false);
            this.grpClubManagement.ResumeLayout(false);
            this.grpReporting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Declare controls as private members
        private Label lblTotalEvents;
        private Label lblUpcomingEvents;
        private Label lblTotalClubs;
        private Label lblPendingMembershipRequests;
        private Label lblFeedbackPendingResponse;
        private GroupBox grpEventManagement;
        private Button btnCreateNewEvent;
        private Button btnViewFeedbackAttendance;
        private GroupBox grpClubManagement;
        private Button btnViewClubs;
        private GroupBox grpReporting;
        private Button btnGenerateReports;
        private Button btnLogout;
        private Button btnManageEvents;
        private Button btnApproveMembershipRequests;
        private Button btnAddUpdateClubs;
        private Button ViewFeedback;
        private Button button1;
    }
}
