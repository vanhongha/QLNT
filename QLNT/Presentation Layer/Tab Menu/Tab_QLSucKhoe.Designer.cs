namespace QLNT.Presentation_Layer.Tab_Menu
{
    partial class Tab_QLSucKhoe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tab_QLSucKhoe));
            this.btnDichVu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThemCapNhat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // btnDichVu
            // 
            this.btnDichVu.ActiveBorderThickness = 1;
            this.btnDichVu.ActiveCornerRadius = 20;
            this.btnDichVu.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnDichVu.ActiveForecolor = System.Drawing.Color.White;
            this.btnDichVu.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnDichVu.BackColor = System.Drawing.Color.White;
            this.btnDichVu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDichVu.BackgroundImage")));
            this.btnDichVu.ButtonText = "Dịch vụ";
            this.btnDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDichVu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnDichVu.IdleBorderThickness = 1;
            this.btnDichVu.IdleCornerRadius = 20;
            this.btnDichVu.IdleFillColor = System.Drawing.Color.White;
            this.btnDichVu.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnDichVu.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnDichVu.Location = new System.Drawing.Point(196, 7);
            this.btnDichVu.Margin = new System.Windows.Forms.Padding(5);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(181, 41);
            this.btnDichVu.TabIndex = 6;
            this.btnDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnThemCapNhat
            // 
            this.btnThemCapNhat.ActiveBorderThickness = 1;
            this.btnThemCapNhat.ActiveCornerRadius = 20;
            this.btnThemCapNhat.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThemCapNhat.ActiveForecolor = System.Drawing.Color.White;
            this.btnThemCapNhat.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThemCapNhat.BackColor = System.Drawing.Color.White;
            this.btnThemCapNhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemCapNhat.BackgroundImage")));
            this.btnThemCapNhat.ButtonText = "Thêm/cập nhật";
            this.btnThemCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemCapNhat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCapNhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThemCapNhat.IdleBorderThickness = 1;
            this.btnThemCapNhat.IdleCornerRadius = 20;
            this.btnThemCapNhat.IdleFillColor = System.Drawing.Color.White;
            this.btnThemCapNhat.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThemCapNhat.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThemCapNhat.Location = new System.Drawing.Point(5, 7);
            this.btnThemCapNhat.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemCapNhat.Name = "btnThemCapNhat";
            this.btnThemCapNhat.Size = new System.Drawing.Size(181, 41);
            this.btnThemCapNhat.TabIndex = 4;
            this.btnThemCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemCapNhat.Click += new System.EventHandler(this.btnThemCapNhat_Click);
            // 
            // Tab_QLSucKhoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDichVu);
            this.Controls.Add(this.btnThemCapNhat);
            this.Name = "Tab_QLSucKhoe";
            this.Size = new System.Drawing.Size(927, 53);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnThemCapNhat;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDichVu;
    }
}
