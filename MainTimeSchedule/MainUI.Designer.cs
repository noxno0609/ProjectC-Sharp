namespace MainTimeSchedule
{
    partial class MainUI
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
            this.footer = new System.Windows.Forms.StatusStrip();
            this.menuicon = new System.Windows.Forms.ToolStrip();
            this.iconadd = new System.Windows.Forms.ToolStripButton();
            this.iconedit = new System.Windows.Forms.ToolStripButton();
            this.menumain = new System.Windows.Forms.MenuStrip();
            this.menufile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menufileexit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuedit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuhelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuhelpcopyright = new System.Windows.Forms.ToolStripMenuItem();
            this.bonecontent = new System.Windows.Forms.TableLayoutPanel();
            this.weekUIMain = new WindowsFormsApplication1.Design.WeekUI.WeekUIMain();
            this.dayUIMain = new WindowsFormsApplication1.DayUI.DayUIMain();
            this.toolBarMain = new MainTimeSchedule.Design.ToolBarUI.ToolBarMain();
            this.menuicon.SuspendLayout();
            this.menumain.SuspendLayout();
            this.bonecontent.SuspendLayout();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(0, 421);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(984, 22);
            this.footer.TabIndex = 0;
            this.footer.Text = "statusStrip1";
            // 
            // menuicon
            // 
            this.menuicon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuicon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconadd,
            this.iconedit});
            this.menuicon.Location = new System.Drawing.Point(0, 24);
            this.menuicon.Name = "menuicon";
            this.menuicon.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuicon.Size = new System.Drawing.Size(984, 27);
            this.menuicon.TabIndex = 1;
            this.menuicon.Text = "toolStrip1";
            // 
            // iconadd
            // 
            this.iconadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iconadd.Image = global::MainTimeSchedule.Properties.Resources.addbutton;
            this.iconadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconadd.Name = "iconadd";
            this.iconadd.Size = new System.Drawing.Size(24, 24);
            this.iconadd.Text = "Thêm mốc/lịch";
            this.iconadd.Click += new System.EventHandler(this.addicon_Click);
            // 
            // iconedit
            // 
            this.iconedit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iconedit.Image = global::MainTimeSchedule.Properties.Resources.editbutton;
            this.iconedit.ImageTransparentColor = System.Drawing.Color.White;
            this.iconedit.Name = "iconedit";
            this.iconedit.Size = new System.Drawing.Size(24, 24);
            this.iconedit.Text = "Chỉnh mốc";
            // 
            // menumain
            // 
            this.menumain.GripMargin = new System.Windows.Forms.Padding(0);
            this.menumain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menufile,
            this.menuedit,
            this.menuhelp});
            this.menumain.Location = new System.Drawing.Point(0, 0);
            this.menumain.Name = "menumain";
            this.menumain.Padding = new System.Windows.Forms.Padding(0);
            this.menumain.Size = new System.Drawing.Size(984, 24);
            this.menumain.TabIndex = 2;
            this.menumain.Text = "ToolMenu";
            // 
            // menufile
            // 
            this.menufile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.menufileexit});
            this.menufile.Name = "menufile";
            this.menufile.Size = new System.Drawing.Size(56, 24);
            this.menufile.Text = "Tập tin";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(102, 6);
            // 
            // menufileexit
            // 
            this.menufileexit.Name = "menufileexit";
            this.menufileexit.Size = new System.Drawing.Size(105, 22);
            this.menufileexit.Text = "Thoát";
            this.menufileexit.Click += new System.EventHandler(this.filemenuexit_Click);
            // 
            // menuedit
            // 
            this.menuedit.Name = "menuedit";
            this.menuedit.Size = new System.Drawing.Size(72, 24);
            this.menuedit.Text = "Chỉnh sửa";
            // 
            // menuhelp
            // 
            this.menuhelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.menuhelpcopyright});
            this.menuhelp.Name = "menuhelp";
            this.menuhelp.Size = new System.Drawing.Size(64, 24);
            this.menuhelp.Text = "Trợ giúp";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // menuhelpcopyright
            // 
            this.menuhelpcopyright.Name = "menuhelpcopyright";
            this.menuhelpcopyright.Size = new System.Drawing.Size(127, 22);
            this.menuhelpcopyright.Text = "Sản phẩm";
            this.menuhelpcopyright.Click += new System.EventHandler(this.menuhelpcopyright_Click);
            // 
            // bonecontent
            // 
            this.bonecontent.ColumnCount = 2;
            this.bonecontent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.bonecontent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.bonecontent.Controls.Add(this.weekUIMain, 1, 0);
            this.bonecontent.Controls.Add(this.dayUIMain, 1, 0);
            this.bonecontent.Controls.Add(this.toolBarMain, 0, 0);
            this.bonecontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bonecontent.Location = new System.Drawing.Point(0, 51);
            this.bonecontent.Margin = new System.Windows.Forms.Padding(0);
            this.bonecontent.Name = "bonecontent";
            this.bonecontent.RowCount = 1;
            this.bonecontent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bonecontent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.bonecontent.Size = new System.Drawing.Size(984, 370);
            this.bonecontent.TabIndex = 3;
            // 
            // weekUIMain
            // 
            this.weekUIMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekUIMain.Location = new System.Drawing.Point(137, 0);
            this.weekUIMain.Margin = new System.Windows.Forms.Padding(0);
            this.weekUIMain.Name = "weekUIMain";
            this.weekUIMain.Size = new System.Drawing.Size(847, 350);
            this.weekUIMain.TabIndex = 0;
            // 
            // dayUIMain
            // 
            this.dayUIMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayUIMain.Location = new System.Drawing.Point(0, 350);
            this.dayUIMain.Margin = new System.Windows.Forms.Padding(0);
            this.dayUIMain.Name = "dayUIMain";
            this.dayUIMain.Size = new System.Drawing.Size(137, 20);
            this.dayUIMain.TabIndex = 0;
            // 
            // toolBarMain
            // 
            this.toolBarMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolBarMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolBarMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBarMain.Location = new System.Drawing.Point(0, 0);
            this.toolBarMain.Margin = new System.Windows.Forms.Padding(0);
            this.toolBarMain.Name = "toolBarMain";
            this.toolBarMain.Size = new System.Drawing.Size(137, 350);
            this.toolBarMain.TabIndex = 1;
            this.toolBarMain.Load += new System.EventHandler(this.toolBarMain_Load);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 443);
            this.Controls.Add(this.bonecontent);
            this.Controls.Add(this.menuicon);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.menumain);
            this.MainMenuStrip = this.menumain;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 481);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(16, 481);
            this.Name = "MainUI";
            this.Text = "Time Schedule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUI_FormClosing);
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.menuicon.ResumeLayout(false);
            this.menuicon.PerformLayout();
            this.menumain.ResumeLayout(false);
            this.menumain.PerformLayout();
            this.bonecontent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip footer;
        private System.Windows.Forms.ToolStrip menuicon;
        private System.Windows.Forms.ToolStripButton iconadd;
        private System.Windows.Forms.ToolStripButton iconedit;
        private System.Windows.Forms.MenuStrip menumain;
        private System.Windows.Forms.ToolStripMenuItem menufile;
        private System.Windows.Forms.ToolStripMenuItem menufileexit;
        private System.Windows.Forms.ToolStripMenuItem menuedit;
        private System.Windows.Forms.ToolStripMenuItem menuhelp;
        private System.Windows.Forms.TableLayoutPanel bonecontent;
        private WindowsFormsApplication1.Design.WeekUI.WeekUIMain weekUIMain;
        private WindowsFormsApplication1.DayUI.DayUIMain dayUIMain;
        private Design.ToolBarUI.ToolBarMain toolBarMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuhelpcopyright;
    }
}

