using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using QLNT.BusinessLayer;

namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    public partial class frm_BaoCaoCanNang : Form
    {
        string maTre = "";
        int nam;
        public frm_BaoCaoCanNang(string maTre, int nam)
        {
            this.maTre = maTre;
            this.nam = nam;
            InitializeComponent();
        }

        private void frm_BaoCaoCanNang_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            LoadReport();
        }

        private void FillValue()
        {
            ReportParameter[] key = new ReportParameter[3];
            ReportParameter Nam = new ReportParameter("Nam", nam.ToString());
            ReportParameter NgayIn = new ReportParameter("NgayIn", DateTime.Today.ToShortTimeString());
            ReportParameter TenTre = new ReportParameter("TenTre", TreBLL.GetHoTen(maTre));


            key[0] = NgayIn;
            key[1] = Nam;
            key[2] = TenTre;

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
