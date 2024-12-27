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
        int userid;
        public AddLocationForm(int uid)
        {
            this.userid = uid;
            InitializeComponent();
        }

        private void StartdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
