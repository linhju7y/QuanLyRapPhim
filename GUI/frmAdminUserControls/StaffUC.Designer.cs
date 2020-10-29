namespace GUI.frmAdminUserControls
{
    partial class StaffUC
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
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.txtStaffAddress = new System.Windows.Forms.TextBox();
            this.lblStaffINumber = new System.Windows.Forms.Label();
            this.lblStaffBirth = new System.Windows.Forms.Label();
            this.txtStaffPhone = new System.Windows.Forms.TextBox();
            this.lblStaffPhone = new System.Windows.Forms.Label();
            this.txtSearchStaff = new System.Windows.Forms.TextBox();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.txtStaffBirth = new System.Windows.Forms.TextBox();
            this.lblStaffAddress = new System.Windows.Forms.Label();
            this.txtStaffINumber = new System.Windows.Forms.TextBox();
            this.grpStaff = new System.Windows.Forms.GroupBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grpStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(112, 56);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(144, 26);
            this.txtStaffName.TabIndex = 2;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Location = new System.Drawing.Point(283, 141);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(80, 40);
            this.btnAddStaff.TabIndex = 20;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(48, 30);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(60, 17);
            this.lblStaffID.TabIndex = 4;
            this.lblStaffID.Text = "Mã NV:";
            // 
            // txtStaffId
            // 
            this.txtStaffId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffId.Location = new System.Drawing.Point(112, 26);
            this.txtStaffId.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(144, 26);
            this.txtStaffId.TabIndex = 2;
            // 
            // txtStaffAddress
            // 
            this.txtStaffAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffAddress.Location = new System.Drawing.Point(453, 29);
            this.txtStaffAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffAddress.Name = "txtStaffAddress";
            this.txtStaffAddress.Size = new System.Drawing.Size(144, 26);
            this.txtStaffAddress.TabIndex = 2;
            // 
            // lblStaffINumber
            // 
            this.lblStaffINumber.AutoSize = true;
            this.lblStaffINumber.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffINumber.Location = new System.Drawing.Point(388, 92);
            this.lblStaffINumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffINumber.Name = "lblStaffINumber";
            this.lblStaffINumber.Size = new System.Drawing.Size(61, 17);
            this.lblStaffINumber.TabIndex = 4;
            this.lblStaffINumber.Text = "CMND:";
            // 
            // lblStaffBirth
            // 
            this.lblStaffBirth.AutoSize = true;
            this.lblStaffBirth.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffBirth.Location = new System.Drawing.Point(31, 88);
            this.lblStaffBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffBirth.Name = "lblStaffBirth";
            this.lblStaffBirth.Size = new System.Drawing.Size(77, 17);
            this.lblStaffBirth.TabIndex = 4;
            this.lblStaffBirth.Text = "Ngày sinh:";
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffPhone.Location = new System.Drawing.Point(453, 58);
            this.txtStaffPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(144, 26);
            this.txtStaffPhone.TabIndex = 2;
            // 
            // lblStaffPhone
            // 
            this.lblStaffPhone.AutoSize = true;
            this.lblStaffPhone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffPhone.Location = new System.Drawing.Point(395, 62);
            this.lblStaffPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffPhone.Name = "lblStaffPhone";
            this.lblStaffPhone.Size = new System.Drawing.Size(54, 17);
            this.lblStaffPhone.TabIndex = 4;
            this.lblStaffPhone.Text = "Số ĐT:";
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.Location = new System.Drawing.Point(689, 154);
            this.txtSearchStaff.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.Size = new System.Drawing.Size(188, 20);
            this.txtSearchStaff.TabIndex = 21;
            this.txtSearchStaff.TextChanged += new System.EventHandler(this.txtSearchStaff_TextChanged);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStaff.Location = new System.Drawing.Point(469, 141);
            this.btnDeleteStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(80, 40);
            this.btnDeleteStaff.TabIndex = 18;
            this.btnDeleteStaff.Text = "Xóa";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStaff.Location = new System.Drawing.Point(377, 141);
            this.btnUpdateStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(80, 40);
            this.btnUpdateStaff.TabIndex = 19;
            this.btnUpdateStaff.Text = "Sửa";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // txtStaffBirth
            // 
            this.txtStaffBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffBirth.Location = new System.Drawing.Point(112, 86);
            this.txtStaffBirth.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffBirth.Name = "txtStaffBirth";
            this.txtStaffBirth.Size = new System.Drawing.Size(144, 26);
            this.txtStaffBirth.TabIndex = 2;
            // 
            // lblStaffAddress
            // 
            this.lblStaffAddress.AutoSize = true;
            this.lblStaffAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffAddress.Location = new System.Drawing.Point(391, 33);
            this.lblStaffAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffAddress.Name = "lblStaffAddress";
            this.lblStaffAddress.Size = new System.Drawing.Size(58, 17);
            this.lblStaffAddress.TabIndex = 4;
            this.lblStaffAddress.Text = "Địa chỉ:";
            // 
            // txtStaffINumber
            // 
            this.txtStaffINumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffINumber.Location = new System.Drawing.Point(453, 88);
            this.txtStaffINumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffINumber.Name = "txtStaffINumber";
            this.txtStaffINumber.Size = new System.Drawing.Size(144, 26);
            this.txtStaffINumber.TabIndex = 2;
            // 
            // grpStaff
            // 
            this.grpStaff.BackColor = System.Drawing.Color.Transparent;
            this.grpStaff.Controls.Add(this.lblStaffID);
            this.grpStaff.Controls.Add(this.txtStaffId);
            this.grpStaff.Controls.Add(this.txtStaffAddress);
            this.grpStaff.Controls.Add(this.lblStaffINumber);
            this.grpStaff.Controls.Add(this.txtStaffName);
            this.grpStaff.Controls.Add(this.lblStaffBirth);
            this.grpStaff.Controls.Add(this.txtStaffPhone);
            this.grpStaff.Controls.Add(this.lblStaffPhone);
            this.grpStaff.Controls.Add(this.txtStaffBirth);
            this.grpStaff.Controls.Add(this.lblStaffAddress);
            this.grpStaff.Controls.Add(this.txtStaffINumber);
            this.grpStaff.Controls.Add(this.lblStaffName);
            this.grpStaff.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStaff.Location = new System.Drawing.Point(171, 14);
            this.grpStaff.Margin = new System.Windows.Forms.Padding(2);
            this.grpStaff.Name = "grpStaff";
            this.grpStaff.Padding = new System.Windows.Forms.Padding(2);
            this.grpStaff.Size = new System.Drawing.Size(641, 118);
            this.grpStaff.TabIndex = 23;
            this.grpStaff.TabStop = false;
            this.grpStaff.Text = "Thông tin nhân viên";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(50, 61);
            this.lblStaffName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(58, 17);
            this.lblStaffName.TabIndex = 4;
            this.lblStaffName.Text = "Họ tên:";
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.AllowUserToAddRows = false;
            this.dtgvStaff.AllowUserToDeleteRows = false;
            this.dtgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Location = new System.Drawing.Point(171, 193);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.ReadOnly = true;
            this.dtgvStaff.Size = new System.Drawing.Size(706, 280);
            this.dtgvStaff.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // StaffUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.txtSearchStaff);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnUpdateStaff);
            this.Controls.Add(this.grpStaff);
            this.Controls.Add(this.dtgvStaff);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StaffUC";
            this.Size = new System.Drawing.Size(1050, 528);
            this.grpStaff.ResumeLayout(false);
            this.grpStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.TextBox txtStaffAddress;
        private System.Windows.Forms.Label lblStaffINumber;
        private System.Windows.Forms.Label lblStaffBirth;
        private System.Windows.Forms.TextBox txtStaffPhone;
        private System.Windows.Forms.Label lblStaffPhone;
        private System.Windows.Forms.TextBox txtSearchStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.TextBox txtStaffBirth;
        private System.Windows.Forms.Label lblStaffAddress;
        private System.Windows.Forms.TextBox txtStaffINumber;
        private System.Windows.Forms.GroupBox grpStaff;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private System.Windows.Forms.Label label1;
    }
}
