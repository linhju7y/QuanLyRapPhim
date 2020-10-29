namespace GUI.frmAdminUserControls
{
    partial class CustomerUC
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
            this.components = new System.ComponentModel.Container();
            this.txtSearchCus = new System.Windows.Forms.TextBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.nudPoint = new System.Windows.Forms.NumericUpDown();
            this.lblCusID = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.lblCusINumber = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.lblCusBirth = new System.Windows.Forms.Label();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.lblCusPhone = new System.Windows.Forms.Label();
            this.lblCusPoint = new System.Windows.Forms.Label();
            this.txtCusBirth = new System.Windows.Forms.TextBox();
            this.lblCusAddress = new System.Windows.Forms.Label();
            this.txtCusINumber = new System.Windows.Forms.TextBox();
            this.lblCusName = new System.Windows.Forms.Label();
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchCus
            // 
            this.txtSearchCus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCus.Location = new System.Drawing.Point(684, 176);
            this.txtSearchCus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchCus.Name = "txtSearchCus";
            this.txtSearchCus.Size = new System.Drawing.Size(200, 25);
            this.txtSearchCus.TabIndex = 20;
            this.txtSearchCus.TextChanged += new System.EventHandler(this.txtSearchCus_TextChanged);
          //  this.txtSearchCus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchCus_KeyDown);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(488, 167);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(80, 40);
            this.btnDeleteCustomer.TabIndex = 17;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(404, 167);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(80, 40);
            this.btnUpdateCustomer.TabIndex = 18;
            this.btnUpdateCustomer.Text = "Sửa";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(320, 167);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(80, 40);
            this.btnAddCustomer.TabIndex = 19;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.Transparent;
            this.grpCustomer.Controls.Add(this.nudPoint);
            this.grpCustomer.Controls.Add(this.lblCusID);
            this.grpCustomer.Controls.Add(this.txtCusID);
            this.grpCustomer.Controls.Add(this.txtCusAddress);
            this.grpCustomer.Controls.Add(this.lblCusINumber);
            this.grpCustomer.Controls.Add(this.txtCusName);
            this.grpCustomer.Controls.Add(this.lblCusBirth);
            this.grpCustomer.Controls.Add(this.txtCusPhone);
            this.grpCustomer.Controls.Add(this.lblCusPhone);
            this.grpCustomer.Controls.Add(this.lblCusPoint);
            this.grpCustomer.Controls.Add(this.txtCusBirth);
            this.grpCustomer.Controls.Add(this.lblCusAddress);
            this.grpCustomer.Controls.Add(this.txtCusINumber);
            this.grpCustomer.Controls.Add(this.lblCusName);
            this.grpCustomer.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomer.Location = new System.Drawing.Point(156, 24);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCustomer.Size = new System.Drawing.Size(728, 128);
            this.grpCustomer.TabIndex = 16;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Thông tin khách hàng";
            // 
            // nudPoint
            // 
            this.nudPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPoint.Location = new System.Drawing.Point(641, 89);
            this.nudPoint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudPoint.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPoint.Name = "nudPoint";
            this.nudPoint.Size = new System.Drawing.Size(56, 26);
            this.nudPoint.TabIndex = 5;
            this.nudPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusID.Location = new System.Drawing.Point(33, 33);
            this.lblCusID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(63, 17);
            this.lblCusID.TabIndex = 4;
            this.lblCusID.Text = "Mã KH:";
            // 
            // txtCusID
            // 
            this.txtCusID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusID.Location = new System.Drawing.Point(100, 29);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(144, 26);
            this.txtCusID.TabIndex = 2;
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusAddress.Location = new System.Drawing.Point(377, 29);
            this.txtCusAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(144, 26);
            this.txtCusAddress.TabIndex = 2;
            // 
            // lblCusINumber
            // 
            this.lblCusINumber.AutoSize = true;
            this.lblCusINumber.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusINumber.Location = new System.Drawing.Point(312, 93);
            this.lblCusINumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusINumber.Name = "lblCusINumber";
            this.lblCusINumber.Size = new System.Drawing.Size(61, 17);
            this.lblCusINumber.TabIndex = 4;
            this.lblCusINumber.Text = "CMND:";
            // 
            // txtCusName
            // 
            this.txtCusName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.Location = new System.Drawing.Point(100, 59);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(144, 26);
            this.txtCusName.TabIndex = 2;
            // 
            // lblCusBirth
            // 
            this.lblCusBirth.AutoSize = true;
            this.lblCusBirth.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusBirth.Location = new System.Drawing.Point(19, 92);
            this.lblCusBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusBirth.Name = "lblCusBirth";
            this.lblCusBirth.Size = new System.Drawing.Size(77, 17);
            this.lblCusBirth.TabIndex = 4;
            this.lblCusBirth.Text = "Ngày sinh:";
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusPhone.Location = new System.Drawing.Point(377, 59);
            this.txtCusPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(144, 26);
            this.txtCusPhone.TabIndex = 2;
            // 
            // lblCusPhone
            // 
            this.lblCusPhone.AutoSize = true;
            this.lblCusPhone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusPhone.Location = new System.Drawing.Point(319, 63);
            this.lblCusPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusPhone.Name = "lblCusPhone";
            this.lblCusPhone.Size = new System.Drawing.Size(54, 17);
            this.lblCusPhone.TabIndex = 4;
            this.lblCusPhone.Text = "Số ĐT:";
            // 
            // lblCusPoint
            // 
            this.lblCusPoint.AutoSize = true;
            this.lblCusPoint.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusPoint.Location = new System.Drawing.Point(538, 93);
            this.lblCusPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusPoint.Name = "lblCusPoint";
            this.lblCusPoint.Size = new System.Drawing.Size(99, 17);
            this.lblCusPoint.TabIndex = 4;
            this.lblCusPoint.Text = "Điểm tích lũy:";
            // 
            // txtCusBirth
            // 
            this.txtCusBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusBirth.Location = new System.Drawing.Point(100, 89);
            this.txtCusBirth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCusBirth.Name = "txtCusBirth";
            this.txtCusBirth.Size = new System.Drawing.Size(144, 26);
            this.txtCusBirth.TabIndex = 2;
            // 
            // lblCusAddress
            // 
            this.lblCusAddress.AutoSize = true;
            this.lblCusAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusAddress.Location = new System.Drawing.Point(315, 33);
            this.lblCusAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusAddress.Name = "lblCusAddress";
            this.lblCusAddress.Size = new System.Drawing.Size(58, 17);
            this.lblCusAddress.TabIndex = 4;
            this.lblCusAddress.Text = "Địa chỉ:";
            // 
            // txtCusINumber
            // 
            this.txtCusINumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusINumber.Location = new System.Drawing.Point(377, 89);
            this.txtCusINumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCusINumber.Name = "txtCusINumber";
            this.txtCusINumber.Size = new System.Drawing.Size(144, 26);
            this.txtCusINumber.TabIndex = 2;
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusName.Location = new System.Drawing.Point(38, 63);
            this.lblCusName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(58, 17);
            this.lblCusName.TabIndex = 4;
            this.lblCusName.Text = "Họ tên:";
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.AllowUserToAddRows = false;
            this.dtgvCustomer.AllowUserToDeleteRows = false;
            this.dtgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Location = new System.Drawing.Point(156, 211);
            this.dtgvCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.ReadOnly = true;
            this.dtgvCustomer.RowHeadersWidth = 51;
            this.dtgvCustomer.RowTemplate.Height = 24;
            this.dtgvCustomer.Size = new System.Drawing.Size(728, 302);
            this.dtgvCustomer.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // CustomerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchCus);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.dtgvCustomer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerUC";
            this.Size = new System.Drawing.Size(1050, 528);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchCus;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.NumericUpDown nudPoint;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.Label lblCusINumber;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label lblCusBirth;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.Label lblCusPhone;
        private System.Windows.Forms.Label lblCusPoint;
        private System.Windows.Forms.TextBox txtCusBirth;
        private System.Windows.Forms.Label lblCusAddress;
        private System.Windows.Forms.TextBox txtCusINumber;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.DataGridView dtgvCustomer;
		private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
    }
}
