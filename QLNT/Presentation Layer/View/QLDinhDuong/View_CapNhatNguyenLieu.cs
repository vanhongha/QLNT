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
using QLNT.Entities;

namespace QLNT.Presentation_Layer.View.QLDinhDuong
{
    public partial class View_CapNhatNguyenLieu : UserControl
    {
        public View_CapNhatNguyenLieu()
        {
            InitializeComponent();
        }

        private void View_CapNhatNguyenLieu_Load(object sender, EventArgs e)
        {
            getDataGridView();
            getCombobox();
        }

        private void getDataGridView()
        {
            dataGridView1.DataSource = NguyenLieuBLL.layDanhSachNguyenLieu();
            string[] column = { "MaNguyenLieu", "TenNguyenLieu", "TenLoaiNL", "ChiSoDinhDuong", "SoLuongTon", "DonViTinh" };
            Utility.ControlFormat.DataGridViewFormat(dataGridView1, column);
            
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderText = "Mã nguyên liệu";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].HeaderText = "Tên nguyên liệu";
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].HeaderText = "Loại nguyên liệu";
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].HeaderText = "Chỉ số dinh dưỡng";
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].HeaderText = "Số lượng tồn";
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].HeaderText = "Đơn vị tính";
            dataGridView1.Columns[5].Width = 80;
        }


        private void getCombobox()
        {
            cbxLoaiNguyenLieu.DataSource = LoaiNguyenLieuBLL.layDanhSachLoaiNguyenLieu();
            cbxLoaiNguyenLieu.DisplayMember = "TenLoaiNL";
            cbxLoaiNguyenLieu.ValueMember = "MaLoaiNL";
            cbxLoaiNguyenLieu.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxLoaiNguyenLieu.Text = "";
            txtMaNguyenLieu.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNguyenLieu"].Value.ToString();
            txtTenNguyenLieu.Text = dataGridView1.Rows[e.RowIndex].Cells["TenNguyenLieu"].Value.ToString();
            //txtLoaiNguyenLieu.Text = dataGridView1.Rows[e.RowIndex].Cells["TenLoaiNL"].Value.ToString();
            cbxLoaiNguyenLieu.SelectedText = dataGridView1.Rows[e.RowIndex].Cells["TenLoaiNL"].Value.ToString();
            txtChiSoDinhDuong.Text = dataGridView1.Rows[e.RowIndex].Cells["ChiSoDinhDuong"].Value.ToString();
            txtSoLuongTon.Text = dataGridView1.Rows[e.RowIndex].Cells["SoLuongTon"].Value.ToString();
            txtDonViTinh.Text = dataGridView1.Rows[e.RowIndex].Cells["DonViTinh"].Value.ToString();
            
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaNguyenLieu.Text = "";
            txtTenNguyenLieu.Text = "";
            //txtLoaiNguyenLieu.Text = "";
            txtChiSoDinhDuong.Text = "";
            txtSoLuongTon.Text = "";
            txtDonViTinh.Text = "";
            cbxLoaiNguyenLieu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NguyenLieu nguyenLieu = new NguyenLieu();
            nguyenLieu.MaNguyenLieu = txtMaNguyenLieu.Text.Trim();
            nguyenLieu.TenNguyenLieu = txtTenNguyenLieu.Text.Trim();
            //nguyenLieu.MaLoai = txtLoaiNguyenLieu.Text.Trim();
            nguyenLieu.MaLoai = cbxLoaiNguyenLieu.SelectedValue.ToString().Trim();
            nguyenLieu.ChiSoDinhDuong = txtChiSoDinhDuong.Text.Trim();
            nguyenLieu.DonViTinh = txtDonViTinh.Text.Trim();
            nguyenLieu.SoLuongTon = txtSoLuongTon.Text.Trim();
            

            if(nguyenLieu.MaNguyenLieu != "" && nguyenLieu.TenNguyenLieu != "")
            {
                NguyenLieuBLL.themNguyenLieu(nguyenLieu);
            }
            else
                MessageBox.Show("Tên nguyên liệu và mã nguyên liệu không được để trống");


            getDataGridView();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NguyenLieu nguyenLieu = new NguyenLieu();
            nguyenLieu.MaNguyenLieu = txtMaNguyenLieu.Text.Trim();
            nguyenLieu.TenNguyenLieu = txtTenNguyenLieu.Text.Trim();

            //nguyenLieu.MaLoai = txtLoaiNguyenLieu.Text.Trim();
            nguyenLieu.MaLoai = cbxLoaiNguyenLieu.SelectedValue.ToString().Trim();

            nguyenLieu.ChiSoDinhDuong = txtChiSoDinhDuong.Text.Trim();
            nguyenLieu.DonViTinh = txtDonViTinh.Text.Trim();
            nguyenLieu.SoLuongTon = txtSoLuongTon.Text.Trim();


            if(nguyenLieu.MaNguyenLieu != "" && nguyenLieu.TenNguyenLieu != "")
                NguyenLieuBLL.capNhatNguyenLieu(nguyenLieu);
            else
                MessageBox.Show("Tên nguyên liệu và mã nguyên liệu không được để trống");

            getDataGridView();
        }
    }
}
