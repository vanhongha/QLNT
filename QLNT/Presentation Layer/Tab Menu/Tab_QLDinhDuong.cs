using System;
using System.Windows.Forms;

namespace QLNT.Presentation_Layer.Tab_Menu
{
    public partial class Tab_QLDinhDuong : UserControl
    {
        public Tab_QLDinhDuong()
        {
            InitializeComponent();
        }

        private void btnThemThcDon_Click(object sender, EventArgs e)
        {
            frmMain parentForm = (this.Parent.Parent.Parent as frmMain);
            parentForm.UpdateView(function.ThemThucDon);
        }

        private void btnCapNhatTraCuu_Click(object sender, EventArgs e)
        {
            frmMain parentForm = (this.Parent.Parent.Parent as frmMain);
            parentForm.UpdateView(function.CapNhatTraCuuThucDon);
        }

        private void btnCapNhatNguyenLieu_Click(object sender, EventArgs e)
        {
            frmMain parentForm = (this.Parent.Parent.Parent as frmMain);
            parentForm.UpdateView(function.ThemNguyenLieu);
        }
    }
}
