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
            setNumberforTable();
        }

        private  void setNumberforTable()
        {
            for (int i = 0; i < tableLayoutPanelHour.ColumnCount ; i++)
            {
                Panel timepanel = new Panel();
                timepanel.Dock = DockStyle.Fill;
                timepanel.Margin = new Padding(0);
                timepanel.Padding = new Padding(0);
                tableLayoutPanelHour.Controls.Add(timepanel, i,0);

                int timepos = i + 1;
                if (timepos == tableLayoutPanelHour.ColumnCount / 2)
                {
                    Label label = new Label();
                    label.Text = "12";
                    label.Dock = DockStyle.Fill;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Padding = new Padding(0);
                    label.Margin = new Padding(0);
                    label.BackColor = System.Drawing.Color.Transparent;
                    timepanel.Controls.Add(label);

                    timepanel.BackgroundImage = global::MainTimeSchedule.Properties.Resources.daytimeonestick;
                    timepanel.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }
    }
}
