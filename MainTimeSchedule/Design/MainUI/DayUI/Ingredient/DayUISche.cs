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
        public TableLayoutPanel ScheBone
        {
            get { return scheBone; }
            set { scheBone = value; }
        }
        public DayUISche()
        {
            InitializeComponent();
            setNumberforTable();
            
            float height = (scheBone.Width + panelleft.Width + panelright.Width) * 2 / 100;
            panelleft.Width = Convert.ToInt32(height*1.3);
            panelright.Width = Convert.ToInt32(height*1.5);
        }
        private void setNumberforTable()
        {
            for (int i = 0; i < scheBone.ColumnCount; i++)
            {
                if (i == 0 || i == 26)
                {
                    Panel timepanel = new Panel();
                    timepanel.Dock = DockStyle.Fill;
                    timepanel.Margin = new Padding(0);
                    timepanel.Padding = new Padding(0);
                    timepanel.BackColor = Color.Gray;
                    scheBone.Controls.Add(timepanel, i, 0);
                }
            }
            for (int i = 0; i < tableLayoutPanelHour.ColumnCount; i++)
            {
                Panel timepanel = new Panel();
                timepanel.Dock = DockStyle.Fill;
                timepanel.Margin = new Padding(0);
                timepanel.Padding = new Padding(0);
                tableLayoutPanelHour.Controls.Add(timepanel, i, 0);
                //if (i == 0 || i == 24)
                //    tableLayoutPanelContent.SetColumnSpan(timepanel, 2);


                //if (i==1)
                //{
                //    int j = 0;
                //    while(j<30)
                //    { 
                //        tableLayoutPanelHour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.33F));
                //        j++;
                //    }
                //    tableLayoutPanelHour.Controls.Add(timepanel, i, 0);
                //    tableLayoutPanelHour.SetColumnSpan(timepanel, 15);
                //}

                int timepos = i;
                if (timepos == 0 || timepos == 6 || timepos == 12 || timepos == 18 || timepos == 24)
                {
                    Label label = new Label();
                    label.Text = timepos.ToString();
                    label.Dock = DockStyle.Fill;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Padding = new Padding(0);
                    label.Margin = new Padding(0);
                    label.BackColor = System.Drawing.Color.Transparent;
                    timepanel.Controls.Add(label);

                    timepanel.BackgroundImage = global::MainTimeSchedule.Properties.Resources.daytimeonestick;
                    timepanel.BackgroundImageLayout = ImageLayout.Stretch;
                }

                //if(i==0)
                //{
                //    TableLayoutPanel x = new TableLayoutPanel();
                //    x.Dock = DockStyle.Fill;
                //    x.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                //    x.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                //    Panel p = new Panel();
                //    p.Dock = DockStyle.Fill;
                //    p.BackColor = Color.Gray;
                //    x.Controls.Add(p, 2, 0);
                //    timepanel.Controls.Add(x);
                //}
            }

        }
    }
}
