namespace WindowsFormsApplication1
{
    partial class statestique
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
            this.MM_DataBaseDataSet = new WindowsFormsApplication1.MM_DataBaseDataSet();
            this.Statestique_clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Statestique_clientTableAdapter = new WindowsFormsApplication1.MM_DataBaseDataSetTableAdapters.Statestique_clientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MM_DataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Statestique_clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Statestique_clientBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1013, 623);
            this.reportViewer1.TabIndex = 0;
            // 
            // MM_DataBaseDataSet
            // 
            this.MM_DataBaseDataSet.DataSetName = "MM_DataBaseDataSet";
            this.MM_DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Statestique_clientBindingSource
            // 
            this.Statestique_clientBindingSource.DataMember = "Statestique_client";
            this.Statestique_clientBindingSource.DataSource = this.MM_DataBaseDataSet;
            // 
            // Statestique_clientTableAdapter
            // 
            this.Statestique_clientTableAdapter.ClearBeforeFill = true;
            // 
            // statestique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 623);
            this.Controls.Add(this.reportViewer1);
            this.Name = "statestique";
            this.Text = "statestique";
            this.Load += new System.EventHandler(this.Mouvement_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MM_DataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Statestique_clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       // private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Statestique_clientBindingSource;
        private MM_DataBaseDataSet MM_DataBaseDataSet;
        private MM_DataBaseDataSetTableAdapters.Statestique_clientTableAdapter Statestique_clientTableAdapter;
        //private MM_DataBaseDataSet MM_DataBaseDataSet;
        //private MM_DataBaseDataSetTableAdapters.StatestiqueTableAdapter StatestiqueTableAdapter;




    }
}