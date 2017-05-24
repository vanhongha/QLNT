using System;
using System.Windows.Forms;
using QLNT.Utility;
using QLNT.BusinessLayer;

namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    public partial class View_ThongTinSucKhoe : UserControl
    {
        private string maTre = "";

        public string GetMaTre()
        {
            return maTre;
        }

        public View_ThongTinSucKhoe()
        {
            InitializeComponent();
        }

        private void View_ThongTinSucKhoe_Load(object sender, EventArgs e)
        {
            GetListLop();
        }

        private void GetListLop()
        {
            cboLop.DataSource = LopBLL.GetListLop();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.Text = "";
        }

        private void GetDataGridViewDanhSachTre()
        {
            dgvListTre.DataSource = TreBLL.GetListTreTheoLop(cboLop.SelectedValue.ToString());
            string[] listProp = {"HoTenTre", "GioiTinh", "NgaySinh" };
            ControlFormat.DataGridViewFormat(dgvListTre, listProp);
            dgvListTre.Columns["HoTenTre"].HeaderText = "Họ tên trẻ";
            dgvListTre.Columns["HoTenTre"].Width = 170;
            dgvListTre.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvListTre.Columns["GioiTinh"].Width = 90;
            dgvListTre.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvListTre.Columns["NgaySinh"].Width = 100;
        }

        private void GetDataGridViewKetQua()
        {
            if(cboThang.Text != "" && cboNam.Text != "")
            {
                dgvKetQua.DataSource = DichVuSucKhoeBLL.GetListKetQuaSucKhoeTheoThang(maTre, int.Parse(cboThang.Text), int.Parse(cboNam.Text));
                string[] listProp = { "NgayKham", "CanNang", "ChieuCao" };
                ControlFormat.DataGridViewFormat(dgvKetQua, listProp);
                dgvKetQua.Columns["NgayKham"].HeaderText = "Ngày khám";
                dgvKetQua.Columns["NgayKham"].Width = 120;
                dgvKetQua.Columns["CanNang"].HeaderText = "Cân nặng";
                dgvKetQua.Columns["ChieuCao"].HeaderText = "Chiều cao";
            }
        }

        private void LoadComboboxThang()
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            cboThang.DataSource = list;
            cboThang.Text = DateTime.Today.Month.ToString();
        }

        private void LoadComboboxNam()
        {
            cboNam.DataSource = TreBLL.GetLopDaHoc(maTre);
            cboNam.DisplayMember = "NamHoc";
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataGridViewDanhSachTre();
            txtHoTen.Text = "";
            txtCanNang.Text = "";
            txtChieuCao.Text = "";
            txtNgayKham.Text = "";
            txtTinhTrang.Text = "";
            cboThang.Text = "";
            cboNam.Text = "";
            cboThang.Enabled = false;
            cboNam.Enabled = false;
            dgvKetQua.DataSource = null;
            maTre = "";
        }

        private void dgvListTre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                maTre = dgvListTre.Rows[e.RowIndex].Cells["MaTre"].Value.ToString();
                LoadComboboxThang();
                LoadComboboxNam();
                cboThang.Enabled = true;
                cboNam.Enabled = true;
                GetDataGridViewKetQua();
            }
        }

        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                txtHoTen.Text = TreBLL.GetHoTen(maTre);
                txtCanNang.Text = dgvKetQua.Rows[e.RowIndex].Cells["CanNang"].Value.ToString() + " kg";
                txtChieuCao.Text = dgvKetQua.Rows[e.RowIndex].Cells["ChieuCao"].Value.ToString() + " cm";
                txtTinhTrang.Text = dgvKetQua.Rows[e.RowIndex].Cells["TheTrang"].Value.ToString();
                txtNgayKham.Text = dgvKetQua.Rows[e.RowIndex].Cells["NgayKham"].Value.ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            if (dgvKetQua.SelectedRows.Count > 0)
            {
                    Form frm_BaoCaoCTSK = new frm_BaoCaoChiTietSK(maTre, int.Parse(cboNam.Text), dgvKetQua.SelectedRows[0].Cells["MaDV"].Value.ToString(),
                        dgvKetQua.SelectedRows[0].Cells["CanNang"].Value.ToString(), dgvKetQua.SelectedRows[0].Cells["ChieuCao"].Value.ToString(), dgvKetQua.SelectedRows[0].Cells["TheTrang"].Value.ToString());
                    frm_BaoCaoCTSK.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn phải một kết quả khám để in báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataGridViewKetQua();
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataGridViewKetQua();
        }
    }
}
