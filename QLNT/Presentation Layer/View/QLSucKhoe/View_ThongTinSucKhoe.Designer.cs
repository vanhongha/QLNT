namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    partial class View_ThongTinSucKhoe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_ThongTinSucKhoe));
            this.label1 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvListTre = new System.Windows.Forms.DataGridView();
            this.btnXemCanNang = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXemChieuCao = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXemChiTietSK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCapNhatSucKhoe = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(470, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "Thông tin sức khỏe";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(177, 144);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(121, 28);
            this.cboLop.TabIndex = 57;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(35, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 26);
            this.label8.TabIndex = 56;
            this.label8.Text = "Chọn lớp:";
            // 
            // dgvListTre
            // 
            this.dgvListTre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTre.Location = new System.Drawing.Point(31, 212);
            this.dgvListTre.Name = "dgvListTre";
            this.dgvListTre.RowTemplate.Height = 28;
            this.dgvListTre.Size = new System.Drawing.Size(808, 500);
            this.dgvListTre.TabIndex = 55;
            this.dgvListTre.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListTre_CellClick);
            // 
            // btnXemCanNang
            // 
            this.btnXemCanNang.ActiveBorderThickness = 1;
            this.btnXemCanNang.ActiveCornerRadius = 20;
            this.btnXemCanNang.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXemCanNang.ActiveForecolor = System.Drawing.Color.White;
            this.btnXemCanNang.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXemCanNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.btnXemCanNang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXemCanNang.BackgroundImage")));
            this.btnXemCanNang.ButtonText = "Xem biểu đồ cân nặng";
            this.btnXemCanNang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemCanNang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCanNang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXemCanNang.IdleBorderThickness = 1;
            this.btnXemCanNang.IdleCornerRadius = 20;
            this.btnXemCanNang.IdleFillColor = System.Drawing.Color.White;
            this.btnXemCanNang.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXemCanNang.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXemCanNang.Location = new System.Drawing.Point(934, 225);
            this.btnXemCanNang.Margin = new System.Windows.Forms.Padding(8);
            this.btnXemCanNang.Name = "btnXemCanNang";
            this.btnXemCanNang.Size = new System.Drawing.Size(343, 63);
            this.btnXemCanNang.TabIndex = 59;
            this.btnXemCanNang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXemCanNang.Click += new System.EventHandler(this.btnXemCanNang_Click);
            // 
            // btnXemChieuCao
            // 
            this.btnXemChieuCao.ActiveBorderThickness = 1;
            this.btnXemChieuCao.ActiveCornerRadius = 20;
            this.btnXemChieuCao.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXemChieuCao.ActiveForecolor = System.Drawing.Color.White;
            this.btnXemChieuCao.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXemChieuCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.btnXemChieuCao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXemChieuCao.BackgroundImage")));
            this.btnXemChieuCao.ButtonText = "Xem biểu đồ chiều cao";
            this.btnXemChieuCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemChieuCao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChieuCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXemChieuCao.IdleBorderThickness = 1;
            this.btnXemChieuCao.IdleCornerRadius = 20;
            this.btnXemChieuCao.IdleFillColor = System.Drawing.Color.White;
            this.btnXemChieuCao.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXemChieuCao.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXemChieuCao.Location = new System.Drawing.Point(934, 357);
            this.btnXemChieuCao.Margin = new System.Windows.Forms.Padding(8);
            this.btnXemChieuCao.Name = "btnXemChieuCao";
            this.btnXemChieuCao.Size = new System.Drawing.Size(343, 63);
            this.btnXemChieuCao.TabIndex = 59;
            this.btnXemChieuCao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXemChieuCao.Click += new System.EventHandler(this.btnXemChieuCao_Click);
            // 
            // btnXemChiTietSK
            // 
            this.btnXemChiTietSK.ActiveBorderThickness = 1;
            this.btnXemChiTietSK.ActiveCornerRadius = 20;
            this.btnXemChiTietSK.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXemChiTietSK.ActiveForecolor = System.Drawing.Color.White;
            this.btnXemChiTietSK.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXemChiTietSK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.btnXemChiTietSK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXemChiTietSK.BackgroundImage")));
            this.btnXemChiTietSK.ButtonText = "Xem chi tiết sức khỏe";
            this.btnXemChiTietSK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemChiTietSK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTietSK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXemChiTietSK.IdleBorderThickness = 1;
            this.btnXemChiTietSK.IdleCornerRadius = 20;
            this.btnXemChiTietSK.IdleFillColor = System.Drawing.Color.White;
            this.btnXemChiTietSK.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXemChiTietSK.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXemChiTietSK.Location = new System.Drawing.Point(934, 501);
            this.btnXemChiTietSK.Margin = new System.Windows.Forms.Padding(8);
            this.btnXemChiTietSK.Name = "btnXemChiTietSK";
            this.btnXemChiTietSK.Size = new System.Drawing.Size(343, 63);
            this.btnXemChiTietSK.TabIndex = 59;
            this.btnXemChiTietSK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXemChiTietSK.Click += new System.EventHandler(this.btnXemChiTietSK_Click);
            // 
            // btnCapNhatSucKhoe
            // 
            this.btnCapNhatSucKhoe.ActiveBorderThickness = 1;
            this.btnCapNhatSucKhoe.ActiveCornerRadius = 20;
            this.btnCapNhatSucKhoe.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnCapNhatSucKhoe.ActiveForecolor = System.Drawing.Color.White;
            this.btnCapNhatSucKhoe.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnCapNhatSucKhoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.btnCapNhatSucKhoe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapNhatSucKhoe.BackgroundImage")));
            this.btnCapNhatSucKhoe.ButtonText = "Cập nhật sức khỏe";
            this.btnCapNhatSucKhoe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatSucKhoe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatSucKhoe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnCapNhatSucKhoe.IdleBorderThickness = 1;
            this.btnCapNhatSucKhoe.IdleCornerRadius = 20;
            this.btnCapNhatSucKhoe.IdleFillColor = System.Drawing.Color.White;
            this.btnCapNhatSucKhoe.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnCapNhatSucKhoe.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnCapNhatSucKhoe.Location = new System.Drawing.Point(934, 639);
            this.btnCapNhatSucKhoe.Margin = new System.Windows.Forms.Padding(8);
            this.btnCapNhatSucKhoe.Name = "btnCapNhatSucKhoe";
            this.btnCapNhatSucKhoe.Size = new System.Drawing.Size(343, 63);
            this.btnCapNhatSucKhoe.TabIndex = 59;
            this.btnCapNhatSucKhoe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCapNhatSucKhoe.Click += new System.EventHandler(this.btnCapNhatSucKhoe_Click);
            // 
            // View_ThongTinSucKhoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.btnCapNhatSucKhoe);
            this.Controls.Add(this.btnXemChiTietSK);
            this.Controls.Add(this.btnXemChieuCao);
            this.Controls.Add(this.btnXemCanNang);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvListTre);
            this.Controls.Add(this.label1);
            this.Name = "View_ThongTinSucKhoe";
            this.Size = new System.Drawing.Size(1390, 834);
            this.Load += new System.EventHandler(this.View_ThongTinSucKhoe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvListTre;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXemCanNang;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXemChieuCao;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXemChiTietSK;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCapNhatSucKhoe;
    }
}
