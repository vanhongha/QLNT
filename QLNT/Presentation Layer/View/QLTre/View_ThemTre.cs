using System;

using System.Windows.Forms;
using QLNT.BusinessLayer;

namespace QLNT.Presentation_Layer.View
{
    public partial class View_ThemTre : UserControl
    {
        public View_ThemTre()
        {
            InitializeComponent();
        }

        private void btn_TiepNhanTre_Click(object sender, EventArgs e)
        {
            string gioiTinh;
            if(rdoNu.Checked == false && rdoNam.Checked == false)
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

            Entities.Tre tre = new Entities.Tre(TreBLL.AutoMaTre(),
            txtHoTen.Text,
            gioiTinh,
            dtNgaySinh.Value,
            txtTenBo.Text,
            txtTenMe.Text,
            txtDiaChi.Text,
            txtDienThoai.Text);

            try
            {
                if (TreBLL.ThemTre(tre))
                {
                    MessageBox.Show("Đã thêm trẻ thành công", "Thông báo", MessageBoxButtons.OK);
                    CleanInput();
                }
                else
                    MessageBox.Show("Lỗi chưa xác định", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CleanInput()
        {
            txtHoTen.Text = null;
            txtTenBo.Text = null;
            txtTenMe.Text = null;
            txtDienThoai.Text = null;
            txtDiaChi.Text = null;
            dtNgaySinh.ResetText();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
        }
    }
}
