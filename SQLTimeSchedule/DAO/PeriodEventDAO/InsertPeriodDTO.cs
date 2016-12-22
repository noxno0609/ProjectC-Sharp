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
    public partial class PeriodEventDAO
    {
        public static int InsertPeriod(PeriodEventDTO dto, MySqlConnection conn)
        {
            conn.Open();

            string sql = String.Format(@"INSERT INTO PeriodEvent (Note, TimeStart, TimeEnd, DaySelect, DateStart, DateEnd)
                                        VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",

            dto.Note,
            SQLFormat.addDateTime(dto.TimeStart),
            SQLFormat.addDateTime(dto.TimeEnd),
            dto.DaySelect,
            SQLFormat.addDateTime(dto.TimeStart),
            SQLFormat.addDateTime(dto.DateEnd));


            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            int a = Convert.ToInt32(cmd.LastInsertedId);
            addtimeevent.addintimeevent(a, dto, conn);
            conn.Close();
            return a;



        }
    }
}