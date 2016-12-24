using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonTimeSchedule;
using SQLTS;
using MainTimeSchedule.Utils;

namespace WindowsFormsApplication1.Design.WeekUI.Ingredient
{
    public partial class WeekUISche : UserControl
    {
        public TableLayoutPanel ScheBone
        {
            get { return schebone; }
            set { schebone = value; }
        }
        public WeekUISche()
        {
            InitializeComponent();
            setupTopBone();
        }
        public void setupTopBone()
        {
            topbone.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            for (int i = 0; i < topbone.ColumnCount; i++)
            {
                Label label = new Label();
                label.Text = FormatUtils.formatDoW(DateTimeUtils.numberDoW(i + 1));
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Padding = new Padding(0);
                label.Margin = new Padding(0);
                topbone.Controls.Add(label, i, 0);
            }
            float height = borderschebone.Height * 2 / 100;
            paneldropbottom.Height = Convert.ToInt32(height * 1.5);
            paneldroptop.Height = Convert.ToInt32(height * 1.0);
           
            //for (int i = 0; i < schebone.RowCount; i++)
            //{
            //    if (i == 0 || i == 26)
            //    {
            //        Panel timepanel = new Panel();
            //        timepanel.Dock = DockStyle.Fill;
            //        timepanel.Margin = new Padding(0);
            //        timepanel.Padding = new Padding(0);
            //        timepanel.BackColor = Color.Gray;
                    
            //        schebone.Controls.Add(timepanel, 0, i);
            //        schebone.SetColumnSpan(timepanel, 7);
            //    }
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
