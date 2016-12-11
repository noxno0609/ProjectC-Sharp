using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DayUI;

namespace WindowsFormsApplication1.Design.WeekUI
{
    public partial class WeekUIMain : UserControl
    {
        public WeekUIMain()
        {
            InitializeComponent();
            weekUITool.buttonswitch.Click += new EventHandler(ButtonSwitch_Click);
        }

        private void ButtonSwitch_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            DayUIMain dayform = new DayUIMain();
            dayform.Dock = DockStyle.Fill;
            this.Controls.Add(dayform);
        }
    }
}
