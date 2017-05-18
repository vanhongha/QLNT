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
            string[] listProp = { "MaDichVu", "TenDichVu", "NgayKham", "ChiTiet" };
            ControlFormat.DataGridViewFormat(dgvSucKhoe, listProp);
        }

        private void dgvSucKhoe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maDV = dgvSucKhoe.Rows[e.RowIndex].Cells["MaDichVu"].Value.ToString();
            txtMaDV.Text = maDV;
            txtTenDV.Text = dgvSucKhoe.Rows[e.RowIndex].Cells["TenDichVu"].Value.ToString();
            dtNgayKham.Value = DateTime.Parse(dgvSucKhoe.Rows[e.RowIndex].Cells["NgayKham"].Value.ToString());
            txtChiPhi.Text = dgvSucKhoe.Rows[e.RowIndex].Cells["ChiPhi"].Value.ToString();
            txtChiTiet.Text = dgvSucKhoe.Rows[e.RowIndex].Cells["ChiTiet"].Value.ToString();
        }

        private void btnDSLopThamGia_Click(object sender, EventArgs e)
        {
            if (maDV != "")
            {
                //goi form danh sach lop tham gia dich vu
                frmMain parentForm = (this.Parent.Parent as frmMain);
                parentForm.UpdateSubView("DanhSachLopThamGiaDichVu");

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
            //txtMaDV.Text = ;
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
        }
    }
}
