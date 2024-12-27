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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userId = 2;

            UserSession.UserId = userId;

            StudentDashboardForm studentDashboardForm=new StudentDashboardForm(this);   
            studentDashboardForm.Show();
          
            this.Hide(); 
        }
    }
}
