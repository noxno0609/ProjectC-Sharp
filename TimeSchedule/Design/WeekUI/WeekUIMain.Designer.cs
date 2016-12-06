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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.weekUITool1 = new TSProject.Design.WeekUI.Ingredient.WeekUITool();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.weekUIToolBar1 = new WindowsFormsApplication1.Design.WeekUI.Ingredient.WeekUITop();
            this.weekUISche2 = new WindowsFormsApplication1.Design.WeekUI.Ingredient.WeekUISche();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel2.Controls.Add(this.weekUITool1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.weekUISche2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(498, 313);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // weekUITool1
            // 
            this.weekUITool1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekUITool1.Location = new System.Drawing.Point(0, 0);
            this.weekUITool1.Margin = new System.Windows.Forms.Padding(0);
            this.weekUITool1.Name = "weekUITool1";
            this.weekUITool1.Size = new System.Drawing.Size(79, 313);
            this.weekUITool1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.weekUIToolBar1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 336);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // weekUIToolBar1
            // 
            this.weekUIToolBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekUIToolBar1.Location = new System.Drawing.Point(0, 0);
            this.weekUIToolBar1.Margin = new System.Windows.Forms.Padding(0);
            this.weekUIToolBar1.Name = "weekUIToolBar1";
            this.weekUIToolBar1.Size = new System.Drawing.Size(498, 23);
            this.weekUIToolBar1.TabIndex = 1;
            // 
            // weekUISche2
            // 
            this.weekUISche2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekUISche2.Location = new System.Drawing.Point(79, 0);
            this.weekUISche2.Margin = new System.Windows.Forms.Padding(0);
            this.weekUISche2.Name = "weekUISche2";
            this.weekUISche2.Size = new System.Drawing.Size(419, 313);
            this.weekUISche2.TabIndex = 1;
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Ingredient.WeekUITop weekUIToolBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TSProject.Design.WeekUI.Ingredient.WeekUITool weekUITool1;
        private Ingredient.WeekUISche weekUISche1;
        private Ingredient.WeekUISche weekUISche2;



    }
}
