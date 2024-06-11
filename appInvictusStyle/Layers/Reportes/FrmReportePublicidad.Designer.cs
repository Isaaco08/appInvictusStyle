
namespace appInvictusStyle.Layers.Reportes
{
    partial class FrmReportePublicidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportePublicidad));
            this.PublicidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteCliente = new appInvictusStyle.Layers.Reportes.ReporteCliente();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PublicidadTableAdapter = new appInvictusStyle.Layers.Reportes.ReporteClienteTableAdapters.PublicidadTableAdapter();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PublicidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tspBarraSuperior.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PublicidadBindingSource
            // 
            this.PublicidadBindingSource.DataMember = "Publicidad";
            this.PublicidadBindingSource.DataSource = this.ReporteCliente;
            // 
            // ReporteCliente
            // 
            this.ReporteCliente.DataSetName = "ReporteCliente";
            this.ReporteCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Publicidad";
            reportDataSource1.Value = this.PublicidadBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "appInvictusStyle.Layers.Reportes.ReportPublicidad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(737, 240);
            this.reportViewer1.TabIndex = 0;
            // 
            // PublicidadTableAdapter
            // 
            this.PublicidadTableAdapter.ClearBeforeFill = true;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(165, 20);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 1;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(165, 59);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFinal.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(437, 106);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.dtpFinal);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Fechas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha de Inicio";
            // 
            // tspBarraSuperior
            // 
            this.tspBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSalir});
            this.tspBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tspBarraSuperior.Name = "tspBarraSuperior";
            this.tspBarraSuperior.Size = new System.Drawing.Size(767, 55);
            this.tspBarraSuperior.TabIndex = 23;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reportViewer1);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 259);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reporte de Ofertas de Publicidad";
            // 
            // FrmReportePublicidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tspBarraSuperior);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FrmReportePublicidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publicidad";
            this.Load += new System.EventHandler(this.FrmReportePublicidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PublicidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PublicidadBindingSource;
        private ReporteCliente ReporteCliente;
        private ReporteClienteTableAdapters.PublicidadTableAdapter PublicidadTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}