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
    public partial class Taking_Attendance : Form
    {
        private FacultyMemberControler facultyController;
        int userid;
        public Taking_Attendance(Form parentform,int usid)
        {
            facultyController = new FacultyMemberControler(); // Initialize the controller
            userid=usid;
            facultyController = new FacultyMemberControler(); 
            InitializeComponent();
          //  facultyController.PopulateEventNames(eventnamebox,userid);
        }

        private void eventnamebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacultyMemberControler controller = new FacultyMemberControler();
            int studentId;
            if (int.TryParse(studentidbox.Text, out studentId))
            {
                string eventName = eventnamebox.SelectedItem.ToString();
                int eventId = controller.GetEventIDByName(eventName);

                if (eventId != -1)
                {

                    string checkInTime = textBox1.Text.Trim();

                    DateTime parsedTime;
                    if (DateTime.TryParse(checkInTime, out parsedTime))
                    {

                        bool isSuccess = controller.RecordAttendance(studentId, eventId, checkInTime);

                        if (isSuccess)
                        {
                            MessageBox.Show("Attendance marked successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to mark attendance.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid check-in time in the format: HH:mm:ss");
                    }
                }
                else
                {
                    MessageBox.Show("Event not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid student ID.");
            }
        }

        private void Taking_Attendance_Load(object sender, EventArgs e)
        {

        }
    }
}