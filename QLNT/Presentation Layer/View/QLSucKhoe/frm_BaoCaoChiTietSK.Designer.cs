namespace QLNT.Presentation_Layer.View.QLSucKhoe
{
    partial class frm_BaoCaoChiTietSK
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SucKhoeDataSet = new QLNT.Presentation_Layer.View.QLSucKhoe.SucKhoeDataSet();
            this.VW_SUCKHOEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VW_SUCKHOETableAdapter = new QLNT.Presentation_Layer.View.QLSucKhoe.SucKhoeDataSetTableAdapters.VW_SUCKHOETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SucKhoeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_SUCKHOEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ChiTietSucKhoeDS";
            reportDataSource1.Value = this.VW_SUCKHOEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNT.Presentation_Layer.View.QLSucKhoe.ChiTietSK.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1054, 610);
            this.reportViewer1.TabIndex = 0;
            // 
            // SucKhoeDataSet
            // 
            this.SucKhoeDataSet.DataSetName = "SucKhoeDataSet";
            this.SucKhoeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VW_SUCKHOEBindingSource
            // 
            this.VW_SUCKHOEBindingSource.DataMember = "VW_SUCKHOE";
            this.VW_SUCKHOEBindingSource.DataSource = this.SucKhoeDataSet;
            // 
            // VW_SUCKHOETableAdapter
            // 
            this.VW_SUCKHOETableAdapter.ClearBeforeFill = true;
            // 
            // frm_BaoCaoChiTietSK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 610);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_BaoCaoChiTietSK";
            this.Text = "frm_BaoCaoChiTietSK";
            this.Load += new System.EventHandler(this.frm_BaoCaoChiTietSK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SucKhoeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_SUCKHOEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VW_SUCKHOEBindingSource;
        private SucKhoeDataSet SucKhoeDataSet;
        private SucKhoeDataSetTableAdapters.VW_SUCKHOETableAdapter VW_SUCKHOETableAdapter;
    }
}