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
    public partial class ReserveLocationForm : Form
    {

        StudentController studentController=new StudentController();
        public ReserveLocationForm(Form parentForm)
        {
            InitializeComponent();
            Form ParentForm = parentForm;

            ParentForm.Hide();

            this.FormClosed += (sender, e) => { ParentForm.Show(); };
                DataTable locations = studentController.GetAvailableSpacesForReservation();
            cmbLocation.DisplayMember = "LocName";
            cmbLocation.ValueMember = "LocationID";
            cmbLocation.DataSource = locations;
            cmbLocation.Refresh();
            SetupTimePickers();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            int userId = 1;
            string StartTime = dtpStartTime.Value.ToString("HH:mm:ss");
            string EndTime = dtpEndTime.Value.ToString("HH:mm:ss");
            int locationId = (int)cmbLocation.SelectedValue;
                studentController.ReserveLocation(userId, locationId,StartTime,EndTime);
            
          
        }
        private void SetupTimePickers()
        {
            // Set the Format to Time to show only time
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "HH:mm"; // Show only hour and minute

            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "HH:mm"; // Show only hour and minute

            // Optional: Enable the ShowUpDown property to display the spinner buttons
            dtpStartTime.ShowUpDown = true;
            dtpEndTime.ShowUpDown = true;
        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
