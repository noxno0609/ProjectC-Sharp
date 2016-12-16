﻿using MySql.Data.MySqlClient;
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
        public static PeriodEventDTO GetOneByID(int id, MySqlConnection conn)
        {   
            PeriodEventDTO dto = new PeriodEventDTO();
            conn.Open();
            string sql = "SELECT * FROM PeriodEvent WHERE PE_ID = " + id;
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            DataRow dr = dt.Rows[0];
            dto.PE_ID = Convert.ToInt32(dr["PE_ID"]);
            dto.DateStart = Convert.ToDateTime(dr["DayStart"]);
            dto.DateEnd = Convert.ToDateTime(dr["DayEnd"]);
            dto.TimeStart = SQLFormat.formatTime(dr["TimeStart"].ToString());
            dto.TimeEnd = SQLFormat.formatTime(dr["TimeEnd"].ToString());
            dto.DaySelect = Convert.ToString(dr["Dayselect"]);
            dto.Note = Convert.ToString(dr["Note"]);

            conn.Close();
            return dto;
        }
    }
}