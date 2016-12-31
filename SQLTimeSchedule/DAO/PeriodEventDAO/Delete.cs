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
        public static bool Delete(PeriodEventDTO dto, MySqlConnection conn)
        {
            conn.Open();

            string sql = "DELETE FROM periodevent WHERE PE_ID = " + dto.ID;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int periodresult = cmd.ExecuteNonQuery();

            sql = "DELETE FROM timeevent WHERE PE_ID = " + dto.ID;
            cmd = new MySqlCommand(sql, conn);
            int timeresult = cmd.ExecuteNonQuery();

            conn.Close();

            return (periodresult > 0 && timeresult > 0) ? true : false;
        }
    }
}
