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
        public static void DeleteOneDTOByID(TimeEventDTO dto, MySqlConnection conn)
        {
            conn.Open();
            string sql = string.Format(@"DELETE FROM timeevent WHERE TE_ID = '{0}'", dto.ID);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
