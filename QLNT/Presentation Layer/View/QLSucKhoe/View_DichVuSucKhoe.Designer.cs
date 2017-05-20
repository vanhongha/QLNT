namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    partial class View_DichVuSucKhoe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_DichVuSucKhoe));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSucKhoe = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaDV = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTenDV = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtChiPhi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChiTiet = new System.Windows.Forms.RichTextBox();
            this.btnLuu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThemMoi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDSLopThamGia = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtNgayKham = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucKhoe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(378, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dịch vụ sức khỏe";
            // 
            // dgvSucKhoe
            // 
            this.dgvSucKhoe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucKhoe.Location = new System.Drawing.Point(10, 95);
            this.dgvSucKhoe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSucKhoe.Name = "dgvSucKhoe";
            this.dgvSucKhoe.RowTemplate.Height = 28;
            this.dgvSucKhoe.Size = new System.Drawing.Size(475, 372);
            this.dgvSucKhoe.TabIndex = 3;
            this.dgvSucKhoe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSucKhoe_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(512, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tên dịch vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(516, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mã dịch vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(512, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Ngày khám:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(542, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "Chi phí:";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDV.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMaDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaDV.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaDV.HintText = "";
            this.txtMaDV.isPassword = false;
            this.txtMaDV.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(89)))), ((int)(((byte)(180)))));
            this.txtMaDV.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaDV.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(89)))), ((int)(((byte)(180)))));
            this.txtMaDV.LineThickness = 3;
            this.txtMaDV.Location = new System.Drawing.Point(609, 96);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(303, 32);
            this.txtMaDV.TabIndex = 56;
            this.txtMaDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDV.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTenDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenDV.HintForeColor = System.Drawing.Color.Empty;
            this.txtTenDV.HintText = "";
            this.txtTenDV.isPassword = false;
            this.txtTenDV.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(89)))), ((int)(((byte)(180)))));
            this.txtTenDV.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTenDV.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(89)))), ((int)(((byte)(180)))));
            this.txtTenDV.LineThickness = 3;
            this.txtTenDV.Location = new System.Drawing.Point(609, 142);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(303, 32);
            this.txtTenDV.TabIndex = 56;
            this.txtTenDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChiPhi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtChiPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtChiPhi.HintForeColor = System.Drawing.Color.Empty;
            this.txtChiPhi.HintText = "";
            this.txtChiPhi.isPassword = false;
            this.txtChiPhi.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(89)))), ((int)(((byte)(180)))));
            this.txtChiPhi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtChiPhi.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(89)))), ((int)(((byte)(180)))));
            this.txtChiPhi.LineThickness = 3;
            this.txtChiPhi.Location = new System.Drawing.Point(609, 237);
            this.txtChiPhi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(303, 32);
            this.txtChiPhi.TabIndex = 56;
            this.txtChiPhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(542, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "Chi tiết:";
            // 
            // txtChiTiet
            // 
            this.txtChiTiet.Location = new System.Drawing.Point(609, 302);
            this.txtChiTiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChiTiet.Name = "txtChiTiet";
            this.txtChiTiet.Size = new System.Drawing.Size(304, 75);
            this.txtChiTiet.TabIndex = 57;
            this.txtChiTiet.Text = "";
            // 
            // btnLuu
            // 
            this.btnLuu.ActiveBorderThickness = 1;
            this.btnLuu.ActiveCornerRadius = 20;
            this.btnLuu.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnLuu.ActiveForecolor = System.Drawing.Color.White;
            this.btnLuu.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.ButtonText = "Lưu";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnLuu.IdleBorderThickness = 1;
            this.btnLuu.IdleCornerRadius = 20;
            this.btnLuu.IdleFillColor = System.Drawing.Color.White;
            this.btnLuu.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnLuu.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnLuu.Location = new System.Drawing.Point(818, 408);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 41);
            this.btnLuu.TabIndex = 58;
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.ActiveBorderThickness = 1;
            this.btnThemMoi.ActiveCornerRadius = 20;
            this.btnThemMoi.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThemMoi.ActiveForecolor = System.Drawing.Color.White;
            this.btnThemMoi.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThemMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.btnThemMoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.BackgroundImage")));
            this.btnThemMoi.ButtonText = "Refresh";
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThemMoi.IdleBorderThickness = 1;
            this.btnThemMoi.IdleCornerRadius = 20;
            this.btnThemMoi.IdleFillColor = System.Drawing.Color.White;
            this.btnThemMoi.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThemMoi.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThemMoi.Location = new System.Drawing.Point(684, 408);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(102, 41);
            this.btnThemMoi.TabIndex = 58;
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnDSLopThamGia
            // 
            this.btnDSLopThamGia.ActiveBorderThickness = 1;
            this.btnDSLopThamGia.ActiveCornerRadius = 20;
            this.btnDSLopThamGia.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnDSLopThamGia.ActiveForecolor = System.Drawing.Color.White;
            this.btnDSLopThamGia.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnDSLopThamGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.btnDSLopThamGia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDSLopThamGia.BackgroundImage")));
            this.btnDSLopThamGia.ButtonText = "Lớp tham gia";
            this.btnDSLopThamGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDSLopThamGia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSLopThamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnDSLopThamGia.IdleBorderThickness = 1;
            this.btnDSLopThamGia.IdleCornerRadius = 20;
            this.btnDSLopThamGia.IdleFillColor = System.Drawing.Color.White;
            this.btnDSLopThamGia.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnDSLopThamGia.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnDSLopThamGia.Location = new System.Drawing.Point(526, 408);
            this.btnDSLopThamGia.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDSLopThamGia.Name = "btnDSLopThamGia";
            this.btnDSLopThamGia.Size = new System.Drawing.Size(123, 41);
            this.btnDSLopThamGia.TabIndex = 58;
            this.btnDSLopThamGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDSLopThamGia.Click += new System.EventHandler(this.btnDSLopThamGia_Click);
            // 
            // dtNgayKham
            // 
            this.dtNgayKham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(89)))), ((int)(((byte)(180)))));
            this.dtNgayKham.BorderRadius = 0;
            this.dtNgayKham.ForeColor = System.Drawing.Color.White;
            this.dtNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtNgayKham.FormatCustom = null;
            this.dtNgayKham.Location = new System.Drawing.Point(609, 196);
            this.dtNgayKham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtNgayKham.Name = "dtNgayKham";
            this.dtNgayKham.Size = new System.Drawing.Size(304, 36);
            this.dtNgayKham.TabIndex = 76;
            this.dtNgayKham.Value = new System.DateTime(2017, 4, 27, 21, 49, 25, 791);
            // 
            // View_DichVuSucKhoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.dtNgayKham);
            this.Controls.Add(this.btnDSLopThamGia);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtChiTiet);
            this.Controls.Add(this.txtChiPhi);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSucKhoe);
            this.Controls.Add(this.label1);
            this.Name = "View_DichVuSucKhoe";
            this.Size = new System.Drawing.Size(927, 542);
            this.Load += new System.EventHandler(this.View_DichVuSucKhoe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucKhoe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSucKhoe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaDV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenDV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtChiPhi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtChiTiet;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuu;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThemMoi;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDSLopThamGia;
        private Bunifu.Framework.UI.BunifuDatepicker dtNgayKham;
    }
}
