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
    public partial class ManageLocationsForm : Form
    {
        Form prevForm;
        int UserID;
        public ManageLocationsForm(Form pf, int userID)
        {
            prevForm = pf;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
            UserID = userID;
        }

        private void buttEditLoc_Click(object sender, EventArgs e)
        {
            EditLocationsForm EditLoc = new EditLocationsForm(this,int.Parse(txtLocID.Text));
            EditLoc.Show();
            this.Hide();
        }

        private void txtLocID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
