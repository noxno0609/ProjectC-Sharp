using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainTimeSchedule.Design.MainUI.DayUI.Ingredient
{
    public partial class DayCalenderPicker : Form
    {
        public DateTime SelectionStart
        {
            get { return dateTimePicker1.MaxDate; }
            set { dateTimePicker1.Value = value; }
        }
        public DateTime DayPicked { get; set; }
        public DayCalenderPicker()
        {
            InitializeComponent();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            DayPicked = dateTimePicker1.Value;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
