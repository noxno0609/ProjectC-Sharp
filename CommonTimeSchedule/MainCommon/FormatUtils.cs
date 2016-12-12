using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTimeSchedule
{
    public class FormatUtils
    {
        public static string formatDate(DateTime date)
        {
            return date.Day.ToString("00") + "/" + date.Month.ToString("00") + "/" + date.Year.ToString("0000");
        }
        public static string formatTime(DateTime date)
        {
            return date.Hour.ToString("00") + "/" + date.Minute.ToString("00") + "/" + date.Second.ToString("00");
        }
    }
}
