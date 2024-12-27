using System;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AttendanceTrackerForm : Form
    {
        private FacultyMemberControler facultyController = new FacultyMemberControler();
        private Controller c = new Controller();
        Form prevForm;
        int UserID;
        string userType;
        public AttendanceTrackerForm(Form pf, int id)
        {
            UserID = id;
            prevForm = pf;
            InitializeComponent();

            this.FormClosed += (s, e) => prevForm.Show();            

            btnExport.Visible = false;
           
            Form ParentForm = parentForm;
            ParentForm.Hide();

            
            this.FormClosed += (sender, e) => { ParentForm.Show(); };

            facultyController = new FacultyMemberControler(); 
                                                             
            cbEventFilter.DataSource = facultyController.GetEventData(UserID,c.GetType(UserID));
            cbEventFilter.DisplayMember = "Title";
            cbEventFilter.ValueMember = "EventID";
            DataTable Attendance = facultyController.TrackAttendance((int)cbEventFilter.SelectedValue);
            dgvEventDetails.DataSource = Attendance; btnExport.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            if (c.GetType(UserID) == "Admin")
            {
                userType = "Admin";
                btnExport.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
            }else if(c.GetType(UserID) == "Faculty Member")
            {
                userType = "Faculty Member";
            }else if(userType =="Student")
            {
                userType = "Student";
            }
            cbEventFilter.DisplayMember = "Title";
            cbEventFilter.ValueMember = "EventID";
            cbEventFilter.DataSource = facultyController.GetEventData(UserID, userType);
            dgvEventDetails.DataSource = facultyController.TrackAttendance(Convert.ToInt32(cbEventFilter.SelectedValue));
        }

        private void dgvEventDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbEventFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvEventDetails.DataSource = facultyController.TrackAttendance(Convert.ToInt32(cbEventFilter.SelectedValue));
            DataTable Attendance = facultyController.TrackAttendance(Convert.ToInt32(cbEventFilter.SelectedValue));
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
                dgvEventDetails.DataSource = facultyController.TrackAttendance(Convert.ToInt32(cbEventFilter.SelectedValue));
                DataTable Attendance = facultyController.TrackAttendance((int)cbEventFilter.SelectedValue);
                dgvEventDetails.DataSource = Attendance; btnExport.Visible = false;
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
      
