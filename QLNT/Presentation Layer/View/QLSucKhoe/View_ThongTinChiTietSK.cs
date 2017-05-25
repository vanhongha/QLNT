using System;
using System.Windows.Forms;
using QLNT.BusinessLayer;
using QLNT.Entities;
using System.Data;

namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    public partial class View_ThongTinChiTietSK : UserControl
    {
        string maTre = "";

        private void SetMaTre()
        {
            frmMain parentForm = (this.Parent as frmMain);
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
            LoadComboboxThang();
            LoadComboboxNam();
        }

        private void LoadComboboxThang()
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            cboThang.DataSource = list;
            cboThang.Text = DateTime.Today.Month.ToString();
        }

        private void LoadComboboxNam()
        {
            cboNam.DataSource = TreBLL.GetLopDaHoc(maTre);
            cboNam.DisplayMember = "NamHoc";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongTinSucKhoe();
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongTinSucKhoe();
        }

        private void LoadThongTinSucKhoe()
        {
            try
            {
                DataTable dt = TreBLL.GetSucKhoeTheoThang(maTre, int.Parse(cboThang.Text), int.Parse(cboNam.Text));
                foreach (DataRow row in dt.Rows)
                {
                    txtCanNang.Text = row["CanNang"].ToString();
                    txtChieuCao.Text = row["ChieuCao"].ToString();
                    txtTinhTrangSK.Text = row["TheTrang"].ToString();
                    return;
                }

                txtCanNang.Text = "";
                txtChieuCao.Text = "";
                txtTinhTrangSK.Text = "";

            } catch(Exception ex)
            {

            }
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
           
        }
    }
}
