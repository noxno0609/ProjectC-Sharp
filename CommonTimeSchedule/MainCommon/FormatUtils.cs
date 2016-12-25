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
        public static string formatDoW(DayOfWeek dow)
        {
            switch(dow)
            {
                case DayOfWeek.Monday: return "Thứ Hai";
                case DayOfWeek.Tuesday: return "Thứ Ba";
                case DayOfWeek.Wednesday: return "Thứ Tư";
                case DayOfWeek.Thursday: return "Thứ Năm";
                case DayOfWeek.Friday: return "Thứ Sáu";
                case DayOfWeek.Saturday: return "Thứ Bảy";
                case DayOfWeek.Sunday: return "Chủ Nhật";
            }
            return "";
        }
        public static int numberDoW(DayOfWeek dow)
        {
            switch (dow)
            {
                case DayOfWeek.Monday: return 1;
                case DayOfWeek.Tuesday: return 2;
                case DayOfWeek.Wednesday: return 3;
                case DayOfWeek.Thursday: return 4;
                case DayOfWeek.Friday: return 5;
                case DayOfWeek.Saturday: return 6;
                case DayOfWeek.Sunday: return 7;
            }
            return -1;
        }
    }
}
