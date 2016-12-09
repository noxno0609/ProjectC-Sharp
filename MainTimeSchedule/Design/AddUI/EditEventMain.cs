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
    public partial class EditEventMain : Form
    {
        public EditEventMain()
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
            DayEventUI dayform = new DayEventUI();
            showControl(dayform);
        }

        private void radioButtonweek_CheckedChanged(object sender, EventArgs e)
        {
            WeekEventUI weekform = new WeekEventUI();
            showControl(weekform);
        }
    }
}
