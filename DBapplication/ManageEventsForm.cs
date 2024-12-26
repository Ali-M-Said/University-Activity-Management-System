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
    public partial class ManageEventsForm : Form
    {
        Form prevForm;
        public ManageEventsForm(Form pf)
        {
            prevForm = pf;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
        }

        private void buttEditEvent_Click(object sender, EventArgs e)
        {
            EditEventForm EditEvent = new EditEventForm(this, int.Parse(txtEventID.Text));
            EditEvent.Show();
            this.Hide();
        }

        private void txtEventID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
