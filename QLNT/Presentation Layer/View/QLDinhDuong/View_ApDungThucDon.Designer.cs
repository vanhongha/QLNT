namespace QLNT.Presentation_Layer.View.QLDinhDuong
{
    partial class View_ApDungThucDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_ApDungThucDon));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvApDungThucDon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboBuoiAD = new System.Windows.Forms.ComboBox();
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgay_Loc = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cboThucDon_Loc = new System.Windows.Forms.ComboBox();
            this.btnApDungThucDon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApDungThucDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(527, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 62);
            this.label1.TabIndex = 48;
            this.label1.Text = "ÁP DỤNG THỰC ĐƠN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.dgvApDungThucDon);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(20, 523);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1353, 306);
            this.groupBox3.TabIndex = 86;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CHI TIẾT ÁP DỤNG THỰC ĐƠN";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QLNT.Properties.Resources.chef;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(921, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(297, 294);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // dgvApDungThucDon
            // 
            this.dgvApDungThucDon.AllowUserToAddRows = false;
            this.dgvApDungThucDon.AllowUserToDeleteRows = false;
            this.dgvApDungThucDon.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApDungThucDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApDungThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApDungThucDon.Location = new System.Drawing.Point(9, 31);
            this.dgvApDungThucDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvApDungThucDon.Name = "dgvApDungThucDon";
            this.dgvApDungThucDon.ReadOnly = true;
            this.dgvApDungThucDon.RowHeadersVisible = false;
            this.dgvApDungThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApDungThucDon.Size = new System.Drawing.Size(783, 266);
            this.dgvApDungThucDon.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboBuoiAD);
            this.groupBox1.Controls.Add(this.ckbAll);
            this.groupBox1.Controls.Add(this.dgvLop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpNgay_Loc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboThucDon_Loc);
            this.groupBox1.Controls.Add(this.btnApDungThucDon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(20, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1353, 406);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH LỚP";
            // 
            // cboBuoiAD
            // 
            this.cboBuoiAD.AccessibleDescription = "";
            this.cboBuoiAD.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboBuoiAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuoiAD.FormattingEnabled = true;
            this.cboBuoiAD.Items.AddRange(new object[] {
            "Sáng",
            "Trưa",
            "Chiều"});
            this.cboBuoiAD.Location = new System.Drawing.Point(1053, 143);
            this.cboBuoiAD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboBuoiAD.Name = "cboBuoiAD";
            this.cboBuoiAD.Size = new System.Drawing.Size(205, 33);
            this.cboBuoiAD.TabIndex = 96;
            this.cboBuoiAD.SelectedIndexChanged += new System.EventHandler(this.cboBuoiAD_SelectedIndexChanged);
            // 
            // ckbAll
            // 
            this.ckbAll.AutoSize = true;
            this.ckbAll.Location = new System.Drawing.Point(40, 37);
            this.ckbAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(22, 21);
            this.ckbAll.TabIndex = 88;
            this.ckbAll.UseVisualStyleBackColor = true;
            this.ckbAll.CheckedChanged += new System.EventHandler(this.ckbAll_CheckedChanged);
            this.ckbAll.Click += new System.EventHandler(this.ckbAll_Click);
            // 
            // dgvLop
            // 
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.AllowUserToDeleteRows = false;
            this.dgvLop.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(9, 29);
            this.dgvLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersVisible = false;
            this.dgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLop.Size = new System.Drawing.Size(783, 349);
            this.dgvLop.TabIndex = 96;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(872, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 98;
            this.label4.Text = "Ngày áp dụng: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(966, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 96;
            this.label3.Text = "LỌC KẾT QUẢ THEO ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(870, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 29);
            this.label5.TabIndex = 96;
            this.label5.Text = "Buổi Áp Dụng: ";
            // 
            // dtpNgay_Loc
            // 
            this.dtpNgay_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgay_Loc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay_Loc.Location = new System.Drawing.Point(1053, 100);
            this.dtpNgay_Loc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgay_Loc.Name = "dtpNgay_Loc";
            this.dtpNgay_Loc.Size = new System.Drawing.Size(205, 30);
            this.dtpNgay_Loc.TabIndex = 95;
            this.dtpNgay_Loc.Value = new System.DateTime(2017, 5, 31, 20, 12, 25, 0);
            this.dtpNgay_Loc.ValueChanged += new System.EventHandler(this.dtpNgay_Loc_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(886, 186);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 29);
            this.label8.TabIndex = 97;
            this.label8.Text = "Mã thực đơn: ";
            // 
            // cboThucDon_Loc
            // 
            this.cboThucDon_Loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThucDon_Loc.FormattingEnabled = true;
            this.cboThucDon_Loc.Location = new System.Drawing.Point(1053, 185);
            this.cboThucDon_Loc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboThucDon_Loc.Name = "cboThucDon_Loc";
            this.cboThucDon_Loc.Size = new System.Drawing.Size(205, 33);
            this.cboThucDon_Loc.TabIndex = 89;
            // 
            // btnApDungThucDon
            // 
            this.btnApDungThucDon.ActiveBorderThickness = 1;
            this.btnApDungThucDon.ActiveCornerRadius = 20;
            this.btnApDungThucDon.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnApDungThucDon.ActiveForecolor = System.Drawing.Color.White;
            this.btnApDungThucDon.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnApDungThucDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.btnApDungThucDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApDungThucDon.BackgroundImage")));
            this.btnApDungThucDon.ButtonText = "Áp dụng thực đơn";
            this.btnApDungThucDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApDungThucDon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApDungThucDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnApDungThucDon.IdleBorderThickness = 1;
            this.btnApDungThucDon.IdleCornerRadius = 20;
            this.btnApDungThucDon.IdleFillColor = System.Drawing.Color.White;
            this.btnApDungThucDon.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnApDungThucDon.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.btnApDungThucDon.Location = new System.Drawing.Point(932, 283);
            this.btnApDungThucDon.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnApDungThucDon.Name = "btnApDungThucDon";
            this.btnApDungThucDon.Size = new System.Drawing.Size(286, 63);
            this.btnApDungThucDon.TabIndex = 83;
            this.btnApDungThucDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnApDungThucDon.Click += new System.EventHandler(this.btnApDungThucDon_Click);
            // 
            // View_ApDungThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "View_ApDungThucDon";
            this.Size = new System.Drawing.Size(1390, 834);
            this.Load += new System.EventHandler(this.View_ApDungThucDon_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApDungThucDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvApDungThucDon;
        private Bunifu.Framework.UI.BunifuThinButton2 btnApDungThucDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboThucDon_Loc;
        private System.Windows.Forms.CheckBox ckbAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgay_Loc;
        private System.Windows.Forms.ComboBox cboBuoiAD;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
