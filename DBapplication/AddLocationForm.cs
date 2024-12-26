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
    public partial class AddLocationForm : Form
    {
        Form prevForm;
        int UserID;
        public AddLocationForm(Form pf, int userID)
        {
            prevForm = pf;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
            UserID = userID;
        }

        private void StartdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
