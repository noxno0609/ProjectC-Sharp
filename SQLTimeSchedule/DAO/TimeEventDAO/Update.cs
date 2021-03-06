﻿
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLCommon;

namespace SQLTS
{
    public partial class TimeEventDAO
    {
        public static bool Update(TimeEventDTO dto, MySqlConnection conn)
        {
            conn.Open();
            string sql = String.Format(@"UPDATE timeevent 
                SET PE_ID = {0}, Note = '{1}', TimeStart = '{2}', TimeEnd = '{3}', DaySelect = '{4}', Color = '{5}'
                WHERE TE_ID = '{6}'",
            dto.PE_ID,
            dto.Note,
            SQLFormat.addDateTime(dto.TimeStart),
            SQLFormat.addDateTime(dto.TimeEnd),
            SQLFormat.addDateTime(dto.DaySelect),
            dto.Color,
            dto.ID);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int kqua = cmd.ExecuteNonQuery();
            conn.Close();

            if (kqua != 0)
                return true;
            
            return false;
        }
    }
}

