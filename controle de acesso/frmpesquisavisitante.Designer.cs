namespace controle_de_acesso
{
    partial class frmpesquisavisitante
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
            this.relatoriovisitante = new controle_de_acesso.relatoriovisitante();
            this.visitanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitanteTableAdapter = new controle_de_acesso.relatoriovisitanteTableAdapters.visitanteTableAdapter();
            this.relatoriovisitante1 = new controle_de_acesso.relatoriovisitante();
            this.visitanteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.relatoriovisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriovisitante1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.visitanteBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "controle_de_acesso.relatorio.visitante.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(614, 368);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // relatoriovisitante
            // 
            this.relatoriovisitante.DataSetName = "relatoriovisitante";
            this.relatoriovisitante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitanteBindingSource
            // 
            this.visitanteBindingSource.DataMember = "visitante";
            this.visitanteBindingSource.DataSource = this.relatoriovisitante;
            // 
            // visitanteTableAdapter
            // 
            this.visitanteTableAdapter.ClearBeforeFill = true;
            // 
            // relatoriovisitante1
            // 
            this.relatoriovisitante1.DataSetName = "relatoriovisitante";
            this.relatoriovisitante1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitanteBindingSource1
            // 
            this.visitanteBindingSource1.DataMember = "visitante";
            this.visitanteBindingSource1.DataSource = this.relatoriovisitante1;
            // 
            // frmpesquisavisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(614, 368);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmpesquisavisitante";
            this.Text = "Frmrelatoriovisitante";
            this.Load += new System.EventHandler(this.frmpesquisavisitante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relatoriovisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriovisitante1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private relatoriovisitante relatoriovisitante;
        private System.Windows.Forms.BindingSource visitanteBindingSource;
        private relatoriovisitanteTableAdapters.visitanteTableAdapter visitanteTableAdapter;
        private relatoriovisitante relatoriovisitante1;
        private System.Windows.Forms.BindingSource visitanteBindingSource1;
    }
}