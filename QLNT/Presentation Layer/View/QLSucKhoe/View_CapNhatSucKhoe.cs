using System;
using System.Windows.Forms;
using QLNT.BusinessLayer;
using QLNT.Entities;
using QLNT.Utility;

namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    public partial class View_CapNhatSucKhoe : UserControl
    {
        public View_CapNhatSucKhoe()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
        }

        private void View_CapNhatSucKhoe_Load(object sender, EventArgs e)
        {
            LoadDanhSachLop();
            LoadDanhSachDichVu();
        }

        private void LoadDanhSachLop()
        {
            cboLop.DataSource = LopBLL.GetListLop();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.Text = "";
        }

        private void LoadDanhSachDichVu()
        {
            cboDichVu.DataSource = DichVuSucKhoeBLL.GetListDichVu();
            cboDichVu.DisplayMember = "TenDichVu";
            cboDichVu.ValueMember = "MaDichVu";
            cboDichVu.Text = "";
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDichVu.Text != "")
                LoadDataGridView();
        }

        private void cboDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgvListTre.DataSource = DichVuSucKhoeBLL.GetListSucKhoe(cboDichVu.SelectedValue.ToString(), cboLop.SelectedValue.ToString());
            string[] listProp = { "MaTre", "HoTenTre", "CanNang", "ChieuCao" };
            ControlFormat.DataGridViewFormat(dgvListTre, listProp);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "")
            {
                //cap nhat suc khoe cho tre
                if (DichVuSucKhoeBLL.CapNhatSucKhoe(cboDichVu.SelectedValue.ToString(), dgvListTre.CurrentRow.Cells["MaTre"].Value.ToString(),
                                                        float.Parse(txtCanNang.Text), float.Parse(txtChieuCao.Text), txtTinhTrang.Text))
                {
                    MessageBox.Show("Cập nhật sức khỏe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một trẻ để lưu sức khỏe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvListTre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHoTen.Text = dgvListTre.Rows[e.RowIndex].Cells["HoTenTre"].Value.ToString();
            txtCanNang.Text = dgvListTre.Rows[e.RowIndex].Cells["CanNang"].Value.ToString();
            txtChieuCao.Text = dgvListTre.Rows[e.RowIndex].Cells["ChieuCao"].Value.ToString();
            txtTinhTrang.Text = dgvListTre.Rows[e.RowIndex].Cells["TheTrang"].Value.ToString();
        }
    }
}
