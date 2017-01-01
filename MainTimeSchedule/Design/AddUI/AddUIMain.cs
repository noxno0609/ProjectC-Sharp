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
using CommonTimeSchedule;
using SQLCommon;


namespace MainTimeSchedule.Design.AddUI
{
    public partial class AddUIMain : Form
    {
        public bool updateRequest = false;
        TimeEventUI dayform = new TimeEventUI();
        MySqlConnection conn = DBUtils.GetDBConnection();
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
        private bool checkOverlapTE(DateTime timestart, DateTime timeend, DateTime date)
        {
            List<TimeEventDTO> listdto = TimeEventDAO.GetAllDTOByDate(date, conn);
            foreach(TimeEventDTO dto in listdto)
            {
                if (DateTimeUtils.checkTimeOverlap(timestart, timeend, dto.TimeStart, dto.TimeEnd) == true)
                {
                    if (solveOverlap(timestart, timeend, dto) == false) 
                        return false;
                }
            }
            return true;
        }
        private List<TimeEventDTO> checkOverlapPE(DateTime timestart, DateTime timeend, DateTime datestart, DateTime dateend, string dayselect)
        {
            List<TimeEventDTO> denylist = new List<TimeEventDTO>();
            List<DayOfWeek> listDoW = SQLFormat.formatDaySelect(dayselect);
            List<TimeEventDTO> listdto = TimeEventDAO.GetAllDTO(conn);
            foreach (TimeEventDTO dto in listdto)
            {
                if ((dto.DaySelect >= datestart && dto.DaySelect <= dateend) && listDoW.Contains(dto.DaySelect.DayOfWeek))
                {
                    if (DateTimeUtils.checkTimeOverlap(timestart, timeend, dto.TimeStart, dto.TimeEnd) == true)
                    {
                        if (solveOverlap(timestart, timeend, dto) == false)
                            denylist.Add(dto);
                    }
                }
            }
            return denylist;
        }
        private bool solveOverlap(DateTime timestart, DateTime timeend, TimeEventDTO dto)
        {
            if (timestart <= dto.TimeStart && timeend >= dto.TimeEnd)
            {
                string content = "Thời gian của bạn bị trùng lịch! Nếu tiếp tục, mốc cũ sẽ bị xóa, bạn có muốn tiếp tục?" + " (Nội dung: " + dto.Note + ")";
                DialogResult rs = MessageBox.Show(content, "Thêm Sự Kiện", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == System.Windows.Forms.DialogResult.Yes)
                {
                    TimeEventDAO.Delete(dto, conn);
                    return true;
                }
                return false;
            }
            else if(timestart > dto.TimeStart && timeend < dto.TimeEnd)
            {
                string content = "Thời gian của bạn bị trùng lịch! Nếu tiếp tục, mốc cũ sẽ bị chia làm các mốc nhỏ, bạn có muốn tiếp tục?" + " (Nội dung: " + dto.Note + ")";
                DialogResult rs = MessageBox.Show(content, "Thêm Sự Kiện", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == System.Windows.Forms.DialogResult.Yes)
                {
                    TimeEventDTO dtotemp = new TimeEventDTO(dto);

                    dto.TimeEnd = timestart;
                    TimeEventDAO.Update(dto, conn);
                    dtotemp.TimeStart = timeend;
                    TimeEventDAO.Insert(dtotemp, conn);
                    return true;
                }
                return false;
            }
            else if(timestart < dto.TimeStart && (timeend > dto.TimeStart && timeend < dto.TimeEnd))
            {
                string content = "Thời gian của bạn bị trùng lịch! Nếu tiếp tục, mốc cũ sẽ bị cắt thời gian, bạn có muốn tiếp tục?" + " (Nội dung: " + dto.Note + ")";
                DialogResult rs = MessageBox.Show(content, "Thêm Sự Kiện", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == System.Windows.Forms.DialogResult.Yes)
                {
                    dto.TimeStart = timeend;
                    TimeEventDAO.Update(dto, conn);
                }
                else timeend = dto.TimeStart;
                
                return true;
            }
            else if((timestart > dto.TimeStart && timestart < dto.TimeEnd) && timeend > dto.TimeEnd)
            {
                string content = "Thời gian của bạn bị trùng lịch! Nếu tiếp tục, mốc cũ sẽ bị cắt thời gian, bạn có muốn tiếp tục?" + " (Nội dung: " + dto.Note + ")";
                DialogResult rs = MessageBox.Show(content, "Thêm Sự Kiện", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == System.Windows.Forms.DialogResult.Yes)
                {
                    dto.TimeEnd = timestart;
                    TimeEventDAO.Update(dto, conn);
                }
                else timestart = dto.TimeEnd;
                return true;
            }
            return true;
        }
        private void buttonOK_Click_1(object sender, EventArgs e)
        {
            if (radioButtonday.Checked == true)
            {
                DateTime dateselect = dayform.tbPickdate.Value.Date + new TimeSpan(0, 0, 0);

                TimeEventDTO dto = new TimeEventDTO();
                dto.Note = dayform.tbNote.Text;
                dto.DaySelect = dateselect;
                dto.PE_ID = 0;
                dto.TimeStart = DateTime.MinValue + new TimeSpan(Convert.ToInt32(dayform.tbTimestarth.Value), Convert.ToInt32(dayform.tbTimestartm.Value), 0);
                dto.TimeEnd = DateTime.MinValue + new TimeSpan(Convert.ToInt32(dayform.tbTimeendh.Value), Convert.ToInt32(dayform.tbTimeendm.Value), 0);
                Color colortemp = (Color)dayform.cbColor.SelectedItem;
                dto.Color = Convert.ToString(colortemp.R + "," + colortemp.G + "," + colortemp.B);

                if (dto.TimeStart.AddMinutes(4) >= dto.TimeEnd)
                    MessageBox.Show("Giờ bắt đầu phải trước giờ kết thúc và cách ít nhất 5 phút!!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (dayform.tbNote.Text == null)
                    MessageBox.Show("Nội dung sự kiện không được trống!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (checkOverlapTE(dto.TimeStart, dto.TimeEnd, dto.DaySelect) == false)
                        return;
                    
                    if(TimeEventDAO.Insert(dto, conn) >= 1)
                        MessageBox.Show("Thêm sự kiện thành công!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm sự kiện không thành công!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                updateRequest = true;
            }
            else if (radioButtonweek.Checked == true)
            {
                DateTime datestart = weekform.tbDatestart.Value.Date + new TimeSpan(0, 0, 0);
                DateTime dateend = weekform.tbDateend.Value.Date + new TimeSpan(0, 0, 0);

                PeriodEventDTO dtoP = new PeriodEventDTO();
                dtoP.Name = weekform.tbName.Text;
                dtoP.Note = weekform.tbNote.Text;
                dtoP.DateStart = datestart;
                dtoP.DateEnd = dateend;
                dtoP.DaySelect = numberCheck(weekform.cbt2).ToString() + numberCheck(weekform.cbt3).ToString() + numberCheck(weekform.cbt4).ToString() +
                                    numberCheck(weekform.cbt5).ToString() + numberCheck(weekform.cbt6).ToString() + numberCheck(weekform.cbt7).ToString() + numberCheck(weekform.cbtCN).ToString();
                dtoP.TimeStart = DateTime.MinValue + new TimeSpan(Convert.ToInt32(weekform.tbTimestarth.Value), Convert.ToInt32(weekform.tbTimestartm.Value), 0);
                dtoP.TimeEnd = DateTime.MinValue + new TimeSpan(Convert.ToInt32(weekform.tbTimeendh.Value), Convert.ToInt32(weekform.tbTimeendm.Value), 0);
                Color colortemp = (Color)weekform.cbColor.SelectedItem;
                dtoP.Color = Convert.ToString(colortemp.R + "," + colortemp.G + "," + colortemp.B);

                if(dtoP.Name == null)
                    MessageBox.Show("Tên lịch trình không được để trống!!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (dtoP.DateEnd <= dtoP.DateStart)
                    MessageBox.Show("Ngày kết thúc phải là ngày sau ngày bắt đầu!!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (dtoP.DaySelect == "0000000")
                    MessageBox.Show("Chọn ít nhất một ngày trong tuần!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (dtoP.TimeStart.AddMinutes(4) >= dtoP.TimeEnd)
                    MessageBox.Show("Giờ bắt đầu phải trước giờ kết thúc và cách ít nhất 5 phút!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (weekform.tbNote.Text == null)
                    MessageBox.Show("Nội dung sự kiện không được trống!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    List<TimeEventDTO> listdeny = checkOverlapPE(dtoP.TimeStart, dtoP.TimeEnd, dtoP.DateStart, dtoP.DateEnd, dtoP.DaySelect);
                    int insertresult = PeriodEventDAO.Insert(dtoP, conn);
                    if (listdeny.Count == PeriodEventDAO.GetCountAllTEDTOByID(insertresult, conn))
                    {
                        PeriodEventDAO.Delete(dtoP, conn);
                        return;
                    }

                    foreach (TimeEventDTO dtodeny in listdeny)
                    {
                        TimeEventDAO.Delete(dtodeny, conn);
                    }
                    
                    if (insertresult >= 0)
                        MessageBox.Show("Thêm lịch trình thành công!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm lịch trình không thành công!", "Thêm Sự Kiện", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    
                }
                updateRequest = true;
            }
        }
        public static int numberCheck(CheckBox cb)
        {
            if(cb.Checked == true)
                return 1;
            return 0;
        }
        private void AddUIMain_Load(object sender, EventArgs e)
        {
            radioButtonday.Checked = true;
        }
    }
}