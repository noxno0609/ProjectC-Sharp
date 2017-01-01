using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLCommon;

namespace SQLTS
{
    public partial class TimeEventDAO
    {
        public static int Insert(TimeEventDTO dto, MySqlConnection conn)
        {
            conn.Open();
            string sql = String.Format(@"INSERT INTO TimeEvent (PE_ID, Note, TimeStart, TimeEnd, DaySelect, Color)
                                        VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}')",
            dto.PE_ID,
            dto.Note,
            SQLFormat.addDateTime(dto.TimeStart),
            SQLFormat.addDateTime(dto.TimeEnd),
            SQLFormat.addDateTime(dto.DaySelect),
            dto.Color);

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            return Convert.ToInt32(cmd.LastInsertedId);
        }
    }
}
