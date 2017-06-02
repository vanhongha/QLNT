using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.BusinessLayer;
using QLNT.Entities;
using System.Windows.Forms;

namespace QLNT.Presentation_Layer.View.QLDinhDuong
{
    public partial class View_CapNhatTraCuuThucDon : UserControl
    {
        

        string maThucDon = "";
        public View_CapNhatTraCuuThucDon()
        {
            InitializeComponent();
        }

        private void View_CapNhatTraCuuThucDon_Load(object sender, EventArgs e)
        {
            getDataGridViewThucDon();
            
            getDataGridViewChiTietThucDon("");
            
            getComboBoxMonAn();
            

        }

        private void getDataGridViewThucDon()
        {
            dgvThucDon.DataSource = ThucDonBLL.LayDanhSachThucDon();
            string[] columns = { "MaThucDon", "NgayLap", "NguoiLap" };
            Utility.ControlFormat.DataGridViewFormat(dgvThucDon, columns);

            dgvThucDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThucDon.Columns[0].HeaderText = "Mã thực đơn";
            dgvThucDon.Columns[0].Width = 140;
            dgvThucDon.Columns[1].HeaderText = "Ngày lập";
            dgvThucDon.Columns[1].Width = 130;
            dgvThucDon.Columns[2].HeaderText = "Người lập";
            dgvThucDon.Columns[2].Width = 135;
        }

        private void getDataGridViewChiTietThucDon(string maThucDon)
        {
            dgvChiTietThucDon.DataSource = ChiTietThucDonBLL.LayDanhSachChiTietThucDon(maThucDon);
            string[] columns = { "MaThucDon", "MaMonAn", "TenMonAn" };
            Utility.ControlFormat.DataGridViewFormat(dgvChiTietThucDon, columns);

            dgvChiTietThucDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiTietThucDon.Columns[0].HeaderText = "Mã thực đơn";
            dgvChiTietThucDon.Columns[0].Width = 150;
            dgvChiTietThucDon.Columns[1].HeaderText = "Mã Món Ăn";
            dgvChiTietThucDon.Columns[1].Width = 150;
            dgvChiTietThucDon.Columns[2].HeaderText = "Tên Món Ăn";
            dgvChiTietThucDon.Columns[2].Width = 150;
        }

        private void getComboBoxMonAn()
        {
            cboMonAn.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            cboMonAn.DisplayMember = "TenMonAn";
            cboMonAn.ValueMember = "MaMonAn";
        }

        private void btnTaoMoiThucDon_Click(object sender, EventArgs e)
        {
            string maThucDonMoi = ThucDonBLL.SinhMaTuDong();
            ThucDonBLL.ThemThucDon(maThucDonMoi);
            getDataGridViewThucDon();
            getDataGridViewChiTietThucDon(maThucDonMoi);
        }

        public void SetEnableComponent(bool value)
        {
            cboMonAn.Enabled = value;
        }

        private void txtMaThucDon_TextChanged(object sender, EventArgs e)
        {
            maThucDon = txtMaThucDon.Text;
            if ( maThucDon == "")
            {
                txtNguoiLap.Text = "";
                cboMonAn.Text = "";
            }
            txtMaThucDon2.Text = maThucDon;

        }

        private void btnXoaThucDon_Click(object sender, EventArgs e)
        {
            if (ThucDonBLL.KiemTraThucDonDaDuocApDung(maThucDon))
            {
                MessageBox.Show("Không thể xóa thực đơn này, Thực đơn đã được áp dụng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            ThucDonBLL.XoaThucDon(maThucDon);
            getDataGridViewThucDon();
            getDataGridViewChiTietThucDon("");
            SetEnableComponent(false);
            txtMaThucDon.Text = "";

        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            if (maThucDon == "")
            {
                MessageBox.Show("Chưa chọn thực đơn để cập nhật,\nNhấp chọn 1 thực đơn trong bảng THỰC ĐƠN", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (ThucDonBLL.KiemTraThucDonDaDuocApDung(maThucDon))
            {
                MessageBox.Show("Không thể cập nhật chi tiết của thực đơn đã được áp dụng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (cboMonAn.Text == "")
            {
                MessageBox.Show("Chưa chọn món ăn để thêm vào, Vui lòng chọn một món ăn", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (ChiTietThucDonBLL.KiemTraMonAnTrongThucDon(maThucDon, cboMonAn.SelectedValue.ToString().Trim()))
            {
                MessageBox.Show("Món ăn này đã có trong thực đơn, Vui lòng chọn món khác để thêm", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            ChiTietThucDonBLL.ThemChiTietThucDon(maThucDon, cboMonAn.SelectedValue.ToString().Trim());
            getDataGridViewChiTietThucDon(maThucDon);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maThucDon == "")
            {
                MessageBox.Show("Chưa chọn thực đơn để cập nhật,\nNhấp chọn 1 thực đơn trong bảng THỰC ĐƠN", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (ThucDonBLL.KiemTraThucDonDaDuocApDung(maThucDon))
            {
                MessageBox.Show("Không thể cập nhật chi tiết của thực đơn đã được áp dụng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (cboMonAn.Text == "")
            {
                MessageBox.Show("Chưa chọn món ăn để xóa , Vui lòng chọn một món ăn", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (!ChiTietThucDonBLL.KiemTraMonAnTrongThucDon(maThucDon, cboMonAn.SelectedValue.ToString().Trim()))
            {
                MessageBox.Show("Món ăn này chưa có trong thực đơn, Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            ChiTietThucDonBLL.XoaChiTietThucDon(maThucDon, cboMonAn.SelectedValue.ToString().Trim());
            getDataGridViewChiTietThucDon(maThucDon);
        }

        private void dgvChiTietThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dgvChiTietThucDon.RowCount)
                return;

            cboMonAn.Text = dgvChiTietThucDon.Rows[e.RowIndex].Cells["TenMonAn"].Value.ToString(); 
            
        }

        private void dgvThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dgvThucDon.RowCount)
                return;
            txtMaThucDon.Text = dgvThucDon.Rows[e.RowIndex].Cells["MaThucDon"].Value.ToString();
            txtNguoiLap.Text = dgvThucDon.Rows[e.RowIndex].Cells["NguoiLap"].Value.ToString();
            getDataGridViewChiTietThucDon(maThucDon);

            if (ThucDonBLL.KiemTraThucDonDaDuocApDung(maThucDon))
            {
                lblWarning.Visible = true;
            }
            else
            {
                lblWarning.Visible = false;
            }

            SetEnableComponent(true);
        }


    }
}
