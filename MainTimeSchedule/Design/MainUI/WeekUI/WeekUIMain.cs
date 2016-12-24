using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DayUI;
using SQLTS;
using MainTimeSchedule.Utils;
using CommonTimeSchedule;
using TSProject.Design.WeekUI.Ingredient;

namespace WindowsFormsApplication1.Design.WeekUI
{
    public partial class WeekUIMain : UserControl
    {
        public WeekUITool weektool
        {
            get { return weekUITool; }
        }
        public WeekUIMain()
        {
            InitializeComponent();
            setupSche();
        }
        public void setupSche()
        {
            weekUISche.ScheBone.RowStyles.Clear();
            weekUISche.ScheBone.RowCount = 288;
            //weekUISche.ScheBone.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            //weekUISche.ScheBone.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            float height = weekUISche.Height / 288;
            for (int i = 0; i < weekUISche.ScheBone.RowCount; i++)
            {
                weekUISche.ScheBone.RowStyles.Add(new RowStyle(SizeType.Absolute, height));
            }
            //weekUISche.ScheBone.RowCount += 2;
            //weekUISche.ScheBone.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            //weekUISche.ScheBone.RowStyles.Add(new RowStyle(SizeType.Absolute, 0.0F));
            loadWeekUI();
            //Panel eventpanel = new Panel();
            //eventpanel.BackColor = Color.Green;
            //eventpanel.Dock = DockStyle.Fill;
            //eventpanel.Margin = new Padding(0);
            //eventpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //weekUISche.ScheBone.Controls.Add(eventpanel, 0, 0);
            //weekUISche.ScheBone.SetRowSpan(eventpanel, 287);
        }
        public void displayTimeEvent(TimeEventDTO dto, int columnpos)
        {
            Panel eventpanel = new Panel();
            eventpanel.BackColor = Color.Brown;
            eventpanel.Dock = DockStyle.Fill;
            eventpanel.Margin = new Padding(0);
            eventpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            string content = @"Ngày: " + dto.DaySelect.Day.ToString("00") + "/" + dto.DaySelect.Month.ToString("00")
                + "/" + dto.DaySelect.Year.ToString("0000") + "\n"
                + "Bắt đầu: " + dto.TimeStart.TimeOfDay +"\n"
                + "Kết thúc: " + dto.TimeEnd.TimeOfDay + "\n"
                + "Nội dung: " + dto.Note;
            ToolTip eventpaneltip = new ToolTip();
            eventpaneltip.ShowAlways = true;
            eventpaneltip.SetToolTip(eventpanel, content);

            int rowposStart = dto.TimeStart.Hour * 12 + (dto.TimeStart.Minute/5);
            int rowposEnd = dto.TimeEnd.Hour * 12 + (dto.TimeEnd.Minute/5);
            int rowposSpan = rowposEnd - rowposStart;
            if(rowposSpan > 12)
            {
                Label labelep = new Label();
                labelep.Dock = DockStyle.Fill;
                labelep.Text = dto.Note;
                if (rowposSpan > 24)
                {
                    labelep.Text = "Ngày: " + dto.DaySelect.Day.ToString("00") + "/" + dto.DaySelect.Month.ToString("00")
                + "/" + dto.DaySelect.Year.ToString("0000") + "\nNội dung: " + dto.Note;
                }
                labelep.ForeColor = Color.White;
                labelep.TextAlign = ContentAlignment.MiddleCenter;

                eventpanel.Controls.Add(labelep);
                eventpaneltip.SetToolTip(labelep, content);
            }
            if (weekUISche.ScheBone.RowCount > 0)
            {
                Console.Write(weekUISche.ScheBone.RowCount);
            }
            weekUISche.ScheBone.Controls.Add(eventpanel, columnpos, rowposStart);
            weekUISche.ScheBone.SetRowSpan(eventpanel, rowposSpan);
            weekUISche.ScheBone.Refresh();
        }


        public void loadWeekUI()
        {
            List<TimeEventDTO> listdto = TimeEventDAO.GetAllDTO(DBUtils.GetDBConnection());
            foreach (TimeEventDTO dto in listdto)
            {
                if(dto.DaySelect <= weekUITop.endDoW && dto.DaySelect >= weekUITop.startDoW)
                {
                    displayTimeEvent(dto, FormatUtils.numberDoW(dto.DaySelect.DayOfWeek)-1);
                }
            }
        }
    }
}
