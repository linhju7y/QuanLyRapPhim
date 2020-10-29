﻿namespace GUI.frmAdminUserControls.DataUserControl
{
    partial class ScreenTypeUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnUpdateScreenType = new System.Windows.Forms.Button();
            this.btnDeleteScreenType = new System.Windows.Forms.Button();
            this.btnInsertScreenType = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtScreenTypeID = new System.Windows.Forms.TextBox();
            this.txtScreenTypeName = new System.Windows.Forms.TextBox();
            this.lblScreenTypeID = new System.Windows.Forms.Label();
            this.lblScreenTypeName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvScreenType = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvScreenType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 59);
            this.panel1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(383, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 25);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "LOẠI MÀN HÌNH";
            // 
            // btnUpdateScreenType
            // 
            this.btnUpdateScreenType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateScreenType.Location = new System.Drawing.Point(222, 85);
            this.btnUpdateScreenType.Name = "btnUpdateScreenType";
            this.btnUpdateScreenType.Size = new System.Drawing.Size(80, 40);
            this.btnUpdateScreenType.TabIndex = 6;
            this.btnUpdateScreenType.Text = "Sửa";
            this.btnUpdateScreenType.UseVisualStyleBackColor = true;
            this.btnUpdateScreenType.Click += new System.EventHandler(this.btnUpdateScreenType_Click);
            // 
            // btnDeleteScreenType
            // 
            this.btnDeleteScreenType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteScreenType.Location = new System.Drawing.Point(136, 86);
            this.btnDeleteScreenType.Name = "btnDeleteScreenType";
            this.btnDeleteScreenType.Size = new System.Drawing.Size(80, 40);
            this.btnDeleteScreenType.TabIndex = 5;
            this.btnDeleteScreenType.Text = "Xóa";
            this.btnDeleteScreenType.UseVisualStyleBackColor = true;
            this.btnDeleteScreenType.Click += new System.EventHandler(this.btnDeleteScreenType_Click);
            // 
            // btnInsertScreenType
            // 
            this.btnInsertScreenType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertScreenType.Location = new System.Drawing.Point(50, 86);
            this.btnInsertScreenType.Name = "btnInsertScreenType";
            this.btnInsertScreenType.Size = new System.Drawing.Size(80, 40);
            this.btnInsertScreenType.TabIndex = 4;
            this.btnInsertScreenType.Text = "Thêm";
            this.btnInsertScreenType.UseVisualStyleBackColor = true;
            this.btnInsertScreenType.Click += new System.EventHandler(this.btnInsertScreenType_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 459);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtScreenTypeID);
            this.panel4.Controls.Add(this.txtScreenTypeName);
            this.panel4.Controls.Add(this.lblScreenTypeID);
            this.panel4.Controls.Add(this.btnUpdateScreenType);
            this.panel4.Controls.Add(this.lblScreenTypeName);
            this.panel4.Controls.Add(this.btnDeleteScreenType);
            this.panel4.Controls.Add(this.btnInsertScreenType);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(584, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 459);
            this.panel4.TabIndex = 1;
            // 
            // txtScreenTypeID
            // 
            this.txtScreenTypeID.Location = new System.Drawing.Point(152, 5);
            this.txtScreenTypeID.Name = "txtScreenTypeID";
            this.txtScreenTypeID.Size = new System.Drawing.Size(150, 20);
            this.txtScreenTypeID.TabIndex = 1;
            // 
            // txtScreenTypeName
            // 
            this.txtScreenTypeName.Location = new System.Drawing.Point(152, 37);
            this.txtScreenTypeName.Name = "txtScreenTypeName";
            this.txtScreenTypeName.Size = new System.Drawing.Size(150, 20);
            this.txtScreenTypeName.TabIndex = 1;
            // 
            // lblScreenTypeID
            // 
            this.lblScreenTypeID.AutoSize = true;
            this.lblScreenTypeID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblScreenTypeID.Location = new System.Drawing.Point(21, 8);
            this.lblScreenTypeID.Name = "lblScreenTypeID";
            this.lblScreenTypeID.Size = new System.Drawing.Size(125, 17);
            this.lblScreenTypeID.TabIndex = 0;
            this.lblScreenTypeID.Text = "Mã loại màn hình:";
            // 
            // lblScreenTypeName
            // 
            this.lblScreenTypeName.AutoSize = true;
            this.lblScreenTypeName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblScreenTypeName.Location = new System.Drawing.Point(44, 40);
            this.lblScreenTypeName.Name = "lblScreenTypeName";
            this.lblScreenTypeName.Size = new System.Drawing.Size(102, 17);
            this.lblScreenTypeName.TabIndex = 0;
            this.lblScreenTypeName.Text = "Tên màn hình:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvScreenType);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 459);
            this.panel3.TabIndex = 0;
            // 
            // dtgvScreenType
            // 
            this.dtgvScreenType.AllowUserToAddRows = false;
            this.dtgvScreenType.AllowUserToDeleteRows = false;
            this.dtgvScreenType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvScreenType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvScreenType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvScreenType.Location = new System.Drawing.Point(0, 0);
            this.dtgvScreenType.Name = "dtgvScreenType";
            this.dtgvScreenType.ReadOnly = true;
            this.dtgvScreenType.Size = new System.Drawing.Size(584, 459);
            this.dtgvScreenType.TabIndex = 1;
            // 
            // ScreenTypeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScreenTypeUC";
            this.Size = new System.Drawing.Size(925, 518);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvScreenType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdateScreenType;
        private System.Windows.Forms.Button btnDeleteScreenType;
        private System.Windows.Forms.Button btnInsertScreenType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvScreenType;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtScreenTypeName;
        private System.Windows.Forms.Label lblScreenTypeName;
        private System.Windows.Forms.TextBox txtScreenTypeID;
        private System.Windows.Forms.Label lblScreenTypeID;
        private System.Windows.Forms.TextBox textBox2;
    }
}
