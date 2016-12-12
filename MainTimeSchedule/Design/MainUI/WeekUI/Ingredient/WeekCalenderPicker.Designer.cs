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
            this.labelNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Top;
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
            // labelNote
            // 
            this.labelNote.BackColor = System.Drawing.Color.White;
            this.labelNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(0, 162);
            this.labelNote.Margin = new System.Windows.Forms.Padding(0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(227, 26);
            this.labelNote.TabIndex = 2;
            this.labelNote.Text = "Ấn \'Enter\' để chọn tuần";
            this.labelNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeekCalenderPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 188);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.monthCalendar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeekCalenderPicker";
            this.Text = "Chọn Tuần";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label labelNote;
    }
}