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
            this.maintoolbar = new System.Windows.Forms.ToolStrip();
            this.addbutton = new System.Windows.Forms.ToolStripButton();
            this.editbutton = new System.Windows.Forms.ToolStripButton();
            this.maintoolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(0, 436);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(663, 22);
            this.footer.TabIndex = 0;
            this.footer.Text = "statusStrip1";
            // 
            // maintoolbar
            // 
            this.maintoolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.maintoolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addbutton,
            this.editbutton});
            this.maintoolbar.Location = new System.Drawing.Point(0, 0);
            this.maintoolbar.Name = "maintoolbar";
            this.maintoolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.maintoolbar.Size = new System.Drawing.Size(663, 27);
            this.maintoolbar.TabIndex = 1;
            this.maintoolbar.Text = "toolStrip1";
            // 
            // addbutton
            // 
            this.addbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addbutton.Image = global::MainTimeSchedule.Properties.Resources.addbutton;
            this.addbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(24, 24);
            this.addbutton.Text = "toolStripButton1";
            // 
            // editbutton
            // 
            this.editbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editbutton.Image = global::MainTimeSchedule.Properties.Resources.editbutton;
            this.editbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(24, 24);
            this.editbutton.Text = "toolStripButton1";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 458);
            this.Controls.Add(this.maintoolbar);
            this.Controls.Add(this.footer);
            this.Name = "MainUI";
            this.Text = "Form1";
            this.maintoolbar.ResumeLayout(false);
            this.maintoolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip footer;
        private System.Windows.Forms.ToolStrip maintoolbar;
        private System.Windows.Forms.ToolStripButton addbutton;
        private System.Windows.Forms.ToolStripButton editbutton;
    }
}

