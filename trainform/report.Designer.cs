namespace trainform
{
    partial class report
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
            this.reportAction1 = new Microsoft.AnalysisServices.ReportAction();
            this.SuspendLayout();
            // 
            // reportAction1
            // 
            this.reportAction1.Application = null;
            this.reportAction1.Description = null;
            this.reportAction1.Name = null;
            this.reportAction1.OwningCollection = null;
            this.reportAction1.Path = null;
            this.reportAction1.ReportServer = null;
            this.reportAction1.SiteID = "reportAction1";
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "report";
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.AnalysisServices.ReportAction reportAction1;
    }
}