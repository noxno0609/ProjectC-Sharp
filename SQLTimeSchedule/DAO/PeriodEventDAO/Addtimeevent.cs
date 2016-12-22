using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLCommon;
using System.Data;
using SQLTS;
namespace SQLTS
{
    public partial class addtimeevent
    {
        public static void addintimeevent(int a, PeriodEventDTO dto, MySqlConnection conn)
        {
            List<DayOfWeek> list = SQLFormat.formatDaySelect(dto.DaySelect);
            for (DateTime date = dto.DateStart; date <= dto.DateEnd; date = date.AddDays(1))
            {
                if (list.Contains(date.DayOfWeek) == true)
                {

                    TimeEventDTO dto1 = new TimeEventDTO();
                    dto1.PE_ID = a;
                    dto1.Note = dto.Note;
                    dto1.TimeStart = dto.TimeStart;
                    dto1.TimeEnd = dto.TimeEnd;
                    dto1.DaySelect = date;
                    conn.Close();                   
                    TimeeventDAO.Insert(dto1, conn);
                    conn.Open();
                }
            }
        }
    }
}
