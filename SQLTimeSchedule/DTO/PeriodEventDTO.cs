using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLCommon;

namespace SQLTS
{
    public class PeriodEventDTO
    {
        internal int ID;
        public string Note;
        public DateTime DateStart;
        public DateTime DateEnd;
        public string DaySelect;
        public DateTime TimeStart;
        public DateTime TimeEnd;
    }
}