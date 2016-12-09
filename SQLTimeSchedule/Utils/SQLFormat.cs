using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTS
{
    class SQLFormat
    {
        public static string addDateTime(DateTime date)
        {
            string year = date.Year.ToString("0000");
            string month = date.Month.ToString("00");
            string day = date.Day.ToString("00");

            string hour = date.Hour.ToString("00");
            string minute = date.Minute.ToString("00");
            string second = date.Second.ToString("00");

            return year + "-" + month + "-" + day + " " + hour + ":" + minute + ":" + second;
        }
    }
}
