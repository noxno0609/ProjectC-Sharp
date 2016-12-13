using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonTimeSchedule;
using MainTimeSchedule;

namespace WindowsFormsApplication1.Design.WeekUI.Ingredient
{
    public partial class WeekUITop : UserControl
    {
        WeekCalenderPicker weekpicker = new WeekCalenderPicker();

        public DateTime daypicked = DateTime.Now;
        public WeekUITop()
        {
            InitializeComponent();
            UpdateButtonDate();
        }
        public void UpdateButtonDate()
        {
            DateTime startDoW = DateTimeUtils.getFirstDoW(daypicked);
            DateTime endDoW = DateTimeUtils.getLastDoW(daypicked);
            buttonDate.Text = FormatUtils.formatDate(startDoW) + " - " + FormatUtils.formatDate(endDoW);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            daypicked = daypicked.AddDays(7);
            UpdateButtonDate();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            daypicked = daypicked.AddDays(-7);
            UpdateButtonDate();
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            weekpicker.SelectionStart = daypicked;
            weekpicker.FormClosed += new FormClosedEventHandler(weekpicker_FormClosed);
            weekpicker.Text = "Chọn Tuần";
            weekpicker.StartPosition = FormStartPosition.CenterParent;
            weekpicker.ShowDialog();
        }
        private void weekpicker_FormClosed(object sender, FormClosedEventArgs e)
        {
            WeekCalenderPicker weekpicker = (WeekCalenderPicker)sender;
            if (weekpicker.DayPicked != DateTime.MinValue)
            {
                daypicked = weekpicker.DayPicked;
                UpdateButtonDate();
            }
        }
    }
}
