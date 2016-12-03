using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSSQL.DTO
{
    public partial class DayDTO
    {
        public static void deleteSQL(string name, int id, MySqlConnection conn)
        {
            string sql = "UPDATE user SET Ten = '" + name + "' WHERE ID = " + id;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
