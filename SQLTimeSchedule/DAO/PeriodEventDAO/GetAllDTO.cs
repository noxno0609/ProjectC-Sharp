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
        public static List<PeriodEventDTO> GetAllDTO(MySqlConnection conn)
        {
            List<PeriodEventDTO> listdto = new List<PeriodEventDTO>();

            conn.Open();
            string sql = "SELECT * FROM PeriodEvent ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PeriodEventDTO dto = new PeriodEventDTO();
                dto.ID = Convert.ToInt32(dr["PE_ID"]);
                dto.DateStart = Convert.ToDateTime(dr["DayStart"]);
                dto.DateEnd = Convert.ToDateTime(dr["DayEnd"]);
                dto.TimeStart = SQLFormat.formatTime(dr["TimeStart"].ToString());
                dto.TimeEnd = SQLFormat.formatTime(dr["TimeEnd"].ToString());
                dto.DaySelect = Convert.ToString(dr["Dayselect"]);
                dto.Note = Convert.ToString(dr["Note"]);
                listdto.Add(dto);
            }
            conn.Close();
            return listdto;
        }
    }

}
