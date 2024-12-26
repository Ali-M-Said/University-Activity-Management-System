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
    public partial class ViewUsersForm : Form
    {
        Form prevForm;
        public ViewUsersForm(Form pf)
        {
            prevForm = pf;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
        }

        private void ViewUsersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
