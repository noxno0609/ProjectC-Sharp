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
using WindowsFormsApplication1.Design.WeekUI;

namespace WindowsFormsApplication1.DayUI
{
    public partial class DayUIMain : UserControl
    {
        public DayUITool daytool
        {
            get { return dayUITool; }
        }
        public DayUIMain()
        {
            InitializeComponent();
        }
    }
}
