
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
        public static void Update(TimeEventDTO dto, MySqlConnection conn)
        {
            conn.Open();
            string sql = String.Format(@"UPDATE timeevent 
                SET PE_ID = {0}, Note = '{1}', TimeStart = '{2}', TimeEnd = '{3}', DaySelect = '{4}' 
                WHERE TE_ID = '{5}'",
            dto.PE_ID,
            dto.Note,
            SQLFormat.addDateTime(dto.TimeStart),
            SQLFormat.addDateTime(dto.TimeEnd),
            SQLFormat.addDateTime(dto.DaySelect),
            dto.ID);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}

