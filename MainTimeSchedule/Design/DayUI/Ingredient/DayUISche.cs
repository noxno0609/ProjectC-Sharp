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
            ///setNumberforTable(this.tableLayoutPanel1);
            
        }

        public static void setNumberforTable(TableLayoutPanel table)
        {
            for(int i=0; i<table.ColumnCount; i++)
            {
                string number = Convert.ToString(i+1);
                TextBox textbox = new TextBox();
                textbox.Text = number;
                textbox.TextAlign = HorizontalAlignment.Center;
                // textbox.FlatStyle = FlatStyle.System;
                textbox.AutoSize = false;
                textbox.BorderStyle = BorderStyle.FixedSingle;
                textbox.Padding = new Padding(0);
                textbox.Margin = new Padding(0);
                textbox.Dock = DockStyle.Fill;
                textbox.Padding = new Padding(0, textbox.Height / 2, 0, 0);
                //textbox.TextAlign = ContentAlignment.MiddleCenter;
                table.Controls.Add(textbox, i, 0);
            }
        }
    }
}
