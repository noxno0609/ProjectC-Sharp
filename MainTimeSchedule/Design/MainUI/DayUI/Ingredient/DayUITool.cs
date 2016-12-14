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

namespace WindowsFormsApplication1.DayUI.Ingredient
{
    public partial class DayUITool : UserControl
    {
        public Button buttonchange
        {
            get { return buttonDayUIChange; }
        }
        public DateTime daypicked = DateTime.Now;
        public DayUITool()
        {
            InitializeComponent();
            UpdateButtonDate();
            buttonDayUIUpDay.Click += new EventHandler(buttonUp_click);
            buttonDayUIDownDay.Click += new EventHandler(buttonDown_click);
        }
        public void UpdateButtonDate()
        {
            buttonDayUIDaynow.Text = Get_Day();
        }
        public string Get_Day()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(0, 2);
            return str;
        }
        public string Get_Month()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(3, 2);
            return str;
        }
        public string Get_Year()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(6, 4);
            return str;
        }
        public DateTime GetLastDayOfMonth(int year, int month )
        {
            DateTime aday = new DateTime(year,month,1);
            DateTime retday = aday.AddMonths(1).AddDays(-1);
            return retday;
        }

        private void buttonUp_click(object sender, EventArgs e)
        {
            int c = int.Parse(buttonDayUIDaynow.Text)+1;
            int a = c-1;
            int b = a-1;
            int d = c+1;
            int f =d+1;
            buttonDayUIDaynow.Text = Convert.ToString(c);
            labelDayUIDay1.Text = Convert.ToString(b);
            labelDayUIDay2.Text = Convert.ToString(a);
            labelDayUIDay4.Text = Convert.ToString(d);
            labelDayUIDay5.Text = Convert.ToString(f);
            //MessageBox.Show
            //    (
            //     GetLastDayOfMonth(Convert.ToInt32(Get_Year), Convert.ToInt32(month));
            //    );

        }
        private void buttonDown_click(object sender, EventArgs e)
        {
            int c = int.Parse(buttonDayUIDaynow.Text) - 1;
            int a = c - 1;
            int b = a - 1;
            int d = c + 1;
            int f = d + 1;
            buttonDayUIDaynow.Text = Convert.ToString(c);
            labelDayUIDay1.Text = Convert.ToString(b);
            labelDayUIDay2.Text = Convert.ToString(a);
            labelDayUIDay4.Text = Convert.ToString(d);
            labelDayUIDay5.Text = Convert.ToString(f);
        }
    }
}
