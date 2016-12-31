using CommonTimeSchedule;
using MySql.Data.MySqlClient;
using SQLCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTS
{
    public partial class PeriodEventDAO
    {
        public static bool Update(PeriodEventDTO dto, MySqlConnection conn)
        {
            #region Update Period Event

            conn.Open();

            string sql = String.Format(@"UPDATE periodevent 
                SET Datestart = '{0}', Dateend = '{1}', Timestart = '{2}', Timeend = '{3}', Dayselect = '{4}' , Note = '{5}', Name = '{6}'
                WHERE PE_ID = {7}",
            SQLFormat.addDateTime(dto.DateStart),
            SQLFormat.addDateTime(dto.DateEnd),
            SQLFormat.addDateTime(dto.TimeStart),
            SQLFormat.addDateTime(dto.TimeEnd),
            dto.DaySelect,
            dto.Note,
            dto.Name,
            dto.ID);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int resultperiod = cmd.ExecuteNonQuery();

            conn.Close();

            #endregion

            #region Update Time Event By Period

            //Update old case, If It's not on case anymore, delete!
            List<TimeEventDTO> listdtoTE = TimeEventDAO.GetDTOByPeriodID(dto.ID, conn);
            List<DayOfWeek> listDoW = SQLFormat.formatDaySelect(dto.DaySelect);
            foreach (TimeEventDTO dtoTE in listdtoTE)
            {
                dtoTE.TimeStart = dto.TimeStart;
                dtoTE.TimeEnd = dto.TimeEnd;
                dtoTE.Note = dto.Note;
                dtoTE.PE_ID = dto.ID;
                if (!listDoW.Contains(dtoTE.DaySelect.DayOfWeek))
                {
                    TimeEventDAO.Delete(dtoTE, conn);
                }
                else TimeEventDAO.Update(dtoTE, conn);
            }

            #endregion

            #region Insert New Time Event If Not On DB

            //Insert new case, which don't exists on old DB
            for (DateTime date = dto.DateStart; date <= dto.DateEnd; date = date.AddDays(1))
            {
                if (listDoW.Contains(date.DayOfWeek))
                {
                    conn.Open();
                    sql = "SELECT COUNT(*) FROM timeevent WHERE PE_ID = " + dto.ID + " AND Dayselect = '" + SQLFormat.addDateTime(date) + "'";
                    cmd = new MySqlCommand(sql, conn);
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();

                    if (result == 0)
                    {
                        TimeEventDTO dtotemp = new TimeEventDTO();
                        dtotemp.PE_ID = dto.ID;
                        dtotemp.Note = dto.Note;
                        dtotemp.TimeStart = dto.TimeStart;
                        dtotemp.TimeEnd = dto.TimeEnd;
                        dtotemp.DaySelect = date;
                        TimeEventDAO.Insert(dtotemp, conn);
                    }
                }
            }

            #endregion

            return (resultperiod > 0) ? true : false;
        }
    }
}
