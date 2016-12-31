using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLCommon;

namespace SQLTS
{
    public class TimeEventDTO //Data Transfer Object
    {
        internal int ID;
        public int PE_ID;
        public DateTime TimeStart;
        public DateTime TimeEnd;
        public string Note;
        public DateTime DaySelect;

        public TimeEventDTO(TimeEventDTO dto)
        {
            this.ID = dto.ID;
            this.PE_ID = dto.PE_ID;
            this.TimeStart = dto.TimeStart;
            this.TimeEnd = dto.TimeEnd;
            this.Note = dto.Note;
            this.DaySelect = dto.DaySelect;
        }
        public TimeEventDTO()
        {
            this.ID = 0;
            this.PE_ID = 0;
            this.TimeStart = DateTime.MinValue;
            this.TimeEnd = DateTime.MinValue;
            this.Note = null;
            this.DaySelect = DateTime.MinValue;
        }
    }
}
