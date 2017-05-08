namespace QLNT.Presentation_Layer.View.QLHoatDong
{
    partial class View_DiemNgoaiKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_DiemNgoaiKhoa));
            this.label1 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDiemTre = new System.Windows.Forms.DataGridView();
            this.cboHoatDong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuy = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLuu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtDiem = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNhanXet = new System.Windows.Forms.RichTextBox();
            this.txtHoTenTre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemTre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(360, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Điểm hoạt động ngoại khóa";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(179, 151);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(121, 28);
            this.cboLop.TabIndex = 54;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(37, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 26);
            this.label8.TabIndex = 53;
            this.label8.Text = "Chọn lớp:";
            // 
            // dgvDiemTre
            // 
            this.dgvDiemTre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemTre.Location = new System.Drawing.Point(33, 219);
            this.dgvDiemTre.Name = "dgvDiemTre";
            this.dgvDiemTre.RowTemplate.Height = 28;
            this.dgvDiemTre.Size = new System.Drawing.Size(808, 500);
            this.dgvDiemTre.TabIndex = 52;
            this.dgvDiemTre.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiemTre_CellClick);
            // 
            // cboHoatDong
            // 
            this.cboHoatDong.FormattingEnabled = true;
            this.cboHoatDong.Location = new System.Drawing.Point(668, 151);
            this.cboHoatDong.Name = "cboHoatDong";
            this.cboHoatDong.Size = new System.Drawing.Size(180, 28);
            this.cboHoatDong.TabIndex = 56;
            this.cboHoatDong.SelectedIndexChanged += new System.EventHandler(this.cboHoatDong_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(526, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 26);
            this.label2.TabIndex = 55;
            this.label2.Text = "Hoạt động:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(900, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 57;
            this.label3.Text = "Điểm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(900, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 57;
            this.label4.Text = "Họ tên trẻ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(900, 440);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 26);
            this.label5.TabIndex = 57;
            this.label5.Text = "Nhận xét:";
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
            this.btnHuy.Location = new System.Drawing.Point(1151, 636);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(8);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(211, 63);
            this.btnHuy.TabIndex = 58;
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.btnLuu.Location = new System.Drawing.Point(892, 636);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(8);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(211, 63);
            this.btnLuu.TabIndex = 58;
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiem.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiem.HintForeColor = System.Drawing.Color.Empty;
            this.txtDiem.HintText = "";
            this.txtDiem.isPassword = false;
            this.txtDiem.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(89)))), ((int)(((byte)(180)))));
            this.txtDiem.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDiem.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(89)))), ((int)(((byte)(180)))));
            this.txtDiem.LineThickness = 3;
            this.txtDiem.Location = new System.Drawing.Point(1037, 325);
            this.txtDiem.Margin = new System.Windows.Forms.Padding(6);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(325, 50);
            this.txtDiem.TabIndex = 59;
            this.txtDiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNhanXet
            // 
            this.txtNhanXet.Location = new System.Drawing.Point(1037, 440);
            this.txtNhanXet.Name = "txtNhanXet";
            this.txtNhanXet.Size = new System.Drawing.Size(325, 135);
            this.txtNhanXet.TabIndex = 63;
            this.txtNhanXet.Text = "";
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
            this.txtHoTenTre.Location = new System.Drawing.Point(1037, 237);
            this.txtHoTenTre.Margin = new System.Windows.Forms.Padding(6);
            this.txtHoTenTre.Name = "txtHoTenTre";
            this.txtHoTenTre.Size = new System.Drawing.Size(325, 50);
            this.txtHoTenTre.TabIndex = 59;
            this.txtHoTenTre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // View_DiemNgoaiKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.txtNhanXet);
            this.Controls.Add(this.txtHoTenTre);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboHoatDong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvDiemTre);
            this.Controls.Add(this.label1);
            this.Name = "View_DiemNgoaiKhoa";
            this.Size = new System.Drawing.Size(1390, 834);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemTre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDiemTre;
        private System.Windows.Forms.ComboBox cboHoatDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHuy;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuu;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiem;
        private System.Windows.Forms.RichTextBox txtNhanXet;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHoTenTre;
    }
}
