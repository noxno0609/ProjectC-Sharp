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

namespace WindowsFormsApplication1.Design.WeekUI.Ingredient
{
    public partial class WeekUISche : UserControl
    {
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
        }
    }
}
