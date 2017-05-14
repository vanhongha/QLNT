using System;
using System.Windows.Forms;
using QLNT.BusinessLayer;
using QLNT.Entities;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;

namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    public partial class View_BieuDoChieuCao : UserControl
    {
        private string maTre = "";
        private Series series = new Series("Chiều cao");

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
            LoadCombobox();
        }

        private void LoadCombobox()
        {
            cboLop.DataSource = TreBLL.GetLopDaHoc(maTre);
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.Text = "";
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = LopBLL.GetNamHoc(cboLop.SelectedValue.ToString());
            DataTable dt = TreBLL.GetSucKhoe(maTre, year);

            int[] x = new int[dt.Rows.Count];
            double[] y = new double[dt.Rows.Count];

            DateTime ngayKham;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ngayKham = (DateTime)dt.Rows[0]["NgayKham"];
                x[i] = ngayKham.Month;
                y[i] = (double)dt.Rows[0]["ChieuCao"];
            }

            series.Points.DataBindXY(x, y);
            if (x.Length == 1)
                series.ChartType = SeriesChartType.Column;
            else
                series.ChartType = SeriesChartType.Line;

            chartChieuCao.Series.Clear();
            chartChieuCao.Series.Add(series);
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            Form frm_BaoCaoChieuCao = new frm_BaoCaoChieuCao(maTre, LopBLL.GetNamHoc(cboLop.SelectedValue.ToString()));
            frm_BaoCaoChieuCao.ShowDialog();
        }
    }
}
