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
            setNumberforTable(tableLayoutPanelHour);
            
        }

        public static void setNumberforTable(TableLayoutPanel table)
        {
            for(int i=0; i<table.ColumnCount; i++)
            { 
                string number = Convert.ToString(i+1);
                int t = Convert.ToInt32(number);
                if (t == 12)
                {
                    Label textbox = new Label();
                    textbox.Text = number;
                    textbox.TextAlign = ContentAlignment.MiddleCenter;
                    // textbox.FlatStyle = FlatStyle.System;
                    textbox.AutoSize = false;
                    //textbox.BorderStyle = BorderStyle.FixedSingle;
                    textbox.Padding = new Padding(0);
                    textbox.Margin = new Padding(0);
                    textbox.Dock = DockStyle.Fill;
                    textbox.Padding = new Padding(0, textbox.Height / 6, 0, 0);
                    //textbox.BackColor = Color.LightGray;
                    table.Controls.Add(textbox, i, 0);
                }

            }
        }

        private void tableLayoutPanelHour_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
