using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DayUISche : UserControl
    {
        public DayUISche()
        {
            InitializeComponent();
            setNumberforTable(this.tableLayoutPanel1);
        }

        public static void setNumberforTable(TableLayoutPanel table)
        {
            for(int i=0; i<table.ColumnCount; i++)
            {
                string number = Convert.ToString(i+1);
                Label tableLabel = new Label();
                tableLabel.Text = number;
                tableLabel.FlatStyle = FlatStyle.System;
                tableLabel.AutoSize = false;
                tableLabel.BorderStyle = BorderStyle.FixedSingle;
                tableLabel.Padding = new Padding(0);
                tableLabel.Margin = new Padding(0);
                tableLabel.Dock = DockStyle.Fill;
                tableLabel.TextAlign = ContentAlignment.MiddleCenter;
                table.Controls.Add(tableLabel, i, 0);
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
