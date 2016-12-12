using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSProject.Design.EditEvent.Ingredient;

namespace MainTimeSchedule.Design.AddUI
{
    public partial class AddUIMain : Form
    {
        public AddUIMain()
        {
            InitializeComponent();
        }

        public void showControl(System.Windows.Forms.Control obj)
        {
            panelcontrol.Controls.Clear();
            obj.Dock = DockStyle.Fill;
            panelcontrol.Controls.Add(obj);
        }


        private void radioButtonday_CheckedChanged(object sender, EventArgs e)
        {
            TimeEventUI dayform = new TimeEventUI();
            showControl(dayform);
        }

        private void radioButtonweek_CheckedChanged(object sender, EventArgs e)
        {
            PeriodEventUI weekform = new PeriodEventUI();
            showControl(weekform);
        }
    }
}
