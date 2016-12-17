using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSProject.Design.EditEvent;

namespace TSProject.Design.ListEvent
{
    public partial class ListEventForm : Form
    {
        public ListEventForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditEvent.ListEventForm frm = new EditEvent.ListEventForm();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
