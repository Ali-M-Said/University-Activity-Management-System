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
    public partial class EditEventForm : Form
    {
        Form prevForm;
        int EventID;
        public EditEventForm(Form pf,int id)
        {
            prevForm = pf;
            EventID = id;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
        }
    }
}
