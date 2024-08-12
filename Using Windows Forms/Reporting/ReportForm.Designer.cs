
namespace Reporting
{
    partial class ReportForm
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
            this.EmloyeesDataSet = new Reporting.EmloyeesDataSet();
            this.tbl_employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_employeesTableAdapter = new Reporting.EmloyeesDataSetTableAdapters.tbl_employeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EmloyeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_employeesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reporting.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // EmloyeesDataSet
            // 
            this.EmloyeesDataSet.DataSetName = "EmloyeesDataSet";
            this.EmloyeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_employeesBindingSource
            // 
            this.tbl_employeesBindingSource.DataMember = "tbl_employees";
            this.tbl_employeesBindingSource.DataSource = this.EmloyeesDataSet;
            // 
            // tbl_employeesTableAdapter
            // 
            this.tbl_employeesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmloyeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tbl_employeesBindingSource;
        private EmloyeesDataSetTableAdapters.tbl_employeesTableAdapter tbl_employeesTableAdapter;
        public EmloyeesDataSet EmloyeesDataSet;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}