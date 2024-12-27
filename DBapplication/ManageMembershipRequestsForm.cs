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
    public partial class ManageMembershipRequestsForm : Form
    {
        private FacultyMemberControler facultyController;
        public ManageMembershipRequestsForm(Form parentForm)
        {
            InitializeComponent();

            // Store the parent form
              Form ParentForm = parentForm;

            // Hide the parent form when the sub-form opens
            ParentForm.Hide();     

            // Add event handler to show the parent form when the sub-form is closed
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
            facultyController = new FacultyMemberControler();
            DataTable PendingRequests = facultyController.GetPendingMemberships();
            dgvEvents.DataSource = PendingRequests;
        }

        private void txtEventID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttRejectReq_Click(object sender, EventArgs e)
        {
            FacultyMemberControler controller = new FacultyMemberControler();

            // Get the MembershipID from the text box
            int membershipId;
            if (int.TryParse(txtEventID.Text, out membershipId))  // Ensure it's a valid integer
            {
                // Call the AcceptMembership function
                bool isSuccess = controller.RejectMembership(membershipId);

                if (isSuccess)
                {
                    MessageBox.Show("Membership status updated to Rejected.");

                    // Refresh the DataGridView to show the updated pending list
                    DataTable pendingMemberships = controller.GetPendingMemberships();
                    dgvEvents.DataSource = pendingMemberships;
                }
                else
                {
                    MessageBox.Show("Failed to update membership status. Please check the Membership ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Membership ID.");
            }
        }

        private void buttAcceptReq_Click(object sender, EventArgs e)
        {
            FacultyMemberControler controller = new FacultyMemberControler();

            // Get the MembershipID from the text box
            int membershipId;
            if (int.TryParse(txtEventID.Text, out membershipId))  // Ensure it's a valid integer
            {
                // Call the AcceptMembership function
                bool isSuccess = controller.AcceptMembership(membershipId);

                if (isSuccess)
                {
                    MessageBox.Show("Membership status updated to Accepted.");

                    // Refresh the DataGridView to show the updated pending list
                    DataTable pendingMemberships = controller.GetPendingMemberships();
                    dgvEvents.DataSource = pendingMemberships;
                }
                else
                {
                    MessageBox.Show("Failed to update membership status. Please check the Membership ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Membership ID.");
            }
        }

        private void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
