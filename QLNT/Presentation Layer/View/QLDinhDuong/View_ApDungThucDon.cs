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
                
                if (ApDungThucDonBLL.KiemTraApdungThucDon(row.Cells["MaLop"].Value.ToString(), dtpNgay_Loc.Value.ToShortDateString(), cboBuoiAD.Text))
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.ReadOnly = true;
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[0];
                    //cell.Selected = true;
                    cell.Value = true;
                }

                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.ReadOnly = false;
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[0];
                    //cell.Selected = true;
                    cell.Value = false;
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

        private bool KiemTra_btnApDungThucDon_Click()
        {

            

            if (dtpNgay_Loc.Value < DateTime.Today)
            {
                MessageBox.Show("Thất bại! Không thể áp dụng thực đơn cho ngày đã qua", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (cboBuoiAD.Text == "")
            {
                MessageBox.Show("chọn buổi để áp dụng", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

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

        private void HuyBoMuaHang_btnApDungThucDon_Click(PhieuMuaNL phieuMua, List<string> listMaNguyenLieu, List<int> listSoLuong)
        {
            //xóa phiếu mua vừa tạo
            PhieuMuaNLBLL.XoaPhieuMuaNL(phieuMua.MaPhieu);

            //thực hiện trừ số lượng nguyên liệu được dùng
            for (int i = 0; i < listMaNguyenLieu.Count; i++)
                NguyenLieuBLL.CapNhatTonNguyenLieuTheoMa(listMaNguyenLieu[i], -listSoLuong[i]);

            //Thêm thông tin áp dụng vào CSDL
            //ApDungThucDonBLL.ThemApDungThucDon(txtMaThucDon.Text, cboLop.SelectedValue.ToString(), dtpNgayApDung.Value, cboBuoiAD2.Text);
            getDataGridViewApDungThucDon(dtpNgay_Loc.Value, cboBuoiAD.Text);

            MessageBox.Show("Áp dụng thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void ThongBaoThanhCong_btnApDungThucDon_Click(string maPhieu)
        {
            DialogResult dialogResult = MessageBox.Show("Không đủ nguyên liệu để áp dụng\nTự động thêm phiếu mua hàng?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Đã thêm phiếu mua thành công với mã '" + maPhieu + "'\nvui lòng chuyển sang màn hình phiếu mua để xác nhận nhập kho\nCuối cùng Nhấp ''Áp dụng thực đơn'' để hoàn tất", "Thông báo", MessageBoxButtons.OK);
            }
            else if (dialogResult == DialogResult.No)
            { return; }
        }

        private void dgvApDungThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dgvApDungThucDon.RowCount)
                return;
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex > dgvApDungThucDon.RowCount)
                return;

            if(dgvLop.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.Yellow)
            {
                dgvLop.ClearSelection();
                return;
            }

            if(!Convert.ToBoolean(dgvLop.Rows[e.RowIndex].Cells[0].Value))
            {
                dgvLop.Rows[e.RowIndex].Cells[0].Value = true;
            }
        }

        private void ckbAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvLop.Rows)
            {
                if(!(row.DefaultCellStyle.BackColor == Color.Yellow))
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[0];
                    cell.Selected = ckbAll.Checked;
                    cell.Value = ckbAll.Checked;
                }
            }
        }

        private void btnApDungThucDon_Click(object sender, EventArgs e)
        {
            //---------------kiểm tra điều kiện nhấn áp dụng-------------------
            if (!KiemTra_btnApDungThucDon_Click())
                return;

            //--------------------------tiến hành kiểm tra thông tin và áp dụng--------------------------

            ////biến kiểm tra số lượng nguyên liệu có đủ dùng hay không
            //bool KiemTraSoLuongTonCoDuDung = true;

            ////xóa danh sách số lượng nguyên liệu cần để áp dụng(cũ)
            //thongTinSoLuongNguyenLieuCanDeApDung.Clear();
            //DataTable DanhSachMonAn = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            ////duyệt tất cả các món ăn trong thực đơn
            //foreach (DataRow MonAn in DanhSachMonAn.Rows)
            //{
            //    //lấy ra danh sách các nguyên liệu có trong món ăn đang duyệt
            //    DataTable danhSachNguyenLieu = ApDungThucDonBLL.LayDanhSachMaNguyenLieuVaSoLuongTrongMonAn(MonAn["MaMonAn"].ToString());

            //    //duyệt danh sách nguyên liệu của món ăn
            //    foreach (DataRow nguyenLieu in danhSachNguyenLieu.Rows)
            //    {
            //        ThemNguyenLieuVaoDanhSach(nguyenLieu["MaNguyenLieu"].ToString(), nguyenLieu["SoLuong"].ToString());
            //    }
            //}

            ////lấy ra danh sách nguyên liệu, sô lượng
            //List<string> listMaNguyenLieu = new List<string>(thongTinSoLuongNguyenLieuCanDeApDung.Keys);
            //List<int> listSoLuong = new List<int>(thongTinSoLuongNguyenLieuCanDeApDung.Values);

            ////Thêm phiếu mua mới vào CSDL (giả sử cần phải mua thêm nguyên liệu)
            //PhieuMuaNL phieuMua = new PhieuMuaNL();
            //phieuMua = PhieuMuaNLBLL.TaoPhieuMuaMoi();

            ////duyệt từng nguyên liệu để so sánh số lượng cần dùng và số lượng tồn trong kho
            //for (int i = 0; i < listMaNguyenLieu.Count; i++)
            //{
            //    int soLuongThieu = listSoLuong[i] - int.Parse(NguyenLieuBLL.LaySoLuongTonTheoMaNguyenLieu(listMaNguyenLieu[i]));

            //    //trường hợp thiếu nguyên liệu
            //    if (soLuongThieu > 0)
            //    {
            //        //Thêm chi tiết mua nguyên liệu bị thiếu
            //        ChiTietPhieuMuaNLBLL.ThemChiTietPhieuMuaNL(phieuMua.MaPhieu, listMaNguyenLieu[i], soLuongThieu, 0, 0);
            //        //xác nhận số lượng không đủ dùng
            //        KiemTraSoLuongTonCoDuDung = false;
            //    }
            //}

            ////trường hợp mọi nguyên liệu đủ dùng
            //if (KiemTraSoLuongTonCoDuDung)
            //{
            //    HuyBoMuaHang_btnApDungThucDon_Click(phieuMua, listMaNguyenLieu, listSoLuong);
            //    return;
            //}

            //ThongBaoThanhCong_btnApDungThucDon_Click(phieuMua.MaPhieu);

            string danhSachLopThanhCong = "";
            string danhSachLopThatBai = "";

            foreach (DataGridViewRow row in dgvLop.Rows)
            {
                //DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[0];
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

            if(danhSachLopThanhCong != "")
                MessageBox.Show("Lớp áp dụng thành công:\n" + danhSachLopThanhCong, "Thông báo", MessageBoxButtons.OK);
            if(danhSachLopThatBai != "")
                MessageBox.Show("Lớp áp dụng không thành công:\n" + danhSachLopThatBai + "các lớp này đã được xét áp dụng thực đơn rồi", "Thông báo", MessageBoxButtons.OK);

            ChangeRowsColor();

        }

        private void dtpNgay_Loc_ValueChanged(object sender, EventArgs e)
        {
            ChangeRowsColor();
            getDataGridViewApDungThucDon(dtpNgay_Loc.Value, cboBuoiAD.Text);

        }

        private void cboBuoiAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeRowsColor();
            getDataGridViewApDungThucDon(dtpNgay_Loc.Value, cboBuoiAD.Text);
        }
    }
}
