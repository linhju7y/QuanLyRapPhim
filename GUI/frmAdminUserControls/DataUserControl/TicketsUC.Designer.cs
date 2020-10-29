namespace GUI.frmAdminUserControls.DataUserControl
{
    partial class TicketsUC
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
            this.panel61 = new System.Windows.Forms.Panel();
            this.btnShowAllTicketsByShowTime = new System.Windows.Forms.Button();
            this.btnShowAllTicketsBoughtByShowTime = new System.Windows.Forms.Button();
            this.btnAddTicketsByShowTime = new System.Windows.Forms.Button();
            this.btnShowShowTimeNotCreateTickets = new System.Windows.Forms.Button();
            this.btnDeleteTicketsByShowTime = new System.Windows.Forms.Button();
            this.lsvAllListShowTimes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtgvTicket = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAllListShowTimes = new System.Windows.Forms.Button();
            this.panel61.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // panel61
            // 
            this.panel61.Controls.Add(this.textBox2);
            this.panel61.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel61.Location = new System.Drawing.Point(0, 0);
            this.panel61.Name = "panel61";
            this.panel61.Size = new System.Drawing.Size(1161, 42);
            this.panel61.TabIndex = 10;
            // 
            // btnShowAllTicketsByShowTime
            // 
            this.btnShowAllTicketsByShowTime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllTicketsByShowTime.Location = new System.Drawing.Point(369, 48);
            this.btnShowAllTicketsByShowTime.Name = "btnShowAllTicketsByShowTime";
            this.btnShowAllTicketsByShowTime.Size = new System.Drawing.Size(116, 46);
            this.btnShowAllTicketsByShowTime.TabIndex = 5;
            this.btnShowAllTicketsByShowTime.Text = "Xem Tất Cả Các Vé Theo Lịch Chiếu";
            this.btnShowAllTicketsByShowTime.UseVisualStyleBackColor = true;
            this.btnShowAllTicketsByShowTime.Click += new System.EventHandler(this.btnShowAllTicketsByShowTime_Click);
            // 
            // btnShowAllTicketsBoughtByShowTime
            // 
            this.btnShowAllTicketsBoughtByShowTime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllTicketsBoughtByShowTime.Location = new System.Drawing.Point(247, 48);
            this.btnShowAllTicketsBoughtByShowTime.Name = "btnShowAllTicketsBoughtByShowTime";
            this.btnShowAllTicketsBoughtByShowTime.Size = new System.Drawing.Size(116, 46);
            this.btnShowAllTicketsBoughtByShowTime.TabIndex = 4;
            this.btnShowAllTicketsBoughtByShowTime.Text = "Xem Các Vé Được Bán Theo Lịch Chiếu";
            this.btnShowAllTicketsBoughtByShowTime.UseVisualStyleBackColor = true;
            this.btnShowAllTicketsBoughtByShowTime.Click += new System.EventHandler(this.btnShowAllTicketsBoughtByShowTime_Click);
            // 
            // btnAddTicketsByShowTime
            // 
            this.btnAddTicketsByShowTime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTicketsByShowTime.Location = new System.Drawing.Point(3, 48);
            this.btnAddTicketsByShowTime.Name = "btnAddTicketsByShowTime";
            this.btnAddTicketsByShowTime.Size = new System.Drawing.Size(116, 46);
            this.btnAddTicketsByShowTime.TabIndex = 0;
            this.btnAddTicketsByShowTime.Text = "Tự Động Thêm Vé Theo Lịch Chiếu\r\n";
            this.btnAddTicketsByShowTime.UseVisualStyleBackColor = true;
            this.btnAddTicketsByShowTime.Click += new System.EventHandler(this.btnAddTicketsByShowTime_Click);
            // 
            // btnShowShowTimeNotCreateTickets
            // 
            this.btnShowShowTimeNotCreateTickets.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowShowTimeNotCreateTickets.Location = new System.Drawing.Point(613, 48);
            this.btnShowShowTimeNotCreateTickets.Name = "btnShowShowTimeNotCreateTickets";
            this.btnShowShowTimeNotCreateTickets.Size = new System.Drawing.Size(116, 46);
            this.btnShowShowTimeNotCreateTickets.TabIndex = 3;
            this.btnShowShowTimeNotCreateTickets.Text = "Xem Lịch Chiếu Chưa Được Tạo Vé";
            this.btnShowShowTimeNotCreateTickets.UseVisualStyleBackColor = true;
            this.btnShowShowTimeNotCreateTickets.Click += new System.EventHandler(this.btnShowShowTimeNotCreateTickets_Click);
            // 
            // btnDeleteTicketsByShowTime
            // 
            this.btnDeleteTicketsByShowTime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTicketsByShowTime.Location = new System.Drawing.Point(125, 48);
            this.btnDeleteTicketsByShowTime.Name = "btnDeleteTicketsByShowTime";
            this.btnDeleteTicketsByShowTime.Size = new System.Drawing.Size(116, 46);
            this.btnDeleteTicketsByShowTime.TabIndex = 1;
            this.btnDeleteTicketsByShowTime.Text = "Xóa Vé Theo Lịch Chiếu";
            this.btnDeleteTicketsByShowTime.UseVisualStyleBackColor = true;
            this.btnDeleteTicketsByShowTime.Click += new System.EventHandler(this.btnDeleteTicketsByShowTime_Click);
            // 
            // lsvAllListShowTimes
            // 
            this.lsvAllListShowTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvAllListShowTimes.FullRowSelect = true;
            this.lsvAllListShowTimes.GridLines = true;
            this.lsvAllListShowTimes.HideSelection = false;
            this.lsvAllListShowTimes.Location = new System.Drawing.Point(647, 100);
            this.lsvAllListShowTimes.Margin = new System.Windows.Forms.Padding(2);
            this.lsvAllListShowTimes.Name = "lsvAllListShowTimes";
            this.lsvAllListShowTimes.Size = new System.Drawing.Size(512, 418);
            this.lsvAllListShowTimes.TabIndex = 9;
            this.lsvAllListShowTimes.UseCompatibleStateImageBehavior = false;
            this.lsvAllListShowTimes.View = System.Windows.Forms.View.Details;
            this.lsvAllListShowTimes.Click += new System.EventHandler(this.lsvAllListShowTimes_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Phòng Chiếu";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Phim";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời Gian";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trạng Thái";
            this.columnHeader4.Width = 100;
            // 
            // dtgvTicket
            // 
            this.dtgvTicket.AllowUserToAddRows = false;
            this.dtgvTicket.AllowUserToDeleteRows = false;
            this.dtgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTicket.Location = new System.Drawing.Point(0, 100);
            this.dtgvTicket.Name = "dtgvTicket";
            this.dtgvTicket.Size = new System.Drawing.Size(644, 418);
            this.dtgvTicket.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(446, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 25);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "VÉ";
            // 
            // btnAllListShowTimes
            // 
            this.btnAllListShowTimes.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllListShowTimes.Location = new System.Drawing.Point(491, 48);
            this.btnAllListShowTimes.Name = "btnAllListShowTimes";
            this.btnAllListShowTimes.Size = new System.Drawing.Size(116, 46);
            this.btnAllListShowTimes.TabIndex = 3;
            this.btnAllListShowTimes.Text = "Xem Tất Cả Lịch Chiếu\r\n";
            this.btnAllListShowTimes.UseVisualStyleBackColor = true;
            this.btnAllListShowTimes.Click += new System.EventHandler(this.btnAllListShowTimes_Click);
            // 
            // TicketsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAllListShowTimes);
            this.Controls.Add(this.btnShowAllTicketsByShowTime);
            this.Controls.Add(this.lsvAllListShowTimes);
            this.Controls.Add(this.btnShowShowTimeNotCreateTickets);
            this.Controls.Add(this.dtgvTicket);
            this.Controls.Add(this.btnShowAllTicketsBoughtByShowTime);
            this.Controls.Add(this.btnAddTicketsByShowTime);
            this.Controls.Add(this.panel61);
            this.Controls.Add(this.btnDeleteTicketsByShowTime);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TicketsUC";
            this.Size = new System.Drawing.Size(1161, 518);
            this.panel61.ResumeLayout(false);
            this.panel61.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel61;
        private System.Windows.Forms.Button btnShowAllTicketsByShowTime;
        private System.Windows.Forms.Button btnShowAllTicketsBoughtByShowTime;
        private System.Windows.Forms.Button btnAddTicketsByShowTime;
        private System.Windows.Forms.Button btnShowShowTimeNotCreateTickets;
        private System.Windows.Forms.Button btnDeleteTicketsByShowTime;
        private System.Windows.Forms.ListView lsvAllListShowTimes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DataGridView dtgvTicket;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAllListShowTimes;
    }
}
