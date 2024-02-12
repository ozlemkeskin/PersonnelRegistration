namespace Personel_Kayit
{
    partial class FrmRapor
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
            this.personelveritabaniDataSet = new Personel_Kayit.personelveritabaniDataSet();
            this.personelveritabaniDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PersonelTableAdapter = new Personel_Kayit.personelveritabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.tblPersonelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personelveritabaniDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Tbl_PersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_PersonelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // personelveritabaniDataSet
            // 
            this.personelveritabaniDataSet.DataSetName = "personelveritabaniDataSet";
            this.personelveritabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelveritabaniDataSetBindingSource
            // 
            this.personelveritabaniDataSetBindingSource.DataSource = this.personelveritabaniDataSet;
            this.personelveritabaniDataSetBindingSource.Position = 0;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelveritabaniDataSetBindingSource;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // tblPersonelBindingSource1
            // 
            this.tblPersonelBindingSource1.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource1.DataSource = this.personelveritabaniDataSetBindingSource;
            // 
            // personelveritabaniDataSetBindingSource1
            // 
            this.personelveritabaniDataSetBindingSource1.DataSource = this.personelveritabaniDataSet;
            this.personelveritabaniDataSetBindingSource1.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tbl_PersonelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Personel_Kayit.ReportTest.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1167, 675);
            this.reportViewer1.TabIndex = 0;
            // 
            // Tbl_PersonelBindingSource
            // 
            this.Tbl_PersonelBindingSource.DataMember = "Tbl_Personel";
            this.Tbl_PersonelBindingSource.DataSource = this.personelveritabaniDataSet;
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 675);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRapor";
            this.Text = "FrmRapor";
            this.Load += new System.EventHandler(this.FrmRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_PersonelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource personelveritabaniDataSetBindingSource;
        private personelveritabaniDataSet personelveritabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private personelveritabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource1;
        private System.Windows.Forms.BindingSource personelveritabaniDataSetBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tbl_PersonelBindingSource;
    }
}