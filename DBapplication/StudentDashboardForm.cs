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
    public partial class StudentDashboardForm : Form
    {
        StudentController controller = new StudentController();
        int userid = 1;
        public StudentDashboardForm()
        {
    

    
            InitializeComponent();


            label1.Text = controller.ResCount(userid).ToString();
            label2.Text = controller.UpEventCount().ToString();
            label3.Text = controller.AccClubCount(userid).ToString();
            label11.Text = controller.RejClubCount(userid).ToString();
            label10.Text = controller.PenClubCount(userid).ToString();
            label6.Text = controller.FeedbackCount(userid).ToString();
            label7.Text = controller.RegEventCount(userid).ToString();
            label15.Text = userid.ToString();
            label14.Text= controller.AttEventCount(userid).ToString();

        }


        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Placeholder for any actions, currently no actions are implemented.
        }

        private void btnViewAvailableSpaces_Click(object sender, EventArgs e)
        {
            AvailableSpaces availableSpaces = new AvailableSpaces(this);
            availableSpaces.Show();
        }

     

        private void btnViewReservationHistory_Click(object sender, EventArgs e)
        {
            ReservationHistoryForm reservationHistoryForm = new ReservationHistoryForm(this);
            reservationHistoryForm.Show();
        }

        private void btnViewUpcomingEvents_Click(object sender, EventArgs e)
        {
          UpcomingEventsForm upcomingEventsForm = new UpcomingEventsForm(this);
            upcomingEventsForm.Show();
        }

       

        private void btnProvideFeedback_Click(object sender, EventArgs e)
        {
            GiveFeedbackForm eventFeedbackForm = new GiveFeedbackForm(this);
            eventFeedbackForm.Show();
        }

       

        private void btnViewClubMembershipStatus_Click(object sender, EventArgs e)
        {
            ClubMembershipStatusForm clubMembershipStatusForm = new ClubMembershipStatusForm(this);
            clubMembershipStatusForm.Show();
        }

       

        private void btnViewClubs_Click(object sender, EventArgs e)
        {
            AvailableClubsForm availableClubsForm = new AvailableClubsForm(this);
            availableClubsForm.Show();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            label1.Text = controller.ResCount(userid).ToString();
            label2.Text = controller.UpEventCount().ToString();
            label2.Text = controller.AttEventCount(userid).ToString();
            label3.Text = controller.AccClubCount(userid).ToString();
            label11.Text = controller.RejClubCount(userid).ToString();
            label10.Text = controller.PenClubCount(userid).ToString();
            label6.Text = controller.FeedbackCount(userid).ToString();
            label7.Text = controller.RegEventCount(userid).ToString();
            label14.Text = controller.AttEventCount(userid).ToString();
        }

        private void btRegEv_Click(object sender, EventArgs e)
        {
          RegisteredEventsForm registeredEventsForm=new RegisteredEventsForm(this);
            registeredEventsForm.Show();
        }

        private void btViewFeed_Click(object sender, EventArgs e)
        {
            StudentViewFeedback viewFeedbackForm = new StudentViewFeedback(this);
            viewFeedbackForm.Show();
        }

      
    }
}
