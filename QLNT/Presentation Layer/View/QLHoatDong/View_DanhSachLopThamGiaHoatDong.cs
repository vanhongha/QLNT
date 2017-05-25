using System;
using System.Windows.Forms;
using QLNT.BusinessLayer;
using QLNT.Utility;
using QLNT.Entities;
using System.Collections.Generic;
using System.Data;

namespace QLNT.Presentation_Layer.View.QLHoatDong
{
    public partial class View_DanhSachLopThamGiaHoatDong : UserControl
    {
        string maHD = "";
        Dictionary<string, bool> listLop = new Dictionary<string, bool>();

        public View_DanhSachLopThamGiaHoatDong()
        {
            InitializeComponent();
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "CheckBox";
            checkBoxColumn.HeaderText = "X";
            checkBoxColumn.Width = 50;
            checkBoxColumn.ReadOnly = false;
            dgvListLop.Columns.Add(checkBoxColumn);
        }

        private void SetMaHD()
        {
            frmMain parentForm = (this.Parent.Parent as frmMain);
            View_HoatDongNgoaiKhoa view_DSLop = parentForm.GetView("HoatDongNgoaiKhoa") as View_HoatDongNgoaiKhoa;
            maHD = view_DSLop.GetMaHD();
        }

        private void View_DanhSachLopThamGiaHoatDong_Load(object sender, EventArgs e)
        {
        }

        public void LoadForm()
        {
            SetMaHD();
            labelTenHoatDong.Text = HoatDongNgoaiKhoaBLL.GetTenHoatDong(maHD);
            SetMaHD();
            if (maHD != "")
                LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgvListLop.DataSource = LopBLL.GetListLop();
            string[] listProp = { "CheckBox", "MaLop", "TenLop", "SiSo" };
            ControlFormat.DataGridViewFormat(dgvListLop, listProp);
            dgvListLop.Columns["MaLop"].HeaderText = "Mã lớp";
            dgvListLop.Columns["TenLop"].HeaderText = "Tên lớp";
            dgvListLop.Columns["SiSo"].HeaderText = "Sỉ số";
        }

        private bool CheckLopThamGia(string maLop, string[] listLop)
        {
            foreach (string lop in listLop)
            {
                if(maLop == lop)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnApDungTatCa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvListLop.Rows.Count; i++)
            {
                listLop[dgvListLop.Rows[i].Cells["MaLop"].Value.ToString()] = true;
            }
            if (HoatDongNgoaiKhoaBLL.CapNhatLopThamGia(listLop, maHD))
            {
                MessageBox.Show("Cập nhật lớp tham gia thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvListLop.Rows.Count; i++)
            {
                string maLop = dgvListLop.Rows[i].Cells["MaLop"].Value.ToString();
                if (dgvListLop.Rows[i].Cells["CheckBox"].Value.ToString() == "true" || dgvListLop.Rows[i].Cells["CheckBox"].Value.ToString() == "True")
                    listLop[maLop] = true;
                else
                    listLop[maLop] = false;
            }
            if(HoatDongNgoaiKhoaBLL.CapNhatLopThamGia(listLop, maHD))
            {
                MessageBox.Show("Cập nhật lớp tham gia thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
        }

        private void dgvListLop_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string[] lopThamGia = HoatDongNgoaiKhoaBLL.GetListLopThamGia(maHD);
            listLop.Clear();
            if (lopThamGia != null)
            {
                for (int i = 0; i < dgvListLop.RowCount; i++)
                {
                    DataGridViewCheckBoxCell chkBoxCell = (DataGridViewCheckBoxCell)dgvListLop.Rows[i].Cells["CheckBox"];
                    if (CheckLopThamGia(dgvListLop.Rows[i].Cells["MaLop"].Value.ToString(), lopThamGia))
                    {
                        chkBoxCell.Value = "true";
                        listLop.Add(dgvListLop.Rows[i].Cells["MaLop"].Value.ToString(), true);
                    }
                    else
                    {
                        chkBoxCell.Value = "false";
                        listLop.Add(dgvListLop.Rows[i].Cells["MaLop"].Value.ToString(), false);
                    }
                }
            }
        }

        private void btnTreThamGia_Click(object sender, EventArgs e)
        {
            string[] lopThamGia = HoatDongNgoaiKhoaBLL.GetListLopThamGia(maHD);
            if (dgvListLop.SelectedRows.Count > 0)
            {
                if(!CheckLopThamGia(dgvListLop.SelectedRows[0].Cells["MaLop"].Value.ToString(), lopThamGia))
                {
                    MessageBox.Show("Lớp này không tham gia hoạt động ngoại khóa, bạn cần chọn và lưu lớp này tham gia hoạt động trước mới có thể chỉnh sửa danh sách trẻ tham gia hoạt động.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmMain parentForm = (this.Parent.Parent as frmMain);
                    parentForm.UpdateSubView("DanhSachTreThamGiaHoatDong");
                    View_DanhSachTreThamGiaHoatDong view = (View_DanhSachTreThamGiaHoatDong)parentForm.GetSubView("DanhSachTreThamGiaHoatDong");
                    view.LoadForm(maHD, dgvListLop.SelectedRows[0].Cells["MaLop"].Value.ToString());
                }
            }
        }

        private void dgvListLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                txtMaLop.Text = dgvListLop.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
                txtTenLop.Text = dgvListLop.Rows[e.RowIndex].Cells["TenLop"].Value.ToString();
                txtSiSoLop.Text = dgvListLop.Rows[e.RowIndex].Cells["SiSo"].Value.ToString();
                txtTreThamGia.Text = HoatDongNgoaiKhoaBLL.GetListTreThamGiaHoatDong(maHD, txtMaLop.Text).Length.ToString();
            }
        }
    }
}
