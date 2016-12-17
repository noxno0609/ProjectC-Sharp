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

        public static DayOfWeek numberDoW(int number)
        {
            switch (number)
            {
                case 1: return DayOfWeek.Monday;
                case 2: return DayOfWeek.Tuesday;
                case 3: return DayOfWeek.Wednesday;
                case 4: return DayOfWeek.Thursday;
                case 5: return DayOfWeek.Friday;
                case 6: return DayOfWeek.Saturday;
                case 7: return DayOfWeek.Sunday;
            }
            return DayOfWeek.Monday;
        }
    }
}
