using System;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class FacultyViewFeedback : Form
    {
        private FacultyMemberControler facultyController; // Declare the controller
        int userId;
        public FacultyViewFeedback(Form parentForm,int uid)
        {
            userId= uid;
            InitializeComponent(); // Initialize the form's components
            facultyController = new FacultyMemberControler(); // Initialize the controller
            facultyController.PopulateEventNames(cbEventFilter,userId);
            string selectedEventName = cbEventFilter.SelectedItem.ToString();
            DataTable feedbacks = facultyController.GetFeedBacks(selectedEventName);
            dgvFeedback.DataSource = feedbacks;
        }

     
        private void dgvFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell clicks if additional actions are needed
        }

        private void cbEventFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEventName = cbEventFilter.SelectedItem.ToString();
            DataTable feedbacks = facultyController.GetFeedBacks(selectedEventName);
            dgvFeedback.DataSource = feedbacks;

        }

     
        private void btnExportFeedback_Click(object sender, EventArgs e)
        {
            {
                // Assuming you're using a ComboBox to display the feedback IDs
                if (txtResponse.Text != null)
                {
                    // Get the selected Feedback ID from the ComboBox (or TextBox, depending on your design)
                    int feedbackId = Convert.ToInt32(txtResponse.Text.ToString());

                    // Call the DeleteFeedBack method in your controller
                    FacultyMemberControler controller = new FacultyMemberControler();
                    controller.DeleteFeedBack(feedbackId);

                    // Optionally, display a message to confirm deletion
                    MessageBox.Show("Feedback is  deleted successfully.");
                    string selectedEventName = cbEventFilter.SelectedItem.ToString();
                    DataTable feedbacks = facultyController.GetFeedBacks(selectedEventName);
                    dgvFeedback.DataSource = feedbacks;
                }
                else
                {
                    MessageBox.Show("Please select a feedback to delete.");
                }
            }
        }
    }
}
