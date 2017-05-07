using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNT.Utility;
using QLNT.BusinessLayer;

namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    public partial class View_ThongTinSucKhoe : UserControl
    {
        private string maTre = "";

        public View_ThongTinSucKhoe()
        {
            InitializeComponent();
        }

        private void View_ThongTinSucKhoe_Load(object sender, EventArgs e)
        {
            GetListLop();
            GetDataGridView();
        }

        private void GetListLop()
        {
            cboLop.DataSource = LopBLL.GetListLop();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.SelectedItem = cboLop.Top;
        }

        private void GetDataGridView()
        {
            dgvListTre.DataSource = TreBLL.GetListTreTheoLop(cboLop.Text);
            string[] listProp = { "MaTre", "HoTenTre", "GioiTinh", "NgaySinh" };
            ControlFormat.DataGridViewFormat(dgvListTre, listProp);
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void btnXemCanNang_Click(object sender, EventArgs e)
        {
            if(maTre != "")
            {
                //goi form bieu do can nang
            } else
            {
                MessageBox.Show("Bạn phải chọn một trẻ trong danh sách để xem thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXemChieuCao_Click(object sender, EventArgs e)
        {
            if (maTre != "")
            {
                //goi form bieu do chieu cao
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một trẻ trong danh sách để xem thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXemChiTietSK_Click(object sender, EventArgs e)
        {
            if (maTre != "")
            {
                //goi form chi tiet suc khoe
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một trẻ trong danh sách để xem thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhatSucKhoe_Click(object sender, EventArgs e)
        {
            if (maTre != "")
            {
                //goi form cap nhat suc khoe
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một trẻ trong danh sách để xem thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvListTre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maTre = dgvListTre.Rows[e.RowIndex].Cells["MaTre"].Value.ToString();
        }
    }
}
