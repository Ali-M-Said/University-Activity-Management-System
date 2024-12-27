using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class FacultyMemberDashboardForm : Form
    {
        public FacultyMemberDashboardForm()
        {
            InitializeComponent();
        }

        private void FacultyDashboardForm_Load(object sender, EventArgs e)
        {
            // Placeholder for any actions, currently no actions are implemented.
        }

        private void btnViewFeedbackAttendance_Click(object sender, EventArgs e)
        {
            AttendanceTrackerForm attendanceTrackerForm = new AttendanceTrackerForm(this);
            attendanceTrackerForm.Show();
        }

        private void btnCreateNewEvent_Click(object sender, EventArgs e)
        {
         
            CreateEventForm createEventForm = new CreateEventForm(this);
            createEventForm.Show();
        }

        private void btnManageEvents_Click(object sender, EventArgs e)
        {
            ManageEventsForm manageEventForm = new ManageEventsForm(this);
            manageEventForm.Show();

        }

        private void ViewFeedback_Click(object sender, EventArgs e)
        {
            FacultyViewFeedback viewEventFeedbackForm = new FacultyViewFeedback(this);
            viewEventFeedbackForm.Show();
        }

        private void btnViewClubs_Click(object sender, EventArgs e)
        {
            ClubDetailsForm clubDetailsForm = new ClubDetailsForm(this);
            clubDetailsForm.Show();
        }

        private void btnApproveMembershipRequests_Click(object sender, EventArgs e)
        {
            ManageMembershipRequestsForm manageMembershipRequestsForm = new ManageMembershipRequestsForm(this);
            manageMembershipRequestsForm.Show();
        }

        private void btnAddUpdateClubs_Click(object sender, EventArgs e)
        {
            CreateClubForm createClubForm = new CreateClubForm(this);
            createClubForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Taking_Attendance taking_Attendance = new Taking_Attendance();
          taking_Attendance.Show();
        }
    }
}
