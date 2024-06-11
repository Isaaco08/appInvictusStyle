namespace appInvictusStyle.Layers.UI.Procesos
{
    partial class FrmFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturacion));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDolares = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPrecioArticulo = new System.Windows.Forms.Label();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.btnElegirArticulo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSimboloSubtotal = new System.Windows.Forms.Label();
            this.lblSimboloDescuento = new System.Windows.Forms.Label();
            this.lblSimboloIVA = new System.Windows.Forms.Label();
            this.lblSimboloTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID_Factura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.sttInferior = new System.Windows.Forms.StatusStrip();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tspBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvDatos);
            this.groupBox5.Location = new System.Drawing.Point(12, 229);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(549, 255);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Artículos Seleccionados";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Cantidad});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(3, 16);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(543, 236);
            this.dgvDatos.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "IdArticulo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Descripcion";
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Precio";
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDolares);
            this.groupBox4.Location = new System.Drawing.Point(884, 197);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(176, 78);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo de Moneda";
            // 
            // btnDolares
            // 
            this.btnDolares.Enabled = false;
            this.btnDolares.Location = new System.Drawing.Point(6, 32);
            this.btnDolares.Name = "btnDolares";
            this.btnDolares.Size = new System.Drawing.Size(164, 23);
            this.btnDolares.TabIndex = 24;
            this.btnDolares.Text = "Pagar en Dolares";
            this.btnDolares.UseVisualStyleBackColor = true;
            this.btnDolares.Click += new System.EventHandler(this.btnDolares_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPrecioArticulo);
            this.groupBox3.Controls.Add(this.btnAgregarArticulo);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblDescripcionArticulo);
            this.groupBox3.Controls.Add(this.btnElegirArticulo);
            this.groupBox3.Location = new System.Drawing.Point(567, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 217);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Compra";
            // 
            // lblPrecioArticulo
            // 
            this.lblPrecioArticulo.AutoSize = true;
            this.lblPrecioArticulo.Location = new System.Drawing.Point(30, 65);
            this.lblPrecioArticulo.Name = "lblPrecioArticulo";
            this.lblPrecioArticulo.Size = new System.Drawing.Size(130, 13);
            this.lblPrecioArticulo.TabIndex = 23;
            this.lblPrecioArticulo.Text = "-----------------------------------------";
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Enabled = false;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(33, 175);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(256, 23);
            this.btnAgregarArticulo.TabIndex = 22;
            this.btnAgregarArticulo.Text = "Agregar Artículo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(89, 134);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(71, 20);
            this.txtCantidad.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cantidad";
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(30, 30);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(130, 13);
            this.lblDescripcionArticulo.TabIndex = 9;
            this.lblDescripcionArticulo.Text = "-----------------------------------------";
            // 
            // btnElegirArticulo
            // 
            this.btnElegirArticulo.Enabled = false;
            this.btnElegirArticulo.Location = new System.Drawing.Point(192, 53);
            this.btnElegirArticulo.Name = "btnElegirArticulo";
            this.btnElegirArticulo.Size = new System.Drawing.Size(97, 23);
            this.btnElegirArticulo.TabIndex = 8;
            this.btnElegirArticulo.Text = "Elegir Artículo";
            this.btnElegirArticulo.UseVisualStyleBackColor = true;
            this.btnElegirArticulo.Click += new System.EventHandler(this.btnElegirArticulo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSimboloSubtotal);
            this.groupBox2.Controls.Add(this.lblSimboloDescuento);
            this.groupBox2.Controls.Add(this.lblSimboloIVA);
            this.groupBox2.Controls.Add(this.lblSimboloTotal);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSubtotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDescuento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIva);
            this.groupBox2.Location = new System.Drawing.Point(567, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 200);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desglose";
            // 
            // lblSimboloSubtotal
            // 
            this.lblSimboloSubtotal.AutoSize = true;
            this.lblSimboloSubtotal.Location = new System.Drawing.Point(345, 44);
            this.lblSimboloSubtotal.Name = "lblSimboloSubtotal";
            this.lblSimboloSubtotal.Size = new System.Drawing.Size(18, 13);
            this.lblSimboloSubtotal.TabIndex = 23;
            this.lblSimboloSubtotal.Text = "₡ ";
            // 
            // lblSimboloDescuento
            // 
            this.lblSimboloDescuento.AutoSize = true;
            this.lblSimboloDescuento.Location = new System.Drawing.Point(345, 81);
            this.lblSimboloDescuento.Name = "lblSimboloDescuento";
            this.lblSimboloDescuento.Size = new System.Drawing.Size(18, 13);
            this.lblSimboloDescuento.TabIndex = 22;
            this.lblSimboloDescuento.Text = "₡ ";
            // 
            // lblSimboloIVA
            // 
            this.lblSimboloIVA.AutoSize = true;
            this.lblSimboloIVA.Location = new System.Drawing.Point(345, 117);
            this.lblSimboloIVA.Name = "lblSimboloIVA";
            this.lblSimboloIVA.Size = new System.Drawing.Size(18, 13);
            this.lblSimboloIVA.TabIndex = 21;
            this.lblSimboloIVA.Text = "₡ ";
            // 
            // lblSimboloTotal
            // 
            this.lblSimboloTotal.AutoSize = true;
            this.lblSimboloTotal.Location = new System.Drawing.Point(345, 149);
            this.lblSimboloTotal.Name = "lblSimboloTotal";
            this.lblSimboloTotal.Size = new System.Drawing.Size(18, 13);
            this.lblSimboloTotal.TabIndex = 20;
            this.lblSimboloTotal.Text = "₡ ";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(239, 146);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "IVA";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(239, 41);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Descuento";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(239, 78);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Subtotal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total";
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(239, 114);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(100, 20);
            this.txtIva.TabIndex = 17;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Enabled = false;
            this.btnFacturar.Location = new System.Drawing.Point(19, 75);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(139, 34);
            this.btnFacturar.TabIndex = 11;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.lblClienteID);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblID_Factura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 165);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Facturación";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Location = new System.Drawing.Point(386, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(154, 135);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "QR ID Factura";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 103);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Location = new System.Drawing.Point(120, 75);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(106, 13);
            this.lblClienteID.TabIndex = 8;
            this.lblClienteID.Text = "---------------------------------";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(120, 120);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(106, 13);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "---------------------------------";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(250, 70);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(112, 23);
            this.btnBuscarCliente.TabIndex = 5;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente (ID)";
            // 
            // lblID_Factura
            // 
            this.lblID_Factura.AutoSize = true;
            this.lblID_Factura.Location = new System.Drawing.Point(120, 32);
            this.lblID_Factura.Name = "lblID_Factura";
            this.lblID_Factura.Size = new System.Drawing.Size(106, 13);
            this.lblID_Factura.TabIndex = 1;
            this.lblID_Factura.Text = "---------------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Factura";
            // 
            // tspBarraSuperior
            // 
            this.tspBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSalir});
            this.tspBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tspBarraSuperior.Name = "tspBarraSuperior";
            this.tspBarraSuperior.Size = new System.Drawing.Size(1077, 55);
            this.tspBarraSuperior.TabIndex = 19;
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
            // sttInferior
            // 
            this.sttInferior.Location = new System.Drawing.Point(0, 494);
            this.sttInferior.Name = "sttInferior";
            this.sttInferior.Size = new System.Drawing.Size(1077, 22);
            this.sttInferior.TabIndex = 25;
            this.sttInferior.Text = "statusStrip1";
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTotalAPagar);
            this.groupBox6.Controls.Add(this.btnFacturar);
            this.groupBox6.Location = new System.Drawing.Point(884, 58);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(176, 133);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Total Pagar";
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Location = new System.Drawing.Point(16, 34);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(139, 13);
            this.lblTotalAPagar.TabIndex = 12;
            this.lblTotalAPagar.Text = "--------------------------------------------";
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 516);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.sttInferior);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tspBarraSuperior);
            this.Name = "FrmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label lblDescripcionArticulo;
        private System.Windows.Forms.Button btnElegirArticulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID_Factura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.StatusStrip sttInferior;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Label lblPrecioArticulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblSimboloSubtotal;
        private System.Windows.Forms.Label lblSimboloDescuento;
        private System.Windows.Forms.Label lblSimboloIVA;
        private System.Windows.Forms.Label lblSimboloTotal;
        private System.Windows.Forms.Button btnDolares;
    }
}