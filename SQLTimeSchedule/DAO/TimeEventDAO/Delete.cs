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
        public static bool Delete(TimeEventDTO dto, MySqlConnection conn)
        {
            conn.Open();
            string sql = "DELETE FROM timeevent WHERE TE_ID = " + dto.ID;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int kqua = cmd.ExecuteNonQuery();
            conn.Close();

            if (kqua != 0)
                return true;
            
            return false;
        }
    }
}
