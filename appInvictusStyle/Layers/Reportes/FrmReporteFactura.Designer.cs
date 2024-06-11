
namespace appInvictusStyle.Layers.Reportes
{
    partial class FrmReporteFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteFactura));
            this.FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteCliente = new appInvictusStyle.Layers.Reportes.ReporteCliente();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturaTableAdapter = new appInvictusStyle.Layers.Reportes.ReporteClienteTableAdapters.FacturaTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tspPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBorrar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tspPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // FacturaBindingSource
            // 
            this.FacturaBindingSource.DataMember = "Factura";
            this.FacturaBindingSource.DataSource = this.ReporteCliente;
            // 
            // ReporteCliente
            // 
            this.ReporteCliente.DataSetName = "ReporteCliente";
            this.ReporteCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Factura";
            reportDataSource1.Value = this.FacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "appInvictusStyle.Layers.Reportes.ReportFacturas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(486, 402);
            this.reportViewer1.TabIndex = 2;
            // 
            // FacturaTableAdapter
            // 
            this.FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 421);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reporte de Facturas";
            // 
            // tspPrincipal
            // 
            this.tspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNuevo,
            this.toolStripBtnEditar,
            this.toolStripBtnBorrar});
            this.tspPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tspPrincipal.Name = "tspPrincipal";
            this.tspPrincipal.Size = new System.Drawing.Size(527, 55);
            this.tspPrincipal.TabIndex = 24;
            // 
            // toolStripBtnNuevo
            // 
            this.toolStripBtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnNuevo.Image")));
            this.toolStripBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNuevo.Name = "toolStripBtnNuevo";
            this.toolStripBtnNuevo.Size = new System.Drawing.Size(81, 52);
            this.toolStripBtnNuevo.Text = "Salir";
            this.toolStripBtnNuevo.Click += new System.EventHandler(this.toolStripBtnNuevo_Click);
            // 
            // toolStripBtnEditar
            // 
            this.toolStripBtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnEditar.Image")));
            this.toolStripBtnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEditar.Name = "toolStripBtnEditar";
            this.toolStripBtnEditar.Size = new System.Drawing.Size(80, 52);
            this.toolStripBtnEditar.Text = "PDF";
            this.toolStripBtnEditar.Click += new System.EventHandler(this.toolStripBtnEditar_Click);
            // 
            // toolStripBtnBorrar
            // 
            this.toolStripBtnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnBorrar.Image")));
            this.toolStripBtnBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBorrar.Name = "toolStripBtnBorrar";
            this.toolStripBtnBorrar.Size = new System.Drawing.Size(95, 52);
            this.toolStripBtnBorrar.Text = "Correo";
            this.toolStripBtnBorrar.Click += new System.EventHandler(this.toolStripBtnBorrar_Click);
            // 
            // FrmReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 500);
            this.Controls.Add(this.tspPrincipal);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmReporteFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Facturas";
            this.Load += new System.EventHandler(this.FrmReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tspPrincipal.ResumeLayout(false);
            this.tspPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturaBindingSource;
        private ReporteCliente ReporteCliente;
        private ReporteClienteTableAdapters.FacturaTableAdapter FacturaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip tspPrincipal;
        private System.Windows.Forms.ToolStripButton toolStripBtnNuevo;
        private System.Windows.Forms.ToolStripButton toolStripBtnEditar;
        private System.Windows.Forms.ToolStripButton toolStripBtnBorrar;
    }
}