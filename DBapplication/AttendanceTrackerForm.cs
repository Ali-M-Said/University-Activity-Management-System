using System;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AttendanceTrackerForm : Form
    {
        private FacultyMemberControler facultyController;
        int userId;
        public AttendanceTrackerForm(Form parentForm,int uid)
        {
            InitializeComponent();
            userId = uid;
           
            Form ParentForm = parentForm;

          
            ParentForm.Hide();

            
            this.FormClosed += (sender, e) => { ParentForm.Show(); };

            facultyController = new FacultyMemberControler(); // Initialize the controller
            facultyController.PopulateEventNames(cbEventFilter,userId);
        }

        private void dgvEventDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbEventFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEventName = cbEventFilter.SelectedItem.ToString();
            DataTable Attendance = facultyController.TrackAttendance(selectedEventName);
            dgvEventDetails.DataSource = Attendance;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            // Assuming you're using a ComboBox to display the feedback IDs
            if (textBox1.Text != null)
            {
                // Get the selected Feedback ID from the ComboBox (or TextBox, depending on your design)
                int AttendanceId = Convert.ToInt32(textBox1.Text.ToString());

                // Call the DeleteFeedBack method in your controller
                FacultyMemberControler controller = new FacultyMemberControler();
                controller.DeleteAttendance(AttendanceId);

                // Optionally, display a message to confirm deletion
                MessageBox.Show("Attendance is  deleted successfully.");
                string selectedEventName = cbEventFilter.SelectedItem.ToString();
                DataTable Attendance = facultyController.TrackAttendance(selectedEventName);
                dgvEventDetails.DataSource = Attendance;
            }
            else
            {
                MessageBox.Show("Please select a feedback to delete.");
            }
        }
    }
}
      
