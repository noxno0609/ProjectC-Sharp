using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSProject.Design.EditEvent.Ingredient
{
    public partial class PeriodEventUI : UserControl
    {
        public PeriodEventUI()
        {
            InitializeComponent();
        }
        public DateTime getdayStart
        {
            get 
            { 
                DateTime datetemp = dateStart.Value;
                return datetemp.Date;
            }
        }
        public DateTime getdayEnd
        {
            get 
            {
                DateTime datetemp = dateEnd.Value;
                return datetemp.Date;
            }
        }
        public decimal hourstart
        {
            get { return nmrHourStart.Value; }
        }
        public decimal Minstart
        {
            get { return nmrMinStart.Value; }
        }
        public string note
        {
            get
            {
                return textBox1.Text;
            }
        }
        public decimal hourend
        {
            get { return nmrHourEnd.Value; }
        }
        public decimal minrend
        {
            get { return mnrMinEnd.Value; }
        }
        public string thu2
        {
            get { if (checkBoxthu2.Checked == true) return "1";
                return "0";
            }
        }
        public string thu3
        {
            get
            {
                if (checkBoxthu3.Checked == true) return "1";
                return "0";
            }
        }
        public string thu4
        {
            get
            {
                if (checkBoxthu4.Checked == true) return "1";
                return "0";
            }
        }
        public string thu5
        {
            get
            {
                if (checkBoxthu5.Checked == true) return "1";
                return "0";
            }
        }
        public string thu6
        {
            get
            {
                if (checkBoxthu6.Checked == true) return "1";
                return "0";
            }
        }
        public string thu7
        {
            get
            {
                if (checkBoxthu7.Checked == true) return "1";
                return "0";
            }
        }
        public string CN
        {
            get
            {
                if (checkBoxCN.Checked == true) return "1";
                return "0";
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            PeriodEventUI w = (PeriodEventUI)this.Parent;
            w.Hide();
        }
    }
}
