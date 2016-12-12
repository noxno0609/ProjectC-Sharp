namespace WindowsFormsApplication1.Design.WeekUI.Ingredient
{
    partial class WeekUITop
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
            this.buttonRight = new System.Windows.Forms.Button();
            this.BoneUI = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDate = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.BoneUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = global::MainTimeSchedule.Properties.Resources.arrowright;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRight.Location = new System.Drawing.Point(456, 0);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(52, 125);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // BoneUI
            // 
            this.BoneUI.ColumnCount = 3;
            this.BoneUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BoneUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.BoneUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BoneUI.Controls.Add(this.buttonDate, 1, 0);
            this.BoneUI.Controls.Add(this.buttonRight, 2, 0);
            this.BoneUI.Controls.Add(this.buttonLeft, 0, 0);
            this.BoneUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoneUI.Location = new System.Drawing.Point(0, 0);
            this.BoneUI.Margin = new System.Windows.Forms.Padding(0);
            this.BoneUI.Name = "BoneUI";
            this.BoneUI.RowCount = 1;
            this.BoneUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BoneUI.Size = new System.Drawing.Size(508, 125);
            this.BoneUI.TabIndex = 0;
            // 
            // buttonDate
            // 
            this.buttonDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDate.Location = new System.Drawing.Point(50, 0);
            this.buttonDate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(406, 125);
            this.buttonDate.TabIndex = 3;
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = global::MainTimeSchedule.Properties.Resources.arrowleft;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLeft.Location = new System.Drawing.Point(0, 0);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(50, 125);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // WeekUITop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BoneUI);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WeekUITop";
            this.Size = new System.Drawing.Size(508, 125);
            this.BoneUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.TableLayoutPanel BoneUI;
        private System.Windows.Forms.Button buttonDate;


    }
}
