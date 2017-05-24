using System;
using System.Windows.Forms;
using QLNT.BusinessLayer;
using QLNT.Entities;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;

namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    public partial class View_BieuDoCanNang : UserControl
    {
        private string maTre = "";
        private Series series = new Series("Cân Nặng");

        private void SetMaTre()
        {
            frmMain parentForm = (this.Parent.Parent as frmMain);
            View_ThongTinSucKhoe view_ThongTinSucKhoe = parentForm.GetView("ThongTinSucKhoe") as View_ThongTinSucKhoe;
            maTre = view_ThongTinSucKhoe.GetMaTre();
        }

        public View_BieuDoCanNang()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
        }

        private void View_BieuDoCanNang_Load(object sender, EventArgs e)
        {
            SetMaTre();
            Tre tre = TreBLL.GetTre(maTre);
            if(tre != null)
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
            //int year = LopBLL.GetNamHoc(cboLop.SelectedValue.ToString());
            //DataTable dt = TreBLL.GetSucKhoe(maTre, year);

            //DateTime[] x = new DateTime[dt.Rows.Count];
            //double[] y = new double[dt.Rows.Count];

            //DateTime ngayKham;

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    ngayKham = (DateTime)dt.Rows[0]["NgayKham"];
            //    x[i] = (DateTime)dt.Rows[0]["NgayKham"];
            //    y[i] = (double)dt.Rows[0]["CanNang"];
            //    series.Points.AddXY((DateTime)dt.Rows[i]["NgayKham"], (double)dt.Rows[i]["CanNang"]);
            //}

            ////series.Points.DataBindXY(x, y);
            //if (x.Length == 1)
            //    series.ChartType = SeriesChartType.Column;
            //else
            //    series.ChartType = SeriesChartType.Line;

            //series.XValueType = ChartValueType.DateTime;

            //chartCanNang.Series.Clear();
            //chartCanNang.Series.Add(series);

            //chartCanNang.Series[0].XValueType = ChartValueType.DateTime;
            //chartCanNang.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
            //if (x.Length > 0)
            //{
            //    DateTime minDate = new DateTime(x[0].Year, x[0].Month, x[0].Day);
            //    DateTime maxDate = new DateTime(x[x.Length - 1].Year, x[x.Length - 1].Month, x[x.Length - 1].Day);
            //    chartCanNang.ChartAreas[0].AxisX.Interval = 1;
            //    chartCanNang.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            //    chartCanNang.ChartAreas[0].AxisX.IntervalOffset = 1;
            //    chartCanNang.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            //    chartCanNang.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
            //}

            var s = new Series();
            s.ChartType = SeriesChartType.Line;

            var d = new DateTime(2013, 04, 01);

            int year = LopBLL.GetNamHoc(cboLop.SelectedValue.ToString());
            DataTable dt = TreBLL.GetSucKhoe(maTre, year);
            DateTime[] x = new DateTime[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                x[i] = (DateTime)dt.Rows[i]["NgayKham"];
                s.Points.AddXY((DateTime)dt.Rows[i]["NgayKham"], (double)dt.Rows[i]["CanNang"]);
            }

            //s.Points.AddXY(d, 3);
            //s.Points.AddXY(d.AddMonths(-1), 2);
            //s.Points.AddXY(d.AddMonths(-2), 1);
            //s.Points.AddXY(d.AddMonths(-3), 4);

            chartCanNang.Series.Clear();
            chartCanNang.Series.Add(s);


            chartCanNang.Series[0].XValueType = ChartValueType.DateTime;
            chartCanNang.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";
            chartCanNang.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;

            chartCanNang.Series[0].XValueType = ChartValueType.DateTime;
            if (x.Length > 0)
            {
                DateTime minDate = new DateTime(x[0].Year, x[0].Month, x[0].Day);
                DateTime maxDate = new DateTime(x[x.Length - 1].Year, x[x.Length - 1].Month, x[x.Length - 1].Day);
                chartCanNang.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                chartCanNang.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
            }
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            if(cboLop.SelectedValue.ToString() != "")
            {
                Form frm_BaoCaoCanNang = new frm_BaoCaoCanNang(maTre, LopBLL.GetNamHoc(cboLop.SelectedValue.ToString()));
                frm_BaoCaoCanNang.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn lớp cho trẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
}
