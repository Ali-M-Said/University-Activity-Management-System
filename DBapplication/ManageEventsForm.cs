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
        ControllerAdmin controller = new ControllerAdmin();
        Form prevForm;
        int UserID;
        public ManageEventsForm(Form pf, int userID)
        {
            prevForm = pf;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
            UserID = userID;
            dgvEvents.DataSource = controller.Events();
        }

        private void buttEditEvent_Click(object sender, EventArgs e)
        {
            if (txtEventID.Text == "")
            {
                MessageBox.Show("Enter A Event ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!controller.DoesEventExist(Convert.ToInt32(txtEventID.Text)))
            {
                MessageBox.Show("Event does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EditEventForm EditEvent = new EditEventForm(this, int.Parse(txtEventID.Text));
                EditEvent.Show();
                this.Hide();
            }
        }

        private void txtEventID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttDeleteEvent_Click(object sender, EventArgs e)
        {
            if (txtEventID.Text == "")
            {
                MessageBox.Show("Enter A Event ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!controller.DoesEventExist(Convert.ToInt32(txtEventID.Text)))
            {
                MessageBox.Show("Event does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                controller.DeleteEvent(Convert.ToInt32(txtEventID.Text));
                MessageBox.Show("Event Deleted Successfully");
                dgvEvents.DataSource = controller.Events();
            }
        }

        private void ManageEventsForm_Load(object sender, EventArgs e)
        {
            dgvEvents.DataSource = controller.Events();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvEvents.DataSource = controller.Events();
        }
    }
}
