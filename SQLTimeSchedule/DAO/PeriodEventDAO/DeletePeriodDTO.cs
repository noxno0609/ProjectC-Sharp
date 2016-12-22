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
        public static bool DeleteDTO(PeriodEventDTO dto, MySqlConnection conn)
        {
            conn.Open();
            TimeEventDTO dto1 = new TimeEventDTO();
            dto1.PE_ID = dto.ID;
            time.Delete(dto1.PE_ID, dto1, conn);
            string sql1 = "DELETE FROM periodevent WHERE PE_ID = " + dto.ID;

            MySqlCommand cmd = new MySqlCommand(sql1, conn);

            int kqua = cmd.ExecuteNonQuery();
            conn.Close();

            if (kqua != 0)
                return true;

            return false;
        }
    }
}
