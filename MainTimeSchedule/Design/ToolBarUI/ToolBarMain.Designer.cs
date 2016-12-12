namespace MainTimeSchedule.Design.ToolBarUI
{
    partial class ToolBarMain
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
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonxem = new System.Windows.Forms.Button();
            this.buttonmail = new System.Windows.Forms.Button();
            this.buttonexcel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonadd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttondelete, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonxem, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonmail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonexcel, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(117, 287);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonadd
            // 
            this.buttonadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonadd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.Location = new System.Drawing.Point(3, 8);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(111, 40);
            this.buttonadd.TabIndex = 0;
            this.buttonadd.Text = "Thêm sự kiện";
            this.buttonadd.UseVisualStyleBackColor = true;
            // 
            // buttondelete
            // 
            this.buttondelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttondelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.Location = new System.Drawing.Point(3, 65);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(111, 40);
            this.buttondelete.TabIndex = 0;
            this.buttondelete.Text = "Xóa sự kiện";
            this.buttondelete.UseVisualStyleBackColor = true;
            // 
            // buttonxem
            // 
            this.buttonxem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonxem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonxem.Location = new System.Drawing.Point(3, 122);
            this.buttonxem.Name = "buttonxem";
            this.buttonxem.Size = new System.Drawing.Size(111, 40);
            this.buttonxem.TabIndex = 0;
            this.buttonxem.Text = "Xem lịch trình";
            this.buttonxem.UseVisualStyleBackColor = true;
            // 
            // buttonmail
            // 
            this.buttonmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmail.Location = new System.Drawing.Point(3, 179);
            this.buttonmail.Name = "buttonmail";
            this.buttonmail.Size = new System.Drawing.Size(111, 40);
            this.buttonmail.TabIndex = 0;
            this.buttonmail.Text = "Gửi Mail";
            this.buttonmail.UseVisualStyleBackColor = true;
            // 
            // buttonexcel
            // 
            this.buttonexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonexcel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexcel.Location = new System.Drawing.Point(3, 237);
            this.buttonexcel.Name = "buttonexcel";
            this.buttonexcel.Size = new System.Drawing.Size(111, 40);
            this.buttonexcel.TabIndex = 0;
            this.buttonexcel.Text = "Xuất Excel";
            this.buttonexcel.UseVisualStyleBackColor = true;
            // 
            // ToolBarMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ToolBarMain";
            this.Size = new System.Drawing.Size(117, 287);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonxem;
        private System.Windows.Forms.Button buttonmail;
        private System.Windows.Forms.Button buttonexcel;
    }
}
