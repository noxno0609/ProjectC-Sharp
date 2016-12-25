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
                dto.TimeStart = Convert.ToDateTime(dayform.hourstart + ":" + dayform.Minstart + ":00");
                dto.TimeEnd = Convert.ToDateTime(dayform.hourend + ":" + dayform.minrend + ":00");

                if (dto.TimeStart.AddMinutes(4) >= dto.TimeEnd)
                    MessageBox.Show("Giờ bắt đầu phải trước giờ kết thúc và cách ít nhất 5 phút!!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if ("".Equals(dayform.note))
                    MessageBox.Show("Nội dung sự kiện không được trống!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if(TimeEventDAO.Insert(dto, conn) >= 1)
                        MessageBox.Show("Thêm sự kiện thành công!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm sự kiện không thành công!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (radioButtonweek.Checked == true)
            {
                PeriodEventDTO dtoP = new PeriodEventDTO();
                dtoP.Note = weekform.note;
                dtoP.DateStart = weekform.getdayStart;
                dtoP.DateEnd = weekform.getdayEnd;
                dtoP.DaySelect = weekform.thu2 + weekform.thu3 + weekform.thu4 + weekform.thu5 + weekform.thu6 + weekform.thu7 + weekform.CN;
                dtoP.TimeStart = Convert.ToDateTime(weekform.hourstart + ":" + weekform.Minstart + ":00");
                dtoP.TimeEnd = Convert.ToDateTime(weekform.hourend + ":" + weekform.minrend + ":00");

                if (dtoP.DateEnd <= dtoP.DateStart)
                    MessageBox.Show("Ngày kết thúc phải là ngày sau ngày bắt đầu!!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (dtoP.DaySelect == "0000000")
                    MessageBox.Show("Chọn ít nhất một ngày trong tuần!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (dtoP.TimeStart.AddMinutes(4) >= dtoP.TimeEnd)
                    MessageBox.Show("Giờ bắt đầu phải trước giờ kết thúc và cách ít nhất 5 phút!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if ("".Equals(weekform.note))
                    MessageBox.Show("Nội dung sự kiện không được trống!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (PeriodEventDAO.Insert(dtoP, conn) >= 0)
                        MessageBox.Show("Thêm lịch trình thành công!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm lịch trình không thành công!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void AddUIMain_Load(object sender, EventArgs e)
        {
            radioButtonday.Checked = true;
        }
    }
}