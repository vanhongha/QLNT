using System;
using System.Windows.Forms;
using QLNT.BusinessLayer;
using QLNT.Entities;
using QLNT.Utility;

namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    public partial class View_DichVuSucKhoe : UserControl
    {
        private string maDV = "";

        public View_DichVuSucKhoe()
        {
            InitializeComponent();
        }

        public string GetMaDV()
        {
            return maDV;
        }

        private void View_DichVuSucKhoe_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            dtNgayKham.Value = DateTime.Today;
        }

        private void LoadDataGridView()
        {
            dgvSucKhoe.DataSource = DichVuSucKhoeBLL.GetListDichVu();
            string[] listProp = { "MaDichVu", "TenDichVu", "NgayKham" };
            ControlFormat.DataGridViewFormat(dgvSucKhoe, listProp);
            dgvSucKhoe.Columns["MaDichVu"].HeaderText = "Mã dịch vụ";
            dgvSucKhoe.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgvSucKhoe.Columns["NgayKham"].HeaderText = "Ngày khám";
            dgvSucKhoe.Columns["TenDichVu"].Width = 250;
        }

        private void dgvSucKhoe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                maDV = dgvSucKhoe.Rows[e.RowIndex].Cells["MaDichVu"].Value.ToString();
                txtMaDV.Text = maDV;
                txtTenDV.Text = dgvSucKhoe.Rows[e.RowIndex].Cells["TenDichVu"].Value.ToString();
                dtNgayKham.Value = DateTime.Parse(dgvSucKhoe.Rows[e.RowIndex].Cells["NgayKham"].Value.ToString());
                txtChiPhi.Text = dgvSucKhoe.Rows[e.RowIndex].Cells["ChiPhi"].Value.ToString();
                txtChiTiet.Text = dgvSucKhoe.Rows[e.RowIndex].Cells["ChiTiet"].Value.ToString();
            }
        }

        private void btnDSLopThamGia_Click(object sender, EventArgs e)
        {
            if (maDV != "")
            {
                //goi form danh sach lop tham gia dich vu
                frmMain parentForm = (this.Parent.Parent as frmMain);
                parentForm.UpdateSubView("DanhSachLopThamGiaDichVu");
<<<<<<< HEAD
=======
                View_LopThamGia view = (View_LopThamGia)parentForm.GetSubView("DanhSachLopThamGiaDichVu");
                view.LoadForm(maDV);
>>>>>>> origin/master
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một dịch vụ để xem thông tin lớp tham gia", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            dtNgayKham.Value = DateTime.Today;
            txtChiPhi.Text = "";
            txtChiTiet.Text = "";

            // auto generate MaDichVu here
            txtMaDV.Text = DichVuSucKhoeBLL.AutoMaDichVu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //luu dich vu
            if(txtTenDV.Text != "" && txtChiPhi.Text != "")
            {
                DichVuSucKhoe dichVu = new DichVuSucKhoe();
                dichVu.MaDV = txtMaDV.Text;
                dichVu.TenDV = txtTenDV.Text;
                dichVu.NgayKham = dtNgayKham.Value;
                dichVu.ChiTiet = txtChiTiet.Text;
                dichVu.ChiPhi = decimal.Parse(txtChiPhi.Text);
                if (DichVuSucKhoeBLL.LuuDichVu(dichVu))
                {
                    MessageBox.Show("Đã lưu dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Tên dịch vụ và chi phí không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSucKhoe.SelectedRows.Count > 0)
            {
                DichVuSucKhoe dichVu = new DichVuSucKhoe();
                dichVu.MaDV = dgvSucKhoe.SelectedRows[0].Cells["MaDichVu"].Value.ToString();
                dichVu.TenDV = dgvSucKhoe.SelectedRows[0].Cells["TenDichVu"].Value.ToString();
                dichVu.NgayKham = DateTime.Parse(dgvSucKhoe.SelectedRows[0].Cells["NgayKham"].Value.ToString());
                dichVu.ChiTiet = dgvSucKhoe.SelectedRows[0].Cells["ChiTiet"].Value.ToString();
                dichVu.ChiPhi = decimal.Parse(dgvSucKhoe.SelectedRows[0].Cells["ChiPhi"].Value.ToString());

                DialogResult result = MessageBox.Show("Bạn có muốn xóa dịch vụ " + dichVu.TenDV + " với mã là: " + dichVu.MaDV + " không?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (DichVuSucKhoeBLL.XoaDichVu(dichVu))
                    {
                        MessageBox.Show("Đã xóa dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGridView();
                        txtMaDV.Clear();
                        txtTenDV.Clear();
                        txtChiPhi.Clear();
                        txtChiTiet.Clear();
                        dtNgayKham.Value = DateTime.Today;
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
