using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;


namespace QuanLyKhoVan
{
    public partial class Form_Customers : Form
    {
        public Form_Customers()
        {
            InitializeComponent();
            LoadDataCustomer();
        }
        #region Xu li UI
        private void txt_CustomerID_Click(object sender, EventArgs e)
        {
            txt_CustomerID.BackColor = Color.White;
            panel_CustomerID.BackColor = Color.White;
            txt_TenKhachHang.BackColor = SystemColors.Control;
            panel_TenKhachHang.BackColor = SystemColors.Control;
            txt_SDT.BackColor = SystemColors.Control;
            panel_SDT.BackColor = SystemColors.Control;
            txt_DiaChi.BackColor = SystemColors.Control;
            panel_DiaChi.BackColor = SystemColors.Control;

        }

        private void txt_TenKhachHang_Click(object sender, EventArgs e)
        {
            txt_TenKhachHang.BackColor = Color.White;
            panel_TenKhachHang.BackColor = Color.White;
            txt_CustomerID.BackColor = SystemColors.Control;
            panel_CustomerID.BackColor = SystemColors.Control;
            txt_SDT.BackColor = SystemColors.Control;
            panel_SDT.BackColor = SystemColors.Control;
            txt_DiaChi.BackColor = SystemColors.Control;
            panel_DiaChi.BackColor = SystemColors.Control;

        }

        private void txt_SDT_Click(object sender, EventArgs e)
        {
            txt_SDT.BackColor = Color.White;
            panel_SDT.BackColor = Color.White;
            txt_CustomerID.BackColor = SystemColors.Control;
            panel_CustomerID.BackColor = SystemColors.Control;
            txt_TenKhachHang.BackColor = SystemColors.Control;
            panel_TenKhachHang.BackColor = SystemColors.Control;
            txt_DiaChi.BackColor = SystemColors.Control;
            panel_DiaChi.BackColor = SystemColors.Control;

        }

        private void txt_DiaChi_Click(object sender, EventArgs e)
        {
            txt_DiaChi.BackColor = Color.White;
            panel_DiaChi.BackColor = Color.White;
            txt_CustomerID.BackColor = SystemColors.Control;
            panel_CustomerID.BackColor = SystemColors.Control;
            txt_TenKhachHang.BackColor = SystemColors.Control;
            panel_TenKhachHang.BackColor = SystemColors.Control;
            txt_SDT.BackColor = SystemColors.Control;
            panel_SDT.BackColor = SystemColors.Control;

        }
        #endregion

        QuanLyKhoVan db = new QuanLyKhoVan();

        #region Method 
        void LoadDataCustomer()
        {
            var data = from c in db.Customers
                       select new
                       {
                           c.Customer_ID,
                           c.TenKhachHang,
                           c.SDT,
                           c.DiaChi
                       };
            dataGridView1.DataSource = data.ToList();
        }
        void ClearTextBox()
        {
            txt_CustomerID.Text = "";
            txt_TenKhachHang.Text = "";
            txt_SDT.Text = "";
            txt_DiaChi.Text = "";
        }
        void AddCustomer()
        {
            Customers c = new Customers();
            c.Customer_ID = int.Parse(txt_CustomerID.Text);
            c.TenKhachHang = txt_TenKhachHang.Text;
            c.SDT = txt_SDT.Text;
            c.DiaChi = txt_DiaChi.Text;
            db.Customers.Add(c);
            db.SaveChanges();
            LoadDataCustomer();
            ClearTextBox();
        }

        void UpdateCustomer()
        {
            int id = int.Parse(txt_CustomerID.Text);
            Customers c = db.Customers.Where(s => s.Customer_ID == id).FirstOrDefault();
            c.TenKhachHang = txt_TenKhachHang.Text;
            c.SDT = txt_SDT.Text;
            c.DiaChi = txt_DiaChi.Text;
            db.SaveChanges();
            LoadDataCustomer();
            ClearTextBox();
        }

        void DeleteCustomer()
        {
            int id = int.Parse(txt_CustomerID.Text);
            Customers c = db.Customers.Where(s => s.Customer_ID == id).FirstOrDefault();
            db.Customers.Remove(c);
            db.SaveChanges();
            LoadDataCustomer();
            ClearTextBox();
        }
        #endregion

        private void Form_Customers_Load(object sender, EventArgs e)
        {
            LoadDataCustomer();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_CustomerID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_TenKhachHang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_SDT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_DiaChi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_CustomerID.Text == "" || txt_TenKhachHang.Text == "" || txt_SDT.Text == "" || txt_DiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    AddCustomer();
                    MessageBox.Show("Thêm Khách hàng thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm khách hàng thành công " + ex);
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_CustomerID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa");
            }
            else
            {
                try
                {
                    UpdateCustomer();
                    MessageBox.Show("Sửa khách hàng thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa khách hàng thất bại  " + ex);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_CustomerID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa");
            }
            else
            {
                try
                {
                    DeleteCustomer();
                    MessageBox.Show("Xóa khách hàng thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa khách hàng thất bại  " + ex);
                }
            }
        }



        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application(); application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                application.Cells[1, i + 1]
                =
                dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j
                =
                0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1]
                    =
                    dataGridView1.Rows[i].Cells[j].Value;
                }
                application.Columns.AutoFit();
                application.ActiveWorkbook.SaveCopyAs(path);
                application.ActiveWorkbook.Saved
                = true;
            }
        }

                private void btn_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx) | *.xlsx | Excel 2003 (*.xls) |*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
           
            }
        }
    }
}

