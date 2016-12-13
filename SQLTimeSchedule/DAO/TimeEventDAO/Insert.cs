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
        public static int insert(TimeEventDTO dto, MySqlConnection conn)
        {
            conn.Open();
            string sql = String.Format(@"INSERT INTO TimeEvent (ID, PE_ID, Note, TimeStart, TimeEnd, DaySelect)
                                        VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
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
