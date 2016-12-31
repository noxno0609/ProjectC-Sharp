using MySql.Data.MySqlClient;
using SQLCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTS
{
    public partial class TimeEventDAO
    {
        public static List<TimeEventDTO> GetDTOByPeriodID(int pe_id, MySqlConnection conn)
        {
            conn.Open();

            List<TimeEventDTO> listdto = new List<TimeEventDTO>();
            string sql = "SELECT * FROM TimeEvent WHERE PE_ID = " + pe_id;
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                TimeEventDTO dto = new TimeEventDTO();
                dto.ID = Convert.ToInt32(dr["TE_ID"]);
                dto.TimeStart = SQLFormat.formatTime(Convert.ToString(dr["TimeStart"]));
                dto.TimeEnd = SQLFormat.formatTime(Convert.ToString(dr["TimeEnd"]));
                dto.DaySelect = Convert.ToDateTime(dr["Dayselect"]);
                dto.Note = Convert.ToString(dr["Note"]);
                dto.PE_ID = Convert.ToInt32(dr["PE_ID"]);

                listdto.Add(dto);
            }
            conn.Close();

            return listdto;
        }
    }
}
