using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ClubDetailsForm : Form
    {
        int ClubID;
        public ClubDetailsForm(Form parentForm, int id)
        {
            InitializeComponent();
            ClubID = id;
            // Store the parent form
            Form ParentForm = parentForm;

            // Hide the parent form when the sub-form opens
            ParentForm.Hide();

            // Add event handler to show the parent form when the sub-form is closed
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
        }


        private void ClubDetailsForm_Load(object sender, EventArgs e)
        {
            // Placeholder for any actions, currently no actions are implemented.
        }

        private void btnEditClubDetails_Click(object sender, EventArgs e)
        {
            EditClubForm EditClub = new EditClubForm(this, ClubID);
            EditClub.Show();
            this.Hide();
        }

        private void ClubDetailsForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}