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
            this.weekUIContentBone = new System.Windows.Forms.TableLayoutPanel();
            this.weekUITopBone = new System.Windows.Forms.TableLayoutPanel();
            this.weekUITool = new TSProject.Design.WeekUI.Ingredient.WeekUITool();
            this.weekUISche = new WindowsFormsApplication1.Design.WeekUI.Ingredient.WeekUISche();
            this.weekUITop = new WindowsFormsApplication1.Design.WeekUI.Ingredient.WeekUITop();
            this.weekUIContentBone.SuspendLayout();
            this.weekUITopBone.SuspendLayout();
            this.SuspendLayout();
            // 
            // weekUIContentBone
            // 
            this.weekUIContentBone.ColumnCount = 2;
            this.weekUIContentBone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.weekUIContentBone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.weekUIContentBone.Controls.Add(this.weekUITool, 0, 0);
            this.weekUIContentBone.Controls.Add(this.weekUISche, 1, 0);
            this.weekUIContentBone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekUIContentBone.Location = new System.Drawing.Point(0, 23);
            this.weekUIContentBone.Margin = new System.Windows.Forms.Padding(0);
            this.weekUIContentBone.Name = "weekUIContentBone";
            this.weekUIContentBone.RowCount = 1;
            this.weekUIContentBone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.weekUIContentBone.Size = new System.Drawing.Size(498, 313);
            this.weekUIContentBone.TabIndex = 0;
            // 
            // weekUITopBone
            // 
            this.weekUITopBone.ColumnCount = 1;
            this.weekUITopBone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.weekUITopBone.Controls.Add(this.weekUIContentBone, 0, 1);
            this.weekUITopBone.Controls.Add(this.weekUITop, 0, 0);
            this.weekUITopBone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekUITopBone.Location = new System.Drawing.Point(0, 0);
            this.weekUITopBone.Margin = new System.Windows.Forms.Padding(0);
            this.weekUITopBone.Name = "weekUITopBone";
            this.weekUITopBone.RowCount = 2;
            this.weekUITopBone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.weekUITopBone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.weekUITopBone.Size = new System.Drawing.Size(498, 336);
            this.weekUITopBone.TabIndex = 1;
            // 
            // weekUITool
            // 
            this.weekUITool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekUITool.Location = new System.Drawing.Point(0, 0);
            this.weekUITool.Margin = new System.Windows.Forms.Padding(0);
            this.weekUITool.Name = "weekUITool";
            this.weekUITool.Size = new System.Drawing.Size(49, 313);
            this.weekUITool.TabIndex = 0;
            // 
            // weekUISche
            // 
            this.weekUISche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekUISche.Location = new System.Drawing.Point(49, 0);
            this.weekUISche.Margin = new System.Windows.Forms.Padding(0);
            this.weekUISche.Name = "weekUISche";
            this.weekUISche.Size = new System.Drawing.Size(449, 313);
            this.weekUISche.TabIndex = 1;
            // 
            // weekUITop
            // 
            this.weekUITop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekUITop.Location = new System.Drawing.Point(0, 0);
            this.weekUITop.Margin = new System.Windows.Forms.Padding(0);
            this.weekUITop.Name = "weekUITop";
            this.weekUITop.Size = new System.Drawing.Size(498, 23);
            this.weekUITop.TabIndex = 1;
            // 
            // WeekUIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.weekUITopBone);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WeekUIMain";
            this.Size = new System.Drawing.Size(498, 336);
            this.weekUIContentBone.ResumeLayout(false);
            this.weekUITopBone.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Ingredient.WeekUITop weekUITop;
        private System.Windows.Forms.TableLayoutPanel weekUIContentBone;
        private System.Windows.Forms.TableLayoutPanel weekUITopBone;
        private TSProject.Design.WeekUI.Ingredient.WeekUITool weekUITool;
        private Ingredient.WeekUISche weekUISche;



    }
}
