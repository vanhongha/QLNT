using System;
using System.Windows.Forms;
using QLNT.BusinessLayer;

namespace QLNT.Presentation_Layer.View
{
    public partial class View_ThemNV : UserControl
    {
        public View_ThemNV()
        {
            InitializeComponent();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string gioiTinh;
            if (rdoNu.Checked == false && rdoNam.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính cho trẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (rdoNu.Checked)
                    gioiTinh = "Nu";
                else
                    gioiTinh = "Nam";
            }

            Entities.NhanVien nhanVien = new Entities.NhanVien(
            NhanVienBLL.AutoMaNV(),
            txtHoTen.Text,
            gioiTinh,
            dtNgaySinh.Value,
            txtEmail.Text,
            txtDiaChi.Text,
            txtSDT.Text);

            try
            {
                if (NhanVienBLL.ThemNV(nhanVien))
                {
                    MessageBox.Show("Đã thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
                    CleanInput();
                }
                else
                    MessageBox.Show("Lỗi chưa xác định", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CleanInput()
        {
            txtHoTen.Text = null;
            txtDiaChi.Text = null;
            dtNgaySinh.ResetText();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            txtEmail.Text = null;
            txtSDT.Text = null;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            CleanInput();
        }
    }
}
