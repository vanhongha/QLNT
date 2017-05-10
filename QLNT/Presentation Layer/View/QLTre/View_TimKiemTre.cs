using QLNT.BusinessLayer;
using QLNT.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLNT.Presentation_Layer.View
{
    public partial class View_TimKiemTre : UserControl
    {
        string maTre;
        public View_TimKiemTre()
        {
            InitializeComponent();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTimKiem.Text != "")
                {
                    dgvTimKiem.DataSource = TreBLL.TimKiemTre(txtTimKiem.Text);
                    labSoLuong.Text = "Tìm được " + (dgvTimKiem.RowCount - 1).ToString() + " kết quả";
                }
                else
                {
                    MessageBox.Show("Nhập từ khóa tìm kiếm", "Thông báo");
                }
            }
        }

        private void dgvTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.RowIndex != dgvTimKiem.RowCount)
                {
                    maTre = dgvTimKiem.Rows[e.RowIndex].Cells["MaTre"].Value.ToString();
                    GetThongTinTre(maTre);
                    btnXoa.Enabled = true;
                    btnCapNhat.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void GetThongTinTre(string maTre)
        {
            string gioiTinh;
            DataTable dt = TreBLL.GetThongTinTre(maTre);
            txtHoTen.Text = dt.Rows[0]["HoTenTre"].ToString();

            gioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            if (gioiTinh == "Nam")
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;

            //dtNgaySinh.Value = DateTime.ParseExact(dt.Rows[0]["HoTenMe"].ToString(), "dd/MM/yyy", null);

            txtHoTenMe.Text = dt.Rows[0]["HoTenMe"].ToString();
            txtHoTenBo.Text = dt.Rows[0]["HoTenCha"].ToString();
            txtDienThoai.Text = dt.Rows[0]["SDTLienLac"].ToString();
            txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
        }

        private void View_TimKiemTre_Load(object sender, EventArgs e)
        {
            GetDataGridView();
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Tre tre = new Tre();

                tre.MaTre = maTre;
                tre.HoTenTre = txtHoTen.Text;

                if (rdoNam.Checked)
                    tre.GioiTinh = "Nam";
                else
                    tre.GioiTinh = "Nu";

                tre.NgaySinh = dtNgaySinh.Value;
                tre.HoTenCha = txtHoTenBo.Text;
                tre.HoTenMe = txtHoTenMe.Text;
                tre.DiaChi = txtDiaChi.Text;
                tre.SoDT = txtDienThoai.Text;

                MessageBox.Show(tre.MaTre);

                TreBLL.CapNhatThongTinTre(tre);
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                GetDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void GetDataGridView()
        {
            dgvTimKiem.DataSource = TreBLL.GetList();
            string[] columns = { "HoTenTre", "GioiTinh", "NgaySinh" };
            Utility.ControlFormat.DataGridViewFormat(dgvTimKiem, columns);
            /*dgvTimKiem.Columns[0].HeaderText = "Họ và tên";
            dgvTimKiem.Columns[1].HeaderText = "Ngày sinh";
            dgvTimKiem.Columns[2].HeaderText = "Giới tính";*/
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa trẻ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    TreBLL.XoaTre(maTre);
                    MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtDiaChi.Text = "";
                    txtDienThoai.Text = "";
                    txtHoTen.Text = "";
                    txtHoTenBo.Text = "";
                    txtHoTenMe.Text = "";
                    dtNgaySinh.ResetText();

                    GetDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
    
}
