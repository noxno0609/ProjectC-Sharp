using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSProject.Design.EditEvent.Ingredient;

namespace TSProject.Design.WeekUI.Ingredient
{
    public partial class WeekUITool : UserControl
    {
        public WeekUITool()
        {
            InitializeComponent();
            setupContentBone();
        }
        private void setupContentBone()
        {
           for(int i=0; i < contentbone.RowCount; i++)
           {
               Panel timepanel = new Panel();
               timepanel.Dock = DockStyle.Fill;
               timepanel.Margin = new Padding(0);
               timepanel.Padding = new Padding(0);
               contentbone.Controls.Add(timepanel, 0, i);

               int timepos = i + 1;
               if(timepos == contentbone.RowCount/2)
               {
                   Label label = new Label();
                   label.Text = "12";
                   label.TextAlign = ContentAlignment.MiddleCenter;
                   label.AutoSize = false;
                   label.Padding = new Padding(0);
                   label.Margin = new Padding(0);
                   label.Dock = DockStyle.Fill;
                   label.BackColor = System.Drawing.Color.Transparent;
                   timepanel.Controls.Add(label);

                   timepanel.BackgroundImage = global::MainTimeSchedule.Properties.Resources.weektimeonestick;
                   timepanel.BackgroundImageLayout = ImageLayout.Stretch;
               }
           }
        }
    }
}
