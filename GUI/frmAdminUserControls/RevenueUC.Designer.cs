namespace GUI.frmAdminUserControls
{
    partial class RevenueUC
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
            this.lblSelectMovie = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvRevenue = new System.Windows.Forms.DataGridView();
            this.btnReportRevenue = new System.Windows.Forms.Button();
            this.btnShowRevenue = new System.Windows.Forms.Button();
            this.cboSelectMovie = new System.Windows.Forms.ComboBox();
            this.dtmToDate = new System.Windows.Forms.DateTimePicker();
            this.dtmFromDate = new System.Windows.Forms.DateTimePicker();
            this.grpRevenue = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).BeginInit();
            this.grpRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectMovie
            // 
            this.lblSelectMovie.AutoSize = true;
            this.lblSelectMovie.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMovie.Location = new System.Drawing.Point(108, 36);
            this.lblSelectMovie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectMovie.Name = "lblSelectMovie";
            this.lblSelectMovie.Size = new System.Drawing.Size(84, 17);
            this.lblSelectMovie.TabIndex = 39;
            this.lblSelectMovie.Text = "Chọn phim:";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(544, 437);
            this.lblTongDoanhThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(117, 19);
            this.lblTongDoanhThu.TabIndex = 38;
            this.lblTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Enabled = false;
            this.txtDoanhThu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThu.Location = new System.Drawing.Point(665, 432);
            this.txtDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(177, 29);
            this.txtDoanhThu.TabIndex = 37;
            this.txtDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.Location = new System.Drawing.Point(341, 84);
            this.lblDenNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(74, 17);
            this.lblDenNgay.TabIndex = 36;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Từ ngày:";
            // 
            // dtgvRevenue
            // 
            this.dtgvRevenue.AllowUserToAddRows = false;
            this.dtgvRevenue.AllowUserToDeleteRows = false;
            this.dtgvRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRevenue.Location = new System.Drawing.Point(150, 195);
            this.dtgvRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvRevenue.Name = "dtgvRevenue";
            this.dtgvRevenue.ReadOnly = true;
            this.dtgvRevenue.Size = new System.Drawing.Size(692, 233);
            this.dtgvRevenue.TabIndex = 34;
            // 
            // btnReportRevenue
            // 
            this.btnReportRevenue.AutoSize = true;
            this.btnReportRevenue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportRevenue.Location = new System.Drawing.Point(497, 151);
            this.btnReportRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportRevenue.Name = "btnReportRevenue";
            this.btnReportRevenue.Size = new System.Drawing.Size(80, 40);
            this.btnReportRevenue.TabIndex = 32;
            this.btnReportRevenue.Text = "Báo Cáo";
            this.btnReportRevenue.UseVisualStyleBackColor = true;
            this.btnReportRevenue.Click += new System.EventHandler(this.btnReportRevenue_Click);
            // 
            // btnShowRevenue
            // 
            this.btnShowRevenue.AutoSize = true;
            this.btnShowRevenue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRevenue.Location = new System.Drawing.Point(413, 151);
            this.btnShowRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowRevenue.Name = "btnShowRevenue";
            this.btnShowRevenue.Size = new System.Drawing.Size(80, 40);
            this.btnShowRevenue.TabIndex = 33;
            this.btnShowRevenue.Text = "Thống kê";
            this.btnShowRevenue.UseVisualStyleBackColor = true;
            this.btnShowRevenue.Click += new System.EventHandler(this.btnShowRevenue_Click);
            // 
            // cboSelectMovie
            // 
            this.cboSelectMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectMovie.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectMovie.FormattingEnabled = true;
            this.cboSelectMovie.Location = new System.Drawing.Point(196, 36);
            this.cboSelectMovie.Margin = new System.Windows.Forms.Padding(2);
            this.cboSelectMovie.Name = "cboSelectMovie";
            this.cboSelectMovie.Size = new System.Drawing.Size(261, 26);
            this.cboSelectMovie.TabIndex = 31;
            // 
            // dtmToDate
            // 
            this.dtmToDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmToDate.Location = new System.Drawing.Point(419, 84);
            this.dtmToDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtmToDate.Name = "dtmToDate";
            this.dtmToDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtmToDate.Size = new System.Drawing.Size(102, 25);
            this.dtmToDate.TabIndex = 29;
            // 
            // dtmFromDate
            // 
            this.dtmFromDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmFromDate.Location = new System.Drawing.Point(137, 84);
            this.dtmFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtmFromDate.Name = "dtmFromDate";
            this.dtmFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtmFromDate.Size = new System.Drawing.Size(102, 25);
            this.dtmFromDate.TabIndex = 30;
            // 
            // grpRevenue
            // 
            this.grpRevenue.BackColor = System.Drawing.Color.Transparent;
            this.grpRevenue.Controls.Add(this.lblSelectMovie);
            this.grpRevenue.Controls.Add(this.dtmFromDate);
            this.grpRevenue.Controls.Add(this.dtmToDate);
            this.grpRevenue.Controls.Add(this.cboSelectMovie);
            this.grpRevenue.Controls.Add(this.lblDenNgay);
            this.grpRevenue.Controls.Add(this.label1);
            this.grpRevenue.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRevenue.Location = new System.Drawing.Point(150, 21);
            this.grpRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.grpRevenue.Name = "grpRevenue";
            this.grpRevenue.Padding = new System.Windows.Forms.Padding(2);
            this.grpRevenue.Size = new System.Drawing.Size(692, 117);
            this.grpRevenue.TabIndex = 40;
            this.grpRevenue.TabStop = false;
            this.grpRevenue.Text = "Báo cáo thống kê doanh thu";
            // 
            // RevenueUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpRevenue);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.dtgvRevenue);
            this.Controls.Add(this.btnReportRevenue);
            this.Controls.Add(this.btnShowRevenue);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RevenueUC";
            this.Size = new System.Drawing.Size(1050, 528);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).EndInit();
            this.grpRevenue.ResumeLayout(false);
            this.grpRevenue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectMovie;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvRevenue;
        private System.Windows.Forms.Button btnReportRevenue;
        private System.Windows.Forms.Button btnShowRevenue;
        private System.Windows.Forms.ComboBox cboSelectMovie;
        private System.Windows.Forms.DateTimePicker dtmToDate;
        private System.Windows.Forms.DateTimePicker dtmFromDate;
        private System.Windows.Forms.GroupBox grpRevenue;
    }
}
