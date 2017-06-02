using System;
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

namespace QLNT.Presentation_Layer.View.QLDinhDuong
{
    public partial class View_PhieuMuaNguyenLieu : UserControl
    {
        public View_PhieuMuaNguyenLieu()
        {
            InitializeComponent();
        }

        private void View_PhieuNguyenLieu_Load(object sender, EventArgs e)
        {
            getDataGridViewPhieuMua();
            getDataGridViewChiTietPhieuMua("");
            getCombobox();
            setTextInfo();

        }

        //------------------------------support function-----------------------------------------------

        private void getDataGridViewChiTietPhieuMua(string maPhieu)
        {
           
            dgvChiTietPhieuMua.DataSource = ChiTietPhieuMuaNLBLL.LayDanhSachChiTietPhieuMuaNL(maPhieu);

            string[] column = { "MaPhieu", "MaNguyenLieu","TenNguyenLieu", "SoLuong", "DonGia", "ThanhTien"};
            Utility.ControlFormat.DataGridViewFormat(dgvChiTietPhieuMua, column);

            //dgvDanhSachMuaNL.ColumnCount.ToString();
            //MessageBox.Show(dgvDanhSachMuaNL.ColumnCount.ToString());

            dgvChiTietPhieuMua.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiTietPhieuMua.Columns[0].HeaderText = "Mã phiếu";
            dgvChiTietPhieuMua.Columns[0].Width = 100;
            dgvChiTietPhieuMua.Columns[1].HeaderText = "Mã nguyên liệu";
            dgvChiTietPhieuMua.Columns[1].Width = 100;
            dgvChiTietPhieuMua.Columns[2].HeaderText = "Tên nguyên liệu";
            dgvChiTietPhieuMua.Columns[2].Width = 100;
            dgvChiTietPhieuMua.Columns[3].HeaderText = "Số lượng";
            dgvChiTietPhieuMua.Columns[3].Width = 90;
            dgvChiTietPhieuMua.Columns[4].HeaderText = "Đơn Giá";
            dgvChiTietPhieuMua.Columns[4].Width = 90;
            dgvChiTietPhieuMua.Columns[5].HeaderText = "Thành tiền";
            dgvChiTietPhieuMua.Columns[5].Width = 90;

            dgvChiTietPhieuMua.ClearSelection();
            XoaTrang();
        }

        private void getDataGridViewPhieuMua()
        {
            dgvPhieuMua.DataSource = PhieuMuaNLBLL.LayDanhSachPhieuMuaNL();

            string[] column = { "MaPhieu", "NgayMua", "TongTien" , "TrangThai", "NguoiLapPhieu"};
            Utility.ControlFormat.DataGridViewFormat(dgvPhieuMua, column);
            dgvPhieuMua.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPhieuMua.Columns[0].HeaderText = "Mã phiếu";
            dgvPhieuMua.Columns[0].Width = 100;
            dgvPhieuMua.Columns[1].HeaderText = "Ngày mua";
            dgvPhieuMua.Columns[1].Width = 100;
            dgvPhieuMua.Columns[2].HeaderText = "Tổng tiền";
            dgvPhieuMua.Columns[2].Width = 100;
            dgvPhieuMua.Columns[3].HeaderText = "Trạng thái";
            dgvPhieuMua.Columns[3].Width = 100;
            dgvPhieuMua.Columns[4].HeaderText = "Người lập phiếu";
            dgvPhieuMua.Columns[4].Width = 130;

            dgvPhieuMua.ClearSelection();
            dgvPhieuMua.CurrentCell = null;
        }

        private void getCombobox()
        {
            cboNguyenLieu.DataSource = NguyenLieuBLL.LayDanhSachTenVaMaNguyenLieu();
            cboNguyenLieu.DisplayMember = "TenNguyenLieu";
            cboNguyenLieu.ValueMember = "MaNguyenLieu";
            cboNguyenLieu.Text = "";
        }

        private void XoaTrang()
        {
            txtMaPhieuMua2.Text = txtMaPhieuMua.Text;
            txtDonGia.Text = "0";
            txtSoLuong.Text = "0";
            txtThanhTien.Text = "0";
            cboNguyenLieu.Text = "";

        }

        private void setTextInfo()
        {
            txtMaPhieuMua.Text = "";
            txtNguoiLapPhieu.Text = "";
            txtThoiGian.Text = "";

            txtMaPhieuMua2.Text = "";
            txtDonGia.Text = "0";
            txtSoLuong.Text = "0";
            txtThanhTien.Text = "0";
            cboNguyenLieu.Text = "";
        }

