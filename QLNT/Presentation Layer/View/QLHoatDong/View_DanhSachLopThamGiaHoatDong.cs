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
        }

        public void SetMaHD(string _maHD)
        {
            maHD = _maHD;
        }

        private void View_DanhSachLopThamGiaHoatDong_Load(object sender, EventArgs e)
        {
            LoadListHoatDong();
            if(maHD != "")
                LoadDataGridView();
        }

        private void LoadListHoatDong()
        {
            cboHoatDong.DataSource = HoatDongNgoaiKhoaBLL.GetListHoatDong();
            cboHoatDong.DisplayMember = "TenHoatDong";
            cboHoatDong.ValueMember = "MaHoatDong";
            cboHoatDong.SelectedText = maHD;
        }

        private void LoadDataGridView()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "CheckBox";
            checkBoxColumn.HeaderText = "X";
            checkBoxColumn.Width = 50;
            checkBoxColumn.ReadOnly = false;
            dgvListLop.Columns.Add(checkBoxColumn);

            dgvListLop.DataSource = LopBLL.GetListLop();
            string[] listProp = { "CheckBox", "MaLop", "TenLop", "SiSo" };
            ControlFormat.DataGridViewFormat(dgvListLop, listProp);

            string[] lopThamGia = HoatDongNgoaiKhoaBLL.GetListLopThamGia(maHD);
            listLop.Clear();
            if (lopThamGia != null)
            {
                for (int i = 0; i < dgvListLop.RowCount; i++)
                {
                    if (CheckLopThamGia(dgvListLop.Rows[i].Cells["MaLop"].Value.ToString(), lopThamGia))
                    {
                        dgvListLop.Rows[i].Cells["CheckBox"].Value = true;
                        listLop.Add(dgvListLop.Rows[i].Cells["MaLop"].Value.ToString(), true);
                    }
                    else
                    {
                        listLop.Add(dgvListLop.Rows[i].Cells["MaLop"].Value.ToString(), false);
                    }
                }
            }
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
            maHD = cboHoatDong.Text;
            LoadDataGridView();
        }

        private void btnApDungTatCa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvListLop.Rows.Count ; i++)
            {
                listLop[dgvListLop.Rows[i].Cells["MaLop"].Value.ToString()] = true;
            }
            HoatDongNgoaiKhoaBLL.CapNhatLopThamGia(listLop, maHD);
            LoadDataGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvListLop.Rows.Count; i++)
            {
                string maLop = dgvListLop.Rows[i].Cells["MaLop"].Value.ToString();
                if (dgvListLop.Rows[i].Cells["CheckBox"].Value.ToString() == "true")
                    listLop[maLop] = true;
                else
                    listLop[maLop] = false;
            }
            HoatDongNgoaiKhoaBLL.CapNhatLopThamGia(listLop, maHD);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
