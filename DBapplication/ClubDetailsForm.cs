using System;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ClubDetailsForm : Form
    {
        int ClubID;
        ControllerAdmin controller = new ControllerAdmin();
        public ClubDetailsForm(Form parentForm, int id)
        {
            InitializeComponent();
            ClubID = id;

            // Store and manage parent form visibility
            Form ParentForm = parentForm;
            ParentForm.Hide();
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
        }


        private void ClubDetailsForm_Load(object sender, EventArgs e)
        {
            LoadClubDetails();
        }

        private void LoadClubDetails()
        {
            // Fetch club details
            DataTable clubDetails = controller.GetClubDetails(ClubID);
            if (clubDetails.Rows.Count > 0)
            {
                DataRow row = clubDetails.Rows[0];
                txtClubName.Text = row["Name"].ToString();
                txtClubDescription.Text = row["Description"].ToString();

                // Fetch and display total number of members
                int totalMembers = controller.GetTotalMembers(ClubID);
                txtTotalMembers.Text = totalMembers.ToString();

                // Populate the DataGridView with the list of members
                DataTable clubMembers = controller.GetClubMembers(ClubID);
                dgvClubMembers.DataSource = clubMembers;
                dgvClubMembers.Columns["UserID"].Visible = false; // Hide UserID for better UI
                dgvClubMembers.AutoResizeColumns(); // Adjust column widths for readability
            }
            else
            {
                MessageBox.Show("Club details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnEditClubDetails_Click(object sender, EventArgs e)
        {
            EditClubForm editClubForm = new EditClubForm(this, ClubID);
            editClubForm.Show();
            this.Hide();
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            if (dgvClubMembers.SelectedRows.Count > 0)
            {
                int memberID = Convert.ToInt32(dgvClubMembers.SelectedRows[0].Cells["UserID"].Value);

                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to remove this member?",
                    "Confirm Remove",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    bool success = controller.RemoveMemberFromClub(ClubID, memberID);
                    if (success)
                    {
                        MessageBox.Show("Member removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadClubDetails(); // Refresh the club details
                    }
                    else
                    {
                        MessageBox.Show("Error removing member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a member to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClubDetailsForm_Load_1(object sender, EventArgs e)
        {

        }

        private void txtClubName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClubDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalMembers_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvClubMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}