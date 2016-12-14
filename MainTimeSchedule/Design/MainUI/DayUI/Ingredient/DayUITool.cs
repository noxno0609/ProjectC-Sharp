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
        DateTimePicker selectday = new DateTimePicker();
        public DayUITool()
        {
            InitializeComponent();
            Updateday();
            buttonDayUIUpDay.Click += new EventHandler(buttonUp_click);
            buttonDayUIDownDay.Click += new EventHandler(buttonDown_click);
        }
        public void Updateday()
        {
            buttonDayUIDaynow.Text = Get_Day(daypicked) + "/" + Get_Month(daypicked);
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
            
        }
    }        
}
