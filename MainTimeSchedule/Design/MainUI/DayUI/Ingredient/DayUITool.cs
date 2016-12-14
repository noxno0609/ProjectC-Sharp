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

namespace WindowsFormsApplication1.DayUI.Ingredient
{
    public partial class DayUITool : UserControl
    {
        public Button buttonchange
        {
            get { return buttonDayUIChange; }
        }
        public DateTime daypicked = DateTime.Now;
        MonthCalendar selectday = new MonthCalendar();
        public DayUITool()
        {
            InitializeComponent();
            Updateday();
            buttonDayUIUpDay.Click += new EventHandler(buttonUp_click);
            buttonDayUIDownDay.Click += new EventHandler(buttonDown_click);
        }
        public void Updateday()
        {
            int z = checkday(daypicked);
            if (z == 1)
                buttonDayUIDaynow.Text = daypicked.Day + "/" + daypicked.Month + "/" + daypicked.Year;
            if (z == 2)
                buttonDayUIDaynow.Text = daypicked.Day + "/" + daypicked.Month;
            if (z == 0)
                buttonDayUIDaynow.Text = Convert.ToString(daypicked.Day);
            labelDayUIDay1.Text = Convert.ToString(daypicked.AddDays(2).Day);
            labelDayUIDay2.Text = Convert.ToString(daypicked.AddDays(1).Day);
            labelDayUIDay4.Text = Convert.ToString(daypicked.AddDays(-1).Day);
            labelDayUIDay5.Text = Convert.ToString(daypicked.AddDays(-2).Day);
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
        public int checkday(DateTime a)
        {
            int d = Convert.ToInt32(daypicked.Day);
            int m = Convert.ToInt32(daypicked.Month);
            int y = Convert.ToInt32(daypicked.Year);
            if (d == 1)
            {
                if (m == 1)
                    return 1;
                return 2;
            }
            return 0;
        }
        private void buttonDayUIDaynow_Click(object sender, EventArgs e)
        {

        }
        
    }
}   

