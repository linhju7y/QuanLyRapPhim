namespace GUI.frmAdminUserControls.DataUserControl
{
    partial class CinemaUC
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
            this.panel33 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnUpdateCinema = new System.Windows.Forms.Button();
            this.btnDeleteCinema = new System.Windows.Forms.Button();
            this.btnInsertCinema = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCinemaID = new System.Windows.Forms.Label();
            this.txtCinemaID = new System.Windows.Forms.TextBox();
            this.lblCinemaName = new System.Windows.Forms.Label();
            this.txtCinemaName = new System.Windows.Forms.TextBox();
            this.lblScreenType = new System.Windows.Forms.Label();
            this.cboCinemaScreenType = new System.Windows.Forms.ComboBox();
            this.lblCinemaSeats = new System.Windows.Forms.Label();
            this.txtCinemaSeats = new System.Windows.Forms.TextBox();
            this.txtCinemaStatus = new System.Windows.Forms.TextBox();
            this.lblNumberOfRows = new System.Windows.Forms.Label();
            this.lblCinemaStatus = new System.Windows.Forms.Label();
            this.txtNumberOfRows = new System.Windows.Forms.TextBox();
            this.txtSeatsPerRow = new System.Windows.Forms.TextBox();
            this.lblSeatsPerRow = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvCinema = new System.Windows.Forms.DataGridView();
            this.panel33.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCinema)).BeginInit();
            this.SuspendLayout();
            // 
            // panel33
            // 
            this.panel33.Controls.Add(this.textBox2);
            this.panel33.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel33.Location = new System.Drawing.Point(0, 0);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(1088, 47);
            this.panel33.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(383, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 25);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "PHÒNG CHIẾU";
            // 
            // btnUpdateCinema
            // 
            this.btnUpdateCinema.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCinema.Location = new System.Drawing.Point(131, 202);
            this.btnUpdateCinema.Name = "btnUpdateCinema";
            this.btnUpdateCinema.Size = new System.Drawing.Size(80, 40);
            this.btnUpdateCinema.TabIndex = 2;
            this.btnUpdateCinema.Text = "Sửa";
            this.btnUpdateCinema.UseVisualStyleBackColor = true;
            this.btnUpdateCinema.Click += new System.EventHandler(this.btnUpdateCinema_Click);
            // 
            // btnDeleteCinema
            // 
            this.btnDeleteCinema.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCinema.Location = new System.Drawing.Point(217, 202);
            this.btnDeleteCinema.Name = "btnDeleteCinema";
            this.btnDeleteCinema.Size = new System.Drawing.Size(80, 40);
            this.btnDeleteCinema.TabIndex = 1;
            this.btnDeleteCinema.Text = "Xóa";
            this.btnDeleteCinema.UseVisualStyleBackColor = true;
            this.btnDeleteCinema.Click += new System.EventHandler(this.btnDeleteCinema_Click);
            // 
            // btnInsertCinema
            // 
            this.btnInsertCinema.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCinema.Location = new System.Drawing.Point(45, 202);
            this.btnInsertCinema.Name = "btnInsertCinema";
            this.btnInsertCinema.Size = new System.Drawing.Size(80, 40);
            this.btnInsertCinema.TabIndex = 0;
            this.btnInsertCinema.Text = "Thêm";
            this.btnInsertCinema.UseVisualStyleBackColor = true;
            this.btnInsertCinema.Click += new System.EventHandler(this.btnInsertCinema_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCinemaID);
            this.panel2.Controls.Add(this.txtCinemaID);
            this.panel2.Controls.Add(this.lblCinemaName);
            this.panel2.Controls.Add(this.txtCinemaName);
            this.panel2.Controls.Add(this.lblScreenType);
            this.panel2.Controls.Add(this.cboCinemaScreenType);
            this.panel2.Controls.Add(this.lblCinemaSeats);
            this.panel2.Controls.Add(this.txtCinemaSeats);
            this.panel2.Controls.Add(this.txtCinemaStatus);
            this.panel2.Controls.Add(this.lblNumberOfRows);
            this.panel2.Controls.Add(this.lblCinemaStatus);
            this.panel2.Controls.Add(this.txtNumberOfRows);
            this.panel2.Controls.Add(this.txtSeatsPerRow);
            this.panel2.Controls.Add(this.lblSeatsPerRow);
            this.panel2.Controls.Add(this.btnUpdateCinema);
            this.panel2.Controls.Add(this.btnDeleteCinema);
            this.panel2.Controls.Add(this.btnInsertCinema);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(755, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 471);
            this.panel2.TabIndex = 0;
            // 
            // lblCinemaID
            // 
            this.lblCinemaID.AutoSize = true;
            this.lblCinemaID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCinemaID.Location = new System.Drawing.Point(49, 3);
            this.lblCinemaID.Name = "lblCinemaID";
            this.lblCinemaID.Size = new System.Drawing.Size(79, 17);
            this.lblCinemaID.TabIndex = 0;
            this.lblCinemaID.Text = "Mã phòng:";
            // 
            // txtCinemaID
            // 
            this.txtCinemaID.Location = new System.Drawing.Point(134, 3);
            this.txtCinemaID.Name = "txtCinemaID";
            this.txtCinemaID.Size = new System.Drawing.Size(163, 20);
            this.txtCinemaID.TabIndex = 1;
            this.txtCinemaID.TextChanged += new System.EventHandler(this.txtCinemaID_TextChanged);
            // 
            // lblCinemaName
            // 
            this.lblCinemaName.AutoSize = true;
            this.lblCinemaName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCinemaName.Location = new System.Drawing.Point(45, 29);
            this.lblCinemaName.Name = "lblCinemaName";
            this.lblCinemaName.Size = new System.Drawing.Size(83, 17);
            this.lblCinemaName.TabIndex = 0;
            this.lblCinemaName.Text = "Tên phòng:";
            // 
            // txtCinemaName
            // 
            this.txtCinemaName.Location = new System.Drawing.Point(134, 29);
            this.txtCinemaName.Name = "txtCinemaName";
            this.txtCinemaName.Size = new System.Drawing.Size(162, 20);
            this.txtCinemaName.TabIndex = 1;
            // 
            // lblScreenType
            // 
            this.lblScreenType.AutoSize = true;
            this.lblScreenType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblScreenType.Location = new System.Drawing.Point(53, 54);
            this.lblScreenType.Name = "lblScreenType";
            this.lblScreenType.Size = new System.Drawing.Size(75, 17);
            this.lblScreenType.TabIndex = 0;
            this.lblScreenType.Text = "Màn hình:";
            // 
            // cboCinemaScreenType
            // 
            this.cboCinemaScreenType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCinemaScreenType.FormattingEnabled = true;
            this.cboCinemaScreenType.Location = new System.Drawing.Point(134, 54);
            this.cboCinemaScreenType.Margin = new System.Windows.Forms.Padding(2);
            this.cboCinemaScreenType.Name = "cboCinemaScreenType";
            this.cboCinemaScreenType.Size = new System.Drawing.Size(162, 21);
            this.cboCinemaScreenType.TabIndex = 1;
            // 
            // lblCinemaSeats
            // 
            this.lblCinemaSeats.AutoSize = true;
            this.lblCinemaSeats.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCinemaSeats.Location = new System.Drawing.Point(40, 80);
            this.lblCinemaSeats.Name = "lblCinemaSeats";
            this.lblCinemaSeats.Size = new System.Drawing.Size(88, 17);
            this.lblCinemaSeats.TabIndex = 0;
            this.lblCinemaSeats.Text = "Số chỗ ngồi:";
            // 
            // txtCinemaSeats
            // 
            this.txtCinemaSeats.Location = new System.Drawing.Point(134, 80);
            this.txtCinemaSeats.Name = "txtCinemaSeats";
            this.txtCinemaSeats.Size = new System.Drawing.Size(162, 20);
            this.txtCinemaSeats.TabIndex = 1;
            // 
            // txtCinemaStatus
            // 
            this.txtCinemaStatus.Location = new System.Drawing.Point(135, 106);
            this.txtCinemaStatus.Name = "txtCinemaStatus";
            this.txtCinemaStatus.Size = new System.Drawing.Size(162, 20);
            this.txtCinemaStatus.TabIndex = 1;
            // 
            // lblNumberOfRows
            // 
            this.lblNumberOfRows.AutoSize = true;
            this.lblNumberOfRows.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNumberOfRows.Location = new System.Drawing.Point(36, 132);
            this.lblNumberOfRows.Name = "lblNumberOfRows";
            this.lblNumberOfRows.Size = new System.Drawing.Size(92, 17);
            this.lblNumberOfRows.TabIndex = 0;
            this.lblNumberOfRows.Text = "Số hàng ghế:";
            // 
            // lblCinemaStatus
            // 
            this.lblCinemaStatus.AutoSize = true;
            this.lblCinemaStatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCinemaStatus.Location = new System.Drawing.Point(47, 106);
            this.lblCinemaStatus.Name = "lblCinemaStatus";
            this.lblCinemaStatus.Size = new System.Drawing.Size(81, 17);
            this.lblCinemaStatus.TabIndex = 0;
            this.lblCinemaStatus.Text = "Tình trạng:";
            // 
            // txtNumberOfRows
            // 
            this.txtNumberOfRows.Location = new System.Drawing.Point(134, 132);
            this.txtNumberOfRows.Name = "txtNumberOfRows";
            this.txtNumberOfRows.Size = new System.Drawing.Size(162, 20);
            this.txtNumberOfRows.TabIndex = 1;
            // 
            // txtSeatsPerRow
            // 
            this.txtSeatsPerRow.Location = new System.Drawing.Point(135, 158);
            this.txtSeatsPerRow.Name = "txtSeatsPerRow";
            this.txtSeatsPerRow.Size = new System.Drawing.Size(162, 20);
            this.txtSeatsPerRow.TabIndex = 1;
            // 
            // lblSeatsPerRow
            // 
            this.lblSeatsPerRow.AutoSize = true;
            this.lblSeatsPerRow.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSeatsPerRow.Location = new System.Drawing.Point(26, 158);
            this.lblSeatsPerRow.Name = "lblSeatsPerRow";
            this.lblSeatsPerRow.Size = new System.Drawing.Size(103, 17);
            this.lblSeatsPerRow.TabIndex = 0;
            this.lblSeatsPerRow.Text = "Ghế mỗi hàng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvCinema);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 471);
            this.panel1.TabIndex = 11;
            // 
            // dtgvCinema
            // 
            this.dtgvCinema.AllowUserToAddRows = false;
            this.dtgvCinema.AllowUserToDeleteRows = false;
            this.dtgvCinema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCinema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCinema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCinema.Location = new System.Drawing.Point(0, 0);
            this.dtgvCinema.Name = "dtgvCinema";
            this.dtgvCinema.ReadOnly = true;
            this.dtgvCinema.Size = new System.Drawing.Size(755, 471);
            this.dtgvCinema.TabIndex = 1;
            // 
            // CinemaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel33);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CinemaUC";
            this.Size = new System.Drawing.Size(1088, 518);
            this.panel33.ResumeLayout(false);
            this.panel33.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCinema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Button btnUpdateCinema;
        private System.Windows.Forms.Button btnDeleteCinema;
        private System.Windows.Forms.Button btnInsertCinema;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboCinemaScreenType;
        private System.Windows.Forms.Label lblScreenType;
        private System.Windows.Forms.TextBox txtNumberOfRows;
        private System.Windows.Forms.Label lblNumberOfRows;
        private System.Windows.Forms.TextBox txtCinemaStatus;
        private System.Windows.Forms.Label lblCinemaStatus;
        private System.Windows.Forms.TextBox txtCinemaSeats;
        private System.Windows.Forms.Label lblCinemaSeats;
        private System.Windows.Forms.TextBox txtCinemaName;
        private System.Windows.Forms.Label lblCinemaName;
        private System.Windows.Forms.TextBox txtCinemaID;
        private System.Windows.Forms.Label lblCinemaID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvCinema;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtSeatsPerRow;
        private System.Windows.Forms.Label lblSeatsPerRow;
    }
}
