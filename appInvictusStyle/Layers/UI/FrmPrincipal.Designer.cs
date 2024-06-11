namespace appInvictusStyle.Layers.UI
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.sttBarraInferior = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.mspMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.sesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItemCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItemProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarToolStripMenuItemFacturar = new System.Windows.Forms.ToolStripMenuItem();
            this.ofertaModelajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItemReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloToolStripMenuItemElectronico = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItemfacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sttBarraInferior.SuspendLayout();
            this.mspMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // sttBarraInferior
            // 
            this.sttBarraInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLblMensaje});
            this.sttBarraInferior.Location = new System.Drawing.Point(0, 428);
            this.sttBarraInferior.Name = "sttBarraInferior";
            this.sttBarraInferior.Size = new System.Drawing.Size(510, 22);
            this.sttBarraInferior.TabIndex = 4;
            // 
            // toolStripStatusLblMensaje
            // 
            this.toolStripStatusLblMensaje.Name = "toolStripStatusLblMensaje";
            this.toolStripStatusLblMensaje.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLblMensaje.Text = "-";
            // 
            // mspMenuPrincipal
            // 
            this.mspMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesiónToolStripMenuItem,
            this.toolStripMenuItemMantenimientos,
            this.toolStripMenuItemProcesos,
            this.reportesToolStripMenuItemReportes});
            this.mspMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mspMenuPrincipal.Name = "mspMenuPrincipal";
            this.mspMenuPrincipal.Size = new System.Drawing.Size(510, 56);
            this.mspMenuPrincipal.TabIndex = 5;
            this.mspMenuPrincipal.Text = "menuStrip1";
            // 
            // sesiónToolStripMenuItem
            // 
            this.sesiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.sesiónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sesiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sesiónToolStripMenuItem.Image")));
            this.sesiónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sesiónToolStripMenuItem.Name = "sesiónToolStripMenuItem";
            this.sesiónToolStripMenuItem.Size = new System.Drawing.Size(101, 52);
            this.sesiónToolStripMenuItem.Text = "Sesión";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesiónToolStripMenuItem.Image")));
            this.cerrarSesiónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(159, 38);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // toolStripMenuItemMantenimientos
            // 
            this.toolStripMenuItemMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItemCliente,
            this.tipoClientesToolStripMenuItem,
            this.articulosToolStripMenuItemProductos,
            this.descuentosToolStripMenuItem});
            this.toolStripMenuItemMantenimientos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemMantenimientos.Image")));
            this.toolStripMenuItemMantenimientos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemMantenimientos.Name = "toolStripMenuItemMantenimientos";
            this.toolStripMenuItemMantenimientos.Size = new System.Drawing.Size(154, 52);
            this.toolStripMenuItemMantenimientos.Text = "Mantenimientos";
            // 
            // clientesToolStripMenuItemCliente
            // 
            this.clientesToolStripMenuItemCliente.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItemCliente.Image")));
            this.clientesToolStripMenuItemCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItemCliente.Name = "clientesToolStripMenuItemCliente";
            this.clientesToolStripMenuItemCliente.Size = new System.Drawing.Size(174, 54);
            this.clientesToolStripMenuItemCliente.Text = "Clientes";
            this.clientesToolStripMenuItemCliente.Click += new System.EventHandler(this.clientesToolStripMenuItemCliente_Click);
            // 
            // tipoClientesToolStripMenuItem
            // 
            this.tipoClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoClientesToolStripMenuItem.Image")));
            this.tipoClientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tipoClientesToolStripMenuItem.Name = "tipoClientesToolStripMenuItem";
            this.tipoClientesToolStripMenuItem.Size = new System.Drawing.Size(174, 54);
            this.tipoClientesToolStripMenuItem.Text = "Tipo Clientes";
            this.tipoClientesToolStripMenuItem.Click += new System.EventHandler(this.tipoClientesToolStripMenuItem_Click);
            // 
            // articulosToolStripMenuItemProductos
            // 
            this.articulosToolStripMenuItemProductos.Image = ((System.Drawing.Image)(resources.GetObject("articulosToolStripMenuItemProductos.Image")));
            this.articulosToolStripMenuItemProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.articulosToolStripMenuItemProductos.Name = "articulosToolStripMenuItemProductos";
            this.articulosToolStripMenuItemProductos.Size = new System.Drawing.Size(174, 54);
            this.articulosToolStripMenuItemProductos.Text = "Articulos";
            this.articulosToolStripMenuItemProductos.Click += new System.EventHandler(this.articulosToolStripMenuItemProductos_Click);
            // 
            // descuentosToolStripMenuItem
            // 
            this.descuentosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("descuentosToolStripMenuItem.Image")));
            this.descuentosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            this.descuentosToolStripMenuItem.Size = new System.Drawing.Size(174, 54);
            this.descuentosToolStripMenuItem.Text = "Descuentos";
            this.descuentosToolStripMenuItem.Click += new System.EventHandler(this.descuentosToolStripMenuItem_Click);
            // 
            // toolStripMenuItemProcesos
            // 
            this.toolStripMenuItemProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturarToolStripMenuItemFacturar,
            this.ofertaModelajeToolStripMenuItem});
            this.toolStripMenuItemProcesos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemProcesos.Image")));
            this.toolStripMenuItemProcesos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemProcesos.Name = "toolStripMenuItemProcesos";
            this.toolStripMenuItemProcesos.Size = new System.Drawing.Size(114, 52);
            this.toolStripMenuItemProcesos.Text = "Procesos";
            // 
            // facturarToolStripMenuItemFacturar
            // 
            this.facturarToolStripMenuItemFacturar.Image = ((System.Drawing.Image)(resources.GetObject("facturarToolStripMenuItemFacturar.Image")));
            this.facturarToolStripMenuItemFacturar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.facturarToolStripMenuItemFacturar.Name = "facturarToolStripMenuItemFacturar";
            this.facturarToolStripMenuItemFacturar.Size = new System.Drawing.Size(191, 54);
            this.facturarToolStripMenuItemFacturar.Text = "Facturar";
            this.facturarToolStripMenuItemFacturar.Click += new System.EventHandler(this.facturarToolStripMenuItemFacturar_Click);
            // 
            // ofertaModelajeToolStripMenuItem
            // 
            this.ofertaModelajeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ofertaModelajeToolStripMenuItem.Image")));
            this.ofertaModelajeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ofertaModelajeToolStripMenuItem.Name = "ofertaModelajeToolStripMenuItem";
            this.ofertaModelajeToolStripMenuItem.Size = new System.Drawing.Size(212, 54);
            this.ofertaModelajeToolStripMenuItem.Text = "Oferta Publicidad";
            this.ofertaModelajeToolStripMenuItem.Click += new System.EventHandler(this.ofertaModelajeToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItemReportes
            // 
            this.reportesToolStripMenuItemReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItemClientes,
            this.articuloToolStripMenuItemElectronico,
            this.facturaciónToolStripMenuItemfacturacion,
            this.detalleFacturaToolStripMenuItem,
            this.publicidadToolStripMenuItem});
            this.reportesToolStripMenuItemReportes.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItemReportes.Image")));
            this.reportesToolStripMenuItemReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportesToolStripMenuItemReportes.Name = "reportesToolStripMenuItemReportes";
            this.reportesToolStripMenuItemReportes.Size = new System.Drawing.Size(113, 52);
            this.reportesToolStripMenuItemReportes.Text = "Reportes";
            // 
            // clientesToolStripMenuItemClientes
            // 
            this.clientesToolStripMenuItemClientes.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItemClientes.Image")));
            this.clientesToolStripMenuItemClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItemClientes.Name = "clientesToolStripMenuItemClientes";
            this.clientesToolStripMenuItemClientes.Size = new System.Drawing.Size(184, 54);
            this.clientesToolStripMenuItemClientes.Text = "Clientes";
            this.clientesToolStripMenuItemClientes.Click += new System.EventHandler(this.clientesToolStripMenuItemClientes_Click);
            // 
            // articuloToolStripMenuItemElectronico
            // 
            this.articuloToolStripMenuItemElectronico.Image = ((System.Drawing.Image)(resources.GetObject("articuloToolStripMenuItemElectronico.Image")));
            this.articuloToolStripMenuItemElectronico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.articuloToolStripMenuItemElectronico.Name = "articuloToolStripMenuItemElectronico";
            this.articuloToolStripMenuItemElectronico.Size = new System.Drawing.Size(184, 54);
            this.articuloToolStripMenuItemElectronico.Text = "Artículos";
            this.articuloToolStripMenuItemElectronico.Click += new System.EventHandler(this.articuloToolStripMenuItemElectronico_Click);
            // 
            // facturaciónToolStripMenuItemfacturacion
            // 
            this.facturaciónToolStripMenuItemfacturacion.Image = ((System.Drawing.Image)(resources.GetObject("facturaciónToolStripMenuItemfacturacion.Image")));
            this.facturaciónToolStripMenuItemfacturacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.facturaciónToolStripMenuItemfacturacion.Name = "facturaciónToolStripMenuItemfacturacion";
            this.facturaciónToolStripMenuItemfacturacion.Size = new System.Drawing.Size(184, 54);
            this.facturaciónToolStripMenuItemfacturacion.Text = "Facturas";
            this.facturaciónToolStripMenuItemfacturacion.Click += new System.EventHandler(this.facturaciónToolStripMenuItemfacturacion_Click);
            // 
            // detalleFacturaToolStripMenuItem
            // 
            this.detalleFacturaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detalleFacturaToolStripMenuItem.Image")));
            this.detalleFacturaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detalleFacturaToolStripMenuItem.Name = "detalleFacturaToolStripMenuItem";
            this.detalleFacturaToolStripMenuItem.Size = new System.Drawing.Size(184, 54);
            this.detalleFacturaToolStripMenuItem.Text = "Detalle Factura";
            this.detalleFacturaToolStripMenuItem.Click += new System.EventHandler(this.detalleFacturaToolStripMenuItem_Click);
            // 
            // publicidadToolStripMenuItem
            // 
            this.publicidadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("publicidadToolStripMenuItem.Image")));
            this.publicidadToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.publicidadToolStripMenuItem.Name = "publicidadToolStripMenuItem";
            this.publicidadToolStripMenuItem.Size = new System.Drawing.Size(184, 54);
            this.publicidadToolStripMenuItem.Text = "Publicidad";
            this.publicidadToolStripMenuItem.Click += new System.EventHandler(this.publicidadToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.sttBarraInferior);
            this.Controls.Add(this.mspMenuPrincipal);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.sttBarraInferior.ResumeLayout(false);
            this.sttBarraInferior.PerformLayout();
            this.mspMenuPrincipal.ResumeLayout(false);
            this.mspMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sttBarraInferior;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblMensaje;
        private System.Windows.Forms.MenuStrip mspMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem sesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItemCliente;
        private System.Windows.Forms.ToolStripMenuItem tipoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItemProductos;
        private System.Windows.Forms.ToolStripMenuItem descuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProcesos;
        private System.Windows.Forms.ToolStripMenuItem facturarToolStripMenuItemFacturar;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItemReportes;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItemElectronico;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItemClientes;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItemfacturacion;
        private System.Windows.Forms.ToolStripMenuItem ofertaModelajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleFacturaToolStripMenuItem;
    }
}