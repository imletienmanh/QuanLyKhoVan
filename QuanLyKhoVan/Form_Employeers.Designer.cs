namespace QuanLyKhoVan
{
    partial class Form_Employeers
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
            this.txt_TenNhanVien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_TenNhanVien = new System.Windows.Forms.Panel();
            this.txt_EmployeeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_EmployeeID = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.panel_SDT = new System.Windows.Forms.Panel();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_TenNhanVien.SuspendLayout();
            this.panel_EmployeeID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel_SDT.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TenNhanVien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_TenNhanVien.Location = new System.Drawing.Point(188, 9);
            this.txt_TenNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Size = new System.Drawing.Size(282, 38);
            this.txt_TenNhanVien.TabIndex = 1;
            this.txt_TenNhanVien.Click += new System.EventHandler(this.txt_TenNhanVien_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 32);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tên nhân viên : ";
            // 
            // panel_TenNhanVien
            // 
            this.panel_TenNhanVien.BackColor = System.Drawing.Color.White;
            this.panel_TenNhanVien.Controls.Add(this.txt_TenNhanVien);
            this.panel_TenNhanVien.Controls.Add(this.label7);
            this.panel_TenNhanVien.Location = new System.Drawing.Point(10, 106);
            this.panel_TenNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_TenNhanVien.Name = "panel_TenNhanVien";
            this.panel_TenNhanVien.Size = new System.Drawing.Size(474, 58);
            this.panel_TenNhanVien.TabIndex = 21;
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_EmployeeID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmployeeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_EmployeeID.Location = new System.Drawing.Point(188, 8);
            this.txt_EmployeeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.Size = new System.Drawing.Size(282, 38);
            this.txt_EmployeeID.TabIndex = 1;
            this.txt_EmployeeID.Click += new System.EventHandler(this.txt_EmployeeID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Employee_ID :";
            // 
            // panel_EmployeeID
            // 
            this.panel_EmployeeID.BackColor = System.Drawing.Color.White;
            this.panel_EmployeeID.Controls.Add(this.txt_EmployeeID);
            this.panel_EmployeeID.Controls.Add(this.label2);
            this.panel_EmployeeID.Location = new System.Drawing.Point(10, 36);
            this.panel_EmployeeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_EmployeeID.Name = "panel_EmployeeID";
            this.panel_EmployeeID.Size = new System.Drawing.Size(474, 58);
            this.panel_EmployeeID.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 368);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.txt_SDT.Location = new System.Drawing.Point(93, 9);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(377, 38);
            this.txt_SDT.TabIndex = 1;
            this.txt_SDT.Click += new System.EventHandler(this.txt_SDT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "SDT :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn_export);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.panel_SDT);
            this.groupBox1.Controls.Add(this.panel_EmployeeID);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.panel_TenNhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(758, 262);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bản ghi ";
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.Transparent;
            this.btn_export.Image = global::QuanLyKhoVan.Properties.Resources.excel;
            this.btn_export.Location = new System.Drawing.Point(679, 144);
            this.btn_export.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(54, 60);
            this.btn_export.TabIndex = 55;
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
            this.btn_Xoa.Location = new System.Drawing.Point(607, 143);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(54, 60);
            this.btn_Xoa.TabIndex = 53;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Image = global::QuanLyKhoVan.Properties.Resources.ic_edit;
            this.btn_Sua.Location = new System.Drawing.Point(532, 144);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(54, 60);
            this.btn_Sua.TabIndex = 54;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // panel_SDT
            // 
            this.panel_SDT.BackColor = System.Drawing.Color.White;
            this.panel_SDT.Controls.Add(this.txt_SDT);
            this.panel_SDT.Controls.Add(this.label3);
            this.panel_SDT.Location = new System.Drawing.Point(10, 176);
            this.panel_SDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_SDT.Name = "panel_SDT";
            this.panel_SDT.Size = new System.Drawing.Size(474, 58);
            this.panel_SDT.TabIndex = 22;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(563, 48);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(144, 60);
            this.btn_Them.TabIndex = 49;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(27, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách nhân viên : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 799);
            this.panel1.TabIndex = 47;
            // 
            // Form_Employeers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 772);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Employeers";
            this.Text = "Form_Employees";
            this.Load += new System.EventHandler(this.Form_Employees_Load);
            this.panel_TenNhanVien.ResumeLayout(false);
            this.panel_TenNhanVien.PerformLayout();
            this.panel_EmployeeID.ResumeLayout(false);
            this.panel_EmployeeID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel_SDT.ResumeLayout(false);
            this.panel_SDT.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_TenNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_TenNhanVien;
        private System.Windows.Forms.TextBox txt_EmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_EmployeeID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_SDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
    }
}