using System;
using System.Windows.Forms;
using QLNT.BusinessLayer;
using QLNT.Entities;

namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    public partial class View_ThongTinChiTietSK : UserControl
    {
        string maTre = "";

        private void SetMaTre()
        {
            frmMain parentForm = (this.Parent.Parent as frmMain);
            View_ThongTinSucKhoe view_ThongTinSucKhoe = parentForm.GetView("ThongTinSucKhoe") as View_ThongTinSucKhoe;
            maTre = view_ThongTinSucKhoe.GetMaTre();
        }

        public View_ThongTinChiTietSK()
        {
            InitializeComponent();
        }

        private void View_ThongTinChiTietSK_Load(object sender, EventArgs e)
        {
            SetMaTre();
            Tre tre = TreBLL.GetTre(maTre);
            if (tre != null)
                txtHoTenTre.Text = tre.HoTenTre;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
        }
    }
}
