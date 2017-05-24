using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLNT.BusinessLayer;
using QLNT.Utility;

namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    public partial class View_DanhSachTreThamGiaDichVu : UserControl
    {
        string maLop;
        string maDV;
        Dictionary<string, bool> listTre = new Dictionary<string, bool>();

        public View_DanhSachTreThamGiaDichVu()
        {
            InitializeComponent();
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "CheckBox";
            checkBoxColumn.HeaderText = "X";
            checkBoxColumn.Width = 50;
            checkBoxColumn.ReadOnly = false;
            dgvListTre.Columns.Add(checkBoxColumn);
        }

        public void LoadForm(string maDV, string maLop)
        {
            labelTenDV.Text = DichVuSucKhoeBLL.GetTenDV(maDV);
            this.maLop = maLop;
            this.maDV = maDV;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgvListTre.DataSource = TreBLL.GetListTreTheoLop(maLop);
            string[] listProp = { "CheckBox", "MaTre", "HoTenTre" };
            ControlFormat.DataGridViewFormat(dgvListTre, listProp);
            dgvListTre.Columns["MaTre"].HeaderText = "Mã trẻ";
            dgvListTre.Columns["MaTre"].Width = 150;
            dgvListTre.Columns["HoTenTre"].HeaderText = "Tên trẻ";
            dgvListTre.Columns["HoTenTre"].Width = 250;
        }

        private bool CheckTreThamGia(string maTre, string[] listTre)
        {
            foreach (string tre in listTre)
            {
                if (maTre == tre)
                {
                    return true;
                }
            }
            return false;
        }

        private void View_DanhSachTreThamGiaDichVu_Load(object sender, EventArgs e)
        {
           
        }

        private void btnApDungTatCa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvListTre.Rows.Count; i++)
            {
                listTre[dgvListTre.Rows[i].Cells["MaTre"].Value.ToString()] = true;
            }
            if (DichVuSucKhoeBLL.CapNhatTreThamGiaDichVu(listTre, maDV))
            {
                MessageBox.Show("Cập nhật trẻ tham gia thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvListTre.Rows.Count; i++)
            {
                string maTre = dgvListTre.Rows[i].Cells["MaTre"].Value.ToString();
                if (dgvListTre.Rows[i].Cells["CheckBox"].Value.ToString() == "true" || dgvListTre.Rows[i].Cells["CheckBox"].Value.ToString() == "True")
                    listTre[maTre] = true;
                else
                    listTre[maTre] = false;
            }
            if (DichVuSucKhoeBLL.CapNhatTreThamGiaDichVu(listTre, maDV))
            {
                MessageBox.Show("Cập nhật trẻ tham gia thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
        }

        private void dgvListTre_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string[] treThamGia = DichVuSucKhoeBLL.GetListTreThamGiaDichVu(maDV, maLop);
            listTre.Clear();
            if (treThamGia != null)
            {
                for (int i = 0; i < dgvListTre.RowCount; i++)
                {
                    DataGridViewCheckBoxCell chkBoxCell = (DataGridViewCheckBoxCell)dgvListTre.Rows[i].Cells["CheckBox"];
                    if (CheckTreThamGia(dgvListTre.Rows[i].Cells["MaTre"].Value.ToString(), treThamGia))
                    {
                        chkBoxCell.Value = "true";
                        listTre.Add(dgvListTre.Rows[i].Cells["MaTre"].Value.ToString(), true);
                    }
                    else
                    {
                        chkBoxCell.Value = "false";
                        listTre.Add(dgvListTre.Rows[i].Cells["MaTre"].Value.ToString(), false);
                    }
                }
            }
        }

        private void dgvListTre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtMaTre.Text = dgvListTre.Rows[e.RowIndex].Cells["MaTre"].Value.ToString();
                txtTenTre.Text = dgvListTre.Rows[e.RowIndex].Cells["HoTenTre"].Value.ToString();
            }
        }
    }
}
