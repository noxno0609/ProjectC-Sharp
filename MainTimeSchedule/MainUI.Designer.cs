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
            this.addicon = new System.Windows.Forms.ToolStripButton();
            this.editicon = new System.Windows.Forms.ToolStripButton();
            this.menumain = new System.Windows.Forms.MenuStrip();
            this.filemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.filemenuexit = new System.Windows.Forms.ToolStripMenuItem();
            this.editmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentbone = new System.Windows.Forms.TableLayoutPanel();
            this.weekUIMain = new WindowsFormsApplication1.Design.WeekUI.WeekUIMain();
            this.toolBarMain = new MainTimeSchedule.Design.ToolBarUI.ToolBarMain();
            this.menuicon.SuspendLayout();
            this.menumain.SuspendLayout();
            this.contentbone.SuspendLayout();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(0, 590);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(984, 22);
            this.footer.TabIndex = 0;
            this.footer.Text = "statusStrip1";
            // 
            // menuicon
            // 
            this.menuicon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuicon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addicon,
            this.editicon});
            this.menuicon.Location = new System.Drawing.Point(0, 24);
            this.menuicon.Name = "menuicon";
            this.menuicon.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuicon.Size = new System.Drawing.Size(984, 27);
            this.menuicon.TabIndex = 1;
            this.menuicon.Text = "toolStrip1";
            // 
            // addicon
            // 
            this.addicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addicon.Image = global::MainTimeSchedule.Properties.Resources.addbutton;
            this.addicon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addicon.Name = "addicon";
            this.addicon.Size = new System.Drawing.Size(24, 24);
            this.addicon.Text = "Thêm mốc/lịch";
            this.addicon.Click += new System.EventHandler(this.addicon_Click);
            // 
            // editicon
            // 
            this.editicon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editicon.Image = global::MainTimeSchedule.Properties.Resources.editbutton;
            this.editicon.ImageTransparentColor = System.Drawing.Color.White;
            this.editicon.Name = "editicon";
            this.editicon.Size = new System.Drawing.Size(24, 24);
            this.editicon.Text = "Chỉnh mốc";
            // 
            // menumain
            // 
            this.menumain.GripMargin = new System.Windows.Forms.Padding(0);
            this.menumain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filemenu,
            this.editmenu,
            this.helpmenu});
            this.menumain.Location = new System.Drawing.Point(0, 0);
            this.menumain.Name = "menumain";
            this.menumain.Padding = new System.Windows.Forms.Padding(0);
            this.menumain.Size = new System.Drawing.Size(984, 24);
            this.menumain.TabIndex = 2;
            this.menumain.Text = "ToolMenu";
            // 
            // filemenu
            // 
            this.filemenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filemenuexit});
            this.filemenu.Name = "filemenu";
            this.filemenu.Size = new System.Drawing.Size(56, 24);
            this.filemenu.Text = "Tập tin";
            // 
            // filemenuexit
            // 
            this.filemenuexit.Name = "filemenuexit";
            this.filemenuexit.Size = new System.Drawing.Size(105, 22);
            this.filemenuexit.Text = "Thoát";
            this.filemenuexit.Click += new System.EventHandler(this.filemenuexit_Click);
            // 
            // editmenu
            // 
            this.editmenu.Name = "editmenu";
            this.editmenu.Size = new System.Drawing.Size(72, 24);
            this.editmenu.Text = "Chỉnh sửa";
            // 
            // helpmenu
            // 
            this.helpmenu.Name = "helpmenu";
            this.helpmenu.Size = new System.Drawing.Size(64, 24);
            this.helpmenu.Text = "Trợ giúp";
            // 
            // contentbone
            // 
            this.contentbone.ColumnCount = 2;
            this.contentbone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.contentbone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.contentbone.Controls.Add(this.weekUIMain, 1, 0);
            this.contentbone.Controls.Add(this.toolBarMain, 0, 0);
            this.contentbone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentbone.Location = new System.Drawing.Point(0, 51);
            this.contentbone.Margin = new System.Windows.Forms.Padding(0);
            this.contentbone.Name = "contentbone";
            this.contentbone.RowCount = 1;
            this.contentbone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentbone.Size = new System.Drawing.Size(984, 539);
            this.contentbone.TabIndex = 3;
            // 
            // weekUIMain
            // 
            this.weekUIMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekUIMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekUIMain.Location = new System.Drawing.Point(137, 0);
            this.weekUIMain.Margin = new System.Windows.Forms.Padding(0);
            this.weekUIMain.Name = "weekUIMain";
            this.weekUIMain.Size = new System.Drawing.Size(847, 539);
            this.weekUIMain.TabIndex = 0;
            // 
            // toolBarMain
            // 
            this.toolBarMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolBarMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolBarMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBarMain.Location = new System.Drawing.Point(0, 0);
            this.toolBarMain.Margin = new System.Windows.Forms.Padding(0);
            this.toolBarMain.Name = "toolBarMain";
            this.toolBarMain.Size = new System.Drawing.Size(137, 539);
            this.toolBarMain.TabIndex = 1;
            this.toolBarMain.Load += new System.EventHandler(this.toolBarMain_Load);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.Controls.Add(this.contentbone);
            this.Controls.Add(this.menuicon);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.menumain);
            this.MainMenuStrip = this.menumain;
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "MainUI";
            this.Text = "Time Schedule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUI_FormClosing);
            this.menuicon.ResumeLayout(false);
            this.menuicon.PerformLayout();
            this.menumain.ResumeLayout(false);
            this.menumain.PerformLayout();
            this.contentbone.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip footer;
        private System.Windows.Forms.ToolStrip menuicon;
        private System.Windows.Forms.ToolStripButton addicon;
        private System.Windows.Forms.ToolStripButton editicon;
        private System.Windows.Forms.MenuStrip menumain;
        private System.Windows.Forms.ToolStripMenuItem filemenu;
        private System.Windows.Forms.ToolStripMenuItem filemenuexit;
        private System.Windows.Forms.ToolStripMenuItem editmenu;
        private System.Windows.Forms.ToolStripMenuItem helpmenu;
        private System.Windows.Forms.TableLayoutPanel contentbone;
        private WindowsFormsApplication1.Design.WeekUI.WeekUIMain weekUIMain;
        private Design.ToolBarUI.ToolBarMain toolBarMain;
    }
}

