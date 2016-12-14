using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCommon
{
    public class SQLFormat
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

        public static DateTime formatTime(string time)
        {
            DateTime datetime = new DateTime();

            string[] timesplit = time.Split(':');
            int hour = Convert.ToInt32(timesplit[0]);
            int minute = Convert.ToInt32(timesplit[1]);
            int second = Convert.ToInt32(timesplit[2]);

            TimeSpan timetemp = new TimeSpan(hour, minute, second);

            datetime = datetime.Date + timetemp;

            return datetime;
        }
    }
}
