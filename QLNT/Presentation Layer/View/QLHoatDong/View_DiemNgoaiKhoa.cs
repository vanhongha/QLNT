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
using QLNT.Utility;

namespace QLNT.Presentation_Layer.View.QLHoatDong
{
    public partial class View_DiemNgoaiKhoa : UserControl
    {
        public View_DiemNgoaiKhoa()
        {
            InitializeComponent();
        }

        private void View_DiemNgoaiKhoa_Load(object sender, EventArgs e)
        {
            cboLop.DataSource = LopBLL.GetListLop();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";

            cboHoatDong.DataSource = HoatDongNgoaiKhoaBLL.GetListHoatDong();
            cboHoatDong.DisplayMember = "TenHoatDong";
            cboHoatDong.ValueMember = "MaHoatDong";
        }

        private void LoadDataGridView()
        {
            dgvDiemTre.DataSource = HoatDongNgoaiKhoaBLL.GetListDiemHoatDong(cboHoatDong.SelectedValue.ToString(), cboLop.SelectedValue.ToString());
            string[] listProp = { "MaTre", "HoTenTre", "Diem" };
            ControlFormat.DataGridViewFormat(dgvDiemTre, listProp);
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHoatDong.Text != "")
            {
                LoadDataGridView();
            }
        }

        private void cboHoatDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoTenTre.Text != "")
            {
                //cap nhat diem hoat dong cho tre
                if(HoatDongNgoaiKhoaBLL.CapNhatDiemHoatDong(cboHoatDong.SelectedValue.ToString(), dgvDiemTre.CurrentRow.Cells["MaTre"].Value.ToString(),
                                                        float.Parse(txtDiem.Text), txtNhanXet.Text))
                {
                    MessageBox.Show("Cập nhật điểm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một trẻ để lưu điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //quay ve form main hoac form hoat dong

        }

        private void dgvDiemTre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHoTenTre.Text = dgvDiemTre.Rows[e.RowIndex].Cells["HoTenTre"].Value.ToString();
            txtNhanXet.Text = dgvDiemTre.Rows[e.RowIndex].Cells["NhanXet"].Value.ToString();
            txtDiem.Text = dgvDiemTre.Rows[e.RowIndex].Cells["Diem"].Value.ToString();
        }

        
    }
}
