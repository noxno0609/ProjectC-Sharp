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
        public DateTimePicker tbPickdate
        {
            get { return tbpickdate; }
            set { tbpickdate = value; }
        }
        public NumericUpDown tbTimestarth
        {
            get { return tbtimestarth; }
            set { tbtimestarth = value; }
        }
        public NumericUpDown tbTimestartm
        {
            get { return tbtimestartm; }
            set { tbtimestartm = value; }
        }
        public NumericUpDown tbTimeendh
        {
            get { return tbtimeendh; }
            set { tbtimeendh = value; }
        }
        public NumericUpDown tbTimeendm
        {
            get { return tbtimeendm; }
            set { tbtimeendm = value; }
        }
        public TextBox tbNote
        {
            get { return tbnote; }
            set { tbnote = value; }
        }

        public TimeEventUI()
        {
            InitializeComponent();
            tbpickdate.CustomFormat = "dd/MM/yyyy";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            TimeEventUI d = (TimeEventUI)this.Parent;
            d.Hide();
        }
    }
}