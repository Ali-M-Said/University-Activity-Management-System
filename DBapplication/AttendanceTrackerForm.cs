using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AttendanceTrackerForm : Form
    {
        public AttendanceTrackerForm(Form parentForm)
        {
            InitializeComponent();

           
            Form ParentForm = parentForm;

          
            ParentForm.Hide();

            
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
        }


    }
}
