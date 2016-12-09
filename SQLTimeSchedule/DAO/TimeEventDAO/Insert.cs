using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTS
{
    public partial class TimeEventDAO
    {
        public static int insert(TimeEventDTO dto, MySqlConnection conn)
        {
            conn.Open();
            string sql = String.Format(@"INSERT INTO timeevent (Timestart, Timeend, Dayselect)
                                        VALUES ('{0}', '{1}', '{2}')",
            SQLFormat.addDateTime(dto.TimeStart),
            SQLFormat.addDateTime(dto.TimeEnd),
            SQLFormat.addDateTime(dto.DaySelect));
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return Convert.ToInt32(cmd.LastInsertedId);
        }
    }
}
