namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    partial class View_BieuDoCanNang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_BieuDoCanNang));
            this.label1 = new System.Windows.Forms.Label();
            this.chartCanNang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnHuy = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnInBaoCao = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.txtHoTenTre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartCanNang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(486, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Biểu đồ cân nặng";
            // 
            // chartCanNang
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCanNang.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCanNang.Legends.Add(legend2);
            this.chartCanNang.Location = new System.Drawing.Point(156, 200);
            this.chartCanNang.Name = "chartCanNang";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCanNang.Series.Add(series2);
            this.chartCanNang.Size = new System.Drawing.Size(1118, 542);
            this.chartCanNang.TabIndex = 73;
            this.chartCanNang.Text = "chart1";
            // 
            // btnHuy
            // 
            this.btnHuy.ActiveBorderThickness = 1;
            this.btnHuy.ActiveCornerRadius = 20;
            this.btnHuy.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnHuy.ActiveForecolor = System.Drawing.Color.White;
            this.btnHuy.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.ButtonText = "Hủy";
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnHuy.IdleBorderThickness = 1;
            this.btnHuy.IdleCornerRadius = 20;
            this.btnHuy.IdleFillColor = System.Drawing.Color.White;
            this.btnHuy.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnHuy.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnHuy.Location = new System.Drawing.Point(776, 762);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(8);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(272, 63);
            this.btnHuy.TabIndex = 71;
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.ActiveBorderThickness = 1;
            this.btnInBaoCao.ActiveCornerRadius = 20;
            this.btnInBaoCao.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnInBaoCao.ActiveForecolor = System.Drawing.Color.White;
            this.btnInBaoCao.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnInBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.btnInBaoCao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInBaoCao.BackgroundImage")));
            this.btnInBaoCao.ButtonText = "In báo cáo";
            this.btnInBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInBaoCao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnInBaoCao.IdleBorderThickness = 1;
            this.btnInBaoCao.IdleCornerRadius = 20;
            this.btnInBaoCao.IdleFillColor = System.Drawing.Color.White;
            this.btnInBaoCao.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnInBaoCao.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnInBaoCao.Location = new System.Drawing.Point(300, 762);
            this.btnInBaoCao.Margin = new System.Windows.Forms.Padding(8);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(272, 63);
            this.btnInBaoCao.TabIndex = 72;
            this.btnInBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(1152, 135);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(121, 28);
            this.cboLop.TabIndex = 70;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // txtHoTenTre
            // 
            this.txtHoTenTre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTenTre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHoTenTre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoTenTre.HintForeColor = System.Drawing.Color.Empty;
            this.txtHoTenTre.HintText = "";
            this.txtHoTenTre.isPassword = false;
            this.txtHoTenTre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(89)))), ((int)(((byte)(180)))));
            this.txtHoTenTre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtHoTenTre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(89)))), ((int)(((byte)(180)))));
            this.txtHoTenTre.LineThickness = 3;
            this.txtHoTenTre.Location = new System.Drawing.Point(336, 112);
            this.txtHoTenTre.Margin = new System.Windows.Forms.Padding(6);
            this.txtHoTenTre.Name = "txtHoTenTre";
            this.txtHoTenTre.Size = new System.Drawing.Size(522, 49);
            this.txtHoTenTre.TabIndex = 69;
            this.txtHoTenTre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(1048, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 26);
            this.label7.TabIndex = 67;
            this.label7.Text = "Lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(94, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 68;
            this.label3.Text = "Họ tên trẻ:";
            // 
            // View_BieuDoCanNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.chartCanNang);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.txtHoTenTre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "View_BieuDoCanNang";
            this.Size = new System.Drawing.Size(1390, 834);
            this.Load += new System.EventHandler(this.View_BieuDoCanNang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCanNang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCanNang;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHuy;
        private Bunifu.Framework.UI.BunifuThinButton2 btnInBaoCao;
        private System.Windows.Forms.ComboBox cboLop;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHoTenTre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
    }
}
