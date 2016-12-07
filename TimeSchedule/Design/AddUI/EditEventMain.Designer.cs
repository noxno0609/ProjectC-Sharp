namespace TSProject.Design.EditEvent
{
    partial class FrmEventMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.eventMain1 = new TSProject.Design.EditEvent.Ingredient.EventMainUI();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 416);
            this.panel1.TabIndex = 0;
            // 
            // eventMain1
            // 
            this.eventMain1.BackColor = System.Drawing.SystemColors.Control;
            this.eventMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventMain1.Location = new System.Drawing.Point(0, 0);
            this.eventMain1.Name = "eventMain1";
            this.eventMain1.Size = new System.Drawing.Size(527, 430);
            this.eventMain1.TabIndex = 0;
            // 
            // FrmEventMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 416);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEventMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Ingredient.EventMainUI eventMain1;
    }
}