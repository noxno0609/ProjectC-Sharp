using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Design.WeekUI.Ingredient
{
    public partial class WeekUITop : UserControl
    {
        public WeekUITop()
        {
            InitializeComponent();
            UpdateButtonDate(button2);
        }
        public static void UpdateButtonDate(Button but)
        {
            but.Text = Convert.ToString(DateTime.Now);
        }
    }
}
