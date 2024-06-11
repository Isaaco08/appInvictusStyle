using appInvictusStyle.Interfaces;
using appInvictusStyle.Layers.BLL;
using appInvictusStyle.Layers.Reportes;
using appInvictusStyle.Layers.UI.Mantenimientos;
using appInvictusStyle.Layers.UI.Procesos;
using appInvictusStyle.Properties;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace appInvictusStyle.Layers.UI
{
    public partial class FrmPrincipal : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public Usuario oTipoUsuario;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                if (oTipoUsuario.ID_Tipo_Usuario == "2")
                {
                    toolStripMenuItemMantenimientos.Visible = false;
                    reportesToolStripMenuItemReportes.Visible = false;
                }
                if (oTipoUsuario.ID_Tipo_Usuario == "3")
                {
                    toolStripMenuItemMantenimientos.Visible = false;
                    toolStripMenuItemProcesos.Visible = false;
                }


                Utilitarios.CultureInfo();
                toolStripStatusLblMensaje.Text = "Usuario Conectado: " + oTipoUsuario.Contrasena.ToString();

                

                if (!Directory.Exists(@"C:\temp"))
                    Directory.CreateDirectory(@"C:\temp");


                _MyLogControlEventos.InfoFormat("Conectado a Form Principal");

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

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clientesToolStripMenuItemCliente_Click(object sender, EventArgs e)
        {
            FrmMantenimientoClientes frmMantenimientoClientes = new FrmMantenimientoClientes();
            frmMantenimientoClientes.Show();
        }

        private void tipoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoTipoCliente frmMantenimientoTipoCliente = new FrmMantenimientoTipoCliente();
            frmMantenimientoTipoCliente.Show();
        }

        private void articulosToolStripMenuItemProductos_Click(object sender, EventArgs e)
        {
            FrmMantenimientoArticulos frmMantenimientoArticulos = new FrmMantenimientoArticulos();
            frmMantenimientoArticulos.Show();
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoDescuento frmMantenimientoDescuento = new FrmMantenimientoDescuento();
            frmMantenimientoDescuento.Show();
        }

        private void facturarToolStripMenuItemFacturar_Click(object sender, EventArgs e)
        {
            FrmFacturacion frmFacturacion = new FrmFacturacion();
            frmFacturacion.Show();
        }

        private void clientesToolStripMenuItemClientes_Click(object sender, EventArgs e)
        {
            FrmReporteCliente frmReporteCliente = new FrmReporteCliente();
            frmReporteCliente.Show();
        }

        private void facturaciónToolStripMenuItemfacturacion_Click(object sender, EventArgs e)
        {
            FrmReporteFactura frmReporteFactura = new FrmReporteFactura();
            frmReporteFactura.Show();
        }

        private void articuloToolStripMenuItemElectronico_Click(object sender, EventArgs e)
        {
            FrmReporteArticulos frmReporteArticulos = new FrmReporteArticulos();
            frmReporteArticulos.Show();
        }

        private void ofertaModelajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPublicidad frmPublicidad = new FrmPublicidad();
            frmPublicidad.Show();
        }

        private void publicidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportePublicidad frmReportePublicidad = new FrmReportePublicidad();
            frmReportePublicidad.Show();
        }

        private void detalleFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteFacturaDetalle frmReporteFacturaDetalle = new FrmReporteFacturaDetalle();
            frmReporteFacturaDetalle.Show();
        }
    }
}
