﻿namespace QuanLyKhoVan
{
    partial class Form_OrderDetails
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_SoLuongSanPham = new System.Windows.Forms.Panel();
            this.txt_SoLuongSanPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_ProductID = new System.Windows.Forms.Panel();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Gia = new System.Windows.Forms.Panel();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_Order_ID = new System.Windows.Forms.Panel();
            this.txt_Order_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_OrderDetail_ID = new System.Windows.Forms.Panel();
            this.txt_OrderDetail_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel_SoLuongSanPham.SuspendLayout();
            this.panel_ProductID.SuspendLayout();
            this.panel_Gia.SuspendLayout();
            this.panel_Order_ID.SuspendLayout();
            this.panel_OrderDetail_ID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(782, 582);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(144, 60);
            this.btn_Them.TabIndex = 44;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đơn hàng chi tiết : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.panel_SoLuongSanPham);
            this.groupBox1.Controls.Add(this.panel_ProductID);
            this.groupBox1.Controls.Add(this.panel_Gia);
            this.groupBox1.Controls.Add(this.panel_Order_ID);
            this.groupBox1.Controls.Add(this.panel_OrderDetail_ID);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(782, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(528, 518);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bản ghi ";
            // 
            // panel_SoLuongSanPham
            // 
            this.panel_SoLuongSanPham.BackColor = System.Drawing.Color.White;
            this.panel_SoLuongSanPham.Controls.Add(this.txt_SoLuongSanPham);
            this.panel_SoLuongSanPham.Controls.Add(this.label4);
            this.panel_SoLuongSanPham.Location = new System.Drawing.Point(14, 319);
            this.panel_SoLuongSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_SoLuongSanPham.Name = "panel_SoLuongSanPham";
            this.panel_SoLuongSanPham.Size = new System.Drawing.Size(474, 58);
            this.panel_SoLuongSanPham.TabIndex = 22;
            // 
            // txt_SoLuongSanPham
            // 
            this.txt_SoLuongSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SoLuongSanPham.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuongSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_SoLuongSanPham.Location = new System.Drawing.Point(250, 9);
            this.txt_SoLuongSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SoLuongSanPham.Name = "txt_SoLuongSanPham";
            this.txt_SoLuongSanPham.Size = new System.Drawing.Size(220, 38);
            this.txt_SoLuongSanPham.TabIndex = 1;
            this.txt_SoLuongSanPham.Click += new System.EventHandler(this.txt_SoLuongSanPham_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Số lượng sản phẩm :";
            // 
            // panel_ProductID
            // 
            this.panel_ProductID.BackColor = System.Drawing.Color.White;
            this.panel_ProductID.Controls.Add(this.txt_ProductID);
            this.panel_ProductID.Controls.Add(this.label3);
            this.panel_ProductID.Location = new System.Drawing.Point(14, 229);
            this.panel_ProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_ProductID.Name = "panel_ProductID";
            this.panel_ProductID.Size = new System.Drawing.Size(474, 58);
            this.panel_ProductID.TabIndex = 22;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ProductID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_ProductID.Location = new System.Drawing.Point(168, 9);
            this.txt_ProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(303, 38);
            this.txt_ProductID.TabIndex = 1;
            this.txt_ProductID.Click += new System.EventHandler(this.txt_ProductID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Product_ID :";
            // 
            // panel_Gia
            // 
            this.panel_Gia.BackColor = System.Drawing.Color.White;
            this.panel_Gia.Controls.Add(this.txt_Gia);
            this.panel_Gia.Controls.Add(this.label5);
            this.panel_Gia.Location = new System.Drawing.Point(14, 409);
            this.panel_Gia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Gia.Name = "panel_Gia";
            this.panel_Gia.Size = new System.Drawing.Size(474, 58);
            this.panel_Gia.TabIndex = 22;
            // 
            // txt_Gia
            // 
            this.txt_Gia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Gia.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_Gia.Location = new System.Drawing.Point(126, 9);
            this.txt_Gia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(344, 38);
            this.txt_Gia.TabIndex = 1;
            this.txt_Gia.Click += new System.EventHandler(this.txt_Gia_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Giá :";
            // 
            // panel_Order_ID
            // 
            this.panel_Order_ID.BackColor = System.Drawing.Color.White;
            this.panel_Order_ID.Controls.Add(this.txt_Order_ID);
            this.panel_Order_ID.Controls.Add(this.label2);
            this.panel_Order_ID.Location = new System.Drawing.Point(14, 139);
            this.panel_Order_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Order_ID.Name = "panel_Order_ID";
            this.panel_Order_ID.Size = new System.Drawing.Size(474, 58);
            this.panel_Order_ID.TabIndex = 22;
            // 
            // txt_Order_ID
            // 
            this.txt_Order_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Order_ID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Order_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_Order_ID.Location = new System.Drawing.Point(161, 8);
            this.txt_Order_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Order_ID.Name = "txt_Order_ID";
            this.txt_Order_ID.Size = new System.Drawing.Size(309, 38);
            this.txt_Order_ID.TabIndex = 1;
            this.txt_Order_ID.Click += new System.EventHandler(this.txt_Order_ID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Order_ID : ";
            // 
            // panel_OrderDetail_ID
            // 
            this.panel_OrderDetail_ID.BackColor = System.Drawing.Color.White;
            this.panel_OrderDetail_ID.Controls.Add(this.txt_OrderDetail_ID);
            this.panel_OrderDetail_ID.Controls.Add(this.label7);
            this.panel_OrderDetail_ID.Location = new System.Drawing.Point(14, 49);
            this.panel_OrderDetail_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_OrderDetail_ID.Name = "panel_OrderDetail_ID";
            this.panel_OrderDetail_ID.Size = new System.Drawing.Size(474, 58);
            this.panel_OrderDetail_ID.TabIndex = 21;
            // 
            // txt_OrderDetail_ID
            // 
            this.txt_OrderDetail_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_OrderDetail_ID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OrderDetail_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_OrderDetail_ID.Location = new System.Drawing.Point(208, 9);
            this.txt_OrderDetail_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_OrderDetail_ID.Name = "txt_OrderDetail_ID";
            this.txt_OrderDetail_ID.Size = new System.Drawing.Size(262, 38);
            this.txt_OrderDetail_ID.TabIndex = 1;
            this.txt_OrderDetail_ID.Click += new System.EventHandler(this.txt_OrderDetail_ID_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 32);
            this.label7.TabIndex = 20;
            this.label7.Text = "OrderDetail_ID :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 109);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(710, 444);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 636);
            this.panel1.TabIndex = 42;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.Transparent;
            this.btn_export.Image = global::QuanLyKhoVan.Properties.Resources.excel;
            this.btn_export.Location = new System.Drawing.Point(1216, 583);
            this.btn_export.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(54, 60);
            this.btn_export.TabIndex = 58;
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = global::QuanLyKhoVan.Properties.Resources.ic_delete;
            this.btn_Xoa.Location = new System.Drawing.Point(1143, 582);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(54, 60);
            this.btn_Xoa.TabIndex = 56;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Image = global::QuanLyKhoVan.Properties.Resources.ic_edit;
            this.btn_Sua.Location = new System.Drawing.Point(1069, 583);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(54, 60);
            this.btn_Sua.TabIndex = 57;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // Form_OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 679);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_OrderDetails";
            this.Text = "Form_OrderDetails";
            this.Load += new System.EventHandler(this.Form_OrderDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel_SoLuongSanPham.ResumeLayout(false);
            this.panel_SoLuongSanPham.PerformLayout();
            this.panel_ProductID.ResumeLayout(false);
            this.panel_ProductID.PerformLayout();
            this.panel_Gia.ResumeLayout(false);
            this.panel_Gia.PerformLayout();
            this.panel_Order_ID.ResumeLayout(false);
            this.panel_Order_ID.PerformLayout();
            this.panel_OrderDetail_ID.ResumeLayout(false);
            this.panel_OrderDetail_ID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_SoLuongSanPham;
        private System.Windows.Forms.TextBox txt_SoLuongSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_ProductID;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_Gia;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_Order_ID;
        private System.Windows.Forms.TextBox txt_Order_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_OrderDetail_ID;
        private System.Windows.Forms.TextBox txt_OrderDetail_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
    }
}