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
    public partial class Form_Products : Form
    {
        public Form_Products()
        {
            InitializeComponent();
            
        }

        #region Xu li UI

        private void txt_ProductID_Click(object sender, EventArgs e)
        {
            txt_ProductID.BackColor = Color.White;
            panel_ProductID.BackColor = Color.White;
            txt_Mota.BackColor = SystemColors.Control;
            panel_MoTa.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
            txt_SoLuong.BackColor = SystemColors.Control;
            panel_SoLuong.BackColor = SystemColors.Control;
            txt_TenSanPham.BackColor = SystemColors.Control;
            panel_TenSanPham.BackColor = SystemColors.Control;
            txt_CategoryID.BackColor = SystemColors.Control;
            panel_CategoryID.BackColor = SystemColors.Control;  
           
        }

        private void txt_TenSanPham_Click(object sender, EventArgs e)
        {
            txt_ProductID.BackColor = SystemColors.Control;
            panel_ProductID.BackColor = SystemColors.Control;
            txt_Mota.BackColor = SystemColors.Control;
            panel_MoTa.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
            txt_SoLuong.BackColor = SystemColors.Control;
            panel_SoLuong.BackColor = SystemColors.Control;
            txt_TenSanPham.BackColor = Color.White;
            panel_TenSanPham.BackColor = Color.White;
            txt_CategoryID.BackColor = SystemColors.Control;
            panel_CategoryID.BackColor = SystemColors.Control;
        }

        private void txt_Mota_Click(object sender, EventArgs e)
        {
            txt_ProductID.BackColor = SystemColors.Control;
            panel_ProductID.BackColor = SystemColors.Control;
            txt_Mota.BackColor = Color.White;
            panel_MoTa.BackColor = Color.White;
            txt_Gia.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
            txt_SoLuong.BackColor = SystemColors.Control;
            panel_SoLuong.BackColor = SystemColors.Control;
            txt_TenSanPham.BackColor = SystemColors.Control;
            panel_TenSanPham.BackColor = SystemColors.Control;
            txt_CategoryID.BackColor = SystemColors.Control;
            panel_CategoryID.BackColor = SystemColors.Control;
        }

        private void txt_Gia_Click(object sender, EventArgs e)
        {
            txt_ProductID.BackColor = SystemColors.Control;
            panel_ProductID.BackColor = SystemColors.Control;
            txt_Mota.BackColor = SystemColors.Control;
            panel_MoTa.BackColor = SystemColors.Control;
            txt_Gia.BackColor = Color.White;
            panel_Gia.BackColor = Color.White;
            txt_SoLuong.BackColor = SystemColors.Control;
            panel_SoLuong.BackColor = SystemColors.Control;
            txt_TenSanPham.BackColor = SystemColors.Control;
            panel_TenSanPham.BackColor = SystemColors.Control;
            txt_CategoryID.BackColor = SystemColors.Control;
            panel_CategoryID.BackColor = SystemColors.Control;
        }

        private void txt_SoLuong_Click(object sender, EventArgs e)
        {
            txt_ProductID.BackColor = SystemColors.Control;
            panel_ProductID.BackColor = SystemColors.Control;
            txt_Mota.BackColor = SystemColors.Control;
            panel_MoTa.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
            txt_SoLuong.BackColor = Color.White;
            panel_SoLuong.BackColor = Color.White;
            txt_TenSanPham.BackColor = SystemColors.Control;
            panel_TenSanPham.BackColor = SystemColors.Control;
            txt_CategoryID.BackColor = SystemColors.Control;
            panel_CategoryID.BackColor = SystemColors.Control;
        }

        private void txt_CategoryID_Click(object sender, EventArgs e)
        {
            txt_ProductID.BackColor = SystemColors.Control;
            panel_ProductID.BackColor = SystemColors.Control;
            txt_Mota.BackColor = SystemColors.Control;
            panel_MoTa.BackColor = SystemColors.Control;
            txt_Gia.BackColor = SystemColors.Control;
            panel_Gia.BackColor = SystemColors.Control;
            txt_SoLuong.BackColor = SystemColors.Control;
            panel_SoLuong.BackColor = SystemColors.Control;
            txt_TenSanPham.BackColor = SystemColors.Control;
            panel_TenSanPham.BackColor = SystemColors.Control;
            txt_CategoryID.BackColor = Color.White;
            panel_CategoryID.BackColor = Color.White;
        }
        #endregion

        QuanLyKhoVan db = new QuanLyKhoVan();

        #region Method
        
        void LoadDataProduct()
        {
            var data = db.Products.Select(s => new
            {
                ProductID = s.Product_ID,
                TenSanPham = s.TenSanPham,
                MoTa = s.MoTa,
                Gia = s.Gia,
                SoLuong = s.SoLuong,
                CategoryID = s.Category_ID,

            }).ToList();
            dataGridView1.DataSource = data;
            
        }
        void AddProduct()
        {
            if(txt_ProductID.Text == "" || txt_TenSanPham.Text == "" || txt_Mota.Text == "" || txt_Gia.Text == "" || txt_SoLuong.Text == "" || txt_CategoryID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                Products product = new Products();
                product.Product_ID = int.Parse(txt_ProductID.Text);
                product.TenSanPham = txt_TenSanPham.Text;
                product.MoTa = txt_Mota.Text;
                product.Gia = int.Parse(txt_Gia.Text);
                product.SoLuong = int.Parse(txt_SoLuong.Text);
                product.Category_ID = int.Parse(txt_CategoryID.Text);
                db.Products.Add(product);
                db.SaveChanges();
                LoadDataProduct();
                ClearTextBox();
            }   
        }
        void UpdateProduct()
        {
            if (txt_ProductID.Text == "" || txt_TenSanPham.Text == "" || txt_Mota.Text == "" || txt_Gia.Text == "" || txt_SoLuong.Text == "" || txt_CategoryID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                int id = int.Parse(txt_ProductID.Text);
                Products product = db.Products.Where(s => s.Product_ID == id).FirstOrDefault();
                product.TenSanPham = txt_TenSanPham.Text;
                product.MoTa = txt_Mota.Text;
                product.Gia = int.Parse(txt_Gia.Text);
                product.SoLuong = int.Parse(txt_SoLuong.Text);
                product.Category_ID = int.Parse(txt_CategoryID.Text);
                db.SaveChanges();
                LoadDataProduct();
                ClearTextBox();
            }
        }   

        void DeleteProduct ()
        {
            if (txt_ProductID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
            }
            else
            {
                int id = int.Parse(txt_ProductID.Text);
                Products product = db.Products.Where(s => s.Product_ID == id).FirstOrDefault();
                db.Products.Remove(product);
                db.SaveChanges();
                LoadDataProduct();
                ClearTextBox();
            }
        }
        void ClearTextBox()
        {
            txt_CategoryID.Text = "";
            txt_Gia.Text = "";
            txt_Mota.Text = "";
            txt_SoLuong.Text = "";
            txt_TenSanPham.Text = "";
            txt_ProductID.Text = "";
               
        }
        #endregion



        private void Form_Products_Load(object sender, EventArgs e)
        {
            LoadDataProduct();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_ProductID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa");
            }
            else
            {
                try
                {
                    UpdateProduct();
                    MessageBox.Show("Sửa sản phẩm thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Sửa sản phẩm thất bại " + ex);
                }
             
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteProduct();
                MessageBox.Show("Xóa sản phẩm thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa sản phẩm thất bại " + ex);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_ProductID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_TenSanPham.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Mota.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_Gia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_SoLuong.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_CategoryID.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                AddProduct();
                MessageBox.Show("Thêm sản phẩm thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm sản phẩm thất bại" + ex);
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
