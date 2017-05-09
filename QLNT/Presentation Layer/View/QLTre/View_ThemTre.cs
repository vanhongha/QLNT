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
            Entities.Tre tre = new Entities.Tre(TreBLL.AutoMaTre(),
            txtHoTen.Text,
            "Nam",
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
                }
                else
                    MessageBox.Show("Lỗi chưa xác định", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
