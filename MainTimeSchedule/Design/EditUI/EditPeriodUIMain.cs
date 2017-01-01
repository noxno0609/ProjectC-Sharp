using MainTimeSchedule.Design.AddUI;
using MainTimeSchedule.Utils;
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

namespace TSProject.Design.EditEvent
{
    public partial class EditPeriodUIMain : Form
    {
        public bool updateRequest = false;
        public PeriodEventDTO dto = new PeriodEventDTO();
        public EditPeriodUIMain()
        {
            InitializeComponent();
            loadEdit(this.dto);
        }
        public EditPeriodUIMain(PeriodEventDTO dto)
        {
            this.dto = dto;
            InitializeComponent();
            loadEdit(this.dto);
        }
        private void loadEdit(PeriodEventDTO dto)
        {
            weekEventUI.tbName.Text = dto.Name;
            weekEventUI.tbDatestart.Value = dto.DateStart;
            weekEventUI.tbDateend.Value = dto.DateEnd;
            weekEventUI.cbt2.Checked = (isChecked(dto.DaySelect[0]) == true) ? true : false;
            weekEventUI.cbt3.Checked = (isChecked(dto.DaySelect[1]) == true) ? true : false;
            weekEventUI.cbt4.Checked = (isChecked(dto.DaySelect[2]) == true) ? true : false;
            weekEventUI.cbt5.Checked = (isChecked(dto.DaySelect[3]) == true) ? true : false;
            weekEventUI.cbt6.Checked = (isChecked(dto.DaySelect[4]) == true) ? true : false;
            weekEventUI.cbt7.Checked = (isChecked(dto.DaySelect[5]) == true) ? true : false;
            weekEventUI.cbtCN.Checked = (isChecked(dto.DaySelect[6]) == true) ? true : false;
            weekEventUI.tbTimestarth.Value = dto.TimeStart.Hour;
            weekEventUI.tbTimestartm.Value = dto.TimeStart.Minute;
            weekEventUI.tbTimeendh.Value = dto.TimeEnd.Hour;
            weekEventUI.tbTimeendm.Value = dto.TimeEnd.Minute;
            weekEventUI.tbNote.Text = dto.Note;

            string[] coloringre = dto.Color.Split(',');
            Color color = Color.FromArgb(Convert.ToInt32(coloringre[0]), Convert.ToInt32(coloringre[1]), Convert.ToInt32(coloringre[2]));
            weekEventUI.cbColor.SelectedIndex = Convert.ToInt32(weekEventUI.cbColor.itemMapIndex[EditTimeUIMain.getColorName(color)]);
        }
        private bool isChecked(char c)
        {
            if (c.Equals('1'))
                return true;
            return false;
        }
        private void buttonclose_Click(object sender, EventArgs e)
        { 
            //DialogResult answer;
            //answer = MessageBox.Show("Bạn muốn đóng bảng sửa?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (answer == DialogResult.OK)
                Close();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            dto.Name = weekEventUI.tbName.Text;
            dto.DateStart = weekEventUI.tbDatestart.Value;
            dto.DateEnd = weekEventUI.tbDateend.Value;
            dto.DaySelect = AddUIMain.numberCheck(weekEventUI.cbt2).ToString() + AddUIMain.numberCheck(weekEventUI.cbt3).ToString() + AddUIMain.numberCheck(weekEventUI.cbt4).ToString() +
                                    AddUIMain.numberCheck(weekEventUI.cbt5).ToString() + AddUIMain.numberCheck(weekEventUI.cbt6).ToString() + AddUIMain.numberCheck(weekEventUI.cbt7).ToString() + AddUIMain.numberCheck(weekEventUI.cbtCN).ToString();
            dto.TimeStart = Convert.ToDateTime(weekEventUI.tbTimestarth.Value + ":" + weekEventUI.tbTimestartm.Value + ":00");
            dto.TimeEnd = Convert.ToDateTime(weekEventUI.tbTimeendh.Value + ":" + weekEventUI.tbTimeendm.Value + ":00");
            dto.Note = weekEventUI.tbNote.Text;
            Color colortemp = (Color)weekEventUI.cbColor.SelectedItem;
            dto.Color = Convert.ToString(colortemp.R + "," + colortemp.G + "," + colortemp.B);

            if(PeriodEventDAO.Update(dto, DBUtils.GetDBConnection()) == true)
                MessageBox.Show("Đã sửa lịch trình thành công!", "Sửa lịch trình", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateRequest = true;
        }
    }
}
