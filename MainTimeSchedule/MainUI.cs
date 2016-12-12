using MainTimeSchedule.Design.AddUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainTimeSchedule
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void filemenuexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực muốn thoát chương trình??", "Thoát",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else e.Cancel = true;
        }
        private void toolBarMain_Load(object sender, EventArgs e)
        {
            //toolBarMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void addicon_Click(object sender, EventArgs e)
        {
            AddUIMain addUI = new AddUIMain();
            addUI.StartPosition = FormStartPosition.CenterParent;
            addUI.ShowDialog();
        }
    }
}
