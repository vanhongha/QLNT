using System;
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
            dtNgayBatDau.Value = DateTime.Today;
            dtNgayKetThuc.Value = DateTime.Today;
        }

        private void LoadDataGridView()
        {
            dgvListHoatDong.DataSource = HoatDongNgoaiKhoaBLL.GetListHoatDong();
            string[] listProp = { "MaHoatDong", "TenHoatDong", "NgayBatDau", "NgayKetThuc" };
            dgvListHoatDong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ControlFormat.DataGridViewFormat(dgvListHoatDong, listProp);
            dgvListHoatDong.Columns["MaHoatDong"].HeaderText = "Mã hoạt động";
            dgvListHoatDong.Columns["TenHoatDong"].HeaderText = "Tên hoạt động";
            dgvListHoatDong.Columns["TenHoatDong"].Width = 120;
            dgvListHoatDong.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
            dgvListHoatDong.Columns["NgayKetThuc"].HeaderText = "Ngày kết thúc";
        }

        private void dgvListHoatDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                maHD = dgvListHoatDong.Rows[e.RowIndex].Cells["MaHoatDong"].Value.ToString();
                txtMaHoatDong.Text = maHD;
                txtTenHoatDong.Text = dgvListHoatDong.Rows[e.RowIndex].Cells["TenHoatDong"].Value.ToString();
                dtNgayBatDau.Value = DateTime.Parse(dgvListHoatDong.Rows[e.RowIndex].Cells["NgayBatDau"].Value.ToString());
                dtNgayKetThuc.Value = DateTime.Parse(dgvListHoatDong.Rows[e.RowIndex].Cells["NgayKetThuc"].Value.ToString());
                txtChiPhi.Text = dgvListHoatDong.Rows[e.RowIndex].Cells["ChiPhi"].Value.ToString();
                txtKeHoach.Text = dgvListHoatDong.Rows[e.RowIndex].Cells["KeHoach"].Value.ToString();
            }
        }

        private void btnDSLopThamGia_Click(object sender, EventArgs e)
        {
            if (maHD != "")
            {
                //goi form danh sach lop tham gia hoat dong
                frmMain parentForm = (this.Parent.Parent as frmMain);
                parentForm.UpdateSubView("DanhSachLopThamGiaHoatDong");
                View_DanhSachLopThamGiaHoatDong view = (View_DanhSachLopThamGiaHoatDong) parentForm.GetSubView("DanhSachLopThamGiaHoatDong");
                view.LoadForm();
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
            dtNgayBatDau.Value = DateTime.Today;
            dtNgayKetThuc.Value = DateTime.Today;
            txtChiPhi.Text = "";
            txtKeHoach.Text = "";

            // auto generate MaHoatDong here
            txtMaHoatDong.Text = HoatDongNgoaiKhoaBLL.AutoMaHoatDong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //luu hoat dong
            if(txtTenHoatDong.Text != "" && txtChiPhi.Text != "")
            {
                HoatDongNgoaiKhoa hoatDong = new HoatDongNgoaiKhoa();
                hoatDong.MaHoatDong = txtMaHoatDong.Text;
                hoatDong.TenHoatDong = txtTenHoatDong.Text;
                hoatDong.NgayBatDau = dtNgayBatDau.Value;
                hoatDong.NgayKetThuc = dtNgayKetThuc.Value;
                hoatDong.KeHoach = txtKeHoach.Text;
                hoatDong.ChiPhi = decimal.Parse(txtChiPhi.Text);
                if (HoatDongNgoaiKhoaBLL.LuuHoatDong(hoatDong))
                {
                    MessageBox.Show("Đã lưu hoạt động thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                    txtMaHoatDong.Clear();
                    txtTenHoatDong.Clear();
                    txtChiPhi.Clear();
                    txtKeHoach.Clear();
                    dtNgayBatDau.Value = DateTime.Today;
                    dtNgayKetThuc.Value = DateTime.Today;
                }
            }
            else
            {
                MessageBox.Show("Phải điền đầy đủ tất cả các trường thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetMaHD()
        {
            return maHD;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvListHoatDong.SelectedRows.Count > 0)
            {
                HoatDongNgoaiKhoa hoatDong = new HoatDongNgoaiKhoa();
                hoatDong.MaHoatDong = dgvListHoatDong.SelectedRows[0].Cells["MaHoatDong"].Value.ToString();
                hoatDong.TenHoatDong = dgvListHoatDong.SelectedRows[0].Cells["TenHoatDong"].Value.ToString();
                hoatDong.NgayBatDau = DateTime.Parse(dgvListHoatDong.SelectedRows[0].Cells["NgayBatDau"].Value.ToString());
                hoatDong.NgayKetThuc = DateTime.Parse(dgvListHoatDong.SelectedRows[0].Cells["NgayKetThuc"].Value.ToString());
                hoatDong.KeHoach = dgvListHoatDong.SelectedRows[0].Cells["KeHoach"].Value.ToString();
                hoatDong.ChiPhi = decimal.Parse(dgvListHoatDong.SelectedRows[0].Cells["ChiPhi"].Value.ToString());

                DialogResult result = MessageBox.Show("Bạn có muốn xóa hoat động " + hoatDong.TenHoatDong + " với mã là: " + hoatDong.MaHoatDong + " không?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if(result == DialogResult.Yes)
                {
                    if(HoatDongNgoaiKhoaBLL.XoaHoatDong(hoatDong))
                    {
                        MessageBox.Show("Đã xóa hoạt động thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGridView();
                        txtMaHoatDong.Clear();
                        txtTenHoatDong.Clear();
                        txtChiPhi.Clear();
                        txtKeHoach.Clear();
                        dtNgayBatDau.Value = DateTime.Today;
                        dtNgayKetThuc.Value = DateTime.Today;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một hoạt động để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
