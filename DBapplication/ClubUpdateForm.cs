using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ClubUpdateForm : Form
    {
        public ClubUpdateForm()
        {
            InitializeComponent();
        }

        private void ClubUpdateForm_Load(object sender, EventArgs e)
        {
            // Placeholder for any actions, currently no actions are implemented.
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save logic, validate inputs, and update the database
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cancel logic, such as closing the form or clearing inputs
            this.Close();
        }

    }
}
