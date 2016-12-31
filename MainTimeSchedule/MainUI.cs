using MainTimeSchedule.Design.AddUI;
using SQLTS;
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

namespace MainTimeSchedule
{
    public partial class MainUI : Form
    {
        private EditTimeUIMain editui;
        private TimeEventDTO SelectDTO = new TimeEventDTO();
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
            toolBarMain.addui.StartPosition = FormStartPosition.CenterParent;
            toolBarMain.addui.ShowDialog();
        }
        private void onUpdateEvent(object sender, EventArgs e)
        {
            if (toolBarMain.addui.updateRequest == true)
            {
                if (weekUIMain.Visible == true)
                    weekUIMain.updateWeekUI();
                else
                    dayUIMain.updateDayUI();
                toolBarMain.addui.updateRequest = false;
            }
            else if (toolBarMain.listperiod.updateRequest == true)
            {
                if (weekUIMain.Visible == true)
                    weekUIMain.updateWeekUI();
                else
                    dayUIMain.updateDayUI();
                toolBarMain.listperiod.updateRequest = false;
            }
            else if (editui != null && editui.updateRequest != 0)
            {
                if (weekUIMain.Visible == true)
                    weekUIMain.updateWeekUI();
                else
                    dayUIMain.updateDayUI();
                if (editui.updateRequest == 2)
                {
                    SelectDTO = new TimeEventDTO();
                    weekUIMain.SelectDTO = new TimeEventDTO();
                    dayUIMain.SelectDTO = new TimeEventDTO();
                }
                editui.updateRequest = 0;
            }
        }
        private void menuhelpcopyright_Click(object sender, EventArgs e)
        {
            CopyrightUI frm = new CopyrightUI();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        private void MainUI_Load(object sender, EventArgs e)
        {
            weekUIMain.weekuitool.buttonswitch.Click += new EventHandler(ButtonSwitch_Click);
            dayUIMain.daytool.buttonchange.Click += new EventHandler(ButtonSwitch_Click);
            toolBarMain.addui.FormClosed += new FormClosedEventHandler(onUpdateEvent);
            toolBarMain.listperiod.FormClosed += new FormClosedEventHandler(onUpdateEvent);
            toolBarMain.btEdit.Click += new EventHandler(showEditUI);
            dayUIMain.Hide();
        }
        private void showEditUI(object sender, EventArgs e)
        {
            SelectDTO = (weekUIMain.Visible == true) ? weekUIMain.SelectDTO : dayUIMain.SelectDTO;
            if (SelectDTO.DaySelect == DateTime.MinValue)
            {
                MessageBox.Show("Bạn chưa chọn mốc nào để chỉnh sửa!", "Chỉnh sửa mốc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (weekUIMain.Visible == true)
                editui = new EditTimeUIMain(weekUIMain.SelectDTO);
            else
                editui = new EditTimeUIMain(dayUIMain.SelectDTO);
            
            editui.StartPosition = FormStartPosition.CenterParent;
            editui.FormClosed += new FormClosedEventHandler(onUpdateEvent);
            editui.ShowDialog();
        }
        private void ButtonSwitch_Click(object sender, EventArgs e)
        {
            if (weekUIMain.Visible == true)
            {
                weekUIMain.Hide();
                dayUIMain.Show();
                dayUIMain.updateDayUI();
            }
            else
            {
                dayUIMain.Hide();
                weekUIMain.Show();
                weekUIMain.updateWeekUI();
            }
        }

        private void iconsche_Click(object sender, EventArgs e)
        {
            toolBarMain.listperiod.StartPosition = FormStartPosition.CenterParent;
            toolBarMain.listperiod.ShowDialog();
        }
    }
}
