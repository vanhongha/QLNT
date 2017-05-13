namespace QLNT.Presentation_Layer.Tab_Menu
{
    partial class Tab_QLHoatDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tab_QLHoatDong));
            this.btnThemMoi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnApDung = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.ActiveBorderThickness = 1;
            this.btnThemMoi.ActiveCornerRadius = 20;
            this.btnThemMoi.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThemMoi.ActiveForecolor = System.Drawing.Color.White;
            this.btnThemMoi.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThemMoi.BackColor = System.Drawing.Color.White;
            this.btnThemMoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.BackgroundImage")));
            this.btnThemMoi.ButtonText = "Hoạt động ngoại khóa";
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThemMoi.IdleBorderThickness = 1;
            this.btnThemMoi.IdleCornerRadius = 20;
            this.btnThemMoi.IdleFillColor = System.Drawing.Color.White;
            this.btnThemMoi.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThemMoi.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThemMoi.Location = new System.Drawing.Point(0, 11);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(300, 63);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnApDung
            // 
            this.btnApDung.ActiveBorderThickness = 1;
            this.btnApDung.ActiveCornerRadius = 20;
            this.btnApDung.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnApDung.ActiveForecolor = System.Drawing.Color.White;
            this.btnApDung.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnApDung.BackColor = System.Drawing.Color.White;
            this.btnApDung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApDung.BackgroundImage")));
            this.btnApDung.ButtonText = "Điểm hoạt động ngoại khóa";
            this.btnApDung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApDung.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnApDung.IdleBorderThickness = 1;
            this.btnApDung.IdleCornerRadius = 20;
            this.btnApDung.IdleFillColor = System.Drawing.Color.White;
            this.btnApDung.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnApDung.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnApDung.Location = new System.Drawing.Point(316, 11);
            this.btnApDung.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnApDung.Name = "btnApDung";
            this.btnApDung.Size = new System.Drawing.Size(375, 63);
            this.btnApDung.TabIndex = 5;
            this.btnApDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnApDung.Click += new System.EventHandler(this.btnApDung_Click);
            // 
            // Tab_QLHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnApDung);
            this.Controls.Add(this.btnThemMoi);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Tab_QLHoatDong";
            this.Size = new System.Drawing.Size(1390, 82);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnThemMoi;
        private Bunifu.Framework.UI.BunifuThinButton2 btnApDung;
    }
}
