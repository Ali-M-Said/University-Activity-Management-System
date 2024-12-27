using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class StudentDashboardForm : Form
    {
     


        private void InitializeComponent()
        {
            this.lblTotalReservations = new System.Windows.Forms.Label();
            this.lblUpcomingEvents = new System.Windows.Forms.Label();
            this.lblClubMemberships = new System.Windows.Forms.Label();
            this.grpReservations = new System.Windows.Forms.GroupBox();
            this.btnViewAvailableSpaces = new System.Windows.Forms.Button();
            this.btnViewReservationHistory = new System.Windows.Forms.Button();
            this.grpEvents = new System.Windows.Forms.GroupBox();
            this.btViewFeed = new System.Windows.Forms.Button();
            this.btRegEv = new System.Windows.Forms.Button();
            this.btnViewUpcomingEvents = new System.Windows.Forms.Button();
            this.btnProvideFeedback = new System.Windows.Forms.Button();
            this.grpClubsAndSchedule = new System.Windows.Forms.GroupBox();
            this.btnViewClubs = new System.Windows.Forms.Button();
            this.btnViewClubMembershipStatus = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.grpReservations.SuspendLayout();
            this.grpEvents.SuspendLayout();
            this.grpClubsAndSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalReservations
            // 
            this.lblTotalReservations.AutoSize = true;
            this.lblTotalReservations.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalReservations.Location = new System.Drawing.Point(20, 36);
            this.lblTotalReservations.Name = "lblTotalReservations";
            this.lblTotalReservations.Size = new System.Drawing.Size(166, 19);
            this.lblTotalReservations.TabIndex = 0;
            this.lblTotalReservations.Text = "Total Reservations: ";
            // 
            // lblUpcomingEvents
            // 
            this.lblUpcomingEvents.AutoSize = true;
            this.lblUpcomingEvents.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblUpcomingEvents.Location = new System.Drawing.Point(20, 64);
            this.lblUpcomingEvents.Name = "lblUpcomingEvents";
            this.lblUpcomingEvents.Size = new System.Drawing.Size(158, 19);
            this.lblUpcomingEvents.TabIndex = 1;
            this.lblUpcomingEvents.Text = "Upcoming Events: ";
            // 
            // lblClubMemberships
            // 
            this.lblClubMemberships.AutoSize = true;
            this.lblClubMemberships.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblClubMemberships.Location = new System.Drawing.Point(253, 60);
            this.lblClubMemberships.Name = "lblClubMemberships";
            this.lblClubMemberships.Size = new System.Drawing.Size(234, 19);
            this.lblClubMemberships.TabIndex = 2;
            this.lblClubMemberships.Text = "Pending Club Memberships: ";
            // 
            // grpReservations
            // 
            this.grpReservations.Controls.Add(this.btnViewAvailableSpaces);
            this.grpReservations.Controls.Add(this.btnViewReservationHistory);
            this.grpReservations.Location = new System.Drawing.Point(20, 157);
            this.grpReservations.Name = "grpReservations";
            this.grpReservations.Size = new System.Drawing.Size(250, 150);
            this.grpReservations.TabIndex = 3;
            this.grpReservations.TabStop = false;
            this.grpReservations.Text = "Reservations Management";
            // 
            // btnViewAvailableSpaces
            // 
            this.btnViewAvailableSpaces.Location = new System.Drawing.Point(20, 30);
            this.btnViewAvailableSpaces.Name = "btnViewAvailableSpaces";
            this.btnViewAvailableSpaces.Size = new System.Drawing.Size(214, 51);
            this.btnViewAvailableSpaces.TabIndex = 0;
            this.btnViewAvailableSpaces.Text = "View / Reserve Available Spaces";
            this.btnViewAvailableSpaces.UseVisualStyleBackColor = true;
            this.btnViewAvailableSpaces.Click += new System.EventHandler(this.btnViewAvailableSpaces_Click);
            // 
            // btnViewReservationHistory
            // 
            this.btnViewReservationHistory.Location = new System.Drawing.Point(20, 87);
            this.btnViewReservationHistory.Name = "btnViewReservationHistory";
            this.btnViewReservationHistory.Size = new System.Drawing.Size(214, 57);
            this.btnViewReservationHistory.TabIndex = 2;
            this.btnViewReservationHistory.Text = "View Reservation History / Cancel";
            this.btnViewReservationHistory.UseVisualStyleBackColor = true;
            this.btnViewReservationHistory.Click += new System.EventHandler(this.btnViewReservationHistory_Click);
            // 
            // grpEvents
            // 
            this.grpEvents.Controls.Add(this.btViewFeed);
            this.grpEvents.Controls.Add(this.btRegEv);
            this.grpEvents.Controls.Add(this.btnViewUpcomingEvents);
            this.grpEvents.Controls.Add(this.btnProvideFeedback);
            this.grpEvents.Location = new System.Drawing.Point(286, 167);
            this.grpEvents.Name = "grpEvents";
            this.grpEvents.Size = new System.Drawing.Size(244, 285);
            this.grpEvents.TabIndex = 4;
            this.grpEvents.TabStop = false;
            this.grpEvents.Text = "Events";
            // 
            // btViewFeed
            // 
            this.btViewFeed.Location = new System.Drawing.Point(20, 226);
            this.btViewFeed.Name = "btViewFeed";
            this.btViewFeed.Size = new System.Drawing.Size(200, 43);
            this.btViewFeed.TabIndex = 4;
            this.btViewFeed.Text = "View / Delete Feedback";
            this.btViewFeed.UseVisualStyleBackColor = true;
            this.btViewFeed.Click += new System.EventHandler(this.btViewFeed_Click);
            // 
            // btRegEv
            // 
            this.btRegEv.Location = new System.Drawing.Point(20, 98);
            this.btRegEv.Name = "btRegEv";
            this.btRegEv.Size = new System.Drawing.Size(200, 52);
            this.btRegEv.TabIndex = 3;
            this.btRegEv.Text = "View Registered Events / Cancel";
            this.btRegEv.UseVisualStyleBackColor = true;
            this.btRegEv.Click += new System.EventHandler(this.btRegEv_Click);
            // 
            // btnViewUpcomingEvents
            // 
            this.btnViewUpcomingEvents.Location = new System.Drawing.Point(20, 30);
            this.btnViewUpcomingEvents.Name = "btnViewUpcomingEvents";
            this.btnViewUpcomingEvents.Size = new System.Drawing.Size(200, 51);
            this.btnViewUpcomingEvents.TabIndex = 0;
            this.btnViewUpcomingEvents.Text = "View Upcoming Events/ Register";
            this.btnViewUpcomingEvents.UseVisualStyleBackColor = true;
            this.btnViewUpcomingEvents.Click += new System.EventHandler(this.btnViewUpcomingEvents_Click);
            // 
            // btnProvideFeedback
            // 
            this.btnProvideFeedback.Location = new System.Drawing.Point(20, 160);
            this.btnProvideFeedback.Name = "btnProvideFeedback";
            this.btnProvideFeedback.Size = new System.Drawing.Size(200, 44);
            this.btnProvideFeedback.TabIndex = 2;
            this.btnProvideFeedback.Text = "Provide Feedback";
            this.btnProvideFeedback.UseVisualStyleBackColor = true;
            this.btnProvideFeedback.Click += new System.EventHandler(this.btnProvideFeedback_Click);
            // 
            // grpClubsAndSchedule
            // 
            this.grpClubsAndSchedule.Controls.Add(this.btnViewClubs);
            this.grpClubsAndSchedule.Controls.Add(this.btnViewClubMembershipStatus);
            this.grpClubsAndSchedule.Location = new System.Drawing.Point(20, 313);
            this.grpClubsAndSchedule.Name = "grpClubsAndSchedule";
            this.grpClubsAndSchedule.Size = new System.Drawing.Size(260, 164);
            this.grpClubsAndSchedule.TabIndex = 5;
            this.grpClubsAndSchedule.TabStop = false;
            this.grpClubsAndSchedule.Text = "Clubs and Schedule";
            // 
            // btnViewClubs
            // 
            this.btnViewClubs.Location = new System.Drawing.Point(20, 30);
            this.btnViewClubs.Name = "btnViewClubs";
            this.btnViewClubs.Size = new System.Drawing.Size(200, 47);
            this.btnViewClubs.TabIndex = 0;
            this.btnViewClubs.Text = "View / Join Available Clubs";
            this.btnViewClubs.UseVisualStyleBackColor = true;
            this.btnViewClubs.Click += new System.EventHandler(this.btnViewClubs_Click);
            // 
            // btnViewClubMembershipStatus
            // 
            this.btnViewClubMembershipStatus.Location = new System.Drawing.Point(20, 94);
            this.btnViewClubMembershipStatus.Name = "btnViewClubMembershipStatus";
            this.btnViewClubMembershipStatus.Size = new System.Drawing.Size(200, 49);
            this.btnViewClubMembershipStatus.TabIndex = 1;
            this.btnViewClubMembershipStatus.Text = "View Club Membership Status / Leave Club\r\n";
            this.btnViewClubMembershipStatus.UseVisualStyleBackColor = true;
            this.btnViewClubMembershipStatus.Click += new System.EventHandler(this.btnViewClubMembershipStatus_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(348, 458);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(182, 30);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(187, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(177, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(498, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 7;
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(443, 133);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(95, 28);
            this.btRefresh.TabIndex = 8;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(20, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Registered Events:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(20, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Feedback Given:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(206, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(228, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(253, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Rejected Club Memberships: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(253, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Approved Club Memberships: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(486, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(489, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(253, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Attended Events:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(20, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Student ID: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(401, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 16);
            this.label14.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(124, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 16);
            this.label15.TabIndex = 11;
            // 
            // StudentDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(550, 500);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpClubsAndSchedule);
            this.Controls.Add(this.grpEvents);
            this.Controls.Add(this.grpReservations);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblClubMemberships);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUpcomingEvents);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTotalReservations);
            this.Name = "StudentDashboardForm";
            this.Text = "Dashboard";
            this.grpReservations.ResumeLayout(false);
            this.grpEvents.ResumeLayout(false);
            this.grpClubsAndSchedule.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Declare controls as private members
        private Label lblTotalReservations;
        private Label lblUpcomingEvents;
        private Label lblClubMemberships;
        private GroupBox grpReservations;
        private Button btnViewAvailableSpaces;
        private Button btnViewReservationHistory;
        private GroupBox grpEvents;
        private Button btnViewUpcomingEvents;
        private Button btnProvideFeedback;
        private GroupBox grpClubsAndSchedule;
        private Button btnViewClubs;
        private Button btnViewClubMembershipStatus;
        private Button btnLogout;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btRefresh;
        private Button btRegEv;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button btViewFeed;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}
