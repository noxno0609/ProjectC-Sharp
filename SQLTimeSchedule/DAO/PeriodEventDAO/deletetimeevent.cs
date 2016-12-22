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
    public partial class time
    {
        public static void Delete(int a, TimeEventDTO dto, MySqlConnection conn)
        {

            string sql = "DELETE FROM timeevent WHERE PE_ID = " + a;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int kqua = cmd.ExecuteNonQuery();



        }

        internal static void Insert(TimeEventDTO dto1, MySqlConnection conn)
        {
            throw new NotImplementedException();
        }
    }
}
