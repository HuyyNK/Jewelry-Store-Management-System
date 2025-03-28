﻿using ClosedXML.Excel;
using QLCHVBDQ.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHVBDQ
{
    public partial class fNhanVien : Form
    {
        public fNhanVien()
        {
            InitializeComponent();
            LoadNV();
        }

        void LoadNV()
        {

            textUserName.Text = fLogin.userName;
            dtgvQL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvQL.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            string query = "select Email as 'Email',HoTen as 'Họ và tên', SDT as N'Số điện thoại', NgaySinh as N'Ngày sinh', GioiTinh as N'Giới tính', LoaiNguoiDung as N'Loại nhân viên'  from NGUOIDUNG where LoaiNguoiDung = 1 or LoaiNguoiDung = 2";
            dtgvQL.DataSource = DataProvider.Instance.ExecuteQuery(query);
            if (dtgvQL.Columns.Count != 7)
            {
                DataGridViewImageColumn IconCol = new DataGridViewImageColumn();
                dtgvQL.Columns.Add(IconCol);
                IconCol.Image = Properties.Resources.Trash_Full;
                foreach (DataGridViewColumn item in dtgvQL.Columns)
                {
                    item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                dtgvQL.Columns[dtgvQL.Columns.Count - 1].Width = 40;
            }

            dtgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            query = "select Email as 'Email',HoTen as 'Họ và tên', SDT as N'Số điện thoại', NgaySinh as N'Ngày sinh', GioiTinh as N'Giới tính', LoaiNguoiDung as N'Loại nhân viên'  from NGUOIDUNG where LoaiNguoiDung = 0";
            dtgvNV.DataSource = DataProvider.Instance.ExecuteQuery(query);
            if (dtgvNV.Columns.Count < 7)
            {
                DataGridViewImageColumn UpCol = new DataGridViewImageColumn();
                dtgvNV.Columns.Add(UpCol);
                UpCol.Image = Properties.Resources.Arrow_Up_LG;
                DataGridViewImageColumn IconCol = new DataGridViewImageColumn();
                dtgvNV.Columns.Add(IconCol);
                IconCol.Image = Properties.Resources.Trash_Full;
                foreach (DataGridViewColumn item in dtgvNV.Columns)
                {
                    item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                dtgvNV.Columns[6].Width = 40;
                dtgvNV.Columns[1].Width = 40;
            }
        }

        private void btnDeletesNV_Click(object sender, EventArgs e)
        {
            int count = dtgvNV.SelectedRows.Count;
            if (count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa các nhân viên đã chọn", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    int data = 0;
                    for (int i = 0; i < count; i++)
                    {
                        int rowIndex = dtgvNV.SelectedRows[i].Index;
                        int colIndex = 1;
                        string Email = dtgvNV.Rows[rowIndex].Cells[colIndex].Value.ToString();
                        int temp = AccountDAO.Instance.Delete_NV(Email);
                        if (temp == 1) data = data + 1;
                    }
                    string query = "select Email as 'Email',HoTen as 'Họ và tên', SDT as N'Số điện thoại', NgaySinh as N'Ngày sinh', GioiTinh as N'Giới tính', LoaiNguoiDung as N'Loại nhân viên'  from NGUOIDUNG where LoaiNguoiDung = 0";
                    dtgvNV.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    MessageBox.Show(String.Format("{0} nhân viên đã được xóa", data), "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void dtgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string s = e.ColumnIndex.ToString();
            //MessageBox.Show("Bạn đang chọn cột" + s);
            if (e.ColumnIndex == 1)
            {
                int rowIndex = e.RowIndex;
                string Email = dtgvNV.Rows[rowIndex].Cells[2].Value.ToString();
                if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên đã chọn", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    int data = AccountDAO.Instance.Delete_NV(Email);
                    if (data != -1)
                    {
                        string query = "select Email as 'Email',HoTen as 'Họ và tên', SDT as N'Số điện thoại', NgaySinh as N'Ngày sinh', GioiTinh as N'Giới tính', LoaiNguoiDung as N'Loại nhân viên'  from NGUOIDUNG where LoaiNguoiDung = 0";
                        dtgvNV.DataSource = DataProvider.Instance.ExecuteQuery(query);
                        MessageBox.Show(String.Format("Nhân viên đã được xóa"), "Thông báo", MessageBoxButtons.OK);
                    }
                    else MessageBox.Show("Xóa nhân viên không thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else if (e.ColumnIndex == 0)
            {
                int rowIndex = e.RowIndex;
                string Email = dtgvNV.Rows[rowIndex].Cells[2].Value.ToString();
                if (MessageBox.Show("Cấp quyền quản lý cho nhân viên đã chọn", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    string query = String.Format("UPDATE NGUOIDUNG SET LoaiNguoiDung = 1 WHERE Email = '{0}'", Email);
                    int data = DataProvider.Instance.ExecuteNonQuery(query);
                    if (data != -1)
                    {
                        LoadNV();
                        MessageBox.Show(String.Format("Cấp quyền thành công"), "Thông báo", MessageBoxButtons.OK);
                    }
                    else MessageBox.Show("Cấp quyền không thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        public static int flag = 0;
        private void dtgvQL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string s = e.ColumnIndex.ToString();
            //MessageBox.Show("Bạn đang chọn cột" + s);
            if (e.ColumnIndex == 0)
            {
                int rowIndex = e.RowIndex;
                string Email = dtgvQL.Rows[rowIndex].Cells[1].Value.ToString();
                if (Email != fLogin.userEmail && fLogin.userType != "2") MessageBox.Show("Bạn không có quyền xóa quản lý này", "Thông báo", MessageBoxButtons.OK);
                else if (Email == fLogin.userEmail)
                {
                    if (MessageBox.Show("Bạn có thật sự muốn xóa tài khoản quản lý của bạn", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        int data = AccountDAO.Instance.Delete_NV(Email);
                        if (data != -1)
                        {  
                            MessageBox.Show(String.Format("Tài khoản đã được xóa"), "Thông báo", MessageBoxButtons.OK);
                            this.Close();
                            flag = 1;
                        }
                        else MessageBox.Show("Xóa tài khoản không thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn có thật sự muốn xóa tài khoản quản lý này", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        int data = AccountDAO.Instance.Delete_NV(Email);
                        if (data != -1)
                        {
                            string query = "select Email as 'Email',HoTen as 'Họ và tên', SDT as N'Số điện thoại', NgaySinh as N'Ngày sinh', GioiTinh as N'Giới tính', LoaiNguoiDung as N'Loại nhân viên'  from NGUOIDUNG where LoaiNguoiDung = 1 or LoaiNguoiDung = 2";
                            dtgvQL.DataSource = DataProvider.Instance.ExecuteQuery(query);
                            MessageBox.Show(String.Format("Tài khoản đã được xóa"), "Thông báo", MessageBoxButtons.OK);
                        }
                        else MessageBox.Show("Xóa tài khoản không thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }

                
            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            fCaiDat f = new fCaiDat();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnTLTT_Click(object sender, EventArgs e)
        {
            fTLTT f = new fTLTT();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnDVT_Click(object sender, EventArgs e)
        {
            fDVT f = new fDVT();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnXuatExcelQL_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Save an Excel File";
            saveFileDialog.FileName = "BangQuanLy.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                DataTable dataTable = GetDataTableFromDataGridView(dtgvQL); // Hàm lấy dữ liệu từ DataGridView
                ExportToExcel(dataTable, filePath, "Quan ly");
            }

        }

        private void btnXuatExcelNV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Save an Excel File";
            saveFileDialog.FileName = "BangNhanVien.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                DataTable dataTable = GetDataTableFromDataGridView(dtgvNV); // Hàm lấy dữ liệu từ DataGridView
                ExportToExcel(dataTable, filePath, "Nhan vien");
            }
        }

        public void ExportToExcel(DataTable dataTable, string filePath, string sheetName)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(dataTable, sheetName);
                workbook.SaveAs(filePath);
            }
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }


        private DataTable GetDataTableFromDataGridView(DataGridView dgv)
        {
            var dt = new DataTable();
            for (int colIndex = 1; colIndex < dgv.Columns.Count; colIndex++)
            {
                DataGridViewColumn column = dgv.Columns[colIndex];
                dt.Columns.Add(column.HeaderText);
            }
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dataRow = dt.NewRow();
                    for (int colIndex = 1; colIndex < dgv.Columns.Count; colIndex++)
                    {
                        DataGridViewColumn column = dgv.Columns[colIndex];
                        object columnValue = row.Cells[colIndex].Value;

                        if (column.HeaderText == "Ngày sinh")
                        {
                            columnValue = Convert.ToDateTime(columnValue).ToString("dd/MM/yyyy");
                        } else if (column.HeaderText == "Giới tính")
                        {
                            if (columnValue.ToString() == "True")
                                columnValue = "Nữ";
                            else
                                columnValue = "Nam";
                        }
                        dataRow[colIndex - 1] = columnValue;
                    }
                    dt.Rows.Add(dataRow);
                }
            }
            return dt;
        }

        private void dtgvQL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TrangChu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardTrangChu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoaiNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {

        }

        private void textDsQL_Click(object sender, EventArgs e)
        {

        }
    }
}
