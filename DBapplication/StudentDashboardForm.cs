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
        public StudentDashboardForm()
        {
    

    
            InitializeComponent();

           
            label1.Text = controller.ResCount(1).ToString();
            label2.Text = controller.EventCount(1).ToString();
            label3.Text=controller.ClubCount(1).ToString(); 

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
            EventFeedbackForm eventFeedbackForm = new EventFeedbackForm(this);
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
            label1.Text = controller.ResCount(1).ToString();
            label2.Text = controller.EventCount(1).ToString();
            label3.Text = controller.ClubCount(1).ToString();
        }

        private void btRegEv_Click(object sender, EventArgs e)
        {
            RegisteredEventsForm registeredEventsForm=new RegisteredEventsForm(this);
            registeredEventsForm.Show();
        }
    }
}
