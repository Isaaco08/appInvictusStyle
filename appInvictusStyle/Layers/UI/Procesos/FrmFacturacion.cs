using appInvictusStyle.Interfaces;
using appInvictusStyle.Layers.BLL;
using appInvictusStyle.Layers.Reportes;
using appInvictusStyle.Layers.UI.Filtro;
using log4net;
using ServicioBCCR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.InvictusStyle;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace appInvictusStyle.Layers.UI.Procesos
{
    public partial class FrmFacturacion : Form
    {
        public Articulo oArticulo { get; private set; } = null;
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private Cliente oCliente = null;
        private Factura oFactura = null;
        DetalleFactura oDetalle = new DetalleFactura();
        double totalPagar = 0;
        public FrmFacturacion()
        {
            InitializeComponent();
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            try
            {
                IBLLFactura _BLLFactura = new BLLFactura();
                lblID_Factura.Text = _BLLFactura.GetCurrentNumeroFactura().ToString();

                Image qr = QuickResponse.QuickResponseGenerador(_BLLFactura.GetCurrentNumeroFactura().ToString(), 53);

                pictureBox1.Image = qr;
            }
            catch (SqlException sqlError)
            {
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: \n" + Utilitarios.GetCustomErrorByNumber(sqlError), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente frmBuscarCliente = new FrmBuscarCliente();
            IBLLCliente _BLLCliente = new BLLCliente();
            try
            {
                erpError.Clear();

                    // Mostrar ventan de filtro
                    frmBuscarCliente.ShowDialog();
                    if (frmBuscarCliente.DialogResult == DialogResult.OK)
                    {
                        oCliente = frmBuscarCliente.oCliente;
                    }
                

                if (oCliente == null)
                {
                    MessageBox.Show("No existe el Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                IBLLFactura _BLLFactura = new BLLFactura();
                lblID_Factura.Text = _BLLFactura.GetNextNumeroFactura().ToString();
                oFactura = new Factura()
                {
                    ID = lblID_Factura.Text,
                    Fecha = DateTime.Today,
                    ID_Cliente = oCliente.ID
                };



                this.lblCliente.Text = oCliente.Nombre + " " + oCliente.Apellido1 + " " + oCliente.Apellido2;
                this.lblClienteID.Text = oCliente.ID;
                this.lblID_Factura.Text = oFactura.ID;
                btnElegirArticulo.Enabled = true;

            }
            catch (SqlException sqlError)
            {
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: \n" + Utilitarios.GetCustomErrorByNumber(sqlError), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElegirArticulo_Click(object sender, EventArgs e)
        {
            FrmBuscarArticulo frmBuscarArticulo = new FrmBuscarArticulo();
            
            try
            {
                erpError.Clear();
           
                    // Mostrar ventan de filtro
                    frmBuscarArticulo.ShowDialog();
                    if (frmBuscarArticulo.DialogResult == DialogResult.OK)
                    {
                        oArticulo = frmBuscarArticulo.oArticulo;
                    }
                

                if (oArticulo == null)
                {
                    MessageBox.Show("No existe el Artículo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                

                this.lblDescripcionArticulo.Text = "Artículo: " + oArticulo.Descripcion;
                this.lblPrecioArticulo.Text = "Precio: " + oArticulo.Precio.ToString() + "₡";

                IBLLFactura _BLLFactura = new BLLFactura();
                string idDetalle = _BLLFactura.GetNextNumeroFactura().ToString();
                oDetalle.ID = idDetalle;
                oDetalle.ID_Factura = oFactura.ID;
                oDetalle.ID_Articulo = oArticulo.ID;
                oFactura.AddDetalle(oDetalle);

                btnAgregarArticulo.Enabled = true;

            }
            catch (SqlException sqlError)
            {
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: \n" + Utilitarios.GetCustomErrorByNumber(sqlError), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            double sub = 0;
            sub = (double)oArticulo.Precio;
            oDetalle.Subtotal = sub;

                oDetalle.Cantidad = int.Parse(txtCantidad.Text);
                oDetalle.Subtotal = oFactura.calcularSubtotal();
                oDetalle.Descuento = oFactura.calcularDescuento(oArticulo.ID_Descuento, oCliente.ID_Tipo_Cliente) / double.Parse(txtCantidad.Text);
                oDetalle.IVA = oFactura.calcularIVA() / double.Parse(txtCantidad.Text);
                oDetalle.Total = oDetalle.Subtotal - oDetalle.Descuento +
                    oDetalle.IVA;


                this.txtSubtotal.Text = oDetalle.Subtotal.ToString();
                this.txtDescuento.Text = oDetalle.Descuento.ToString();
                this.txtIva.Text = oDetalle.IVA.ToString();
                this.txtTotal.Text = oDetalle.Total.ToString();
   

            // Configuracion del DataGridView para que se vea bien la imagen.
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.RowTemplate.Height = 100;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Cargar el DataGridView
            string[] datosArticulos = {oArticulo.ID,
                oArticulo.Descripcion,
                oArticulo.Precio.ToString(),
                oDetalle.Cantidad.ToString()
                };


            dgvDatos.Rows.Add(datosArticulos);

            txtCantidad.Clear();
            btnFacturar.Enabled = true;
            btnDolares.Enabled = true;

            totalPagar += oDetalle.Total;
            lblTotalAPagar.Text = "Total a pagar: " + totalPagar + "₡";
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                oDetalle.Total = totalPagar;
                IBLLFactura _BLLFactura = new BLLFactura();
                _BLLFactura.SaveFactura(oFactura);
                MessageBox.Show("Factura Guardada con Exito");

                txtSubtotal.Text = "";
                txtDescuento.Text = "";
                txtIva.Text = "";
                txtTotal.Text = "";
                lblTotalAPagar.Text = "--------------------------------------------";
                totalPagar = 0;
                FrmReporteFactura frm = new FrmReporteFactura();
                frm.Show();
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }      

        private void btnDolares_Click(object sender, EventArgs e)
        {
            double precioDolar = 0;
            string venta = "v";
            List<Dolar> lista = new List<Dolar>();

            ServiceBCCR servicio = new ServiceBCCR();
            lista = (List<Dolar>)servicio.GetDolar(DateTime.Now, DateTime.Now, venta);

            foreach (var item in lista)
            {
                precioDolar = item.Monto;
            }

            oDetalle.Subtotal = oFactura.calcularSubtotalDolares(oDetalle.Subtotal, precioDolar);
            oDetalle.Descuento = oFactura.calcularDescuentoDolares(oDetalle.Descuento, precioDolar);
            oDetalle.IVA = oFactura.calcularIVADolares(oDetalle.IVA, precioDolar);
            oDetalle.Total = (oDetalle.Subtotal - oDetalle.Descuento + oDetalle.IVA) / precioDolar;

            totalPagar = totalPagar / precioDolar;
            string totalDolares = totalPagar.ToString("N2");
            lblTotalAPagar.Text = "Total a pagar: " + totalDolares + "$";
        }
    }
}
