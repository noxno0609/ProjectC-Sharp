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
                buttonDayUIDaynow.Text = Get_Day(daypicked) + "/" + Get_Month(daypicked) + "/" + Get_Year(daypicked);
            if (z == 2)
                buttonDayUIDaynow.Text = Get_Day(daypicked) + "/" + Get_Month(daypicked);
            if(z==0)
                buttonDayUIDaynow.Text = Get_Day(daypicked);
            labelDayUIDay1.Text = Get_Day(daypicked.AddDays(2));
            labelDayUIDay2.Text = Get_Day(daypicked.AddDays(1));
            labelDayUIDay4.Text = Get_Day(daypicked.AddDays(-1));
            labelDayUIDay5.Text = Get_Day(daypicked.AddDays(-2));

        }
        public string Get_Day(DateTime a)
        {
            string str = a.ToString().Trim();
            str = str.Substring(0, 2);
            return str;
        }
        public string Get_Month(DateTime a)
        {
            string str = a.ToString().Trim();
            str = str.Substring(3, 2);
            return str;
        }
        public string Get_Year(DateTime a)
        {
            string str = a.ToString().Trim();
            str = str.Substring(6, 4);
            return str;
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
            int d = Convert.ToInt32(Get_Day(daypicked));
            int m = Convert.ToInt32(Get_Month(daypicked));
            int y = Convert.ToInt32(Get_Year(daypicked));
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

