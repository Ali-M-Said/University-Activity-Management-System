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
    public partial class RegisteredEventsForm : Form
    {
        StudentController studentController = new StudentController();
        int userid = 1;
        public RegisteredEventsForm(Form parentForm)
        {
            InitializeComponent();

            Form ParentForm = parentForm;
            ParentForm.Hide();
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
            dgvRegisteredEvents.DataSource = studentController.GetRegisteredEvents(userid);
        }
    }
}
