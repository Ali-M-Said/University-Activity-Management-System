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
    public partial class CreateClubForm : Form
    {
        public CreateClubForm(Form parentForm)
        {
            InitializeComponent();

            // Store the parent form
            Form ParentForm = parentForm;

            // Hide the parent form when the sub-form opens
            ParentForm.Hide();

            // Add event handler to show the parent form when the sub-form is closed
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
        }   

    }
}
