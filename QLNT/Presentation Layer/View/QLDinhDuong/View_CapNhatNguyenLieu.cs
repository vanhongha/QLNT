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
using QLNT.Entities;

namespace QLNT.Presentation_Layer.View.QLDinhDuong
{
    public partial class View_CapNhatNguyenLieu : UserControl
    {
        private string[] selectedNguyenLieu = new string[5];
        private string TuKhoa = "";
        public View_CapNhatNguyenLieu()
        {
            InitializeComponent();
        }

        private void View_CapNhatNguyenLieu_Load(object sender, EventArgs e)
        {
            getDataGridView();
            getCombobox();
            SetEnabledComponents(false);
            XoaTrang();
        }

        private void getDataGridView()
        {
            dgvNguyenLieu.DataSource = NguyenLieuBLL.LayDanhSachNguyenLieu(TuKhoa);
            string[] column = { "MaNguyenLieu", "TenNguyenLieu", "TenLoaiNL", "ChiSoDinhDuong", "SoLuongTon", "DonViTinh" };
            Utility.ControlFormat.DataGridViewFormat(dgvNguyenLieu, column);
            
            dgvNguyenLieu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNguyenLieu.Columns[0].HeaderText = "Mã nguyên liệu";
            dgvNguyenLieu.Columns[0].Width = 100;
            dgvNguyenLieu.Columns[1].HeaderText = "Tên nguyên liệu";
            dgvNguyenLieu.Columns[1].Width = 100;
            dgvNguyenLieu.Columns[2].HeaderText = "Loại nguyên liệu";
            dgvNguyenLieu.Columns[2].Width = 80;
            dgvNguyenLieu.Columns[3].HeaderText = "Chỉ số dinh dưỡng";
            dgvNguyenLieu.Columns[3].Width = 100;
            dgvNguyenLieu.Columns[4].HeaderText = "Số lượng tồn";
            dgvNguyenLieu.Columns[4].Width = 80;
            dgvNguyenLieu.Columns[5].HeaderText = "Đơn vị tính";
            dgvNguyenLieu.Columns[5].Width = 80;
            dgvNguyenLieu.ClearSelection();

        }


        private void getCombobox()
        {
            cboLoaiNguyenLieu.DataSource = LoaiNguyenLieuBLL.layDanhSachLoaiNguyenLieu();
            cboLoaiNguyenLieu.DisplayMember = "TenLoaiNL";
            cboLoaiNguyenLieu.ValueMember = "MaLoaiNL";
            cboLoaiNguyenLieu.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex < 0) || (e.RowIndex > dgvNguyenLieu.RowCount))
            {
                XoaTrang();
                return;
            }
            cboLoaiNguyenLieu.Text = "";
            selectedNguyenLieu[0] = txtMaNguyenLieu.Text = dgvNguyenLieu.Rows[e.RowIndex].Cells["MaNguyenLieu"].Value.ToString();
            selectedNguyenLieu[1] = txtTenNguyenLieu.Text = dgvNguyenLieu.Rows[e.RowIndex].Cells["TenNguyenLieu"].Value.ToString();
            //txtLoaiNguyenLieu.Text = dataGridView1.Rows[e.RowIndex].Cells["TenLoaiNL"].Value.ToString();
            cboLoaiNguyenLieu.SelectedText = dgvNguyenLieu.Rows[e.RowIndex].Cells["TenLoaiNL"].Value.ToString();
            selectedNguyenLieu[2] = txtChiSoDinhDuong.Text = dgvNguyenLieu.Rows[e.RowIndex].Cells["ChiSoDinhDuong"].Value.ToString();
            selectedNguyenLieu[3] = txtSoLuongTon.Text = dgvNguyenLieu.Rows[e.RowIndex].Cells["SoLuongTon"].Value.ToString();
            selectedNguyenLieu[4] = txtDonViTinh.Text = dgvNguyenLieu.Rows[e.RowIndex].Cells["DonViTinh"].Value.ToString();

