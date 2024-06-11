
namespace appInvictusStyle.Layers.Reportes
{
    partial class FrmReporteArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteArticulos));
            this.ArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteCliente = new appInvictusStyle.Layers.Reportes.ReporteCliente();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ArticuloTableAdapter = new appInvictusStyle.Layers.Reportes.ReporteClienteTableAdapters.ArticuloTableAdapter();
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCliente)).BeginInit();
            this.tspBarraSuperior.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArticuloBindingSource
            // 
            this.ArticuloBindingSource.DataMember = "Articulo";
            this.ArticuloBindingSource.DataSource = this.ReporteCliente;
            // 
            // ReporteCliente
            // 
            this.ReporteCliente.DataSetName = "ReporteCliente";
            this.ReporteCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Articulos";
            reportDataSource1.Value = this.ArticuloBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "appInvictusStyle.Layers.Reportes.ReportArticulos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(773, 361);
            this.reportViewer1.TabIndex = 0;
            // 
            // ArticuloTableAdapter
            // 
            this.ArticuloTableAdapter.ClearBeforeFill = true;
            // 
            // tspBarraSuperior
            // 
            this.tspBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSalir});
            this.tspBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tspBarraSuperior.Name = "tspBarraSuperior";
            this.tspBarraSuperior.Size = new System.Drawing.Size(803, 55);
            this.tspBarraSuperior.TabIndex = 21;
            this.tspBarraSuperior.Text = "toolStrip1";
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSalir.Image")));
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(81, 52);
            this.toolStripBtnSalir.Text = "Salir";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 380);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artículos";
            // 
            // FrmReporteArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tspBarraSuperior);
            this.Name = "FrmReporteArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Artículos";
            this.Load += new System.EventHandler(this.FrmReporteArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCliente)).EndInit();
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ArticuloBindingSource;
        private ReporteCliente ReporteCliente;
        private ReporteClienteTableAdapters.ArticuloTableAdapter ArticuloTableAdapter;
        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}