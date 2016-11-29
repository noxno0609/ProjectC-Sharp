namespace WindowsFormsApplication1.Design.WeekUI
{
    partial class WeekUIMain
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
            this.weekUISche1 = new WindowsFormsApplication1.Design.WeekUI.Ingredient.WeekUISche();
            this.weekUIToolBar1 = new WindowsFormsApplication1.Design.WeekUI.Ingredient.WeekUIToolBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.weekUISche1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.weekUIToolBar1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 336);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // weekUISche1
            // 
            this.weekUISche1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekUISche1.Location = new System.Drawing.Point(0, 67);
            this.weekUISche1.Margin = new System.Windows.Forms.Padding(0);
            this.weekUISche1.Name = "weekUISche1";
            this.weekUISche1.Size = new System.Drawing.Size(498, 269);
            this.weekUISche1.TabIndex = 0;
            // 
            // weekUIToolBar1
            // 
            this.weekUIToolBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekUIToolBar1.Location = new System.Drawing.Point(0, 0);
            this.weekUIToolBar1.Margin = new System.Windows.Forms.Padding(0);
            this.weekUIToolBar1.Name = "weekUIToolBar1";
            this.weekUIToolBar1.Size = new System.Drawing.Size(498, 67);
            this.weekUIToolBar1.TabIndex = 1;
            // 
            // WeekUIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WeekUIMain";
            this.Size = new System.Drawing.Size(498, 336);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Ingredient.WeekUISche weekUISche1;
        private Ingredient.WeekUIToolBar weekUIToolBar1;


    }
}
