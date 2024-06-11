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
    public partial class FrmMantenimientoTipoCliente : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public FrmMantenimientoTipoCliente()
        {
            InitializeComponent();
        }

        private void FrmMantenimientoTipoCliente_Load(object sender, EventArgs e)
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

            this.txtID.Enabled = false;
            this.txtDescripcion.Enabled = false;
            this.cmbDescuento.Enabled = false;

            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = false;

            // Coloca el primer item por defecto
            if (cmbDescuento.Items.Count > 0)
                this.cmbDescuento.SelectedIndex = 0;

            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    this.txtID.Enabled = true;
                    this.txtDescripcion.Enabled = true;
                    this.cmbDescuento.Enabled = true;
                    this.btnAceptar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    txtID.Focus();
                    break;
                case EstadoMantenimiento.Editar:
                    this.txtID.Enabled = false;
                    this.txtDescripcion.Enabled = true;
                    this.cmbDescuento.Enabled = true;
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
            IBLLTipoCliente _BLLTipoCliente = new BLLTipoCliente();
            List<Descuento> lista = null;


            // Cambiar el estado
            this.CambiarEstado(EstadoMantenimiento.Ninguno);

            // Configuracion del DataGridView para que se vea bien la imagen.
            dgvDatos.AutoGenerateColumns = false;
            // dgvDatos.RowTemplate.Height = 100;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


            // Cargar el DataGridView
            this.dgvDatos.DataSource = _BLLTipoCliente.GetAllTipoCliente();

            // Cargar el combo
            this.cmbDescuento.Items.Clear();
            lista = _BLLDescuento.GetAllDescuento();
            foreach (Descuento oDescuento in lista)
            {
                this.cmbDescuento.Items.Add(oDescuento);
            }
            // Colocar el primero como default
            this.cmbDescuento.SelectedIndex = 0;
        }

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            this.CambiarEstado(EstadoMantenimiento.Nuevo);
        }

        private void toolStripBtnEditar_Click(object sender, EventArgs e)
        {
            TipoCliente oTipoCliente = null;
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    // Cambiar de estado
                    this.CambiarEstado(EstadoMantenimiento.Editar);
                    oTipoCliente = this.dgvDatos.SelectedRows[0].DataBoundItem as TipoCliente;
                    this.txtID.Text = oTipoCliente.ID;
                    this.txtDescripcion.Text = oTipoCliente.Descripcion;
                    cmbDescuento.SelectedIndex = cmbDescuento.FindString(oTipoCliente.Descuento.ToString());
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
            IBLLTipoCliente _IBLLTipoCliente = new BLLTipoCliente();

            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    this.CambiarEstado(EstadoMantenimiento.Borrar);

                    TipoCliente oTipoCliente = this.dgvDatos.SelectedRows[0].DataBoundItem as TipoCliente;
                    if (MessageBox.Show($"¿Seguro que desea borrar el registro {oTipoCliente.ID} {oTipoCliente.Descripcion}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _IBLLTipoCliente.DeleteTipoCliente(oTipoCliente.ID);
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            IBLLTipoCliente _BLLTipoCliente = new BLLTipoCliente();
            try
            {

                TipoCliente oTipoCliente = new TipoCliente();

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

                oTipoCliente.ID = this.txtID.Text;
                oTipoCliente.Descripcion = this.txtDescripcion.Text;
                oTipoCliente.Descuento = (cmbDescuento.SelectedItem as Descuento).Monto;


                oTipoCliente = _BLLTipoCliente.SaveTipoCliente(oTipoCliente);


                if (oTipoCliente != null)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CambiarEstado(EstadoMantenimiento.Ninguno);
        }
    }
}
