using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNT.BusinessLayer;
using QLNT.Utility;
using QLNT.Entities;

namespace QLNT.Presentation_Layer.View.QLHoatDong
{
    public partial class View_HoatDongNgoaiKhoa : UserControl
    {
        private string maHD = "";

        public View_HoatDongNgoaiKhoa()
        {
            InitializeComponent();
        }

        private void View_HoatDongNgoaiKhoa_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgvListHoatDong.DataSource = HoatDongNgoaiKhoaBLL.GetListHoatDong();
            string[] listProp = { "MaHoatDong", "TenHoatDong", "NgayBatDau", "NgayKetThuc" };
            ControlFormat.DataGridViewFormat(dgvListHoatDong, listProp);
        }

        private void dgvListHoatDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maHD = dgvListHoatDong.Rows[e.RowIndex].Cells["MaHoatDong"].Value.ToString();
            txtMaHoatDong.Text = maHD;
            txtTenHoatDong.Text = dgvListHoatDong.Rows[e.RowIndex].Cells["TenHoatDong"].Value.ToString();
            dtNgayBatDau.Text = dgvListHoatDong.Rows[e.RowIndex].Cells["NgayBatDau"].Value.ToString();
            dtNgayKetThuc.Text = dgvListHoatDong.Rows[e.RowIndex].Cells["NgayKetThuc"].Value.ToString();
            txtChiPhi.Text = dgvListHoatDong.Rows[e.RowIndex].Cells["ChiPhi"].Value.ToString();
            txtKeHoach.Text = dgvListHoatDong.Rows[e.RowIndex].Cells["KeHoach"].Value.ToString();
        }

        private void btnDSLopThamGia_Click(object sender, EventArgs e)
        {
            if (maHD != "")
            {
                //goi form danh sach lop tham gia hoat dong
                frmMain parentForm = (this.Parent.Parent as frmMain);
                parentForm.UpdateSubView("DanhSachLopThamGiaHoatDong");
                View_DanhSachLopThamGiaHoatDong view_DSLop = parentForm.GetSubView("DanhSachLopThamGiaHoatDong") as View_DanhSachLopThamGiaHoatDong;
                view_DSLop.SetMaHD(maHD);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một hoạt động để xem thông tin lớp tham gia", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaHoatDong.Text = "";
            txtTenHoatDong.Text = "";
            dtNgayBatDau.Text = "";
            dtNgayKetThuc.Text = "";
            txtChiPhi.Text = "";
            txtKeHoach.Text = "";

            // auto generate MaHoatDong here
            //txtMaHoatDong.Text = ;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //luu hoat dong
            HoatDongNgoaiKhoa hoatDong = new HoatDongNgoaiKhoa();
            hoatDong.MaHoatDong = txtMaHoatDong.Text;
            hoatDong.TenHoatDong = txtTenHoatDong.Text;
            hoatDong.NgayBatDau = dtNgayBatDau.Value;
            hoatDong.NgayKetThuc = dtNgayKetThuc.Value;
            hoatDong.KeHoach = txtKeHoach.Text;
            hoatDong.ChiPhi = decimal.Parse(txtChiPhi.Text);

            HoatDongNgoaiKhoaBLL.LuuHoatDong(hoatDong);
        }
    }
}
