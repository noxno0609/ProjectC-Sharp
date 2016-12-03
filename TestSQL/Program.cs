using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSSQL.DTO;

namespace TestSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            DBUtils.open(conn);

            //string sql = "UPDATE user SET Ten = 'MinhCho' WHERE ID = 6";
            //MySqlCommand cmd = new MySqlCommand(sql, conn);
            //cmd.ExecuteNonQuery();

            //string sql = "SELECT NgayTruyCap FROM user WHERE ID = 1";
            //MySqlCommand cmd = new MySqlCommand(sql, conn);
            //DateTime dem = Convert.ToDateTime(cmd.ExecuteScalar());

            //string sql = "SELECT * FROM user";
            //MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    int id = Convert.ToInt32(dr["ID"]);
            //    string ten = Convert.ToString(dr["Ten"]);
            //    DateTime ngaysinh = Convert.ToDateTime(dr["NgaySinh"]);
            //    DateTime ngaytruycap = Convert.ToDateTime(dr["NgayTruyCap"]);
            //    Console.WriteLine(id + "\t" + ten + "\t" + ngaysinh + "\t" + ngaytruycap);
            //}
            //SQLTS.TSSQL("Nam", 4, conn);
            //TSSQL.updateSQL("Nam", 4, conn);
            DayDTO.updateSQL("Nam", 4, conn);

            DBUtils.close(conn);
            Console.ReadKey();
        }
    }
}
