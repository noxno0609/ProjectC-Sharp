using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DayUI.Ingredient;

namespace WindowsFormsApplication1.DayUI
{
    public partial class DayUIMain : UserControl
    {
        public DayUIMain()
        {
            InitializeComponent();
            //this.dayUITool1
            this.Width = 580;
            autoSize(this);
            autoSizeIngredient(this);
        }

        public static void autoSize(DayUIMain ui)
        {
            int firstWidth = ui.Width;
            int temp = Convert.ToInt32(firstWidth * 0.85);
            int temp2 = Convert.ToInt32(firstWidth * 0.15);
            while (temp % 24 != 0)
            {
                temp++;
            }
            ui.Width = temp;
        }

        public static void autoSizeIngredient(DayUIMain ui)
        {
            ui.dayUITool1.Height = ui.Height;
            ui.dayUITool1.Width = (int)(ui.Width * 0.15);

            ui.dayUISche1.Height = ui.Height;
            ui.dayUISche1.Width = (int)(ui.Width * 0.85);
        }
        private void dayUISche1_Load(object sender, EventArgs e)
        {

        }

        private void dayUISche1_Load_1(object sender, EventArgs e)
        {

        }

    }
}
