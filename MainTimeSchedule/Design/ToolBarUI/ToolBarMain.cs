using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSProject.Design.EditEvent;

namespace MainTimeSchedule.Design.ToolBarUI
{
    public partial class ToolBarMain : UserControl
    {
        public ToolBarMain()
        {
            InitializeComponent();
        }

        private void buttonxem_Click(object sender, EventArgs e)
        {
            EditPeriodUIMain frm = new EditPeriodUIMain();
            frm.ShowDialog();
        }
    }
}
