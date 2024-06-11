using appInvictusStyle.Interfaces;
using appInvictusStyle.Layers.BLL;
using appInvictusStyle.Layers.Entidades;
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
using UTN.Winform.InvictusStyle;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace appInvictusStyle.Layers.UI.Procesos
{
    public partial class FrmPublicidad : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private Publicidad oPublicidad = null;
        Cliente oCliente = null;
        Articulo oArticulo = null;
        public FrmPublicidad()
        {
            InitializeComponent();
        }

        private void FrmPublicidad_Load(object sender, EventArgs e)
        {
            IBLLPublicidad _BLLPublicidad = new BLLPublicidad();
            lblIDPublicidad.Text = _BLLPublicidad.GetCurrentNumeroPublicidad().ToString();
            CargarDatos();
        }

        private void CargarDatos()
        {
            IBLLCliente _BLLCliente = new BLLCliente();
            IBLLArticulo _BLLArticulo = new BLLArticulo();
        
            dgvClientes.AutoGenerateColumns = false;
            dgvArticulos.AutoGenerateColumns = false;
            // dgvDatos.RowTemplate.Height = 100;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Cargar el DataGridView
            this.dgvClientes.DataSource = _BLLCliente.GetAllCliente();
            this.dgvArticulos.DataSource = _BLLArticulo.GetAllArticulo();
            
        }

        private void btnPublicarOferta_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCliente.Text))
                {
                    MessageBox.Show("El cliente es requerido", "Error");
                    return;
                }
                if (string.IsNullOrEmpty(txtArticulo.Text))
                {
                    MessageBox.Show("El articulo es requerido", "Error");
                    return;
                }
                IBLLPublicidad _BLLPublicidad = new BLLPublicidad();
                
                lblIDPublicidad.Text = _BLLPublicidad.GetNextNumeroPublicidad().ToString();

                oPublicidad = new Publicidad();
                oPublicidad.ID = this.lblIDPublicidad.Text;
                oPublicidad.ID_Cliente = this.txtCliente.Text;
                oPublicidad.ID_Articulo = this.txtArticulo.Text;
                oPublicidad.Fecha = DateTime.Today;
               
                _BLLPublicidad.SavePublicidad(oPublicidad);

                MessageBox.Show("Oferta de Publicidad realizada con exito", "Atención");
                txtCliente.Text = "";
                txtArticulo.Text = "";
                txtNombreArticulo.Text = "";
                txtNombreCliente.Text = "";

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

        private void btnElegirCliente_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (this.dgvClientes.SelectedRows.Count > 0)
                {
                   
                    oCliente = this.dgvClientes.SelectedRows[0].DataBoundItem as Cliente;
                    this.txtCliente.Text = oCliente.ID;
                    this.txtNombreCliente.Text = oCliente.Nombre;
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

        private void btnElegirArticulo_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (this.dgvClientes.SelectedRows.Count > 0)
                {

                    oArticulo = this.dgvArticulos.SelectedRows[0].DataBoundItem as Articulo;
                    this.txtArticulo.Text = oArticulo.ID;
                    this.txtNombreArticulo.Text = oArticulo.Descripcion;
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
    }
}
