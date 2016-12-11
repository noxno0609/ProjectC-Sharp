using CommonTimeSchedule;
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
    public partial class WeekCalenderPicker : Form
    {
        public DateTime DayPicked { get; set; }
        public DateTime SelectionStart
        { 
            get { return monthCalendar.SelectionStart; }
            set { monthCalendar.SelectionStart = value; }
        }
        public WeekCalenderPicker()
        {
            InitializeComponent();
            setupWeekCalenderPicker(monthCalendar);
        }
        public void setupWeekCalenderPicker(MonthCalendar monthCalendar)
        {
            monthCalendar.ShowWeekNumbers = false;
            DateTime startDoW = DateTimeUtils.getFirstDoW(monthCalendar.TodayDate);
            DateTime endDoW = DateTimeUtils.getLastDoW(monthCalendar.TodayDate);
            monthCalendar.SelectionStart = startDoW;
            monthCalendar.SelectionEnd = endDoW;
        }

        private void WeekCalenderPicker_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime pickday = monthCalendar.SelectionRange.Start;
            DateTime startDoW = DateTimeUtils.getFirstDoW(pickday);
            DateTime endDoW = DateTimeUtils.getLastDoW(pickday);
            monthCalendar.SelectionStart = startDoW;
            monthCalendar.SelectionEnd = endDoW;
        }
        private void WeekCalenderPicker_DateSelected(object sender, DateRangeEventArgs e)
        {
            DayPicked = monthCalendar.SelectionRange.Start;
            this.Close();
        }
    }
}
