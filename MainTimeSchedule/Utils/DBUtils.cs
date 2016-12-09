using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainTimeSchedule.Utils
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            // Connection String.
            String connString = "Server='127.0.0.1'" + ";Database='thoikhoabieu'"
                + ";port=3306" + ";User Id='root'" + ";password='12345'" + ";convert zero datetime=True";

            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}
