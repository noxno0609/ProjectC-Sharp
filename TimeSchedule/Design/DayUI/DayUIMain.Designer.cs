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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dayUISche1 = new WindowsFormsApplication1.DayUISche();
            this.dayUITool2 = new WindowsFormsApplication1.DayUI.Ingredient.DayUITool();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Controls.Add(this.dayUISche1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dayUITool2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(635, 391);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dayUISche1
            // 
            this.dayUISche1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayUISche1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayUISche1.Location = new System.Drawing.Point(63, 0);
            this.dayUISche1.Margin = new System.Windows.Forms.Padding(0);
            this.dayUISche1.Name = "dayUISche1";
            this.dayUISche1.Size = new System.Drawing.Size(572, 391);
            this.dayUISche1.TabIndex = 1;
            // 
            // dayUITool2
            // 
            this.dayUITool2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayUITool2.Location = new System.Drawing.Point(0, 0);
            this.dayUITool2.Margin = new System.Windows.Forms.Padding(0);
            this.dayUITool2.Name = "dayUITool2";
            this.dayUITool2.Size = new System.Drawing.Size(63, 391);
            this.dayUITool2.TabIndex = 2;
            // 
            // DayUIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DayUIMain";
            this.Size = new System.Drawing.Size(635, 391);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Ingredient.DayUITool dayUITool1;
        private DayUISche dayUISche1;
        private Ingredient.DayUITool dayUITool2;
    }
}
