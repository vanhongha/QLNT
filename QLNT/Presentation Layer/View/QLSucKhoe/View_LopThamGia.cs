using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLNT.BusinessLayer;
using QLNT.Utility;

namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    public partial class View_LopThamGia : UserControl
    {
        string maDV = "";
        Dictionary<string, bool> listLop = new Dictionary<string, bool>();

        public View_LopThamGia()
        {
            InitializeComponent();
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "CheckBox";
            checkBoxColumn.HeaderText = "X";
            checkBoxColumn.Width = 50;
            checkBoxColumn.ReadOnly = false;
            dgvListLop.Columns.Add(checkBoxColumn);
        }

        private void SetMaDV()
        {
            frmMain parentForm = (this.Parent.Parent as frmMain);
            View_DichVuSucKhoe view_DSLop = parentForm.GetView("DichVuSucKhoe") as View_DichVuSucKhoe;
            if(view_DSLop != null)
                maDV = view_DSLop.GetMaDV();
        }

        private void View_LopThamGia_Load(object sender, EventArgs e)
        {
            SetMaDV();
            LoadListDichVu();
            SetMaDV();
            if (maDV != "")
                LoadDataGridView();
        }

        private void LoadListDichVu()
        {
            cboTenDichVu.DataSource = DichVuSucKhoeBLL.GetListDichVu();
            cboTenDichVu.DisplayMember = "TenDichVu";
            cboTenDichVu.ValueMember = "MaDichVu";
            if (cboTenDichVu.Text == "")
                cboTenDichVu.SelectedText = maDV;
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
                if (maLop == lop)
                {
                    return true;
                }
            }
            return false;
        }

        private void cboTenDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            maDV = cboTenDichVu.SelectedValue.ToString();
            LoadDataGridView();
        }

        private void btnApDungTatCa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvListLop.Rows.Count - 1; i++)
            {
                listLop[dgvListLop.Rows[i].Cells["MaLop"].Value.ToString()] = true;
            }
            if (DichVuSucKhoeBLL.CapNhatLopThamGia(listLop, maDV))
            {
                MessageBox.Show("Cập nhật lớp tham gia thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvListLop.Rows.Count - 1; i++)
            {
                string maLop = dgvListLop.Rows[i].Cells["MaLop"].Value.ToString();
                if (dgvListLop.Rows[i].Cells["CheckBox"].Value.ToString() == "True")
                    listLop[maLop] = true;
                else
                    listLop[maLop] = false;
            }
            if (DichVuSucKhoeBLL.CapNhatLopThamGia(listLop, maDV))
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
            string[] lopThamGia = DichVuSucKhoeBLL.GetListLopThamGia(maDV);
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
