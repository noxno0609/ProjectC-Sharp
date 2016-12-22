using SQLTS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSProject.Design.EditEvent.Ingredient;
using MySql.Data.MySqlClient;
using MainTimeSchedule.Utils;

namespace MainTimeSchedule.Design.AddUI
{
    public partial class AddUIMain : Form
    {
        TimeEventUI dayform = new TimeEventUI();
        MySqlConnection conn =DBUtils.GetDBConnection();
        PeriodEventUI weekform = new PeriodEventUI();
        public AddUIMain()
        {
            InitializeComponent();
        
            
        }

        public void showControl(System.Windows.Forms.Control obj)
        {
            panelcontrol.Controls.Clear();
            obj.Dock = DockStyle.Fill;
            panelcontrol.Controls.Add(obj);
        }

        public void radioButtonday_CheckedChanged(object sender, EventArgs e)
        {
            showControl(dayform);
        }

        private void radioButtonweek_CheckedChanged(object sender, EventArgs e)
        {
            
            showControl(weekform);
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click_1(object sender, EventArgs e)
        {
            if (radioButtonday.Checked == true)
            {
                TimeEventDTO dto = new TimeEventDTO();
                dto.Note = dayform.note;
                dto.DaySelect = dayform.getday;
                dto.PE_ID = 0;
                string start = dayform.hourstart + ":" + dayform.Minstart + ":00";
                var result = Convert.ToDateTime(start);
                string end = dayform.hourend + ":" + dayform.minrend + ":00";
                var result1 = Convert.ToDateTime(end);
                dto.TimeStart = result;
                dto.TimeEnd = result1;

                if (dto.TimeStart.AddMinutes(4) >= dto.TimeEnd)
                {
                        MessageBox.Show("Sự kiện phải ít nhất 5 phút!");
                }
                else
                {
                    if (String.IsNullOrEmpty(dayform.note))
                        MessageBox.Show("Nội dung sự kiện không được trống!");
                    else
                    { 
                        TimeEventDAO.Insert(dto, conn);
                        MessageBox.Show("Thêm thành công!");
                    }
                }
            }
            else
                MessageBox.Show("Chọn kiểu thêm sự kiện!");
        }

        private void AddUIMain_Load(object sender, EventArgs e)
        {
            radioButtonday.Checked = true;
        }
    }
}