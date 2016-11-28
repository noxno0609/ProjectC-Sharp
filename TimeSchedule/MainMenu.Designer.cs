namespace WindowsFormsApplication1
{
    partial class MainMenu
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
            this.dayUIMain1 = new WindowsFormsApplication1.DayUI.DayUIMain();
            this.SuspendLayout();
            // 
            // dayUIMain1
            // 
            this.dayUIMain1.Location = new System.Drawing.Point(12, 42);
            this.dayUIMain1.Name = "dayUIMain1";
            this.dayUIMain1.Size = new System.Drawing.Size(756, 451);
            this.dayUIMain1.TabIndex = 0;
            this.dayUIMain1.Load += new System.EventHandler(this.dayUIMain1_Load);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 480);
            this.Controls.Add(this.dayUIMain1);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DayUI.DayUIMain dayUIMain1;



    }
}