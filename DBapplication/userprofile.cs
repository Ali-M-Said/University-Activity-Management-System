using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DBapplication
{
    public partial class userprofile : Form
    {
        private int currentID;
        Controller controller;
        public userprofile(int id)
        {
            InitializeComponent();
             controller = new Controller();

            currentID = id;     

        }
        private void LoadUserProfile()
        {

            try
            {
                // Retrieve user profile based on UserID
                DataTable userData = controller.GetUserById(currentID);

                if (userData.Rows.Count > 0)
                {
                    DataRow row = userData.Rows[0];
                    firstnametxt.Text = row["FName"].ToString();
                    lastnametxt.Text = row["LName"].ToString();
                    emailtxt.Text = row["Email"].ToString();
                    deptxt.Text = row["Department"].ToString();
                    usertypebox.SelectedItem = row["Type"].ToString();

                    // Additional Student-Specific Data
                    if (row["Type"].ToString() == "Student")
                    {
                        int year = controller.GetStudentYear(currentID);
                        yearlbl.Visible = true;
                        yeartxt.Visible = true;
                        yeartxt.Text = year.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Error: User not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}");
            }
        }

        private void LoadActivityHistory()
        {
            // Retrieve activity history for the user
            DataTable activityData = controller.GetActivityHistory(currentID);

            if (activityData.Rows.Count > 0)
            {
                historydatagrid.DataSource = activityData;
            }
            else
            {
                MessageBox.Show("No activity history found.");
            }
        }
        private void userprofile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Update user profile information
            string firstName = firstnametxt.Text;
            string lastName = lastnametxt.Text;
            string email = emailtxt.Text;
            string department = deptxt.Text;
            string userType = usertypebox.SelectedItem.ToString();

            bool success = controller.UpdateUserProfile(currentID, firstName, lastName, email, department, userType);

            if (success)
            {
                MessageBox.Show("Profile updated successfully.");
            }
            else
            {
                MessageBox.Show("Error updating profile.");
            }
        }
    }
    
}
