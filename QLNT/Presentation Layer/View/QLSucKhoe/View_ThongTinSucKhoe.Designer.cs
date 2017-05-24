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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNam = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHuy = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnInBaoCao = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCanNang = new System.Windows.Forms.TextBox();
            this.txtChieuCao = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.RichTextBox();
            this.txtNgayKham = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTre)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(447, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "THÔNG TIN SỨC KHỎE";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(208, 111);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(121, 28);
            this.cboLop.TabIndex = 57;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(68, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 26);
            this.label8.TabIndex = 56;
            this.label8.Text = "Chọn lớp:";
            // 
            // dgvListTre
            // 
            this.dgvListTre.AllowUserToAddRows = false;
            this.dgvListTre.AllowUserToDeleteRows = false;
            this.dgvListTre.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListTre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTre.Location = new System.Drawing.Point(21, 48);
            this.dgvListTre.Name = "dgvListTre";
            this.dgvListTre.RowTemplate.Height = 28;
            this.dgvListTre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTre.Size = new System.Drawing.Size(593, 256);
            this.dgvListTre.TabIndex = 55;
            this.dgvListTre.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListTre_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListTre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(55, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 325);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách trẻ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboThang);
            this.groupBox2.Controls.Add(this.cboNam);
            this.groupBox2.Controls.Add(this.dgvKetQua);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelNam);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(55, 516);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 302);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả sức khỏe";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(21, 104);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowTemplate.Height = 28;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.Size = new System.Drawing.Size(593, 182);
            this.dgvKetQua.TabIndex = 0;
            this.dgvKetQua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_CellClick);
            // 
            // cboThang
            // 
            this.cboThang.Enabled = false;
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(119, 44);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(121, 33);
            this.cboThang.TabIndex = 62;
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.cboThang_SelectedIndexChanged);
            // 
            // cboNam
            // 
            this.cboNam.Enabled = false;
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(460, 44);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(121, 33);
            this.cboNam.TabIndex = 63;
            this.cboNam.SelectedIndexChanged += new System.EventHandler(this.cboNam_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(25, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 60;
            this.label3.Text = "Tháng:";
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNam.ForeColor = System.Drawing.Color.Navy;
            this.labelNam.Location = new System.Drawing.Point(379, 51);
            this.labelNam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(65, 26);
            this.labelNam.TabIndex = 61;
            this.labelNam.Text = "Năm:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTinhTrang);
            this.groupBox3.Controls.Add(this.txtChieuCao);
            this.groupBox3.Controls.Add(this.txtCanNang);
            this.groupBox3.Controls.Add(this.txtNgayKham);
            this.groupBox3.Controls.Add(this.txtHoTen);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(761, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 491);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết sức khỏe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(120, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 60;
            this.label4.Text = "Họ tên trẻ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(104, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 26);
            this.label5.TabIndex = 60;
            this.label5.Text = "Ngày khám:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(121, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 26);
            this.label6.TabIndex = 60;
            this.label6.Text = "Cân nặng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(117, 285);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 26);
            this.label7.TabIndex = 60;
            this.label7.Text = "Chiều cao:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(26, 357);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 26);
            this.label9.TabIndex = 60;
            this.label9.Text = "Tình trạng sức khỏe:";
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
            this.btnHuy.Location = new System.Drawing.Point(1069, 724);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(8);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(207, 63);
            this.btnHuy.TabIndex = 73;
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
            this.btnInBaoCao.Location = new System.Drawing.Point(797, 724);
            this.btnInBaoCao.Margin = new System.Windows.Forms.Padding(8);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(211, 63);
            this.btnInBaoCao.TabIndex = 74;
            this.btnInBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(241, 64);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(284, 35);
            this.txtHoTen.TabIndex = 61;
            // 
            // txtCanNang
            // 
            this.txtCanNang.Enabled = false;
            this.txtCanNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanNang.Location = new System.Drawing.Point(241, 207);
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size = new System.Drawing.Size(283, 35);
            this.txtCanNang.TabIndex = 61;
            // 
            // txtChieuCao
            // 
            this.txtChieuCao.Enabled = false;
            this.txtChieuCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChieuCao.Location = new System.Drawing.Point(241, 281);
            this.txtChieuCao.Name = "txtChieuCao";
            this.txtChieuCao.Size = new System.Drawing.Size(283, 35);
            this.txtChieuCao.TabIndex = 61;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Enabled = false;
            this.txtTinhTrang.Location = new System.Drawing.Point(241, 355);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(283, 96);
            this.txtTinhTrang.TabIndex = 62;
            this.txtTinhTrang.Text = "";
            // 
            // txtNgayKham
            // 
            this.txtNgayKham.Enabled = false;
            this.txtNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayKham.Location = new System.Drawing.Point(241, 136);
            this.txtNgayKham.Name = "txtNgayKham";
            this.txtNgayKham.Size = new System.Drawing.Size(284, 35);
            this.txtNgayKham.TabIndex = 61;
            // 
            // View_ThongTinSucKhoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "View_ThongTinSucKhoe";
            this.Size = new System.Drawing.Size(1390, 834);
            this.Load += new System.EventHandler(this.View_ThongTinSucKhoe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTre)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvListTre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNam;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtChieuCao;
        private System.Windows.Forms.TextBox txtCanNang;
        private System.Windows.Forms.TextBox txtHoTen;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHuy;
        private Bunifu.Framework.UI.BunifuThinButton2 btnInBaoCao;
        private System.Windows.Forms.TextBox txtNgayKham;
    }
}
