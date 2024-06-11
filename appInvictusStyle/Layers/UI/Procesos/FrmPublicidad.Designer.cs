
namespace appInvictusStyle.Layers.UI.Procesos
{
    partial class FrmPublicidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPublicidad));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnElegirCliente = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.btnElegirArticulo = new System.Windows.Forms.Button();
            this.btnPublicarOferta = new System.Windows.Forms.Button();
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIDPublicidad = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tspBarraSuperior.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvClientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Clientes de la Tienda";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(3, 16);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(453, 147);
            this.dgvClientes.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nombre";
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Apellido1";
            this.Column3.HeaderText = "Apellido1";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Apellido2";
            this.Column4.HeaderText = "Apellido2";
            this.Column4.Name = "Column4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvArticulos);
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Artículos de la Tienda";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulos.Location = new System.Drawing.Point(3, 16);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.Size = new System.Drawing.Size(450, 147);
            this.dgvArticulos.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdArticulo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNombreCliente);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtCliente);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnElegirCliente);
            this.groupBox3.Location = new System.Drawing.Point(477, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 163);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente Modelo";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(98, 78);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(98, 27);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cliente";
            // 
            // btnElegirCliente
            // 
            this.btnElegirCliente.Location = new System.Drawing.Point(6, 120);
            this.btnElegirCliente.Name = "btnElegirCliente";
            this.btnElegirCliente.Size = new System.Drawing.Size(231, 23);
            this.btnElegirCliente.TabIndex = 5;
            this.btnElegirCliente.Text = "Elegir Cliente";
            this.btnElegirCliente.UseVisualStyleBackColor = true;
            this.btnElegirCliente.Click += new System.EventHandler(this.btnElegirCliente_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNombreArticulo);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtArticulo);
            this.groupBox4.Controls.Add(this.btnElegirArticulo);
            this.groupBox4.Location = new System.Drawing.Point(474, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 147);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Artículo a Modelar";
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Enabled = false;
            this.txtNombreArticulo.Location = new System.Drawing.Point(98, 71);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreArticulo.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Artículo";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Enabled = false;
            this.txtArticulo.Location = new System.Drawing.Point(98, 30);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtArticulo.TabIndex = 0;
            // 
            // btnElegirArticulo
            // 
            this.btnElegirArticulo.Location = new System.Drawing.Point(6, 108);
            this.btnElegirArticulo.Name = "btnElegirArticulo";
            this.btnElegirArticulo.Size = new System.Drawing.Size(228, 23);
            this.btnElegirArticulo.TabIndex = 6;
            this.btnElegirArticulo.Text = "Elegir Artículo";
            this.btnElegirArticulo.UseVisualStyleBackColor = true;
            this.btnElegirArticulo.Click += new System.EventHandler(this.btnElegirArticulo_Click);
            // 
            // btnPublicarOferta
            // 
            this.btnPublicarOferta.Image = ((System.Drawing.Image)(resources.GetObject("btnPublicarOferta.Image")));
            this.btnPublicarOferta.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPublicarOferta.Location = new System.Drawing.Point(16, 78);
            this.btnPublicarOferta.Name = "btnPublicarOferta";
            this.btnPublicarOferta.Size = new System.Drawing.Size(198, 60);
            this.btnPublicarOferta.TabIndex = 4;
            this.btnPublicarOferta.Text = "Crear Oferta";
            this.btnPublicarOferta.UseVisualStyleBackColor = true;
            this.btnPublicarOferta.Click += new System.EventHandler(this.btnPublicarOferta_Click);
            // 
            // tspBarraSuperior
            // 
            this.tspBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSalir});
            this.tspBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tspBarraSuperior.Name = "tspBarraSuperior";
            this.tspBarraSuperior.Size = new System.Drawing.Size(967, 55);
            this.tspBarraSuperior.TabIndex = 20;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "ID Publicidad";
            // 
            // lblIDPublicidad
            // 
            this.lblIDPublicidad.AutoSize = true;
            this.lblIDPublicidad.Location = new System.Drawing.Point(109, 30);
            this.lblIDPublicidad.Name = "lblIDPublicidad";
            this.lblIDPublicidad.Size = new System.Drawing.Size(37, 13);
            this.lblIDPublicidad.TabIndex = 22;
            this.lblIDPublicidad.Text = "----------";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblIDPublicidad);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.btnPublicarOferta);
            this.groupBox5.Location = new System.Drawing.Point(735, 73);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(220, 163);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Publicidad";
            // 
            // FrmPublicidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 425);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.tspBarraSuperior);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPublicidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oferta de Publicidad";
            this.Load += new System.EventHandler(this.FrmPublicidad_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Button btnPublicarOferta;
        private System.Windows.Forms.Button btnElegirCliente;
        private System.Windows.Forms.Button btnElegirArticulo;
        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIDPublicidad;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}