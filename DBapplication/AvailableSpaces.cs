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
    public partial class AvailableSpaces : Form
    {
        public AvailableSpaces(Form parentForm)
        {
            StudentController studentController = new StudentController();
            InitializeComponent();
            DataTable dt = studentController.GetAvailableSpacesForReservation();
            dgvAvailableSpaces.Rows.Clear();
            dgvAvailableSpaces.DataSource = dt;
            Form ParentForm = parentForm;

            // Hide the parent form when the sub-form opens
            ParentForm.Hide();

            // Add event handler to show the parent form when the sub-form is closed
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ReserveLocationForm frm = new ReserveLocationForm(this);
            frm.Show();
        }
    }
}
