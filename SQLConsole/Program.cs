using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLTS;
using TestSQL;

namespace TestSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            //DBUtils.open(conn);

            //Thực hiện một câu lệnh SQL
            //string sql = "UPDATE user SET Ten = 'MinhCho' WHERE ID = 6";
            //MySqlCommand cmd = new MySqlCommand(sql, conn);
            //cmd.ExecuteNonQuery();
            
            //Lấy một giá trị duy nhất
            //string sql = "SELECT NgayTruyCap FROM user WHERE ID = 1";
            //MySqlCommand cmd = new MySqlCommand(sql, conn);
            //DateTime dem = Convert.ToDateTime(cmd.ExecuteScalar());

            //Lấy nhiều giá trị từ nhiều cột
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

            //TimeEventDTO dto = new TimeEventDTO();
            //dto.TimeEnd = DateTime.Now;
            //dto.TimeStart = DateTime.Now;
            //dto.DaySelect = DateTime.Now;

            //int insertid = TimeEventDAO.insert(dto, conn);

            //Console.WriteLine(insertid);

            //List<TimeEventDTO> list = TimeEventDAO.GetAllDTO(conn);
            //foreach(TimeEventDTO dto in list)
            //{
            //    Console.WriteLine(dto.ID + " - " + dto.TimeStart + " - " + dto.TimeEnd);
            //}

            //for (DateTime date = DateStart; date.Date <= DateEnd; date = date.AddDays(1))
            //{
            //    if(date.DayOfWeek == "Monday" || date.DayOfWeek == "Wednesday")
            //    {
            //        TimeEventDTO dto = new TimeEventDTO();
            //        dto.DaySelect = date;
            //        dto.TimeStart = Peridod.TimeStart;
            //        dto.TimeStart = PeriodEvent
            //        dto.PE_ID = Period.ID
            //    }
            //}
            //void UpdateDTO(dto, conn)

                
            //int result = cmd.ExcuteScalar();

            //if(result == 0) return;

            //dto
            //    dto.TimeStart = "asdasd"
            //    dto.TimeEnd = "asdasdas"

            //UPDATE timeevent
            //SET

            //    TimeStart = dto.TimeStart;
            //    TimeEnd = dto.TimeEnd;
            //    DaySelect = dto.
            //    Note = dto.
            //WHERE TE_ID = dto.ID;


            Console.ReadKey();
        }
    }
}
