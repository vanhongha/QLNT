using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using QLNT.BusinessLayer;

namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    public partial class frm_BaoCaoChiTietSK : Form
    {
        string maTre = "";
        int nam;
        string maDV;
        string canNang;
        string chieuCao;
        string theTrang;

        public frm_BaoCaoChiTietSK(string maTre, int nam, string maDV, string canNang, string chieuCao, string theTrang)
        {
            this.maTre = maTre;
            this.nam = nam;
            this.maDV = maDV;
            this.canNang = canNang;
            this.chieuCao = chieuCao;
            this.theTrang = theTrang;
            InitializeComponent();

        }

        private void frm_BaoCaoChiTietSK_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            LoadReport();
        }

        private void FillValue()
        {
            ReportParameter[] key = new ReportParameter[8];
            ReportParameter Nam = new ReportParameter("Nam", nam.ToString());
            ReportParameter NgayIn = new ReportParameter("NgayIn", DateTime.Today.ToShortTimeString());
            ReportParameter TenTre = new ReportParameter("TenTre", TreBLL.GetHoTen(maTre));
            ReportParameter TenDV = new ReportParameter("TenDV", DichVuSucKhoeBLL.GetTenDV(maDV));
            ReportParameter NgayKham = new ReportParameter("NgayKham", DichVuSucKhoeBLL.GetDV(maDV).NgayKham.ToShortDateString());
            ReportParameter CanNang = new ReportParameter("CanNang", canNang);
            ReportParameter ChieuCao = new ReportParameter("ChieuCao", chieuCao);
            ReportParameter TheTrang = new ReportParameter("TinhTrang", theTrang);

            key[0] = NgayIn;
            key[1] = Nam;
            key[2] = TenTre;
            key[3] = TenDV;
            key[4] = NgayKham;
            key[5] = CanNang;
            key[6] = ChieuCao;
            key[7] = TheTrang;

            reportViewer1.LocalReport.SetParameters(key);
        }

        private void LoadReport()
        {
            FillValue();
            this.VW_SUCKHOETableAdapter.FillBy(this.SucKhoeDataSet.VW_SUCKHOE, maTre, nam);

            this.reportViewer1.RefreshReport();
        }
    }
}
