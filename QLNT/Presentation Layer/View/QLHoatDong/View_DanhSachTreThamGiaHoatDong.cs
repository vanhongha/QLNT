using System;
using System.Windows.Forms;
using QLNT.BusinessLayer;
using QLNT.Utility;

namespace QLNT.Presentation_Layer.View.QLHoatDong
{
    public partial class View_DanhSachTreThamGiaHoatDong : UserControl
    {
        string maLop;

        public View_DanhSachTreThamGiaHoatDong()
        {
            InitializeComponent();
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "CheckBox";
            checkBoxColumn.HeaderText = "X";
            checkBoxColumn.Width = 50;
            checkBoxColumn.ReadOnly = false;
            dgvListTre.Columns.Add(checkBoxColumn);
        }

        public void LoadForm(string tenHoatDong, string maLop)
        {
            labelTenHoatDong.Text = tenHoatDong;
            this.maLop = maLop;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgvListTre.DataSource = TreBLL.GetListTreTheoLop(maLop);
            string[] listProp = { "CheckBox", "MaTre", "TenTre" };
            ControlFormat.DataGridViewFormat(dgvListTre, listProp);
            dgvListTre.Columns["MaTre"].HeaderText = "Mã trẻ";
            dgvListTre.Columns["TenTre"].HeaderText = "Tên trẻ";           
        }

        private void dgvListTre_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnApDungTatCa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
