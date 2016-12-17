﻿using System;
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

        public static List<DayOfWeek> formatDaySelect(string dayselect)
        {
            if (dayselect.Length != 7) return null;

            List<DayOfWeek> listDay = new List<DayOfWeek>();
            for(int i=0; i<dayselect.Length; i++)
            {
                if(dayselect[i] == '1')
                {
                    DayOfWeek day = new DayOfWeek();
                    switch(i)
                    {
                        case 0: { day = DayOfWeek.Monday; break; }
                        case 1: { day = DayOfWeek.Tuesday; break; }
                        case 2: { day = DayOfWeek.Wednesday; break; }
                        case 3: { day = DayOfWeek.Thursday; break; }
                        case 4: { day = DayOfWeek.Friday; break; }
                        case 5: { day = DayOfWeek.Saturday; break; }
                        case 6: { day = DayOfWeek.Sunday; break; }
                    }
                    listDay.Add(day);
                }
            }
            return listDay;
        }
    }
}
