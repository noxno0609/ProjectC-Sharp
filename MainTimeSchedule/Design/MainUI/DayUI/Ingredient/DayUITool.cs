using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using MainTimeSchedule;
using MainTimeSchedule.Design.MainUI.DayUI.Ingredient;

namespace WindowsFormsApplication1.DayUI.Ingredient
{
    public partial class DayUITool : UserControl
    {
        public Button buttonchange
        {
            get { return buttonDayUIChange; }
        }
        public DateTime daypicked = DateTime.Now;
        DayCalenderPicker dayselect = new DayCalenderPicker();
        public DayUITool()
        {
            InitializeComponent();
            Updateday();
            buttonDayUIUpDay.Click += new EventHandler(buttonUp_click);
            buttonDayUIDownDay.Click += new EventHandler(buttonDown_click);
        }
        public void Updateday()
        {
            buttonDayUIDaynow.Text = formatcontentlabel(daypicked);
            labelDayUIDay1.Text = formatcontentlabel(daypicked.AddDays(2));
            labelDayUIDay2.Text = formatcontentlabel(daypicked.AddDays(1));
            labelDayUIDay4.Text = formatcontentlabel(daypicked.AddDays(-1));
            labelDayUIDay5.Text = formatcontentlabel(daypicked.AddDays(-2)); 
        }
        public string formatcontentlabel(DateTime a)
        {
            int z = checkday(a);
            if (z == 1)
                return a.Day.ToString("00") + "/" + a.Month.ToString("00") + "\n" + a.Year.ToString("0000");
            if (z == 2)
                return a.Day.ToString("00") + "/" + a.Month.ToString("00");
            return a.Day.ToString("00");
        }
        public int checkday(DateTime a)
        {
            int d = a.Day;
            int m = a.Month;
            int y = a.Year;
            if (d == 1)
            {
                if (m == 1)
                    return 1;
                return 2;
            }
            return 0;
        }
        private void buttonUp_click(object sender, EventArgs e)
        {
            daypicked = daypicked.AddDays(1);
            Updateday();
        }
        private void buttonDown_click(object sender, EventArgs e)
        {
            daypicked = daypicked.AddDays(-1);
            Updateday();
        }
        private void buttonDayUIDaynow_Click(object sender, EventArgs e)
        {
            dayselect.SelectionStart = daypicked;
            dayselect.FormClosed += new FormClosedEventHandler(dayselect_FormClosed);
            dayselect.Text = "Chọn ngày";
            dayselect.ShowDialog();
        }
        private void dayselect_FormClosed(object sender, FormClosedEventArgs e)
        {
            DayCalenderPicker dayselect = (DayCalenderPicker)sender;
            if (dayselect.DayPicked != DateTime.MinValue)
            {
                daypicked = dayselect.DayPicked;
                Updateday();
            }
        }
    }
}   

