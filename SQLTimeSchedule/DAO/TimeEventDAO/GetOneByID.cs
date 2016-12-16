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
    public partial class TimeEventDAO 
    {
        public static TimeEventDTO GetOneByID(int id, MySqlConnection conn)
        {
            TimeEventDTO dto = new TimeEventDTO();
            conn.Open();
            string sql = "SELECT * FROM TimeEvent WHERE PE_ID = " + id;
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow dr = dt.Rows[0];
            dto.PE_ID = Convert.ToInt32(dr["PE_ID"]);
            dto.TimeStart = SQLFormat.formatTime(dr["TimeStart"].ToString());
            dto.TimeEnd = SQLFormat.formatTime(dr["TimeEnd"].ToString());
            dto.DaySelect = SQLFormat.formatTime(dr["Dayselect"].ToString());
            dto.Note = Convert.ToString(dr["Note"]);

            conn.Close();
            return dto;
        }
    }
}
