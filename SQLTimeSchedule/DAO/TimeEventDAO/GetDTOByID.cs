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
        public static TimeEventDTO GetDTOByID(int id, MySqlConnection conn)
        {
            TimeEventDTO dto = new TimeEventDTO();
            conn.Open();
            string sql = "SELECT * FROM TimeEvent WHERE TE_ID = " + id;
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow dr = dt.Rows[0];

            dto.ID = Convert.ToInt32(dr["TE_ID"]);
            dto.TimeStart = SQLFormat.formatTime(Convert.ToString(dr["TimeStart"]));
            dto.TimeEnd = SQLFormat.formatTime(Convert.ToString(dr["TimeEnd"]));
            dto.DaySelect = Convert.ToDateTime(dr["Dayselect"]);
            dto.Note = Convert.ToString(dr["Note"]);
            dto.Color = Convert.ToString(dr["Color"]);
            dto.PE_ID = Convert.ToInt32(dr["PE_ID"]);

            conn.Close();

            return dto;
        }
    }
}
