namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    partial class View_LopThamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_LopThamGia));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTenDichVu = new System.Windows.Forms.ComboBox();
            this.dgvListLop = new System.Windows.Forms.DataGridView();
            this.btnApDungTatCa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLuu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnHuy = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(278, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách lớp tham gia dịch vụ sức khỏe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(360, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 26);
            this.label3.TabIndex = 55;
            this.label3.Text = "Tên dịch vụ:";
            // 
            // cboTenDichVu
            // 
            this.cboTenDichVu.FormattingEnabled = true;
            this.cboTenDichVu.Location = new System.Drawing.Point(550, 146);
            this.cboTenDichVu.Name = "cboTenDichVu";
            this.cboTenDichVu.Size = new System.Drawing.Size(312, 28);
            this.cboTenDichVu.TabIndex = 56;
            this.cboTenDichVu.SelectedIndexChanged += new System.EventHandler(this.cboTenDichVu_SelectedIndexChanged);
            // 
            // dgvListLop
            // 
            this.dgvListLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListLop.Location = new System.Drawing.Point(272, 232);
            this.dgvListLop.Name = "dgvListLop";
            this.dgvListLop.RowTemplate.Height = 28;
            this.dgvListLop.Size = new System.Drawing.Size(789, 423);
            this.dgvListLop.TabIndex = 57;
            this.dgvListLop.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvListLop_DataBindingComplete);
            // 
            // btnApDungTatCa
            // 
            this.btnApDungTatCa.ActiveBorderThickness = 1;
            this.btnApDungTatCa.ActiveCornerRadius = 20;
            this.btnApDungTatCa.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnApDungTatCa.ActiveForecolor = System.Drawing.Color.White;
            this.btnApDungTatCa.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnApDungTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.btnApDungTatCa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApDungTatCa.BackgroundImage")));
            this.btnApDungTatCa.ButtonText = "Áp dụng tất cả";
            this.btnApDungTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApDungTatCa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApDungTatCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnApDungTatCa.IdleBorderThickness = 1;
            this.btnApDungTatCa.IdleCornerRadius = 20;
            this.btnApDungTatCa.IdleFillColor = System.Drawing.Color.White;
            this.btnApDungTatCa.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnApDungTatCa.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnApDungTatCa.Location = new System.Drawing.Point(150, 705);
            this.btnApDungTatCa.Margin = new System.Windows.Forms.Padding(8);
            this.btnApDungTatCa.Name = "btnApDungTatCa";
            this.btnApDungTatCa.Size = new System.Drawing.Size(272, 63);
            this.btnApDungTatCa.TabIndex = 58;
            this.btnApDungTatCa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnApDungTatCa.Click += new System.EventHandler(this.btnApDungTatCa_Click);
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
            this.btnLuu.ButtonText = "Cập nhật";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnLuu.IdleBorderThickness = 1;
            this.btnLuu.IdleCornerRadius = 20;
            this.btnLuu.IdleFillColor = System.Drawing.Color.White;
            this.btnLuu.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnLuu.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnLuu.Location = new System.Drawing.Point(566, 705);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(8);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(272, 63);
            this.btnLuu.TabIndex = 58;
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnHuy.Location = new System.Drawing.Point(958, 705);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(8);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(272, 63);
            this.btnHuy.TabIndex = 58;
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // View_LopThamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnApDungTatCa);
            this.Controls.Add(this.dgvListLop);
            this.Controls.Add(this.cboTenDichVu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "View_LopThamGia";
            this.Size = new System.Drawing.Size(1390, 834);
            this.Load += new System.EventHandler(this.View_LopThamGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTenDichVu;
        private System.Windows.Forms.DataGridView dgvListLop;
        private Bunifu.Framework.UI.BunifuThinButton2 btnApDungTatCa;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuu;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHuy;
    }
}
