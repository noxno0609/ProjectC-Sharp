using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSQL
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

        public static void open(MySqlConnection conn)
        {
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                Console.Write("Database open successfully.\n");
            }
        }
        public static void close(MySqlConnection conn)
        {
            conn.Close();
            if (conn.State == ConnectionState.Closed)
            {
                Console.Write("Database close successfully.\n");
            }
        }
    }
}
