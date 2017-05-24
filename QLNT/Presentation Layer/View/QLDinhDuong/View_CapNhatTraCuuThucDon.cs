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
        Dictionary<string, int> thongTinSoLuongNguyenLieuCanDeApDung = new Dictionary<string, int>();

        string maThucDon = "";
        public View_CapNhatTraCuuThucDon()
        {
            InitializeComponent();
        }

        private void View_CapNhatTraCuuThucDon_Load(object sender, EventArgs e)
        {
            getDataGridViewThucDon();
            getDataGridViewApDungThucDon("");
            getDataGridViewChiTietThucDon("");
            getComboBoxLop();
            getComboBoxMonAn();
            cboBuoiApDung.SelectedIndex = 0;

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
            string[] columns = { "MaThucDon", "MaMonAn","TenMonAn" };
            Utility.ControlFormat.DataGridViewFormat(dgvChiTietThucDon, columns);

            dgvChiTietThucDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiTietThucDon.Columns[0].HeaderText = "Mã thực đơn";
            dgvChiTietThucDon.Columns[0].Width = 150;
            dgvChiTietThucDon.Columns[1].HeaderText = "Mã Món Ăn";
            dgvChiTietThucDon.Columns[1].Width = 150;
            dgvChiTietThucDon.Columns[2].HeaderText = "Tên Món Ăn";
            dgvChiTietThucDon.Columns[2].Width = 150;
        }

        private void getDataGridViewApDungThucDon(string maThucDon)
        {
            dgvApDungThucDon.DataSource = ApDungThucDonBLL.LayDanhSachApDungThucDon(maThucDon);
            string[] columns = { "MaThucDon", "TenLop","Buoi", "NgayApDung" };
            Utility.ControlFormat.DataGridViewFormat(dgvApDungThucDon, columns);

            dgvApDungThucDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvApDungThucDon.Columns[0].HeaderText = "Mã thực đơn";
            dgvApDungThucDon.Columns[0].Width = 120;
            dgvApDungThucDon.Columns[1].HeaderText = "Tên lớp";
            dgvApDungThucDon.Columns[1].Width = 100;
            dgvApDungThucDon.Columns[2].HeaderText = "Buổi";
            dgvApDungThucDon.Columns[2].Width = 100;
            dgvApDungThucDon.Columns[3].HeaderText = "Ngày áp dụng";
            dgvApDungThucDon.Columns[3].Width = 120;
        }

        private void getComboBoxMonAn()
        {
            cboMonAn.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            cboMonAn.DisplayMember = "TenMonAn";
            cboMonAn.ValueMember = "MaMonAn";
        }

        private void getComboBoxLop()
        {
            cboLop.DataSource = ApDungThucDonBLL.LayDanhSachTenVaMaLop();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            
        }

        private void btnTaoMoiThucDon_Click(object sender, EventArgs e)
        {
            string maThucDonMoi = ThucDonBLL.SinhMaTuDong();
            ThucDonBLL.ThemThucDon(maThucDonMoi);
            getDataGridViewThucDon();
            getDataGridViewChiTietThucDon(maThucDonMoi);
            getDataGridViewApDungThucDon(maThucDonMoi);
        }

        public void SetEnableComponent(bool value)
        {
            cboBuoiApDung.Enabled = value;
            cboLop.Enabled = value;
            cboMonAn.Enabled = value;
            dtpNgayApDung.Enabled = value;
        }

        private void txtMaThucDon_TextChanged(object sender, EventArgs e)
        {
            maThucDon = txtMaThucDon.Text;
            if ( maThucDon == "")
            {
                txtNguoiLap.Text = "";
                cboMonAn.Text = "";
                cboLop.Text = "";
                cboBuoiApDung.Text = "Sáng";
            }
            txtMaThucDon2.Text = maThucDon;
            txtMaThucDon3.Text = maThucDon;

        }

        private void btnXoaThucDon_Click(object sender, EventArgs e)
        {
            if(ThucDonBLL.KiemTraThucDonDaDuocApDung(maThucDon))
            {
                MessageBox.Show("Không thể xóa thực đơn này, Thực đơn đã được áp dụng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            ThucDonBLL.XoaThucDon(maThucDon);
            getDataGridViewThucDon();
            getDataGridViewChiTietThucDon("");
            getDataGridViewApDungThucDon("");
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

            if(ChiTietThucDonBLL.KiemTraMonAnTrongThucDon(maThucDon, cboMonAn.SelectedValue.ToString().Trim()))
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

            if(ThucDonBLL.KiemTraThucDonDaDuocApDung(maThucDon))
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

        private void btnApDungThucDon_Click(object sender, EventArgs e)
        {
            //---------------kiểm tra điều kiện nhấn áp dụng-------------------
            if(txtMaThucDon.Text == "")
            {
                MessageBox.Show("Chưa chọn thực đơn để áp dụng,\nNhấp chọn 1 thực đơn trong bảng THỰC ĐƠN", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (ApDungThucDonBLL.KiemTraApdungThucDon(cboLop.Text, dtpNgayApDung.Value, cboBuoiApDung.Text))
            {
                MessageBox.Show("Thất bại! Lớp đã xét thực đơn vào thời điểm này rồi", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if(dtpNgayApDung.Value < DateTime.Today)
            {
                MessageBox.Show("Thất bại! Không thể áp dụng thực đơn cho ngày đã qua", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //--------------------------tiến hành kiểm tra thông tin và áp dụng--------------------------
            //biến kiểm tra số lượng nguyên liệu có đủ dùng hay không
            bool KiemTraSoLuongTonCoDuDung = true;
            
            //biến tạm lưu mã nguyên liệu, số lượng
            string strMaNguyenLieu = "";
            string strSoLuong = "";

            //xóa danh sách số lượng nguyên liệu cần để áp dụng (cũ)
            thongTinSoLuongNguyenLieuCanDeApDung.Clear();

            //duyệt tất cả các món ăn trong thực đơn
            foreach(DataGridViewRow MonAn in dgvChiTietThucDon.Rows)
            {
                //lấy ra danh sách các nguyên liệu có trong món ăn đang duyệt
                DataTable danhSachNguyenLieu = ApDungThucDonBLL.LayDanhSachMaNguyenLieuVaSoLuongTrongMonAn(MonAn.Cells["MaMonAn"].Value.ToString());

                //duyệt danh sách nguyên liệu của món ăn
                foreach (DataRow nguyenLieu in danhSachNguyenLieu.Rows)
                {
                    //gán giá trị mã nguyên liệu và số lượng nguyên liệu vào biến tạm
                    strMaNguyenLieu = nguyenLieu["MaNguyenLieu"].ToString();
                    strSoLuong = nguyenLieu["SoLuong"].ToString();

                    //nếu đã có nguyên liệu này trong danh sách thì cộng dồn số lượng nguyên liệu vào danh sách các nguyên liệu cần
                    if (thongTinSoLuongNguyenLieuCanDeApDung.ContainsKey(strMaNguyenLieu))
                    {
                        thongTinSoLuongNguyenLieuCanDeApDung[strMaNguyenLieu] += int.Parse(strSoLuong);
                    }
                    else //nếu chưa có nguyên liệu này trong danh sách thì thêm nguyên liệu và số lượng nguyên liệu vào danh sách
                    {
                        thongTinSoLuongNguyenLieuCanDeApDung.Add(strMaNguyenLieu, int.Parse(strSoLuong));
                    }
                }
            }
            
           //lấy ra danh sách nguyên liệu,sô lượng
            List<string> listMaNguyenLieu = new List<string>(thongTinSoLuongNguyenLieuCanDeApDung.Keys);
            List<int> listSoLuong = new List<int>(thongTinSoLuongNguyenLieuCanDeApDung.Values);

            string thongtin = "";

            //Thêm phiếu mua mới vào CSDL (giả sử cần phải mua thêm nguyên liệu)
            PhieuMuaNL phieuMua = new PhieuMuaNL();
            phieuMua = PhieuMuaNLBLL.TaoPhieuMuaMoi();

            //duyệt từng nguyên liệu để so sánh số lượng cần dùng và số lượng tồn trong kho
            for (int i = 0; i < listMaNguyenLieu.Count; i++)
            {
                int soLuongThieu = listSoLuong[i] - int.Parse(NguyenLieuBLL.LaySoLuongTonTheoMaNguyenLieu(listMaNguyenLieu[i]));

                //trường hợp thiếu nguyên liệu
                if(soLuongThieu > 0)
                {
                    //Thêm chi tiết mua nguyên liệu bị thiếu
                    ChiTietPhieuMuaNL chitiet = new ChiTietPhieuMuaNL();
                    chitiet.MaPhieu = phieuMua.MaPhieu;
                    chitiet.MaNguyenLieu = listMaNguyenLieu[i];
                    chitiet.SoLuong = soLuongThieu;
                    chitiet.DonGia = 0;
                    chitiet.ThanhTien = 0;
                    ChiTietPhieuMuaNLBLL.ThemChiTietPhieuMuaNL(chitiet);

                    //xác nhận số lượng không đủ dùng
                    KiemTraSoLuongTonCoDuDung = false;
                }

                thongtin += "Mã nguyên liệu: " + listMaNguyenLieu[i] + " cần dùng: " + listSoLuong[i] + " trong kho có: " + NguyenLieuBLL.LaySoLuongTonTheoMaNguyenLieu(listMaNguyenLieu[i]) + "\n";
            }

            //trường hợp mọi nguyên liệu đủ dùng
            if(KiemTraSoLuongTonCoDuDung)
            {
                //xóa phiếu mua vừa tạo
                PhieuMuaNLBLL.XoaPhieuMuaNL(phieuMua.MaPhieu);

                //thực hiện trừ số lượng nguyên liệu được dùng
                for(int i = 0; i < listMaNguyenLieu.Count; i++)
                {
                    NguyenLieuBLL.CapNhatTonNguyenLieuTheoMa(listMaNguyenLieu[i], -listSoLuong[i]);
                }

                //Thêm thông tin áp dụng vào CSDL

                ApDungThucDon apDung = new ApDungThucDon();
                apDung.MaThucDon = txtMaThucDon.Text;
                apDung.MaLop = cboLop.SelectedValue.ToString();
                apDung.NgayApDung = dtpNgayApDung.Value;
                apDung.Buoi = cboBuoiApDung.Text;
                ApDungThucDonBLL.ThemApDungThucDon(apDung);
                getDataGridViewApDungThucDon(txtMaThucDon.Text);

                MessageBox.Show("Áp dụng thành công", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Không đủ nguyên liệu để áp dụng\nTự động thêm phiếu mua hàng?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Đã thêm phiếu mua thành công với mã '"+ phieuMua.MaPhieu+ "'\nvui lòng chuyển sang màn hình phiếu mua để xác nhận nhập kho\nCuối cùng Nhấp ''Áp dụng thực đơn'' để hoàn tất", "Thông báo", MessageBoxButtons.OK);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            //MessageBox.Show(thongtin);
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
            getDataGridViewApDungThucDon(maThucDon);

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

        private void dgvApDungThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dgvApDungThucDon.RowCount)
                return;
            cboLop.Text = dgvApDungThucDon.Rows[e.RowIndex].Cells["TenLop"].Value.ToString();
            dtpNgayApDung.Text = dgvApDungThucDon.Rows[e.RowIndex].Cells["NgayApDung"].Value.ToString();
            cboBuoiApDung.Text = dgvApDungThucDon.Rows[e.RowIndex].Cells["Buoi"].Value.ToString();
        }
    }
}
