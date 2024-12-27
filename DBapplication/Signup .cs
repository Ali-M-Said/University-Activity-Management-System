using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class Signup : Form
    {
        Controller controller;
        public Signup()
        {
            InitializeComponent();
           
                controller = new Controller();

                // Populate the department combo box
                DataTable departmentTable = controller.department();
                departmentcombo.DataSource = departmentTable;
                departmentcombo.DisplayMember = "Department";
                departmentcombo.ValueMember = "Department"; // Optional if you need a value

                // Populate the user type combo box
                DataTable userTypeTable = controller.usertype();
                usertypebox.DataSource = userTypeTable;
                usertypebox.DisplayMember = "Type";
                usertypebox.ValueMember = "Type"; // Optional if you need a value
            

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = firstnamebox.Text;
            string lastname = lastnamebox.Text;
            string email = emailbox.Text;
            string password = passwordbox.Text;
            string confirmPassword = confirmpassbox.Text;
            string department = departmentcombo.Text; // Use Text to get the displayed value
            string userType = usertypebox.Text; // Same for user type


            // Validate user input
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(department) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(userType))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Call the AddUser method in the Controller
            string result = controller.AddUser(firstname, lastname, email, department, password, userType);

            // Show the result of the operation
            if (result == "User successfully registered.")
            {
                MessageBox.Show(result, "Success");

                // Clear the form after successful registration
                //ClearForm();
            }
            else
            {
                MessageBox.Show(result, "Registration Error");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
