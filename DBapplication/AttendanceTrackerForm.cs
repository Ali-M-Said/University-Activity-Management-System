using System;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AttendanceTrackerForm : Form
    {
        private FacultyMemberControler facultyController;
        private Controller c = new Controller();
        int UserID;
        public AttendanceTrackerForm(Form parentForm,int id)
        {
            InitializeComponent();
            UserID = id;
           
            Form ParentForm = parentForm;

          
            ParentForm.Hide();

            
            this.FormClosed += (sender, e) => { ParentForm.Show(); };

            facultyController = new FacultyMemberControler(); // Initialize the controller
            facultyController.PopulateEventNames(cbEventFilter);
            btnExport.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            if (c.GetType(UserID) == "Admin")
            {
                btnExport.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
            }
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

        private void AttendanceTrackerForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
      
