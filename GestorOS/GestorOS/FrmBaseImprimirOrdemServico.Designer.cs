﻿namespace GestorOS
{
    partial class FrmBaseImprimirOrdemServico
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
            this.OrdemServicoItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetGestorOS = new GestorOS.DataSetGestorOS();
            this.reportViewOS = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.OrdemServicoItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetGestorOS)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdemServicoItemBindingSource
            // 
            this.OrdemServicoItemBindingSource.DataMember = "OrdemServicoItem";
            this.OrdemServicoItemBindingSource.DataSource = this.DataSetGestorOS;
            // 
            // DataSetGestorOS
            // 
            this.DataSetGestorOS.DataSetName = "DataSetGestorOS";
            this.DataSetGestorOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewOS
            // 
            this.reportViewOS.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetOrdemServicoItem";
            reportDataSource1.Value = this.OrdemServicoItemBindingSource;
            this.reportViewOS.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewOS.LocalReport.ReportEmbeddedResource = "GestorOS.ReportComprovanteOS.rdlc";
            this.reportViewOS.Location = new System.Drawing.Point(0, 0);
            this.reportViewOS.Name = "reportViewOS";
            this.reportViewOS.ServerReport.BearerToken = null;
            this.reportViewOS.Size = new System.Drawing.Size(800, 450);
            this.reportViewOS.TabIndex = 0;
            // 
            // FrmBaseImprimirOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewOS);
            this.Name = "FrmBaseImprimirOrdemServico";
            this.Text = "Pré visualização de impressão ordem de serviço";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBaseImprimirOrdemServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdemServicoItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetGestorOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewOS;
        private System.Windows.Forms.BindingSource OrdemServicoItemBindingSource;
        private DataSetGestorOS DataSetGestorOS;
    }
}