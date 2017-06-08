using System;

using System.Windows.Forms;
using QLNT.BusinessLayer;
using System.Data;
using System.Drawing;

namespace QLNT.Presentation_Layer.View.XepLop
{

    public partial class View_XepLop : UserControl
    {
        string maLop;

        public View_XepLop()
        {
            InitializeComponent();
        }

        private void View_XepLop_Load(object sender, EventArgs e)
        {
            GetListLop();
            GetListLoaiLop();
            GetGVCN();

            txtTaoLop.Visible = false;
            cboLop.Visible = true;
            rdoLopCoSan.Checked = true;
            
            titleLoaiLop.Visible = false;
            cboLoaiLop.Visible = false;
            titleGVCN.Visible = false;
            cboGVCN.Visible = false;
            titleNam.Visible = false;
            txtNam.Visible = false;
            titleSS.Visible = false;
            txtSS.Visible = false;

            ckbAll.Visible = false;
            txtKetQua.Text = "";
        }

        private void rdoLopCoSan_CheckedChanged(object sender, EventArgs e)
        {
            cboLop.Text = "";
            txtTaoLop.Visible = false;
            cboLop.Visible = true;
            title.Text = "Chọn lớp để xếp lớp cho các trẻ được chọn:";
            titleLoaiLop.Visible = false;
            cboLoaiLop.Visible = false;
            titleGVCN.Visible = false;
            cboGVCN.Visible = false;
            titleNam.Visible = false;
            txtNam.Visible = false;
            titleSS.Visible = false;
            txtSS.Visible = false;
        }

        private void rdoLopMoi_CheckedChanged(object sender, EventArgs e)
        {
            cboLoaiLop.Text = "";
            txtTaoLop.Visible = true;
            cboLop.Visible = false;
            title.Text = "Nhập tên lớp mới cần tạo:";
            titleLoaiLop.Visible = true;
            cboLoaiLop.Visible = true;
            titleGVCN.Visible = true;
            cboGVCN.Visible = true;
            titleNam.Visible = true;
            txtNam.Visible = true;
            titleSS.Visible = true;
            txtSS.Visible = true;
        }

        private void GetDataGridView()
        {
            dgvTre.DataSource = TreBLL.TreChuaCoLop(txtNamSinh.Text);
            
            string[] columns = { "MaTre", "HoTenTre", "NgaySinh", "GioiTinh" };
            Utility.ControlFormat.DataGridViewFormat(dgvTre, columns);

            dgvTre.Columns[0].HeaderText = "Mã trẻ";
            dgvTre.Columns[1].HeaderText = "Họ và tên";
            dgvTre.Columns[2].HeaderText = "Ngày sinh";
            dgvTre.Columns[3].HeaderText = "Giới tính";

            DataGridViewCheckBoxColumn columnSave = new DataGridViewCheckBoxColumn();

            ckbAll.Visible = true;
            ckbAll.Checked = false;

            // Set column values
            columnSave.Name = "SaveButton";
            columnSave.HeaderText = "";
            dgvTre.Columns.Insert(0, columnSave);
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

        private void GetListLop()
        {
            cboLop.DataSource = LopBLL.GetListLop();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.Text = "";
        }

        private void GetListLoaiLop()
        {
            cboLoaiLop.DataSource = LopBLL.GetListLoaiLop();
            cboLoaiLop.DisplayMember = "TenLop";
            cboLoaiLop.ValueMember = "MaLoaiLop";
            cboLoaiLop.Text = "";
        }

        private void GetGVCN()
        {
            cboGVCN.DataSource = NhanVienBLL.GetGVCN();
            cboGVCN.DisplayMember = "TenNhanVien";
            cboGVCN.ValueMember = "MaNV";
            cboGVCN.Text = "";
        }

        private void dgvTre_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ckbAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        public void CheckAll()
        {
            foreach (DataGridViewRow row in dgvTre.Rows)
            {
                if (!(row.DefaultCellStyle.BackColor == Color.Yellow))
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[0];
                    cell.Selected = ckbAll.Checked;
                    cell.Value = ckbAll.Checked;
                    row.Cells[0].Value = ckbAll.Checked;
                }
            }
        }

        private void btn_TiepNhanTre_Click(object sender, EventArgs e)
        {
            if(rdoLopCoSan.Checked)
            {
                ThemTreVaoLopCoSan();
                cboLop.Text = "";
            }
            else
            {
                ThemTreVaoLopMoi();
                txtNam.Text = "";
                txtSS.Text = "";
                txtTaoLop.Text = "";
                cboGVCN.Text = "";
                cboLoaiLop.Text = "";
            }

            GetDataGridView();
        }

        private void ThemTreVaoLopCoSan()
        {
            if (cboLop.Text != "" && dgvTre.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvTre.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        TreBLL.ThemTreVaoLop(row.Cells["MaTre"].Value.ToString(), cboLop.SelectedValue.ToString());
                    }
                }
                MessageBox.Show("Thêm trẻ vào lớp thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn trẻ & lớp để tiến hành xếp lớp", "Thông báo");
            }
        }

        private void ThemTreVaoLopMoi()
        {
            ThemLop();

            if (dgvTre.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvTre.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        TreBLL.ThemTreVaoLop(row.Cells["MaTre"].Value.ToString(), maLop);
                    }
                }
                MessageBox.Show("Thêm trẻ vào lớp thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn trẻ & lớp để tiến hành xếp lớp", "Thông báo");
            }
        }

        private void ThemLop()
        {
            maLop = LopBLL.AutoMaLop();
            Entities.Lop lop = new Entities.Lop(maLop,
         cboLoaiLop.SelectedValue.ToString(),
         txtTaoLop.Text,
         Int32.Parse(txtNam.Text),
         cboGVCN.SelectedValue.ToString(),
         Int32.Parse(txtSS.Text));

            if (!LopBLL.ThemLop(lop))
                MessageBox.Show("Thêm lớp thất bại");
        }
    }
}
