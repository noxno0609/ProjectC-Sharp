using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLCommon;

namespace SQLTS
{
    public class TimeEventDTO
    {
        public int ID;
        public int PE_ID;
        public DateTime TimeStart;
        public DateTime TimeEnd;
        public string Note;
        public DateTime DaySelect;
    }
}
