using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNT.BusinessLayer;

namespace QLNT.Presentation_Layer.View.XepLop
{
    public partial class View_XepLop : UserControl
    {
        public View_XepLop()
        {
            InitializeComponent();
        }

        private void View_XepLop_Load(object sender, EventArgs e)
        {
            txtTaoLop.Visible = false;
            cboLop.Visible = true;
            rdoLopCoSan.Checked = true;
        }

        private void rdoLopCoSan_CheckedChanged(object sender, EventArgs e)
        {
            txtTaoLop.Visible = false;
            cboLop.Visible = true;
            title.Text = "Chọn lớp để xếp lớp cho các trẻ được chọn:";
        }

        private void rdoLopMoi_CheckedChanged(object sender, EventArgs e)
        {
            txtTaoLop.Visible = true;
            cboLop.Visible = false;
            title.Text = "Nhập tên lớp mới cần tạo:";
        }

        private void GetDataGridView()
        {
            dgvTre.DataSource = TreBLL.TreChuaCoLop(txtNamSinh.Text);
            string[] columns = { "HoTenTre", "NgaySinh", "GioiTinh" };
            Utility.ControlFormat.DataGridViewFormat(dgvTre, columns);
            dgvTre.Columns[1].HeaderText = "Họ và tên";
            dgvTre.Columns[2].HeaderText = "Ngày sinh";
            dgvTre.Columns[3].HeaderText = "Giới tính";
        }

        private void txtHoTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNamSinh.Text != "")
                {
                    dgvTre.DataSource = TreBLL.TreChuaCoLop(txtNamSinh.Text);
                    txtKetQua.Text = "Tìm được " + (dgvTre.RowCount).ToString() + " trẻ chưa được xếp lớp";
                    GetDataGridView();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập năm sinh để tìm kiếm trẻ", "Thông báo");
                }
            }
        }
    }
}
