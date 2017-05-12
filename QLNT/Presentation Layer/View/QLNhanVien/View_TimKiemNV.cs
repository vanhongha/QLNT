using QLNT.BusinessLayer;
using QLNT.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLNT.Presentation_Layer.View
{
    public partial class View_TimKiemNV : UserControl
    {
        string maNV;

        public View_TimKiemNV()
        {
            InitializeComponent();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTimKiem.Text != "")
                {
                    dgvTimKiem.DataSource = NhanVienBLL.TimNV(txtTimKiem.Text);
                    labSoLuong.Text = "Tìm được " + (dgvTimKiem.RowCount - 1).ToString() + " kết quả";
                    GetDataGridView();
                }
                else
                {
                    MessageBox.Show("Nhập từ khóa tìm kiếm", "Thông báo");
                }
            }
        }

        private void dgvTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.RowIndex != dgvTimKiem.RowCount)
                {
                    maNV = dgvTimKiem.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                    //MessageBox.Show(dgvTimKiem.Rows[e.RowIndex].Cells["MaNhanVien"].)
                    GetThongTinNV(maNV);
                    btnCapNhat.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        
        private void GetThongTinNV(string maNV)
        {
            string gioiTinh;
            DataTable dt = NhanVienBLL.GetThongTinNV(maNV);
            txtHoTen.Text = dt.Rows[0]["TenNhanVien"].ToString();
            gioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            if (gioiTinh == "Nam")
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;

            //dtNgaySinh.Value = DateTime.ParseExact(dt.Rows[0]["HoTenMe"].ToString(), "dd/MM/yyy", null);

            txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtSDT.Text = dt.Rows[0]["SDT"].ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nhanVien = new NhanVien();

                nhanVien.MaNV = maNV;
                nhanVien.TenNhanVien = txtHoTen.Text;

                if (rdoNam.Checked)
                    nhanVien.GioiTinh = "Nam";
                else
                    nhanVien.GioiTinh = "Nu";

                nhanVien.NgaySinh = dtNgaySinh.Value;
                nhanVien.SoDT = txtSDT.Text;
                nhanVien.Email = txtEmail.Text;
                nhanVien.DiaChi = txtDiaChi.Text;

                NhanVienBLL.CapNhatThongTinNV(nhanVien);
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                GetDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void GetDataGridView()
        {
            dgvTimKiem.DataSource = NhanVienBLL.GetList();
            string[] columns = { "TenNhanVien", "GioiTinh", "NgaySinh" };
            Utility.ControlFormat.DataGridViewFormat(dgvTimKiem, columns);
            dgvTimKiem.Columns[1].HeaderText = "Họ và tên";
            dgvTimKiem.Columns[2].HeaderText = "Ngày sinh";
            dgvTimKiem.Columns[3].HeaderText = "Giới tính";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa nhanVien này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    NhanVienBLL.XoaNV(maNV);
                    MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtDiaChi.Text = null;
                    txtEmail.Text = null;
                    txtHoTen.Text = null;
                    txtSDT.Text = null;
                    txtTimKiem.Text = null;
                    dtNgaySinh.ResetText();

                    GetDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
