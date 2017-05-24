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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_DichVuSucKhoe));
            this.dgvSucKhoe = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChiTiet = new System.Windows.Forms.RichTextBox();
            this.btnLuu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThemMoi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDSLopThamGia = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtNgayKham = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucKhoe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSucKhoe
            // 
            this.dgvSucKhoe.AllowUserToAddRows = false;
            this.dgvSucKhoe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSucKhoe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSucKhoe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucKhoe.Location = new System.Drawing.Point(15, 146);
            this.dgvSucKhoe.MultiSelect = false;
            this.dgvSucKhoe.Name = "dgvSucKhoe";
            this.dgvSucKhoe.ReadOnly = true;
            this.dgvSucKhoe.RowTemplate.Height = 28;
            this.dgvSucKhoe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSucKhoe.Size = new System.Drawing.Size(712, 665);
            this.dgvSucKhoe.TabIndex = 3;
            this.dgvSucKhoe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSucKhoe_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(48, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 26);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tên dịch vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(54, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mã dịch vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(48, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 54;
            this.label4.Text = "Ngày khám:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(91, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 26);
            this.label5.TabIndex = 54;
            this.label5.Text = "Chi phí:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(91, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 26);
            this.label6.TabIndex = 54;
            this.label6.Text = "Chi tiết:";
            // 
            // txtChiTiet
            // 
            this.txtChiTiet.Location = new System.Drawing.Point(231, 355);
            this.txtChiTiet.Name = "txtChiTiet";
            this.txtChiTiet.Size = new System.Drawing.Size(358, 113);
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
            this.btnLuu.Location = new System.Drawing.Point(1104, 674);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(8);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(184, 63);
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
            this.btnThemMoi.Location = new System.Drawing.Point(824, 752);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(8);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(184, 63);
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
            this.btnDSLopThamGia.Location = new System.Drawing.Point(824, 674);
            this.btnDSLopThamGia.Margin = new System.Windows.Forms.Padding(8);
            this.btnDSLopThamGia.Name = "btnDSLopThamGia";
            this.btnDSLopThamGia.Size = new System.Drawing.Size(184, 63);
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
            this.dtNgayKham.Location = new System.Drawing.Point(231, 201);
            this.dtNgayKham.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.dtNgayKham.Name = "dtNgayKham";
            this.dtNgayKham.Size = new System.Drawing.Size(360, 55);
            this.dtNgayKham.TabIndex = 76;
            this.dtNgayKham.Value = new System.DateTime(2017, 4, 27, 21, 49, 25, 791);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(348, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 46);
            this.label1.TabIndex = 77;
            this.label1.Text = "DỊCH VỤ SỨC KHỎE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaDV);
            this.groupBox1.Controls.Add(this.txtTenDV);
            this.groupBox1.Controls.Add(this.txtChiPhi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtNgayKham);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtChiTiet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(765, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 500);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Enabled = false;
            this.txtMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.Location = new System.Drawing.Point(231, 70);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(358, 35);
            this.txtMaDV.TabIndex = 77;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Location = new System.Drawing.Point(231, 137);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(358, 35);
            this.txtTenDV.TabIndex = 77;
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiPhi.Location = new System.Drawing.Point(231, 289);
            this.txtChiPhi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(358, 35);
            this.txtChiPhi.TabIndex = 77;
            // 
            // btnXoa
            // 
            this.btnXoa.ActiveBorderThickness = 1;
            this.btnXoa.ActiveCornerRadius = 20;
            this.btnXoa.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXoa.ActiveForecolor = System.Drawing.Color.White;
            this.btnXoa.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXoa.IdleBorderThickness = 1;
            this.btnXoa.IdleCornerRadius = 20;
            this.btnXoa.IdleFillColor = System.Drawing.Color.White;
            this.btnXoa.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXoa.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnXoa.Location = new System.Drawing.Point(1104, 752);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(184, 63);
            this.btnXoa.TabIndex = 58;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // View_DichVuSucKhoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDSLopThamGia);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvSucKhoe);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "View_DichVuSucKhoe";
            this.Size = new System.Drawing.Size(1390, 834);
            this.Load += new System.EventHandler(this.View_DichVuSucKhoe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucKhoe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSucKhoe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtChiTiet;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuu;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThemMoi;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDSLopThamGia;
        private Bunifu.Framework.UI.BunifuDatepicker dtNgayKham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtChiPhi;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
    }
}
