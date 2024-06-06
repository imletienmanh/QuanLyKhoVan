﻿using System;
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
    public partial class Form_Warehouses : Form
    {
        public Form_Warehouses()
        {
            InitializeComponent();
        }
        #region Xu li UI

        private void txt_WarehouseID_Click(object sender, EventArgs e)
        {
            txt_WarehouseID.BackColor = Color.White;
            panel_WarehouseID.BackColor = Color.White;
            txt_DiaDiem.BackColor = SystemColors.Control;
            panel_DiaDiem.BackColor = SystemColors.Control;
        }

        private void txt_DiaDiem_Click(object sender, EventArgs e)
        {
            txt_WarehouseID.BackColor = SystemColors.Control;
            panel_WarehouseID.BackColor = SystemColors.Control;
            txt_DiaDiem.BackColor = Color.White;
            panel_DiaDiem.BackColor = Color.White;
        }
        #endregion

        QuanLyKhoVan db = new QuanLyKhoVan();

        #region Method

        void ClearTextBox()
        {
            txt_WarehouseID.Text = "";
            txt_DiaDiem.Text = "";
        }

        void LoadDataWarehouse()
        {
            var data = from p in db.Warehouses
                       select new
                       {
                           WarehouseID = p.Warehouse_ID,
                           DiaDiem = p.DiaDiem
                       };
            dataGridView1.DataSource = data.ToList();
        }

        void AddWarehouse()
        {
            Warehouses warehouse = new Warehouses();
            warehouse.Warehouse_ID = int.Parse(txt_WarehouseID.Text);
            warehouse.DiaDiem = txt_DiaDiem.Text;
            db.Warehouses.Add(warehouse);
            db.SaveChanges();
            LoadDataWarehouse();
            ClearTextBox();
        }

        void UpdateWarehouse()
        {
            int id = int.Parse(txt_WarehouseID.Text);
            Warehouses warehouse = db.Warehouses.Where(p => p.Warehouse_ID == id).FirstOrDefault();
            warehouse.DiaDiem = txt_DiaDiem.Text;
            db.SaveChanges();
            LoadDataWarehouse();
            ClearTextBox();
        }

        void DeleteWarehouse()
        {
            int id = int.Parse(txt_WarehouseID.Text);
            Warehouses warehouse = db.Warehouses.Where(p => p.Warehouse_ID == id).FirstOrDefault();
            db.Warehouses.Remove(warehouse);
            db.SaveChanges();
            LoadDataWarehouse();
            ClearTextBox();
        }
        #endregion

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_WarehouseID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_DiaDiem.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void Form_Warehouses_Load(object sender, EventArgs e)
        {
            LoadDataWarehouse();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(txt_WarehouseID.Text == "" || txt_DiaDiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    AddWarehouse();
                    MessageBox.Show("Thêm kho thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thêm kho không thành công : " + ex.Message);
                }
                
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(txt_WarehouseID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa");
            }
            else
            {
                try
                {
                    UpdateWarehouse();
                    MessageBox.Show("Cập nhật kho thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Cập nhật kho không thành công : " + ex.Message);
                }
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_WarehouseID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xóa");
            }
            else
            {
                try
                {
                    DeleteWarehouse();
                    MessageBox.Show("Xóa kho thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Xóa kho không thành công : " + ex.Message);
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
