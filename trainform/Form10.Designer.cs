namespace trainform
{
    partial class Form10
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
            this.trainDataSet1 = new trainform.trainDataSet1();
            this.tripsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripsTableAdapter = new trainform.trainDataSet1TableAdapters.tripsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tripsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "trainform.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(171, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(451, 280);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // trainDataSet1
            // 
            this.trainDataSet1.DataSetName = "trainDataSet1";
            this.trainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tripsBindingSource
            // 
            this.tripsBindingSource.DataMember = "trips";
            this.tripsBindingSource.DataSource = this.trainDataSet1;
            // 
            // tripsTableAdapter
            // 
            this.tripsTableAdapter.ClearBeforeFill = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tripsBindingSource;
        private trainDataSet1 trainDataSet1;
        private trainDataSet1TableAdapters.tripsTableAdapter tripsTableAdapter;
    }
}