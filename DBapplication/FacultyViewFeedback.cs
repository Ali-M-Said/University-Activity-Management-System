using System;
using System.Data;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class FacultyViewFeedback : Form
    {
        private FacultyMemberControler facultyController = new FacultyMemberControler();
        private Controller c = new Controller();
        int userId;
        string UserType;
        Form prevForm;
        public FacultyViewFeedback(Form pf, int uid)
        {
            userId= uid;
            prevForm = pf;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();

            btnExportFeedback.Visible = false;
            label1.Visible = false;
            txtResponse.Visible = false;

            if (c.GetType(userId) == "Admin")
            {
                UserType = "Admin";
                btnExportFeedback.Visible = true;
                label1.Visible = true;
                txtResponse.Visible = true;
            }
            else if (c.GetType(userId) == "Faculty Member")
            {
                UserType = "Faculty Member";
            }
            cbEventFilter.DisplayMember = "Title";
            cbEventFilter.ValueMember = "EventID";
            cbEventFilter.DataSource = facultyController.GetEventData(userId, UserType);
            dgvFeedback.DataSource = facultyController.GetFeedBacks(Convert.ToInt32(cbEventFilter.SelectedValue));
        }
        private void dgvFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell clicks if additional actions are needed
        }

        private void cbEventFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFeedback.DataSource = facultyController.GetFeedBacks(Convert.ToInt32(cbEventFilter.SelectedValue));

        }

     
        private void btnExportFeedback_Click(object sender, EventArgs e)
        {
            int feedbackId;

            // Check if the entered Feedback ID is a valid integer
            if (int.TryParse(txtResponse.Text, out feedbackId))
            {
                // Check if the feedback ID exists in the database
                bool feedbackExists = facultyController.DeleteFeedback(feedbackId);

                if (feedbackExists)
                {
                    // Proceed with the deletion
                    bool isDeleted = facultyController.DeleteFeedback(feedbackId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Feedback deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete feedback.");
                    }
                }
                else
                {
                    MessageBox.Show("Feedback ID not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Feedback ID.");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtResponse_TextChanged(object sender, EventArgs e)
        {

        }

        private void FacultyViewFeedback_Load(object sender, EventArgs e)
        {

        }
    }
}
