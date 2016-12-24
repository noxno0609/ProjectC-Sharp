using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainTimeSchedule;

namespace TimeScheduleMain
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MessageBoxTextOption();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainUI());
        }

        public static void MessageBoxTextOption()
        {
            MessageBoxManager.No = "Không";
            MessageBoxManager.Yes = "Có";
            MessageBoxManager.Register();
        }
    }
}







 
