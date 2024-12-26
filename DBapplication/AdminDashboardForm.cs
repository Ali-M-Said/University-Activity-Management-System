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
    public partial class AdminDashboardForm : Form
    {
        ControllerAdmin controller = new ControllerAdmin();
        public AdminDashboardForm()
        {
            InitializeComponent();
            lblTotalUsers.Text = controller.GetTotalUsers();
            lblTotalAdmins.Text = controller.GetTotalAdmins();
            lblTotalFaculty.Text = controller.GetTotalFacultyMembers();
            lblTotalStudents.Text = controller.GetTotalStudents();
            lblTotalClubs.Text = controller.GetTotalClubs();
            lblTotalEvents.Text = controller.GetTotalEvents();
            lblTotalLocations.Text = controller.GetTotalLocations();
        }

        private void pnlQuickStats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateAdminForm NewAdmin = new CreateAdminForm(this);
            NewAdmin.Show();
            this.Hide();
        }

        private void buttViewUsers_Click(object sender, EventArgs e)
        {
            ViewUsersForm AllUsers = new ViewUsersForm(this);
            AllUsers.Show();
            this.Hide();
        }

        private void buttNewEvent_Click(object sender, EventArgs e)
        {
            CreateEventForm NewEvent = new CreateEventForm(this);
            NewEvent.Show();
            this.Hide();
        }

        private void buttManageEvent_Click(object sender, EventArgs e)
        {
            ManageEventsForm ManageEvents = new ManageEventsForm(this);
            ManageEvents.Show();
            this.Hide();
        }

        private void buttNewClub_Click(object sender, EventArgs e)
        {
            CreateClubForm NewClub = new CreateClubForm(this);
            NewClub.Show();
            this.Hide();
        }

        private void buttManageMembership_Click(object sender, EventArgs e)
        {
            ManageClubsForm ManageClubs = new ManageClubsForm(this);
            ManageClubs.Show();
            this.Hide();
        }

        private void buttAddLoc_Click(object sender, EventArgs e)
        {
            AddLocationForm NewLoc = new AddLocationForm(this);
            NewLoc.Show();
            this.Hide();
        }

        private void buttManageLoc_Click(object sender, EventArgs e)
        {
            ManageLocationsForm ManageLoc = new ManageLocationsForm(this);
            ManageLoc.Show();
            this.Hide();
        }

        private void lblTotalUsers_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalAdmins_Click(object sender, EventArgs e)
        {

        }
    }
}
