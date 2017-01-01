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
        private Hashtable SelectAlreadyPanel = new Hashtable();
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
            //Color abc = new Color();
            //eventpanel.Dock = DockStyle.Fill;
            //eventpanel.Margin = new Padding(0);
            //eventpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //dayUISche.ScheBone.Controls.Add(eventpanel, 0, 0);
            //dayUISche.ScheBone.SetColumnSpan(eventpanel, 719);
        }
        public void ClickHoverTimeEvent(Object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Panel panel = (Panel)labelPanelMap[label];
            if (SelectAlreadyPanel.Contains(panel))
                return;

            if (SelectPanel != null)
            {
                SelectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                Color coloringre = SelectPanel.BackColor;
                int colorR = (coloringre.R <= 30) ? coloringre.R : coloringre.R - 30;
                int colorG = (coloringre.G <= 30) ? coloringre.G : coloringre.G - 30;
                int colorB = (coloringre.B <= 30) ? coloringre.B : coloringre.B - 30;

                SelectPanel.BackColor = Color.FromArgb(colorR, colorG, colorB);
            }

            Color colorhover = panel.BackColor;
            int colorRhover = (colorhover.R >= 225) ? colorhover.R : colorhover.R + 30;
            int colorGhover = (colorhover.G >= 225) ? colorhover.G : colorhover.G + 30;
            int colorBhover = (colorhover.B >= 225) ? colorhover.B : colorhover.B + 30;

            panel.BackColor = Color.FromArgb(colorRhover, colorGhover, colorBhover);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            SelectDTO = (TimeEventDTO)labelDTOMap[label];
            SelectPanel = (Panel)panel;
            SelectAlreadyPanel.Clear();
            SelectAlreadyPanel[panel] = 1;
        }
        public void ClickLeaveTimeEvent(Object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Panel panel = (Panel)labelPanelMap[label];
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Color coloringre = panel.BackColor;
            int colorR = (coloringre.R >= 225) ? coloringre.R : coloringre.R + 30;
            int colorG = (coloringre.G >= 225) ? coloringre.G : coloringre.G + 30;
            int colorB = (coloringre.B >= 225) ? coloringre.B : coloringre.B + 30;
            panel.BackColor = Color.FromArgb(colorR, colorG, colorB);

            SelectDTO = new TimeEventDTO();
        }

        public void displayTimeEvent(TimeEventDTO dto)
        {
            if (dto.DaySelect == dayUITool.daypicked)
            {
                Panel eventpanel = new Panel();
                string[] coloringre = dto.Color.Split(',');
                eventpanel.BackColor = Color.FromArgb(Convert.ToInt32(coloringre[0]), Convert.ToInt32(coloringre[1]), Convert.ToInt32(coloringre[2]));
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
