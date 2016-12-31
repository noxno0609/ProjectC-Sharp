using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSProject.Design.ListEvent;
using MainTimeSchedule.Design.AddUI;

namespace MainTimeSchedule.Design.ToolBarUI
{
    public partial class ToolBarMain : UserControl
    {
        public bool updateRequest = false;
        public AddUIMain addui = new AddUIMain();
        public ListEventForm listperiod = new ListEventForm();
        public Button btEdit
        {
            get { return buttonedit; }
            set { buttonedit = value; }
        }
        public ToolBarMain()
        {
            InitializeComponent();
        }
        private void buttonxem_Click(object sender, EventArgs e)
        {
            listperiod.StartPosition = FormStartPosition.CenterParent;
            listperiod.ShowDialog();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            addui.StartPosition = FormStartPosition.CenterParent;
            addui.ShowDialog();
        }
    }
}
