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
            
        }

        public void LoadForm(string maDV)
        {
            this.maDV = maDV;
            labelTenDV.Text = DichVuSucKhoeBLL.GetTenDV(maDV);
            if (maDV != "")
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
                if (maLop == lop)
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
            if (DichVuSucKhoeBLL.CapNhatLopThamGia(listLop, maDV))
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
                if (dgvListLop.Rows[i].Cells["CheckBox"].Value.ToString() == "True" || dgvListLop.Rows[i].Cells["CheckBox"].Value.ToString() == "true")
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
            string[] lopThamGia = DichVuSucKhoeBLL.GetListLopThamGia(maDV);
            if (dgvListLop.SelectedRows.Count > 0)
            {
                if (!CheckLopThamGia(dgvListLop.SelectedRows[0].Cells["MaLop"].Value.ToString(), lopThamGia))
                {
                    MessageBox.Show("Lớp này không tham gia dịch vụ y tế này, bạn cần chọn và lưu lớp này tham gia dịch vụ trước mới có thể chỉnh sửa danh sách trẻ tham gia dịch vụ.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmMain parentForm = (this.Parent.Parent as frmMain);
                    parentForm.UpdateSubView("DanhSachTreThamGiaDichVu");
                    View_DanhSachTreThamGiaDichVu view = (View_DanhSachTreThamGiaDichVu)parentForm.GetSubView("DanhSachTreThamGiaDichVu");
                    view.LoadForm(maDV, dgvListLop.SelectedRows[0].Cells["MaLop"].Value.ToString());
                }
            }
        }

        private void dgvListLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtMaLop.Text = dgvListLop.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
                txtTenLop.Text = dgvListLop.Rows[e.RowIndex].Cells["TenLop"].Value.ToString();
                txtSiSoLop.Text = dgvListLop.Rows[e.RowIndex].Cells["SiSo"].Value.ToString();
                txtTreThamGia.Text = DichVuSucKhoeBLL.GetListTreThamGiaDichVu(maDV, txtMaLop.Text).Length.ToString();
            }
        }
    }
}
