﻿using System;
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
using WindowsFormsApplication1.Design.WeekUI.Ingredient;
using System.Collections;

namespace WindowsFormsApplication1.Design.WeekUI
{
    public partial class WeekUIMain : UserControl
    {
        public TimeEventDTO SelectDTO = new TimeEventDTO();
        private Panel SelectPanel = new Panel();
        private Hashtable SelectAlreadyPanel = new Hashtable();
        Hashtable labelPanelMap = new Hashtable();
        Hashtable labelDTOMap = new Hashtable();
        public WeekUITool weekuitool
        {
            get { return weekUITool; }
        }
        public WeekUISche weekuische
        {
            get { return weekUISche; }
        }
        public WeekUIMain()
        {
            InitializeComponent();
            setupSche();
            weekUITop.updateRequest += new EventHandler(onUpdateEvent);
        }
        private void onUpdateEvent(Object obj, EventArgs e)
        {
            updateWeekUI();
        }
        public void setupSche()
        {
            weekUISche.ScheBone.RowStyles.Clear();
            weekUISche.ScheBone.RowCount = 288;
            //float height = weekUISche.Height / 288F * 100;
            float height = 1F / 288F * 100F;
            for (int i = 0; i < weekUISche.ScheBone.RowCount; i++)
            {
                weekUISche.ScheBone.RowStyles.Add(new RowStyle(SizeType.Percent, height));
            }
            loadWeekUI();
            //Panel eventpanel = new Panel();
            //eventpanel.BackColor = Color.Green;
            //eventpanel.Dock = DockStyle.Fill;
            //eventpanel.Margin = new Padding(0);
            //eventpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //weekUISche.ScheBone.Controls.Add(eventpanel, 0, 0);
            //weekUISche.ScheBone.SetRowSpan(eventpanel, 287);
        }
        public void ClickHoverTimeEvent(Object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Panel panel = (Panel)labelPanelMap[label];
            if (SelectAlreadyPanel.Contains(panel))
                return;

            if(SelectPanel != null)
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
            int colorR = (coloringre.R <= 30) ? coloringre.R : coloringre.R - 30;
            int colorG = (coloringre.G <= 30) ? coloringre.G : coloringre.G - 30;
            int colorB = (coloringre.B <= 30) ? coloringre.B : coloringre.B - 30;

            panel.BackColor = Color.FromArgb(colorR, colorG, colorB);

            SelectDTO = new TimeEventDTO();
        }
        public void displayTimeEvent(TimeEventDTO dto, int columnpos)
        {
            if (dto.DaySelect <= weekUITop.endDoW && dto.DaySelect >= weekUITop.startDoW)
            {
                Panel eventpanel = new Panel();
                string[] coloringre = dto.Color.Split(',');
                eventpanel.BackColor = Color.FromArgb(Convert.ToInt32(coloringre[0]), Convert.ToInt32(coloringre[1]), Convert.ToInt32(coloringre[2]));
                eventpanel.Dock = DockStyle.Fill;
                eventpanel.Margin = new Padding(0);
                eventpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                string content = @"Ngày: " + dto.DaySelect.Day.ToString("00") + "/" + dto.DaySelect.Month.ToString("00")
                                    + "/" + dto.DaySelect.Year.ToString("0000") + "\n"
                                    + "Bắt đầu: " + dto.TimeStart.TimeOfDay + "\n"
                                    + "Kết thúc: " + dto.TimeEnd.TimeOfDay + "\n"
                                    + "Nội dung: " + dto.Note;
                ToolTip eventpaneltip = new ToolTip();
                eventpaneltip.ShowAlways = true;
                eventpaneltip.SetToolTip(eventpanel, content);

                int rowposStart = dto.TimeStart.Hour * 12 + (dto.TimeStart.Minute / 5);
                int rowposEnd = dto.TimeEnd.Hour * 12 + (dto.TimeEnd.Minute / 5);
                int rowposSpan = rowposEnd - rowposStart;
                Label labelep = new Label();
                labelep.Dock = DockStyle.Fill;
                labelep.Text = (rowposSpan > 12) ? dto.Note : "";
                if (rowposSpan > 24)
                {
                    labelep.Text = @"Ngày: " + dto.DaySelect.Day.ToString("00") + "/" + dto.DaySelect.Month.ToString("00")
                        + "/" + dto.DaySelect.Year.ToString("0000") + "\nNội dung: " + dto.Note;
                }
                else if(rowposSpan >32)
                    labelep.Text = content;

                labelep.ForeColor = Color.White;
                labelep.TextAlign = ContentAlignment.MiddleCenter;

                labelep.Click += new EventHandler(ClickHoverTimeEvent);
                labelep.LostFocus += new EventHandler(ClickLeaveTimeEvent);

                labelPanelMap.Add(labelep, eventpanel);
                labelDTOMap.Add(labelep, dto);

                eventpanel.Controls.Add(labelep);
                eventpaneltip.SetToolTip(labelep, content);
                //if (weekUISche.ScheBone.RowCount > 0)
                //{
                //    Console.Write(weekUISche.ScheBone.RowCount);
                //}
                weekUISche.ScheBone.Controls.Add(eventpanel, columnpos, rowposStart);
                weekUISche.ScheBone.SetRowSpan(eventpanel, rowposSpan);
                weekUISche.ScheBone.Refresh();
            }
        }
        public void loadWeekUI()
        {
            List<TimeEventDTO> listdto = TimeEventDAO.GetAllDTO(DBUtils.GetDBConnection());
            foreach (TimeEventDTO dto in listdto)
            {
                displayTimeEvent(dto, FormatUtils.numberDoW(dto.DaySelect.DayOfWeek) - 1);
            }
        }
        public void updateWeekUI()
        {
            weekUISche.ScheBone.Controls.Clear();
            loadWeekUI();
        }
    }
}
