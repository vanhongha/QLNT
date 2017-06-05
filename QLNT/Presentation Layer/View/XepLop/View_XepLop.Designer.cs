namespace QLNT.Presentation_Layer.View.XepLop
{
    partial class View_XepLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_XepLop));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTre = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamSinh = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtKetQua = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.rdoLopCoSan = new System.Windows.Forms.RadioButton();
            this.rdoLopMoi = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TiepNhanTre = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtTaoLop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTre)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(403, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xếp lớp";
            // 
            // dgvTre
            // 
            this.dgvTre.AllowUserToAddRows = false;
            this.dgvTre.AllowUserToDeleteRows = false;
            this.dgvTre.BackgroundColor = System.Drawing.Color.White;
            this.dgvTre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTre.Location = new System.Drawing.Point(3, 128);
            this.dgvTre.Name = "dgvTre";
            this.dgvTre.ReadOnly = true;
            this.dgvTre.Size = new System.Drawing.Size(505, 411);
            this.dgvTre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(5, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lọc theo năm sinh:";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamSinh.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNamSinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNamSinh.HintForeColor = System.Drawing.Color.Empty;
            this.txtNamSinh.HintText = "";
            this.txtNamSinh.isPassword = false;
            this.txtNamSinh.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(89)))), ((int)(((byte)(180)))));
            this.txtNamSinh.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNamSinh.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(89)))), ((int)(((byte)(180)))));
            this.txtNamSinh.LineThickness = 3;
            this.txtNamSinh.Location = new System.Drawing.Point(146, 79);
            this.txtNamSinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(64, 42);
            this.txtNamSinh.TabIndex = 3;
            this.txtNamSinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNamSinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoTen_KeyDown);
            // 
            // txtKetQua
            // 
            this.txtKetQua.AutoSize = true;
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.ForeColor = System.Drawing.Color.Gray;
            this.txtKetQua.Location = new System.Drawing.Point(273, 103);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(235, 18);
            this.txtKetQua.TabIndex = 5;
            this.txtKetQua.Text = "Tìm được 69 trẻ chưa được xếp lớp";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Gray;
            this.title.Location = new System.Drawing.Point(0, 56);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(295, 18);
            this.title.TabIndex = 6;
            this.title.Text = "Chọn lớp để xếp lớp cho các trẻ được chọn:";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(6, 77);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(398, 21);
            this.cboLop.TabIndex = 7;
            // 
            // rdoLopCoSan
            // 
            this.rdoLopCoSan.AutoSize = true;
            this.rdoLopCoSan.Location = new System.Drawing.Point(6, 25);
            this.rdoLopCoSan.Name = "rdoLopCoSan";
            this.rdoLopCoSan.Size = new System.Drawing.Size(117, 17);
            this.rdoLopCoSan.TabIndex = 8;
            this.rdoLopCoSan.TabStop = true;
            this.rdoLopCoSan.Text = "Xếp vào lớp có sẵn";
            this.rdoLopCoSan.UseVisualStyleBackColor = true;
            this.rdoLopCoSan.CheckedChanged += new System.EventHandler(this.rdoLopCoSan_CheckedChanged);
            // 
            // rdoLopMoi
            // 
            this.rdoLopMoi.AutoSize = true;
            this.rdoLopMoi.Location = new System.Drawing.Point(137, 25);
            this.rdoLopMoi.Name = "rdoLopMoi";
            this.rdoLopMoi.Size = new System.Drawing.Size(133, 17);
            this.rdoLopMoi.TabIndex = 9;
            this.rdoLopMoi.TabStop = true;
            this.rdoLopMoi.Text = "Tạo lớp mới để xếp lớp";
            this.rdoLopMoi.UseVisualStyleBackColor = true;
            this.rdoLopMoi.CheckedChanged += new System.EventHandler(this.rdoLopMoi_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTaoLop);
            this.groupBox1.Controls.Add(this.rdoLopMoi);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Controls.Add(this.rdoLopCoSan);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Location = new System.Drawing.Point(514, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 126);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xếp lớp";
            // 
            // btn_TiepNhanTre
            // 
            this.btn_TiepNhanTre.ActiveBorderThickness = 1;
            this.btn_TiepNhanTre.ActiveCornerRadius = 20;
            this.btn_TiepNhanTre.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btn_TiepNhanTre.ActiveForecolor = System.Drawing.Color.White;
            this.btn_TiepNhanTre.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btn_TiepNhanTre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.btn_TiepNhanTre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TiepNhanTre.BackgroundImage")));
            this.btn_TiepNhanTre.ButtonText = "Xếp lớp";
            this.btn_TiepNhanTre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TiepNhanTre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TiepNhanTre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btn_TiepNhanTre.IdleBorderThickness = 1;
            this.btn_TiepNhanTre.IdleCornerRadius = 20;
            this.btn_TiepNhanTre.IdleFillColor = System.Drawing.Color.White;
            this.btn_TiepNhanTre.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btn_TiepNhanTre.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btn_TiepNhanTre.Location = new System.Drawing.Point(628, 262);
            this.btn_TiepNhanTre.Margin = new System.Windows.Forms.Padding(5);
            this.btn_TiepNhanTre.Name = "btn_TiepNhanTre";
            this.btn_TiepNhanTre.Size = new System.Drawing.Size(181, 41);
            this.btn_TiepNhanTre.TabIndex = 12;
            this.btn_TiepNhanTre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTaoLop
            // 
            this.txtTaoLop.Location = new System.Drawing.Point(6, 78);
            this.txtTaoLop.Name = "txtTaoLop";
            this.txtTaoLop.Size = new System.Drawing.Size(398, 20);
            this.txtTaoLop.TabIndex = 13;
            // 
            // View_XepLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.btn_TiepNhanTre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.dgvTre);
            this.Controls.Add(this.label1);
            this.Name = "View_XepLop";
            this.Size = new System.Drawing.Size(927, 542);
            this.Load += new System.EventHandler(this.View_XepLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTre)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTre;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNamSinh;
        private System.Windows.Forms.Label txtKetQua;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.RadioButton rdoLopCoSan;
        private System.Windows.Forms.RadioButton rdoLopMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTaoLop;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_TiepNhanTre;
    }
}
