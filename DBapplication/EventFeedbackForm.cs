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
    public partial class EventFeedbackForm : Form
    {
        StudentController studentController=new StudentController();    
        public EventFeedbackForm(Form parentForm)
        {
            InitializeComponent();

            Form ParentForm = parentForm;
            ParentForm.Hide();
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
            cboEventSelection.DataSource = studentController.LoadAttendedEvents(1);
            cboEventSelection.DisplayMember="Title";
            cboEventSelection.ValueMember="EventID";
        }

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            studentController.ProvideFeedback(1, (int)cboEventSelection.SelectedValue, (int)numRating.Value, txtComments.Text);
        }
    }
}
