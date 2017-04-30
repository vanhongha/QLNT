namespace QLNT.Presentation_Layer.Tab_Menu
{
    partial class Tab_QLThuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tab_QLThuChi));
            this.btnThu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnChi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // btnThu
            // 
            this.btnThu.ActiveBorderThickness = 1;
            this.btnThu.ActiveCornerRadius = 20;
            this.btnThu.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThu.ActiveForecolor = System.Drawing.Color.White;
            this.btnThu.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThu.BackColor = System.Drawing.Color.White;
            this.btnThu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThu.BackgroundImage")));
            this.btnThu.ButtonText = "Thu";
            this.btnThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThu.IdleBorderThickness = 1;
            this.btnThu.IdleCornerRadius = 20;
            this.btnThu.IdleFillColor = System.Drawing.Color.White;
            this.btnThu.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThu.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnThu.Location = new System.Drawing.Point(5, 7);
            this.btnThu.Margin = new System.Windows.Forms.Padding(5);
            this.btnThu.Name = "btnThu";
            this.btnThu.Size = new System.Drawing.Size(181, 41);
            this.btnThu.TabIndex = 5;
            this.btnThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThu.Click += new System.EventHandler(this.btnThu_Click);
            // 
            // btnChi
            // 
            this.btnChi.ActiveBorderThickness = 1;
            this.btnChi.ActiveCornerRadius = 20;
            this.btnChi.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnChi.ActiveForecolor = System.Drawing.Color.White;
            this.btnChi.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnChi.BackColor = System.Drawing.Color.White;
            this.btnChi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChi.BackgroundImage")));
            this.btnChi.ButtonText = "Chi";
            this.btnChi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnChi.IdleBorderThickness = 1;
            this.btnChi.IdleCornerRadius = 20;
            this.btnChi.IdleFillColor = System.Drawing.Color.White;
            this.btnChi.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnChi.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnChi.Location = new System.Drawing.Point(196, 7);
            this.btnChi.Margin = new System.Windows.Forms.Padding(5);
            this.btnChi.Name = "btnChi";
            this.btnChi.Size = new System.Drawing.Size(181, 41);
            this.btnChi.TabIndex = 6;
            this.btnChi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChi.Click += new System.EventHandler(this.btnChi_Click);
            // 
            // Tab_QLThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnChi);
            this.Controls.Add(this.btnThu);
            this.Name = "Tab_QLThuChi";
            this.Size = new System.Drawing.Size(927, 53);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnThu;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChi;
    }
}
