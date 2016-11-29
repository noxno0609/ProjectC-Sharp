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
            this.dayUISche1 = new WindowsFormsApplication1.DayUISche();
            this.dayUITool1 = new WindowsFormsApplication1.DayUI.Ingredient.DayUITool();
            this.SuspendLayout();
            // 
            // dayUISche1
            // 
            this.dayUISche1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayUISche1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dayUISche1.Location = new System.Drawing.Point(162, 0);
            this.dayUISche1.Margin = new System.Windows.Forms.Padding(0);
            this.dayUISche1.Name = "dayUISche1";
            this.dayUISche1.Size = new System.Drawing.Size(2402, 343);
            this.dayUISche1.TabIndex = 1;
            this.dayUISche1.Load += new System.EventHandler(this.dayUISche1_Load_2);
            // 
            // dayUITool1
            // 
            this.dayUITool1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayUITool1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dayUITool1.Location = new System.Drawing.Point(0, 0);
            this.dayUITool1.Margin = new System.Windows.Forms.Padding(0);
            this.dayUITool1.Name = "dayUITool1";
            this.dayUITool1.Size = new System.Drawing.Size(162, 343);
            this.dayUITool1.TabIndex = 0;
            // 
            // DayUIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.dayUISche1);
            this.Controls.Add(this.dayUITool1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DayUIMain";
            this.Size = new System.Drawing.Size(739, 343);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private Ingredient.DayUITool dayUITool1;
        private DayUISche dayUISche1;
        
    }
}