        //------------------------------event Click-----------------------------------------------

        private void btnTaoMoiPhieuMua_Click(object sender, EventArgs e)
        {
            PhieuMuaNL phieuMuaNL = PhieuMuaNLBLL.TaoPhieuMuaMoi();
            getDataGridViewPhieuMua();
        }

        private void dgvPhieuMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex < 0) || (e.RowIndex > dgvPhieuMua.RowCount))
            {
                return;
            }
           
            txtMaPhieuMua.Text = dgvPhieuMua.Rows[e.RowIndex].Cells["MaPhieu"].Value.ToString();
            txtNguoiLapPhieu.Text = dgvPhieuMua.Rows[e.RowIndex].Cells["NguoiLapPhieu"].Value.ToString();
            txtThoiGian.Text = dgvPhieuMua.Rows[e.RowIndex].Cells["NgayMua"].Value.ToString();
            getDataGridViewChiTietPhieuMua(txtMaPhieuMua.Text);
            if(dgvPhieuMua.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString() == "Đã nhập kho")
            {
                lblWarning.Visible = true;
                setEnabledComponent(false);
            }
            else
            {
                lblWarning.Visible = false;
                XoaTrang();
                setEnabledComponent(true);
            }

            

        }

        private void dgvChiTietPhieuMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex < 0) || (e.RowIndex > dgvChiTietPhieuMua.RowCount))
            {
                if(!lblWarning.Visible)
                    XoaTrang();
                return;
            }
                
            cboNguyenLieu.Text = dgvChiTietPhieuMua.Rows[e.RowIndex].Cells["TenNguyenLieu"].Value.ToString();
            if (cboNguyenLieu.Text == "")
                return;

            if (!lblWarning.Visible)
                setEnabledComponent(true);

            cboNguyenLieu.Enabled = false;
            txtDonGia.Text = dgvChiTietPhieuMua.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
            txtSoLuong.Text = dgvChiTietPhieuMua.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            txtThanhTien.Text = dgvChiTietPhieuMua.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            getCombobox();
        }

        private void btnReloadPhieuMua_Click(object sender, EventArgs e)
        {
            getDataGridViewPhieuMua();
            getDataGridViewChiTietPhieuMua("");

            setEnabledComponent(false);
            setTextInfo();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            if (lblWarning.Visible)
            {
                MessageBox.Show("Phiếu mua này đã nhập kho rồi", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (txtMaPhieuMua.Text == "")
            {
                MessageBox.Show("Chưa chọn phiếu mua để nhập kho\nVui lòng Nhấn chọn phiếu mua cần thêm chi tiết trong Bảng PHIẾU MUA", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (dgvChiTietPhieuMua.Rows.Count <= 0)
            {
                MessageBox.Show("Phiếu mua này chưa có nội dung\nVui lòng thêm nội dụng vào Bảng CHI TIẾT PHIẾU MUA", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //nếu phiếu mua không có tổng tiền hợp lệ
            decimal tongTien = decimal.Parse(PhieuMuaNLBLL.LayTongTienTuMaPhieu(txtMaPhieuMua.Text));

            if (tongTien <= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Phiếu mua này có tổng tiền = 0đ\nVui lòng xác nhận đã kiểm tra thông tin phiếu?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else if (dialogResult == DialogResult.Yes)
                {
                }
            }


            for (int i = 0; i < dgvChiTietPhieuMua.Rows.Count; i++)
            {
                NguyenLieuBLL.CapNhatTonNguyenLieuTheoMa(dgvChiTietPhieuMua.Rows[i].Cells["MaNguyenLieu"].Value.ToString(), int.Parse(dgvChiTietPhieuMua.Rows[i].Cells["SoLuong"].Value.ToString()));
            }

            PhieuMuaNLBLL.CapNhatTrangThaiPhieuMuaNL(txtMaPhieuMua.Text);
            MessageBox.Show("Đã nhập kho thành công", "Thông báo", MessageBoxButtons.OK);

            getDataGridViewPhieuMua();
            getDataGridViewChiTietPhieuMua("");

            setEnabledComponent(false);
            setTextInfo();

        }

        private void btnXoaPhieuMua_Click(object sender, EventArgs e)
        {
            if (lblWarning.Visible)
            {
                MessageBox.Show("Không thể xóa phiếu mua đã nhập kho", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (txtMaPhieuMua.Text == "")
            {
                MessageBox.Show("Chưa chọn phiếu mua để xóa\nVui lòng Nhấn chọn phiếu mua cần xóa trong Bảng PHIẾU MUA", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            PhieuMuaNLBLL.XoaPhieuMuaNL(txtMaPhieuMua.Text.Trim());
            getDataGridViewPhieuMua();
            getDataGridViewChiTietPhieuMua("");

            setEnabledComponent(false);
            setTextInfo();

        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            if (lblWarning.Visible)
            {
                MessageBox.Show("Không thể thao tác trên chi tiết của phiếu mua đã nhập kho", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (txtMaPhieuMua2.Text == "")
            {
                MessageBox.Show("Chưa chọn phiếu mua\nVui lòng Nhấn chọn phiếu mua cần thêm chi tiết trong Bảng PHIẾU MUA", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            XoaTrang();
            cboNguyenLieu.Enabled = true;
            setEnabledComponent(true);

        }

        private void setEnabledComponent(bool value)
        {
            txtDonGia.Enabled = value;
            txtSoLuong.Enabled = value;
            cboNguyenLieu.Enabled = value;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lblWarning.Visible)
            {
                MessageBox.Show("Không thể cập nhật chi tiết của phiếu mua đã nhập kho", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (txtMaPhieuMua2.Text == "")
            {
                MessageBox.Show("Chưa chọn chi tiết phiếu mua để cập nhật\nVui lòng Nhấn chọn chi tiết phiếu mua cần cập nhật trong Bảng CHI TIẾT PHIẾU MUA", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //trường hợp chưa tồn tại nguyên liệu này trong chi tiết phiếu mua
            if (!ChiTietPhieuMuaNLBLL.KiemTraMaNL(txtMaPhieuMua2.Text.Trim(), NguyenLieuBLL.LayMaNguyenLieuTheoTen(cboNguyenLieu.Text.Trim())))
            {
                //thông báo lỗi không thể cập nhật
                MessageBox.Show("Nguyên liệu này chưa được thêm vào danh sách chi tiết\nVui lòng Nhấn nút 'Thêm' để thêm nguyên liệu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //trường hợp đủ điều kiện để cập nhật
            ChiTietPhieuMuaNL chiTiet = new ChiTietPhieuMuaNL();
            chiTiet.MaPhieu = txtMaPhieuMua2.Text.Trim();
            chiTiet.MaNguyenLieu = NguyenLieuBLL.LayMaNguyenLieuTheoTen(cboNguyenLieu.Text.Trim());
            chiTiet.DonGia = Convert.ToDecimal(txtDonGia.Text.Trim());
            chiTiet.SoLuong = Convert.ToDecimal(txtSoLuong.Text.Trim());
            chiTiet.ThanhTien = Convert.ToDecimal(txtThanhTien.Text.Trim());

            ChiTietPhieuMuaNLBLL.CapNhatPhieuMuaNL(chiTiet);
            getDataGridViewChiTietPhieuMua(txtMaPhieuMua.Text);


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lblWarning.Visible)
            {
                MessageBox.Show("Không thể thêm chi tiết của phiếu mua đã nhập kho", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (txtMaPhieuMua2.Text == "")
            {
                MessageBox.Show("Chưa chọn phiếu mua để thêm chi tiết \nVui lòng Nhấn chọn phiếu mua cần thêm chi tiết trong Bảng PHIẾU MUA", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (cboNguyenLieu.Text == "")
            {
                MessageBox.Show("Nguyên liệu không được để trống \nVui lòng chọn một nguyên liệu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Đơn giá không được để trống \nVui lòng điền vào đơn giá", "Thông báo", MessageBoxButtons.OK);
                txtDonGia.Text = "0";
                return;
            }

            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng không đươc để trống \nVui lòng điền vào số lượng", "Thông báo", MessageBoxButtons.OK);
                txtSoLuong.Text = "0";
                return;
            }

            //trường hợp đã tồn tại nguyên liệu này trong chi tiết phiếu mua
            if (ChiTietPhieuMuaNLBLL.KiemTraMaNL(txtMaPhieuMua2.Text.Trim(), NguyenLieuBLL.LayMaNguyenLieuTheoTen(cboNguyenLieu.Text.Trim())))
            {
                //thông báo lỗi không thể thêm
                MessageBox.Show("Nguyên liệu này đã tồn tại trong chi tiết phiếu mua hiện tại\nVui lòng Nhấn nút 'Cập nhật' để cập nhật nguyên liệu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //đủ điều kiện thêm chi tiet
            ChiTietPhieuMuaNL chiTiet = new ChiTietPhieuMuaNL();
            chiTiet.MaPhieu = txtMaPhieuMua2.Text.Trim();
            chiTiet.MaNguyenLieu = NguyenLieuBLL.LayMaNguyenLieuTheoTen(cboNguyenLieu.Text.Trim());
            chiTiet.DonGia = Convert.ToDecimal(txtDonGia.Text.Trim());
            chiTiet.SoLuong = Convert.ToDecimal(txtSoLuong.Text.Trim());
            chiTiet.ThanhTien = Convert.ToDecimal(txtThanhTien.Text.Trim());

            ChiTietPhieuMuaNLBLL.ThemChiTietPhieuMuaNL(chiTiet);
            getDataGridViewChiTietPhieuMua(txtMaPhieuMua.Text);
            getDataGridViewPhieuMua();

        }

        private void btnXoaChiTietPhieuMua_Click(object sender, EventArgs e)
        {
            if (lblWarning.Visible)
            {
                MessageBox.Show("Không thể xóa chi tiết của phiếu mua đã nhập kho", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (txtMaPhieuMua2.Text == "")
            {
                MessageBox.Show("Chưa chọn chi tiết phiếu mua để xóa\nVui lòng Nhấn chọn chi tiết phiếu mua cần xóa trong Bảng CHI TIẾT PHIẾU MUA", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (cboNguyenLieu.Text == "")
            {
                MessageBox.Show("Chưa chọn chi tiết phiếu mua để xóa\nVui lòng Nhấn chọn chi tiết phiếu mua cần xóa trong Bảng CHI TIẾT PHIẾU MUA", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            ChiTietPhieuMuaNLBLL.XoaChiTietPhieuMuaNL(txtMaPhieuMua.Text.Trim(), cboNguyenLieu.Text.Trim());
            XoaTrang();
            setEnabledComponent(false);
            getDataGridViewChiTietPhieuMua(txtMaPhieuMua2.Text.Trim());
        }

        //------------------------------event TextChanged-----------------------------------------------

        private void txtMaPhieuMua_TextChanged(object sender, EventArgs e)
        {
            getDataGridViewChiTietPhieuMua(txtMaPhieuMua.Text.Trim());
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            decimal donGia;
            decimal soLuong;
            decimal thanhTien;

            try
            {
                if (txtDonGia.Text == "")
                    donGia = 0;
                else    
                    donGia = Convert.ToDecimal(txtDonGia.Text);
            }
            catch
            {
                MessageBox.Show("Đơn giá phải là số\nVui lòng điền đúng đơn giá", "Thông báo", MessageBoxButtons.OK);
                txtDonGia.Text = "0";
                txtThanhTien.Text = "0";
                return;
            }

            try
            {
                soLuong = Convert.ToDecimal(txtSoLuong.Text);
                thanhTien = soLuong * donGia;
                txtThanhTien.Text = thanhTien.ToString();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi do nhập sai đơn giá hoặc số lượng\nVui lòng điền đúng đơn giá và số lượng kiểu số", "Thông báo", MessageBoxButtons.OK);
                txtDonGia.Text = "0";
                txtSoLuong.Text = "0";
                txtThanhTien.Text = "0";
            }
            
            
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            decimal donGia;
            decimal soLuong;
            decimal thanhTien;

            try
            {
                if (txtSoLuong.Text == "")
                    soLuong = 0;
                else
                    soLuong = Convert.ToDecimal(txtSoLuong.Text);
            }
            catch
            {
                MessageBox.Show("Số lượng phải là số\nVui lòng điền đúng số lượng", "Thông báo", MessageBoxButtons.OK);
                txtSoLuong.Text = "0";
                txtThanhTien.Text = "0";
                return;
            }

            try
            {
                donGia = Convert.ToDecimal(txtDonGia.Text);
                thanhTien = soLuong * donGia;
                txtThanhTien.Text = thanhTien.ToString();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi do nhập sai đơn giá hoặc số lượng\nVui lòng điền đúng đơn giá và số lượng kiểu số", "Thông báo", MessageBoxButtons.OK);
                txtDonGia.Text = "0";
                txtSoLuong.Text = "0";
                txtThanhTien.Text = "0";
            }
            
        }


    }
}
