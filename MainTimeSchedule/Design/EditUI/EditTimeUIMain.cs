using MainTimeSchedule.Utils;
using SQLTS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSProject.Design.EditEvent
{
    public partial class EditTimeUIMain : Form
    {
        public int updateRequest = 0;
        public TimeEventDTO dto = new TimeEventDTO();
        public Button btDelete
        {
            get { return btdelete; }
            set { btdelete = value; }
        }
        public EditTimeUIMain()
        {
            InitializeComponent();
            loadEdit(this.dto);
        }
        public EditTimeUIMain(TimeEventDTO dto)
        {
            this.dto = dto;
            InitializeComponent();
            loadEdit(this.dto);
        }

        private void loadEdit(TimeEventDTO dto)
        {
            dayeventUI.tbNote.Text = dto.Note;
            dayeventUI.tbPickdate.Value = dto.DaySelect;
            dayeventUI.tbTimestarth.Value = dto.TimeStart.Hour;
            dayeventUI.tbTimestartm.Value = dto.TimeStart.Minute;
            dayeventUI.tbTimeendh.Value = dto.TimeEnd.Hour;
            dayeventUI.tbTimeendm.Value = dto.TimeEnd.Minute;
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            dto.Note = dayeventUI.tbNote.Text;
            dto.DaySelect = dayeventUI.tbPickdate.Value;
            dto.TimeStart = Convert.ToDateTime(dayeventUI.tbTimestarth.Value + ":" + dayeventUI.tbTimestartm.Value + ":00");
            dto.TimeEnd = Convert.ToDateTime(dayeventUI.tbTimeendh.Value + ":" + dayeventUI.tbTimeendm.Value + ":00");
            if (TimeEventDAO.Update(dto, DBUtils.GetDBConnection()) == true)
                MessageBox.Show("Đã sửa mốc sự kiện thành công!", "Sửa mốc sự kiện", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateRequest = 1;
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa mốc sự kiện", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (TimeEventDAO.Delete(dto, DBUtils.GetDBConnection()) == true)
                {
                    MessageBox.Show("Đã xóa mốc sự kiện này thành công!", "Xóa mốc sự kiện", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateRequest = 2;
                }
            }
        }
    }
}
