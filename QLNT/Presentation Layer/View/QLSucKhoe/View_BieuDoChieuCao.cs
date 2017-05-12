using System;
using System.Windows.Forms;
using QLNT.BusinessLayer;
using QLNT.Entities;

namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    public partial class View_BieuDoChieuCao : UserControl
    {
        public string maTre;

        private void SetMaTre()
        {
            frmMain parentForm = (this.Parent.Parent as frmMain);
            View_ThongTinSucKhoe view_ThongTinSucKhoe = parentForm.GetView("ThongTinSucKhoe") as View_ThongTinSucKhoe;
            maTre = view_ThongTinSucKhoe.GetMaTre();
        }

        public View_BieuDoChieuCao()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Visible = false;
        }

        private void View_BieuDoChieuCao_Load(object sender, EventArgs e)
        {
            SetMaTre();
            Tre tre = TreBLL.GetTre(maTre);
            if (tre != null)
                txtHoTenTre.Text = tre.HoTenTre;
        }
    }
}
