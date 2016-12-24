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

        private void menuhelpcopyright_Click(object sender, EventArgs e)
        {
            CopyrightUI frm = new CopyrightUI();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            weekUIMain.weektool.buttonswitch.Click += new EventHandler(ButtonSwitch_Click);
            dayUIMain.daytool.buttonchange.Click += new EventHandler(ButtonSwitch_Click);
            dayUIMain.Hide();
        }

        private void ButtonSwitch_Click(object sender, EventArgs e)
        {
            if (weekUIMain.Visible == true)
            {
                weekUIMain.Hide();
                dayUIMain.Show();
            }
            else
            {
                dayUIMain.Hide();
                weekUIMain.Show();
            }
        }
    }
}
