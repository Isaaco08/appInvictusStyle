using log4net;
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
using UTN.Winform.InvictusStyle.Interfaces;
using UTN.Winform.InvictusStyle.Layers.BLL;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace appInvictusStyle.Layers.UI.Mantenimientos
{
    public partial class FrmMantenimientoDescuento : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public FrmMantenimientoDescuento()
        {
            InitializeComponent();
        }

        private void FrmMantenimientoDescuento_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
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

        private void CambiarEstado(EstadoMantenimiento estado)
        {
            this.txtID.Clear();
            this.txtDescripcion.Clear();
            this.txtPorcentaje.Clear();

            this.txtID.Enabled = false;
            this.txtDescripcion.Enabled = false;
            this.txtPorcentaje.Enabled = false;

            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = false;

            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    this.txtID.Enabled = true;
                    this.txtDescripcion.Enabled = true;
                    this.txtPorcentaje.Enabled = true;
                    this.btnAceptar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    txtID.Focus();
                    break;
                case EstadoMantenimiento.Editar:
                    this.txtID.Enabled = false;
                    this.txtDescripcion.Enabled = true;
                    this.txtPorcentaje.Enabled = true;
                    this.btnAceptar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    txtDescripcion.Focus();
                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    break;
            }
        }
        ErrorProvider erp = new ErrorProvider();
        private void CargarDatos()
        {
            IBLLDescuento _BLLDescuento = new BLLDescuento();

            // Cambiar el estado
            this.CambiarEstado(EstadoMantenimiento.Ninguno);

            // Configuracion del DataGridView para que se vea bien la imagen.
            dgvDatos.AutoGenerateColumns = false;
            // dgvDatos.RowTemplate.Height = 100;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


            // Cargar el DataGridView
            this.dgvDatos.DataSource = _BLLDescuento.GetAllDescuento();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            IBLLDescuento _BLLDescuento = new BLLDescuento();
            try
            {

                Descuento oDescuento = new Descuento();

                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("El Id es requerido", "Error");
                    return;
                }
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("La descripcion es requerido", "Error");
                    return;
                }
                if (string.IsNullOrEmpty(txtPorcentaje.Text))
                {
                    MessageBox.Show("El porcentaje es requerido", "Error");
                    return;
                }

                oDescuento.ID = this.txtID.Text;
                oDescuento.Descripcion = this.txtDescripcion.Text;
                oDescuento.Monto = double.Parse(this.txtPorcentaje.Text);


                oDescuento = _BLLDescuento.SaveDescuento(oDescuento);

                //frmReporteXClienteId reporte = new frmReporteXClienteId(oCliente.IdCliente);
                //reporte.ShowDialog();

                if (oDescuento != null)
                    this.CargarDatos();

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

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            this.CambiarEstado(EstadoMantenimiento.Nuevo);
        }

        private void toolStripBtnEditar_Click(object sender, EventArgs e)
        {
            Descuento oDescuento = null;
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    // Cambiar de estado
                    this.CambiarEstado(EstadoMantenimiento.Editar);
                    oDescuento = this.dgvDatos.SelectedRows[0].DataBoundItem as Descuento;
                    this.txtID.Text = oDescuento.ID;
                    this.txtDescripcion.Text = oDescuento.Descripcion;
                    this.txtPorcentaje.Text = oDescuento.Monto.ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void toolStripBtnBorrar_Click(object sender, EventArgs e)
        {
            IBLLDescuento _BLLDescuento = new BLLDescuento();

            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    this.CambiarEstado(EstadoMantenimiento.Borrar);

                    Descuento oDescuento = this.dgvDatos.SelectedRows[0].DataBoundItem as Descuento;
                    if (MessageBox.Show($"¿Seguro que desea borrar el registro {oDescuento.ID} {oDescuento.Descripcion}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _BLLDescuento.DeleteDescuento(oDescuento.ID);
                        this.CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CambiarEstado(EstadoMantenimiento.Ninguno);
        }
    }
}
