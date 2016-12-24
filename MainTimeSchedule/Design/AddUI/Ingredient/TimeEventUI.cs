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
    public partial class TimeEventUI : UserControl
    {
        public DateTime getday
        {
            get { return dateTimePicker1.Value; }

        }
        public decimal hourstart
        {
            get { return mnrHstart.Value; }
        }
        public decimal Minstart
        {
            get { return mnrMinstart.Value; }
        }
        public string note
        {
            get
            {
                 return textBoxnoidung.Text;
            }
        }
        public decimal hourend
        {
            get { return mnrHourEnd.Value; }
        }
        public decimal minrend
        {
            get { return mnrMinEnd.Value; }
        }
        public TimeEventUI()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            TimeEventUI d = (TimeEventUI)this.Parent;
            d.Hide();
        }
    }
}