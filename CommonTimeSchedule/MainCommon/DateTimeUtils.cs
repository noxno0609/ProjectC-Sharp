using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTimeSchedule
{
    public class DateTimeUtils
    {
        public static DateTime getFirstDoW(DateTime date)
        {
            DateTime resultdate = date;
            while(resultdate.DayOfWeek != DayOfWeek.Monday)
            {
                resultdate = resultdate.AddDays(-1);
            }
            return resultdate;
        }
        public static DateTime getLastDoW(DateTime date)
        {
            DateTime resultdate = date;
            while (resultdate.DayOfWeek != DayOfWeek.Sunday)
            {
                resultdate = resultdate.AddDays(1);
            }
            return resultdate;
        }
    }
}
