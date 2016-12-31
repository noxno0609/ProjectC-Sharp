using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTS
{
    public partial class PeriodEventDAO
    {
        public static int GetCountAllTEDTOByID(int peid, MySqlConnection conn)
        {
            conn.Open();

            string sql = "SELECT COUNT(*) FROM timeevent WHERE PE_ID = " + peid;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count;
        }
    }
}
