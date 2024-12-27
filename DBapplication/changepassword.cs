using DBapplication;
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
    public partial class changepassword : Form
    {
        Controller controller;
        private string currentUserEmail; //msh haarf astakhdemo lazm tedoly el form el baad el login el hykon feha el change passowrd form

        public changepassword()
        {
            InitializeComponent();
            controller = new Controller();
            
        }

        private void changepassword_Load(object sender, EventArgs e)
        {

        }

        private void changepassbut_Click(object sender, EventArgs e)
        {


            string oldPassword = oldpasstxt.Text;
            string newPassword = newpasstxt.Text;
            string confirmNewPassword = confnewtxt.Text;

            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmNewPassword))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New password and confirm password do not match!");
                return;
            }

            if (!IsValidPassword(newPassword))
            {
                MessageBox.Show("New password does not meet the required criteria.");
                return;
            }

            string email = GetCurrentUserEmail(); // Replace with logic to get the logged-in user's email
            string result = controller.ChangePassword(email, oldPassword, newPassword);

            MessageBox.Show(result);
        }
        private string GetCurrentUserEmail()
        {
            // Logic to retrieve the email of the currently logged-in user
            // This might come from a session, user object, etc.
            return "user@example.com"; // Placeholder
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length < 8) return false;
            if (!password.Any(char.IsUpper)) return false;
            if (!password.Any(char.IsLower)) return false;
            if (!password.Any(char.IsDigit)) return false;
            if (!password.Any(ch => "!@#$%^&*".Contains(ch))) return false;

            return true;
        }
    }
}