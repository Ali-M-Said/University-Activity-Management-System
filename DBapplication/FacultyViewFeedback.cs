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

            facultyController = new FacultyMemberControler(); 
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
            if (int.TryParse(txtResponse.Text.Trim(), out feedbackId))
            {
                // Find the matching row in the DataGridView
                bool feedbackExistsInGrid = false;
                foreach (DataGridViewRow row in dgvFeedback.Rows)
                {
                    if (row.Cells["FeedbackID"].Value != null &&
                        Convert.ToInt32(row.Cells["FeedbackID"].Value) == feedbackId)
                    {
                        feedbackExistsInGrid = true;
                        break;
                    }
                }

                if (feedbackExistsInGrid)
                {
                    // Proceed to delete the feedback
                    bool isDeleted = facultyController.DeleteFeedback(feedbackId);
                    if (isDeleted)
                    {
                        MessageBox.Show("Feedback deleted successfully.");
                        dgvFeedback.DataSource = facultyController.GetFeedBacks(Convert.ToInt32(cbEventFilter.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete feedback.");
                    }
                }
                else
                {
                    MessageBox.Show("Feedback ID not found in the current list.");
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
