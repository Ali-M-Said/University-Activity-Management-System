using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ViewEventFeedbackForm : Form
    {
        public ViewEventFeedbackForm(Form parentForm)
        {
            InitializeComponent();

            // Store the parent form
            Form ParentForm = parentForm;

            // Hide the parent form when the sub-form opens
            ParentForm.Hide();

            // Add event handler to show the parent form when the sub-form is closed
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
        }

        private void EventFeedbackForm_Load(object sender, EventArgs e)
        {
            // Placeholder for any actions, no actions implemented yet.
        }
    }
}
