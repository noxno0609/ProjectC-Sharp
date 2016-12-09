namespace WindowsFormsApplication1.DayUI
{
    partial class DayUIMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelDayUI = new System.Windows.Forms.TableLayoutPanel();
            this.dayUISche = new WindowsFormsApplication1.DayUISche();
            this.dayUITool = new WindowsFormsApplication1.DayUI.Ingredient.DayUITool();
            this.tableLayoutPanelDayUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelDayUI
            // 
            this.tableLayoutPanelDayUI.ColumnCount = 2;
            this.tableLayoutPanelDayUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelDayUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelDayUI.Controls.Add(this.dayUISche, 1, 0);
            this.tableLayoutPanelDayUI.Controls.Add(this.dayUITool, 0, 0);
            this.tableLayoutPanelDayUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDayUI.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDayUI.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelDayUI.Name = "tableLayoutPanelDayUI";
            this.tableLayoutPanelDayUI.RowCount = 1;
            this.tableLayoutPanelDayUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDayUI.Size = new System.Drawing.Size(550, 276);
            this.tableLayoutPanelDayUI.TabIndex = 1;
            // 
            // dayUISche
            // 
            this.dayUISche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayUISche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayUISche.Location = new System.Drawing.Point(55, 0);
            this.dayUISche.Margin = new System.Windows.Forms.Padding(0);
            this.dayUISche.Name = "dayUISche";
            this.dayUISche.Size = new System.Drawing.Size(495, 276);
            this.dayUISche.TabIndex = 1;
            // 
            // dayUITool
            // 
            this.dayUITool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayUITool.Location = new System.Drawing.Point(0, 0);
            this.dayUITool.Margin = new System.Windows.Forms.Padding(0);
            this.dayUITool.Name = "dayUITool";
            this.dayUITool.Size = new System.Drawing.Size(55, 276);
            this.dayUITool.TabIndex = 2;
            // 
            // DayUIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanelDayUI);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DayUIMain";
            this.Size = new System.Drawing.Size(550, 276);
            this.tableLayoutPanelDayUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDayUI;
        private DayUISche dayUISche;
        private Ingredient.DayUITool dayUITool;
    }
}