            txtDonViTinh.Enabled = false;
            SetEnabledComponents(true);

        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrang();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNguyenLieu.Text == "")
            {
                MessageBox.Show("Nhấp 'Xóa trắng' để tiến hành thêm nguyên liệu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //Kiểm tra điều kiện thêm
            if (!KiemTraDuLieu())
                return;
            string maNL = NguyenLieuBLL.LayMaNguyenLieuTheoTen(txtTenNguyenLieu.Text.Trim());


            //Tên nguyên liệu đã có trong CSDL
            if (maNL != "")
            {
                //Tên nguyên liệu được sử dụng cho mã nguyên liệu khác
                if(txtMaNguyenLieu.Text.Trim() != maNL)
                {
                    MessageBox.Show("Nguyên liệu '" + txtTenNguyenLieu.Text + "' đã tồn tại với mã '" + maNL + "'\nVui lòng nhập tên nguyên liệu khác", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Nguyên liệu '" + txtTenNguyenLieu.Text + "' đã tồn tại\nNhấn 'Cập nhật' để lưu thay đổi" , "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //tiến hành Thêm nguyên liệu
            NguyenLieu nguyenLieu = new NguyenLieu(txtMaNguyenLieu.Text.Trim(),
                                                    txtTenNguyenLieu.Text.Trim(),
                                                    LoaiNguyenLieuBLL.layMaLoaiNguyenLieuTheoTen(cboLoaiNguyenLieu.Text.Trim()),
                                                    txtChiSoDinhDuong.Text.Trim(),
                                                    txtSoLuongTon.Text.Trim(),
                                                    txtDonViTinh.Text.Trim());

            NguyenLieuBLL.ThemNguyenLieu(nguyenLieu);

            getDataGridView();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            if (txtMaNguyenLieu.Text == "")
            {
                MessageBox.Show("Chưa chọn nguyên liệu nào\nNhấp chọn một nguyên liệu trong BẢNG NGUYÊN LIỆU", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //kiểm tra điều kiện cập nhật
            if (!KiemTraDuLieu())
                return;

            string maNL = NguyenLieuBLL.LayMaNguyenLieuTheoTen(txtTenNguyenLieu.Text.Trim());

            //trường hợp không tồn tại mã nguyên liệu này trong CSDL
            if (!NguyenLieuBLL.KiemTraMaNL(txtMaNguyenLieu.Text.Trim()))
            {
                MessageBox.Show("Nguyên liệu có mã'" + txtMaNguyenLieu.Text + "' chưa tồn tại\nNhấn 'Thêm' Thêm nguyên liệu mới", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //trường hợp tên nguyên liệu đã được sử dụng cho mã nguyên liệu khác
            if(NguyenLieuBLL.KiemTraTenNL(txtTenNguyenLieu.Text.Trim()) && maNL != txtMaNguyenLieu.Text.Trim())
            {
                MessageBox.Show("Tên nguyên liệu '" + txtTenNguyenLieu.Text + "' đã tồn tại với mã '" + maNL + "'\nVui lòng nhập tên nguyên liệu khác", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if(selectedNguyenLieu[4] != txtDonViTinh.Text)
            {
                MessageBox.Show("Không thể thay đổi đơn vị tính của nguyên liệu", "Thông báo", MessageBoxButtons.OK);
                txtDonViTinh.Text = selectedNguyenLieu[4];
                txtDonViTinh.Enabled = false;
                return;
            }

            //tiến hành cập nhật nguyên liệu
            NguyenLieu nguyenLieu = new NguyenLieu(txtMaNguyenLieu.Text.Trim(),
                                                    txtTenNguyenLieu.Text.Trim(),
                                                    LoaiNguyenLieuBLL.layMaLoaiNguyenLieuTheoTen(cboLoaiNguyenLieu.Text.Trim()),
                                                    txtChiSoDinhDuong.Text.Trim(),
                                                    txtSoLuongTon.Text.Trim(),
                                                    txtDonViTinh.Text.Trim());
            NguyenLieuBLL.CapNhatNguyenLieu(nguyenLieu);

            getDataGridView();
        }

        private void SetEnabledComponents(bool value)
        {
            txtTenNguyenLieu.Enabled = value;
            cboLoaiNguyenLieu.Enabled = value;
            txtChiSoDinhDuong.Enabled = value;
            txtSoLuongTon.Enabled = value;
        }

        private void XoaTrang()
        {
            txtMaNguyenLieu.Text = NguyenLieuBLL.SinhMaTuDong();
            txtTenNguyenLieu.Text = "";
            //txtLoaiNguyenLieu.Text = "";
            txtChiSoDinhDuong.Text = "";
            txtSoLuongTon.Text = "0";
            txtDonViTinh.Text = "";
            cboLoaiNguyenLieu.Text = "";
            SetEnabledComponents(true);
            txtDonViTinh.Enabled = true;
        }

        private bool KiemTraDuLieu()
        {
            if (txtTenNguyenLieu.Text == "")
            {
                MessageBox.Show("Tên nguyên liệu không được để trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (cboLoaiNguyenLieu.Text == "")
            {
                MessageBox.Show("Chưa chọn loại nguyên liệu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtDonViTinh.Text == "")
            {
                MessageBox.Show("Đơn vị tính không được để trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
        

        private void txtSoLuongTon_TextChanged(object sender, EventArgs e)
        {
            int soLuongTon;
            try
            {
                if (txtSoLuongTon.Text == "")
                {
                    soLuongTon = 0;
                    return;
                }
                    
                soLuongTon = int.Parse(txtSoLuongTon.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Số lượng tồn phải là số nguyên và nhỏ hơn 2000000000 \nVui lòng điền đúng số lượng", "Thông báo", MessageBoxButtons.OK);
                txtSoLuongTon.Text = "0";
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaNguyenLieu.Text == "" || !NguyenLieuBLL.KiemTraMaNL(txtMaNguyenLieu.Text))
            {
                MessageBox.Show("Chưa chọn nguyên liệu nào\nNhấp chọn một nguyên liệu trong BẢNG NGUYÊN LIỆU để xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if(NguyenLieuBLL.CoTrongChiTietPhieuMua(txtMaNguyenLieu.Text))
            {
                MessageBox.Show("Không thể xóa nguyên liệu\nNguyên liệu này có trong chi tiết phiếu mua\nVui lòng kiểm tra chi tiết phiếu mua và thử lại", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            NguyenLieuBLL.XoaNguyenLieu(txtMaNguyenLieu.Text.Trim());
            getDataGridView();
            SetEnabledComponents(false);
            XoaTrang();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập từ khóa dưới 50 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTimKiem.Text = "";
            }
            TuKhoa = txtTimKiem.Text;
            getDataGridView();            
            lblSoKetQua.Text = dgvNguyenLieu.RowCount.ToString();
            lblKetQua.Visible = true;
            lblSoKetQua.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getCombobox();
        }
    }
}
