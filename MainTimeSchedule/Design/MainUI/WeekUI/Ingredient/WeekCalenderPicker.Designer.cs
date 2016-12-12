namespace MainTimeSchedule
{
    partial class WeekCalenderPicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.monthCalendar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.monthCalendar.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.TitleBackColor = System.Drawing.SystemColors.GrayText;
            this.monthCalendar.TrailingForeColor = System.Drawing.SystemColors.ControlLight;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.WeekCalenderPicker_DateChanged);
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.WeekCalenderPicker_DateSelected);
            // 
            // WeekCalenderPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 157);
            this.Controls.Add(this.monthCalendar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeekCalenderPicker";
            this.Text = "Chọn Tuần";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
    }
}