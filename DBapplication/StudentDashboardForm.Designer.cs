using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class StudentDashboardForm : Form
    {
     


        private void InitializeComponent()
        {
            // Initialize components
            this.lblTotalReservations = new System.Windows.Forms.Label();
            this.lblUpcomingEvents = new System.Windows.Forms.Label();
            this.lblClubMemberships = new System.Windows.Forms.Label();
            this.grpReservations = new System.Windows.Forms.GroupBox();
            this.btnViewAvailableSpaces = new System.Windows.Forms.Button();
            this.btnReserveSpace = new System.Windows.Forms.Button();
            this.btnViewReservationHistory = new System.Windows.Forms.Button();
            this.grpEvents = new System.Windows.Forms.GroupBox();
            this.btnViewUpcomingEvents = new System.Windows.Forms.Button();
            this.btnRegisterForEvent = new System.Windows.Forms.Button();
            this.btnProvideFeedback = new System.Windows.Forms.Button();
            this.grpClubsAndSchedule = new System.Windows.Forms.GroupBox();
            this.btnJoinClub = new System.Windows.Forms.Button();
            this.btnViewClubMembershipStatus = new System.Windows.Forms.Button();
            this.btnViewPersonalSchedule = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Quick Stats Section
            this.lblTotalReservations.AutoSize = true;
            this.lblTotalReservations.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalReservations.Location = new System.Drawing.Point(20, 20);
            this.lblTotalReservations.Name = "lblTotalReservations";
            this.lblTotalReservations.Size = new System.Drawing.Size(130, 16);
            this.lblTotalReservations.TabIndex = 0;
            this.lblTotalReservations.Text = "Total Reservations: ";

            this.lblUpcomingEvents.AutoSize = true;
            this.lblUpcomingEvents.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblUpcomingEvents.Location = new System.Drawing.Point(20, 50);
            this.lblUpcomingEvents.Name = "lblUpcomingEvents";
            this.lblUpcomingEvents.Size = new System.Drawing.Size(128, 16);
            this.lblUpcomingEvents.TabIndex = 1;
            this.lblUpcomingEvents.Text = "Upcoming Events: ";

            this.lblClubMemberships.AutoSize = true;
            this.lblClubMemberships.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblClubMemberships.Location = new System.Drawing.Point(20, 80);
            this.lblClubMemberships.Name = "lblClubMemberships";
            this.lblClubMemberships.Size = new System.Drawing.Size(145, 16);
            this.lblClubMemberships.TabIndex = 2;
            this.lblClubMemberships.Text = "Club Memberships: ";

            // Reservations Group
            this.grpReservations.Controls.Add(this.btnViewAvailableSpaces);
            this.grpReservations.Controls.Add(this.btnReserveSpace);
            this.grpReservations.Controls.Add(this.btnViewReservationHistory);
            this.grpReservations.Location = new System.Drawing.Point(20, 120);
            this.grpReservations.Name = "grpReservations";
            this.grpReservations.Size = new System.Drawing.Size(250, 150);
            this.grpReservations.TabIndex = 3;
            this.grpReservations.TabStop = false;
            this.grpReservations.Text = "Reservations Management";

            this.btnViewAvailableSpaces.Location = new System.Drawing.Point(20, 30);
            this.btnViewAvailableSpaces.Name = "btnViewAvailableSpaces";
            this.btnViewAvailableSpaces.Size = new System.Drawing.Size(200, 30);
            this.btnViewAvailableSpaces.TabIndex = 0;
            this.btnViewAvailableSpaces.Text = "View Available Spaces";
            this.btnViewAvailableSpaces.UseVisualStyleBackColor = true;

            this.btnReserveSpace.Location = new System.Drawing.Point(20, 70);
            this.btnReserveSpace.Name = "btnReserveSpace";
            this.btnReserveSpace.Size = new System.Drawing.Size(200, 30);
            this.btnReserveSpace.TabIndex = 1;
            this.btnReserveSpace.Text = "Reserve Space";
            this.btnReserveSpace.UseVisualStyleBackColor = true;

            this.btnViewReservationHistory.Location = new System.Drawing.Point(20, 110);
            this.btnViewReservationHistory.Name = "btnViewReservationHistory";
            this.btnViewReservationHistory.Size = new System.Drawing.Size(200, 30);
            this.btnViewReservationHistory.TabIndex = 2;
            this.btnViewReservationHistory.Text = "View Reservation History";
            this.btnViewReservationHistory.UseVisualStyleBackColor = true;

            // Events Group
            this.grpEvents.Controls.Add(this.btnViewUpcomingEvents);
            this.grpEvents.Controls.Add(this.btnRegisterForEvent);
            this.grpEvents.Controls.Add(this.btnProvideFeedback);
            this.grpEvents.Location = new System.Drawing.Point(280, 120);
            this.grpEvents.Name = "grpEvents";
            this.grpEvents.Size = new System.Drawing.Size(250, 150);
            this.grpEvents.TabIndex = 4;
            this.grpEvents.TabStop = false;
            this.grpEvents.Text = "Events";

            this.btnViewUpcomingEvents.Location = new System.Drawing.Point(20, 30);
            this.btnViewUpcomingEvents.Name = "btnViewUpcomingEvents";
            this.btnViewUpcomingEvents.Size = new System.Drawing.Size(200, 30);
            this.btnViewUpcomingEvents.TabIndex = 0;
            this.btnViewUpcomingEvents.Text = "View Upcoming Events";
            this.btnViewUpcomingEvents.UseVisualStyleBackColor = true;

            this.btnRegisterForEvent.Location = new System.Drawing.Point(20, 70);
            this.btnRegisterForEvent.Name = "btnRegisterForEvent";
            this.btnRegisterForEvent.Size = new System.Drawing.Size(200, 30);
            this.btnRegisterForEvent.TabIndex = 1;
            this.btnRegisterForEvent.Text = "Register for Event";
            this.btnRegisterForEvent.UseVisualStyleBackColor = true;

            this.btnProvideFeedback.Location = new System.Drawing.Point(20, 110);
            this.btnProvideFeedback.Name = "btnProvideFeedback";
            this.btnProvideFeedback.Size = new System.Drawing.Size(200, 30);
            this.btnProvideFeedback.TabIndex = 2;
            this.btnProvideFeedback.Text = "Provide Feedback";
            this.btnProvideFeedback.UseVisualStyleBackColor = true;

            // Clubs and Schedule Group
            this.grpClubsAndSchedule.Controls.Add(this.btnJoinClub);
            this.grpClubsAndSchedule.Controls.Add(this.btnViewClubMembershipStatus);
            this.grpClubsAndSchedule.Controls.Add(this.btnViewPersonalSchedule);
            this.grpClubsAndSchedule.Location = new System.Drawing.Point(20, 280);
            this.grpClubsAndSchedule.Name = "grpClubsAndSchedule";
            this.grpClubsAndSchedule.Size = new System.Drawing.Size(250, 150);
            this.grpClubsAndSchedule.TabIndex = 5;
            this.grpClubsAndSchedule.TabStop = false;
            this.grpClubsAndSchedule.Text = "Clubs and Schedule";

            this.btnJoinClub.Location = new System.Drawing.Point(20, 30);
            this.btnJoinClub.Name = "btnJoinClub";
            this.btnJoinClub.Size = new System.Drawing.Size(200, 30);
            this.btnJoinClub.TabIndex = 0;
            this.btnJoinClub.Text = "Join a Club";
            this.btnJoinClub.UseVisualStyleBackColor = true;

            this.btnViewClubMembershipStatus.Location = new System.Drawing.Point(20, 70);
            this.btnViewClubMembershipStatus.Name = "btnViewClubMembershipStatus";
            this.btnViewClubMembershipStatus.Size = new System.Drawing.Size(200, 30);
            this.btnViewClubMembershipStatus.TabIndex = 1;
            this.btnViewClubMembershipStatus.Text = "View Club Membership Status";
            this.btnViewClubMembershipStatus.UseVisualStyleBackColor = true;

            this.btnViewPersonalSchedule.Location = new System.Drawing.Point(20, 110);
            this.btnViewPersonalSchedule.Name = "btnViewPersonalSchedule";
            this.btnViewPersonalSchedule.Size = new System.Drawing.Size(200, 30);
            this.btnViewPersonalSchedule.TabIndex = 2;
            this.btnViewPersonalSchedule.Text = "View Personal Schedule";
            this.btnViewPersonalSchedule.UseVisualStyleBackColor = true;

            // Logout Button
            this.btnLogout.Location = new System.Drawing.Point(20, 450);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(510, 30);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;

            // Form Settings
            this.ClientSize = new System.Drawing.Size(550, 500);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpClubsAndSchedule);
            this.Controls.Add(this.grpEvents);
            this.Controls.Add(this.grpReservations);
            this.Controls.Add(this.lblClubMemberships);
            this.Controls.Add(this.lblUpcomingEvents);
            this.Controls.Add(this.lblTotalReservations);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Declare controls as private members
        private Label lblTotalReservations;
        private Label lblUpcomingEvents;
        private Label lblClubMemberships;
        private GroupBox grpReservations;
        private Button btnViewAvailableSpaces;
        private Button btnReserveSpace;
        private Button btnViewReservationHistory;
        private GroupBox grpEvents;
        private Button btnViewUpcomingEvents;
        private Button btnRegisterForEvent;
        private Button btnProvideFeedback;
        private GroupBox grpClubsAndSchedule;
        private Button btnJoinClub;
        private Button btnViewClubMembershipStatus;
        private Button btnViewPersonalSchedule;
        private Button btnLogout;
    }
}
