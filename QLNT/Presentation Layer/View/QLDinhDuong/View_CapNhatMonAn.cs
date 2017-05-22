﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLNT.Entities;
using QLNT.BusinessLayer;
using QLNT.DataLayer;

namespace QLNT.Presentation_Layer.View.QLDinhDuong
{
    public partial class View_CapNhatMonAn : UserControl
    {
        public View_CapNhatMonAn()
        {
            InitializeComponent();
        }

        private void View_CapNhatMonAn_Load(object sender, EventArgs e)
        {
            getDataGridViewMonAn();
            getDataGridViewNguyenLieuTungMon("");
            getCombobox();
            setTextInfo();
        }

        private void getDataGridViewNguyenLieuTungMon(string maMon)
        {

            dgvNguyenLieuTungMon.DataSource = NguyenLieuTungMonBLL.LayDanhSachNLTungMon(maMon);

            string[] column = {"TenNguyenLieu", "SoLuong","DonViTinh", "ChiSoDinhDuong"};
            Utility.ControlFormat.DataGridViewFormat(dgvNguyenLieuTungMon, column);

            //dgvDanhSachMuaNL.ColumnCount.ToString();
            //MessageBox.Show(dgvDanhSachMuaNL.ColumnCount.ToString());

            dgvNguyenLieuTungMon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNguyenLieuTungMon.Columns[0].HeaderText = "Tên Nguyên Liệu";
            dgvNguyenLieuTungMon.Columns[0].Width = 140;
            dgvNguyenLieuTungMon.Columns[1].HeaderText = "Số/khối lượng";
            dgvNguyenLieuTungMon.Columns[1].Width = 110;
            dgvNguyenLieuTungMon.Columns[2].HeaderText = "Đơn vị tính";
            dgvNguyenLieuTungMon.Columns[2].Width = 90;
            dgvNguyenLieuTungMon.Columns[3].HeaderText = "Chỉ số dinh dưỡng";
            dgvNguyenLieuTungMon.Columns[3].Width = 120;
            dgvNguyenLieuTungMon.ClearSelection();
            XoaTrang();
        }

        private void getDataGridViewMonAn()
        {
            dgvMonAn.DataSource = MonAnBLL.LayDanhSachMonAn();

            string[] column = { "MaMonAn", "TenMonAn" };
            Utility.ControlFormat.DataGridViewFormat(dgvMonAn, column);
            dgvMonAn.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMonAn.Columns[0].HeaderText = "Mã món ăn";
            dgvMonAn.Columns[0].Width = 160;
            dgvMonAn.Columns[1].HeaderText = "Tên món ăn";
            dgvMonAn.Columns[1].Width = 300;

            dgvMonAn.ClearSelection();
            dgvMonAn.CurrentCell = null;
        }

        private void getCombobox()
        {
            cboChonNguyenLieu.DataSource = NguyenLieuBLL.LayDanhSachTenVaMaNguyenLieu();
            cboChonNguyenLieu.DisplayMember = "TenNguyenLieu";
            cboChonNguyenLieu.ValueMember = "MaNguyenLieu";
            cboChonNguyenLieu.Text = "";
        }

        private void XoaTrang()
        {
            txtDonViTinh.Text = "";
            txtCSDD.Text = "0";
            txtSoLuong.Text = "0";
            cboChonNguyenLieu.Text = "";

        }

        private void setTextInfo()
        {
            txtDonViTinh.Text = "";
            txtMaMonAn.Text = "";
            txtCSDD.Text = "";

            txtSoLuong.Text = "";
            txtTenMonAn.Text = "";
            cboChonNguyenLieu.Text = "";
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex < 0) || (e.RowIndex > dgvMonAn.RowCount))
            {
                return;
            }

            txtMaMonAn.Text = dgvMonAn.Rows[e.RowIndex].Cells["MaMonAn"].Value.ToString();
            txtTenMonAn.Text = dgvMonAn.Rows[e.RowIndex].Cells["TenMonAn"].Value.ToString();
            getDataGridViewNguyenLieuTungMon(txtMaMonAn.Text);
        }

        private void dgvNguyenLieuTungMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex < 0) || (e.RowIndex > dgvNguyenLieuTungMon.RowCount))
            {
                XoaTrang();
                return;
            }

            cboChonNguyenLieu.Text = dgvNguyenLieuTungMon.Rows[e.RowIndex].Cells["TenNguyenLieu"].Value.ToString();
            if (cboChonNguyenLieu.Text == "")
                return;

            cboChonNguyenLieu.Enabled = false;
            txtSoLuong.Text = dgvNguyenLieuTungMon.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            txtDonViTinh.Text = dgvNguyenLieuTungMon.Rows[e.RowIndex].Cells["DonViTinh"].Value.ToString();
            txtCSDD.Text = dgvNguyenLieuTungMon.Rows[e.RowIndex].Cells["ChiSoDinhDuong"].Value.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            getCombobox();
        }

        

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            if(txtMaMonAn.Text=="")
            {
                MessageBox.Show("Vui lòng bấm 'Làm mới' để lấy mã món ăn mới", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            MonAn monan = new MonAn();
            monan.MaMonAn = txtMaMonAn.Text;
            monan.TenMonAn = txtTenMonAn.Text;
            MonAnBLL.ThemMonAn(monan);
            getDataGridViewMonAn();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaMonAn.Text = MonAnBLL.SinhMaTuDong();
            txtTenMonAn.Text = "";
            
        }

        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            if (txtMaMonAn.Text == "")
            {
                MessageBox.Show("Vui lòng nhấn chọn món ăn cần xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            MonAnBLL.XoaMonAn(txtMaMonAn.Text.Trim());
            getDataGridViewMonAn();
            getDataGridViewNguyenLieuTungMon("");
            setTextInfo();
        }
    }
}
