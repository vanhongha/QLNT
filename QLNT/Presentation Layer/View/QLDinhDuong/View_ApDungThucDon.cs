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
    public partial class View_ApDungThucDon : UserControl
    {
        Dictionary<string, int> thongTinSoLuongNguyenLieuCanDeApDung = new Dictionary<string, int>();
        //CheckBox checkboxHeader = new CheckBox();

        public View_ApDungThucDon()
        {
            InitializeComponent();
            
        }

        private void View_ApDungThucDon_Load(object sender, EventArgs e)
        {
            getDataGridViewLop();
            getComboBoxThucDon();
            dtpNgay_Loc.Value = DateTime.Today;
            
        }

        private void setCheckBoxColumn()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "X";
            checkBoxColumn.Width = 50;
            checkBoxColumn.ReadOnly = false;
            dgvLop.Columns.Add(checkBoxColumn);

            //Rectangle rect = dgvLop.GetCellDisplayRectangle(0, -1, true);
            //rect.Y = 3;
            //rect.X = rect.Location.X + (rect.Width/2 - 7 );
            //checkboxHeader.Name = "checkboxHeader";
            ////datagridview[0, 0].ToolTipText = "sdfsdf";
            //checkboxHeader.Size = new Size(14, 14);
            //checkboxHeader.Location = rect.Location;
            
            //dgvLop.Controls.Add(checkboxHeader);
        }

        private void getDataGridViewLop()
        {
            setCheckBoxColumn();
            dgvLop.DataSource = ApDungThucDonBLL.LayDanhSachTenVaMaLop();
            string[] columns = { "X", "TenLop", "SiSo", "MaLop", "MaLoaiLop" };
            Utility.ControlFormat.DataGridViewFormat(dgvLop, columns);
            dgvLop.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLop.Columns[1].HeaderText = "Tên lớp";
            dgvLop.Columns[1].Width = 100;
            dgvLop.Columns[2].HeaderText = "Sĩ Số";
            dgvLop.Columns[2].Width = 100;
            dgvLop.Columns[3].HeaderText = "Mã lớp";
            dgvLop.Columns[3].Width = 120;
            dgvLop.Columns[4].HeaderText = "Mã loại lớp";
            dgvLop.Columns[4].Width = 120;

            ChangeRowsColor();

            getDataGridViewApDungThucDon(dtpNgay_Loc.Value, cboBuoiAD.Text);
        }

        private void ChangeRowsColor()
        {
            dgvLop.ClearSelection();

            foreach (DataGridViewRow row in dgvLop.Rows)
            {
                row.Selected = false;
                row.Cells[0].Value = true;

                if (ApDungThucDonBLL.KiemTraApdungThucDon(row.Cells["MaLop"].Value.ToString(), dtpNgay_Loc.Value.ToShortDateString(), cboBuoiAD.Text))
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.ReadOnly = true;
                    row.Cells[0].Value = true;

                }
                else
                {
                    row.ReadOnly = false;
                    row.Cells[0].Value = false;
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void getComboBoxThucDon()
        {
            ChangeRowsColor();
            cboThucDon_Loc.DataSource = ThucDonBLL.LayDanhSachMaThucDon();
            cboThucDon_Loc.DisplayMember = "MaThucDon";
        }

        private void getDataGridViewApDungThucDon(DateTime date, string buoiAD)
        {
            dgvApDungThucDon.DataSource = ApDungThucDonBLL.LayDanhSachApDungThucDonTheoThoiGian(date, buoiAD);
            string[] columns = { "MaThucDon", "SoHocSinhApDung","NgayApDung", "Buoi" };
            Utility.ControlFormat.DataGridViewFormat(dgvApDungThucDon, columns);

            dgvApDungThucDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvApDungThucDon.Columns[0].HeaderText = "Thực đơn áp dụng";
            dgvApDungThucDon.Columns[0].Width = 150;
            dgvApDungThucDon.Columns[1].HeaderText = "Số suất ăn";
            dgvApDungThucDon.Columns[1].Width = 120;
            dgvApDungThucDon.Columns[2].HeaderText = "Ngày áp dụng";
            dgvApDungThucDon.Columns[2].Width = 120;
            dgvApDungThucDon.Columns[3].HeaderText = "Buổi áp dụng";
            dgvApDungThucDon.Columns[3].Width = 120;
           
            
        }

        private bool KiemTraDieuKienBanDauDeApDungThucDon()
        {
            if (dtpNgay_Loc.Value < DateTime.Today)
            {
                MessageBox.Show("Thất bại! Không thể áp dụng thực đơn cho ngày đã qua", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (cboBuoiAD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn buổi để áp dụng", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if(cboThucDon_Loc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thực đơn để áp dụng", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            
            //có lớp để áp dụng hợp lệ
            foreach (DataGridViewRow row in dgvLop.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) && !(row.DefaultCellStyle.BackColor == Color.Yellow))
                {
                    return true;
                }
            }
            MessageBox.Show("Vui lòng chọn lớp chưa áp dụng để thực thi áp dụng", "Thông báo", MessageBoxButtons.OK);

            return true;
        }

        private void ThemNguyenLieuVaoDanhSach(string strMaNguyenLieu, string strSoLuong)
        {
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

        private void HuyBoMuaHangVaCapNhatNguyenLieu(PhieuMuaNL phieuMua, List<string> listMaNguyenLieu, List<int> listSoLuong, int TongSoHocSinhAD)
        {
            //xóa phiếu mua vừa tạo
            PhieuMuaNLBLL.XoaPhieuMuaNL(phieuMua.MaPhieu);

            //thực hiện trừ số lượng nguyên liệu được dùng
            for (int i = 0; i < listMaNguyenLieu.Count; i++)
                NguyenLieuBLL.CapNhatTonNguyenLieuTheoMa(listMaNguyenLieu[i], -TongSoHocSinhAD*listSoLuong[i]);
        }

        private void ThongBaoXacNhanThemPhieuMua(string maPhieu)
        {
            DialogResult dialogResult = MessageBox.Show("Không đủ nguyên liệu để áp dụng\nTự động thêm phiếu mua hàng?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Đã thêm phiếu mua thành công với mã '" + maPhieu + "'\n\nB1: chuyển sang màn hình 'PHIẾU MUA NGUYÊN LIỆU' để xác nhận nhập kho phiếu mua mã: " + maPhieu + "\n\nB2: quay lại màn hình 'ÁP DỤNG THỰC ĐƠN' Nhấp 'Áp dụng thực đơn' để hoàn tất", "Thông báo", MessageBoxButtons.OK);
            }
            else if (dialogResult == DialogResult.No)
            {
                PhieuMuaNLBLL.XoaPhieuMuaNL(maPhieu);
                return;
            }
        }

        private void dgvApDungThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dgvApDungThucDon.RowCount)
                return;
        }

        private bool SoSanhSoLuongTonVaSoLuongCanDung(List<string> listMaNguyenLieu, List<int> listSoLuong, int TongSoHocSinhAD, PhieuMuaNL phieuMua)
        {
            bool KiemTraSoLuongTonCoDuDung = true;
            //duyệt từng nguyên liệu để so sánh số lượng cần dùng và số lượng tồn trong kho
            for (int i = 0; i < listMaNguyenLieu.Count; i++)
            {
                int soLuongThieu = TongSoHocSinhAD * listSoLuong[i] - int.Parse(NguyenLieuBLL.LaySoLuongTonTheoMaNguyenLieu(listMaNguyenLieu[i]));

                //trường hợp thiếu nguyên liệu
                if (soLuongThieu > 0)
                {
                    //Thêm chi tiết mua nguyên liệu bị thiếu
                    ChiTietPhieuMuaNLBLL.ThemChiTietPhieuMuaNL(phieuMua.MaPhieu, listMaNguyenLieu[i], soLuongThieu, 0, 0);
                    //xác nhận số lượng không đủ dùng
                    KiemTraSoLuongTonCoDuDung =  false;
                }
            }

            return KiemTraSoLuongTonCoDuDung;
        }

        private int TinhTongSoLuongHocSinhApDung()
        {
            int TongSoHocSinhAD = 0;
            foreach (DataGridViewRow row in dgvLop.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) && !(row.DefaultCellStyle.BackColor == Color.Yellow))
                    TongSoHocSinhAD += int.Parse(row.Cells["SiSo"].Value.ToString());
            }
            return TongSoHocSinhAD;
        }

        private bool KiemTraNguyenLieuTrongKho()
        {
            //làm mới danh sách
            thongTinSoLuongNguyenLieuCanDeApDung.Clear();

            DataTable DanhSachMonAn = ChiTietThucDonBLL.LayDanhSachMaMonAnTheoThucDon(cboThucDon_Loc.Text.Trim());
            //duyệt tất cả các món ăn trong thực đơn
            foreach (DataRow MonAn in DanhSachMonAn.Rows)
            {
                //lấy ra danh sách các nguyên liệu có trong món ăn đang duyệt
                DataTable danhSachNguyenLieu = ApDungThucDonBLL.LayDanhSachMaNguyenLieuVaSoLuongTrongMonAn(MonAn["MaMonAn"].ToString());

                //duyệt danh sách nguyên liệu của món ăn
                foreach (DataRow nguyenLieu in danhSachNguyenLieu.Rows)
                {
                    ThemNguyenLieuVaoDanhSach(nguyenLieu["MaNguyenLieu"].ToString(), nguyenLieu["SoLuong"].ToString());
                }
            }

            //lấy ra danh sách nguyên liệu, sô lượng
            List<string> listMaNguyenLieu = new List<string>(thongTinSoLuongNguyenLieuCanDeApDung.Keys);
            List<int> listSoLuong = new List<int>(thongTinSoLuongNguyenLieuCanDeApDung.Values);

            //Thêm phiếu mua mới vào CSDL (giả sử cần phải mua thêm nguyên liệu)
            PhieuMuaNL phieuMua = new PhieuMuaNL();
            phieuMua = PhieuMuaNLBLL.TaoPhieuMuaMoi();
            
            //trường hợp mọi nguyên liệu đủ dùng
            if (SoSanhSoLuongTonVaSoLuongCanDung(listMaNguyenLieu,listSoLuong, TinhTongSoLuongHocSinhApDung(), phieuMua))
            {
                HuyBoMuaHangVaCapNhatNguyenLieu(phieuMua, listMaNguyenLieu, listSoLuong, TinhTongSoLuongHocSinhApDung());
                return true;
            }

            ThongBaoXacNhanThemPhieuMua(phieuMua.MaPhieu);
            return false;
        }

        private void btnApDungThucDon_Click(object sender, EventArgs e)
        {
            //---------------kiểm tra điều kiện nhấn áp dụng-------------------
            if (!KiemTraDieuKienBanDauDeApDungThucDon())
                return;

            //--------------------------tiến hành kiểm tra thông tin và áp dụng--------------------------
            if(!KiemTraNguyenLieuTrongKho())
            {
                return;
            }

            string danhSachLopThanhCong = "";
            string danhSachLopThatBai = "";

            foreach (DataGridViewRow row in dgvLop.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) && !(row.DefaultCellStyle.BackColor == Color.Yellow))
                {
                    if (ApDungThucDonBLL.KiemTraApdungThucDon(row.Cells["MaLop"].Value.ToString(), dtpNgay_Loc.Value.ToShortDateString(), cboBuoiAD.Text))
                        danhSachLopThatBai += row.Cells["MaLop"].Value.ToString() + "\n";

                    else
                    {
                        danhSachLopThanhCong += row.Cells["MaLop"].Value.ToString() + "\n";
                        ApDungThucDonBLL.ThemApDungThucDon(cboThucDon_Loc.Text, cboBuoiAD.Text, dtpNgay_Loc.Value, row.Cells["MaLop"].Value.ToString());
                    }
                }
            }

            if (danhSachLopThanhCong != "")
                MessageBox.Show("Lớp áp dụng thành công:\n" + danhSachLopThanhCong, "Thông báo", MessageBoxButtons.OK);
            if (danhSachLopThatBai != "")
                MessageBox.Show("Lớp áp dụng không thành công:\n" + danhSachLopThatBai + "các lớp này đã được xét áp dụng thực đơn rồi", "Thông báo", MessageBoxButtons.OK);

            ChangeRowsColor();

        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex > dgvLop.RowCount)
                return;

            if(dgvLop.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.Yellow)
            {
                dgvLop.ClearSelection();
                return;
            }
        }

        private void ckbAll_Click(object sender, EventArgs e)
        {
            
        }

      

        private void dtpNgay_Loc_ValueChanged(object sender, EventArgs e)
        {
            ChangeRowsColor();
            getDataGridViewApDungThucDon(dtpNgay_Loc.Value, cboBuoiAD.Text);
            Check_DgvLop();

        }

        private void cboBuoiAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeRowsColor();
            getDataGridViewApDungThucDon(dtpNgay_Loc.Value, cboBuoiAD.Text);
            Check_DgvLop();
        }

        private void ckbAll_CheckedChanged(object sender, EventArgs e)
        {
            Check_DgvLop();
        }

        //hàm check combobox của dgvLop theo combobox CheckAll
        public void Check_DgvLop()
        {
            foreach (DataGridViewRow row in dgvLop.Rows)
            {
                if (!(row.DefaultCellStyle.BackColor == Color.Yellow))
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[0];
                    cell.Selected = ckbAll.Checked;
                    cell.Value = ckbAll.Checked;
                    row.Cells[0].Value = ckbAll.Checked;
                }
            }
        }
    }
}
