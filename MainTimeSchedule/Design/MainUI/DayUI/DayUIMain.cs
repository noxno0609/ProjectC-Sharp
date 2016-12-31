using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DayUI.Ingredient;
using WindowsFormsApplication1.Design.WeekUI;
using SQLTS;
using CommonTimeSchedule;
using MainTimeSchedule.Utils;
using System.Collections;

namespace WindowsFormsApplication1.DayUI
{
    public partial class DayUIMain : UserControl
    {
        public TimeEventDTO SelectDTO = new TimeEventDTO();
        private Panel SelectPanel = new Panel();
        Hashtable labelPanelMap = new Hashtable();
        Hashtable labelDTOMap = new Hashtable();
        public DayUITool daytool
        {
            get { return dayUITool; }
        }
        public DayUIMain()
        {
            InitializeComponent();
            setupSche();
            dayUITool.updateRequest += new EventHandler(onUpdateEvent);
        }
        private void onUpdateEvent(Object obj, EventArgs e)
        {
            updateDayUI();
        }
        public void setupSche()
        {
            dayUISche.ScheBone.ColumnStyles.Clear();
            dayUISche.ScheBone.ColumnCount = 720;
            float height = 1F / 720F * 100F;
            for (int i = 0; i < dayUISche.ScheBone.ColumnCount; i++)
            {
                dayUISche.ScheBone.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, height));
            }
            loadDayUI();
            //Panel eventpanel = new Panel();
            //eventpanel.BackColor = Color.Green;
            //eventpanel.Dock = DockStyle.Fill;
            //eventpanel.Margin = new Padding(0);
            //eventpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //dayUISche.ScheBone.Controls.Add(eventpanel, 0, 0);
            //dayUISche.ScheBone.SetColumnSpan(eventpanel, 719);
        }
        public void ClickHoverTimeEvent(Object sender, EventArgs e)
        {
            if (SelectPanel != null)
            {
                SelectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                SelectPanel.BackColor = Color.Brown;
            }
            Label label = (Label)sender;
            Panel panel = (Panel)labelPanelMap[label];
            panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel.BackColor = Color.Red;
            SelectDTO = (TimeEventDTO)labelDTOMap[label];
            SelectPanel = (Panel)panel;
        }
        public void ClickLeaveTimeEvent(Object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Panel panel = (Panel)labelPanelMap[label];
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel.BackColor = Color.Brown;
            SelectDTO = new TimeEventDTO();
        }

        public void displayTimeEvent(TimeEventDTO dto)
        {
            if (dto.DaySelect == dayUITool.daypicked)
            {
                Panel eventpanel = new Panel();
                eventpanel.BackColor = Color.Brown;
                eventpanel.Dock = DockStyle.Fill;
                eventpanel.Margin = new Padding(0);
                eventpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                string content =  @"Ngày: " + dto.DaySelect.Day.ToString("00") + "/" + dto.DaySelect.Month.ToString("00")
                                       + "/" + dto.DaySelect.Year.ToString("0000") + "\n"
                                       + "Bắt đầu: " + dto.TimeStart.TimeOfDay + "\n"
                                       + "Kết thúc: " + dto.TimeEnd.TimeOfDay + "\n"
                                       + "Nội dung: " + dto.Note;

                ToolTip eventpaneltip = new ToolTip();
                eventpaneltip.ShowAlways = true;
                eventpaneltip.SetToolTip(eventpanel, content);

                int colposStart = dto.TimeStart.Hour * 30 + (dto.TimeStart.Minute / 2);
                int colposEnd = dto.TimeEnd.Hour * 30 + (dto.TimeEnd.Minute / 2);
                int colposSpan = colposEnd - colposStart;

                Label labelep = new Label();
                labelep.Dock = DockStyle.Fill;
                labelep.Text = (colposSpan > 32) ? dto.Note : "";
                if (colposSpan > 48)
                {
                    labelep.Text = @"Ngày: " + dto.DaySelect.Day.ToString("00") + "/" + dto.DaySelect.Month.ToString("00")
                        + "/" + dto.DaySelect.Year.ToString("0000") + "\nNội dung: " + dto.Note;
                }
                else if (colposSpan > 56)
                    labelep.Text = content;
                  
                labelep.ForeColor = Color.White;
                labelep.TextAlign = ContentAlignment.MiddleCenter;
                eventpanel.Controls.Add(labelep);
                eventpaneltip.SetToolTip(labelep, content);
          
                labelep.Click += new EventHandler(ClickHoverTimeEvent);
                labelep.LostFocus += new EventHandler(ClickLeaveTimeEvent);

                labelPanelMap.Add(labelep, eventpanel);
                labelDTOMap.Add(labelep, dto);
                //if (dayUISche.ScheBone.ColumnCount > 0)
                //{
                //    Console.Write(dayUISche.ScheBone.ColumnCount);
                //}
                dayUISche.ScheBone.Controls.Add(eventpanel, colposStart, 0);
                dayUISche.ScheBone.SetColumnSpan(eventpanel, colposSpan);
                dayUISche.ScheBone.Refresh();
            }
        }
        public void loadDayUI()
        {
            List<TimeEventDTO> listdto = TimeEventDAO.GetAllDTO(DBUtils.GetDBConnection());
            foreach (TimeEventDTO dto in listdto)
            {
                displayTimeEvent(dto);
            }
        }
        public void updateDayUI()
        {
            dayUISche.ScheBone.Controls.Clear();
            loadDayUI();
        }
    }
}
