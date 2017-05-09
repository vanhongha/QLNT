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

        public void SetMaHD(string _maHD)
        {
            maHD = _maHD;
        }

        private void View_DanhSachLopThamGiaHoatDong_Load(object sender, EventArgs e)
        {
            SetMaHD();
            LoadListHoatDong();
            SetMaHD();
            if(maHD != "")
                LoadDataGridView();
        }

        private void LoadListHoatDong()
        {
            cboHoatDong.DataSource = HoatDongNgoaiKhoaBLL.GetListHoatDong();
            cboHoatDong.DisplayMember = "TenHoatDong";
            cboHoatDong.ValueMember = "MaHoatDong";
            if (cboHoatDong.Text == "")
                cboHoatDong.SelectedText = maHD;
        }

        private void LoadDataGridView()
        {
            dgvListLop.DataSource = LopBLL.GetListLop();
            string[] listProp = { "CheckBox", "MaLop", "TenLop", "SiSo" };
            ControlFormat.DataGridViewFormat(dgvListLop, listProp);
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

        private void cboHoatDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            maHD = cboHoatDong.SelectedValue.ToString();
            LoadDataGridView();
        }

        private void btnApDungTatCa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvListLop.Rows.Count - 1; i++)
            {
                listLop[dgvListLop.Rows[i].Cells["MaLop"].Value.ToString()] = true;
            }
            HoatDongNgoaiKhoaBLL.CapNhatLopThamGia(listLop, maHD);
            MessageBox.Show("Cập nhật lớp tham gia thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvListLop.Rows.Count - 1; i++)
            {
                string maLop = dgvListLop.Rows[i].Cells["MaLop"].Value.ToString();
                if (dgvListLop.Rows[i].Cells["CheckBox"].Value.ToString() == "true")
                    listLop[maLop] = true;
                else
                    listLop[maLop] = false;
            }
            HoatDongNgoaiKhoaBLL.CapNhatLopThamGia(listLop, maHD);
            MessageBox.Show("Cập nhật lớp tham gia thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void dgvListLop_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string[] lopThamGia = HoatDongNgoaiKhoaBLL.GetListLopThamGia(maHD);
            listLop.Clear();
            if (lopThamGia != null)
            {
                for (int i = 0; i < dgvListLop.RowCount - 1; i++)
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
    }
}
