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
            tbdatestart.CustomFormat = "dd/MM/yyyy";
            tbdateend.CustomFormat = "dd/MM/yyyy";
        }
        public TextBox tbName
        {
            get { return tbname; }
            set { tbName = value; }
        }
        public DateTimePicker tbDatestart
        {
            get { return tbdatestart; }
            set { tbdatestart = value;  }
        }
        public DateTimePicker tbDateend
        {
            get { return tbdateend; }
            set { tbdateend = value; }
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
        public TextBox tbNote
        {
            get { return tbnote; }
            set { tbnote = value; }
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
        public CheckBox cbt2
        {
            get { return cb2; }
            set { cb2 = value; }
        }
        public CheckBox cbt3
        {
            get { return cb3; }
            set { cb3 = value; }
        }
        public CheckBox cbt4
        {
            get { return cb4; }
            set { cb4 = value; }
        }
        public CheckBox cbt5
        {
            get { return cb5; }
            set { cb5 = value; }
        }
        public CheckBox cbt6
        {
            get { return cb6; }
            set { cb6 = value; }
        }
        public CheckBox cbt7
        {
            get { return cb7; }
            set { cb7 = value; }
        }
        public CheckBox cbtCN
        {
            get { return cbCN; }
            set { cbCN = value; }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            PeriodEventUI w = (PeriodEventUI)this.Parent;
            w.Hide();
        }
    }
}
