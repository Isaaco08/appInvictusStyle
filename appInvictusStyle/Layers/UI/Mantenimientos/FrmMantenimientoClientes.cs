using appInvictusStyle.Interfaces;
using appInvictusStyle.Layers.BLL;
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
using UTN.Winform.InvictusStyle;
using appInvictusStyle.Layers.Servicio;
using System.IO;

namespace appInvictusStyle.Layers.UI.Mantenimientos
{
    public partial class FrmMantenimientoClientes : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public FrmMantenimientoClientes()
        {
            InitializeComponent();
        }

        private void FrmMantenimientoClientes_Load(object sender, EventArgs e)
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
            this.txtIdCliente.Clear();
            this.txtNombre.Clear();
            this.txtApellido1.Clear();
            this.txtApellido2.Clear();
            this.txtCorreo.Clear();

            this.txtIdCliente.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtApellido1.Enabled = false;
            this.txtApellido2.Enabled = false;
            this.txtCorreo.Enabled = false;

            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.cmbProvincia.Enabled = false;
            this.cmbTipoCliente.Enabled = false;

            // Coloca el primer item por defecto
            if (cmbProvincia.Items.Count > 0)
                this.cmbProvincia.SelectedIndex = 0;

            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    this.txtIdCliente.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.txtCorreo.Enabled = true;
                    this.cmbProvincia.Enabled = true;
                    this.cmbTipoCliente.Enabled = true;
                    this.btnAceptar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    txtIdCliente.Focus();
                    break;
                case EstadoMantenimiento.Editar:
                    this.txtIdCliente.Enabled = false;
                    this.txtNombre.Enabled = true;
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.txtCorreo.Enabled = true;
                    this.cmbProvincia.Enabled = true;
                    this.cmbTipoCliente.Enabled = true;
                    this.btnAceptar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    txtNombre.Focus();
                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    break;
            }
        }

        private void CargarDatos()
        {
            IBLLCliente _BLLCliente = new BLLCliente();
            IBLLTipoCliente _BLLTipoCliente = new BLLTipoCliente();
            List<TipoCliente> listaTipoCliente = null;

            // Cambiar el estado
            this.CambiarEstado(EstadoMantenimiento.Ninguno);

            // Configuracion del DataGridView para que se vea bien la imagen.
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.RowTemplate.Height = 100;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


            // Cargar el DataGridView
            this.dgvDatos.DataSource = _BLLCliente.GetAllCliente();

            // Cargar el combo
            llenarProvincias();
            //this.cmbProvincia.Items.Clear();
            //lista = _BLLProvincia.GetAllProvincia();
            //foreach (Provincia oProvincia in lista)
            //{
            //    this.cmbProvincia.Items.Add(oProvincia);
            //}
            // Colocar el primero como default
            this.cmbProvincia.SelectedIndex = 0;

            // Cargar el combo
            this.cmbTipoCliente.Items.Clear();
            listaTipoCliente = _BLLTipoCliente.GetAllTipoCliente();
            foreach (TipoCliente oTipoCliente in listaTipoCliente)
            {
                this.cmbTipoCliente.Items.Add(oTipoCliente);
            }
            // Colocar el primero como default
            this.cmbTipoCliente.SelectedIndex = 0;
        }

        public void llenarProvincias()
        {
            foreach (var item in ServiceProvincia.GetAllProvince())
            {
                cmbProvincia.Items.Add(item);
                cmbProvincia.DisplayMember = "Nombre";
            }
        }

        ErrorProvider erp = new ErrorProvider();

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            this.CambiarEstado(EstadoMantenimiento.Nuevo);
        }

        private void toolStripBtnEditar_Click(object sender, EventArgs e)
        {
            Cliente oCliente = null;
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    // Cambiar de estado
                    this.CambiarEstado(EstadoMantenimiento.Editar);
                    oCliente = this.dgvDatos.SelectedRows[0].DataBoundItem as Cliente;
                    this.txtIdCliente.Text = oCliente.ID;
                    this.txtApellido1.Text = oCliente.Apellido1;
                    this.txtApellido2.Text = oCliente.Apellido2;
                    this.txtNombre.Text = oCliente.Nombre;
                    this.txtCorreo.Text = oCliente.Correo;
                    this.rdbFemenino.Checked = oCliente.Sexo == 2 ? true : false;
                    this.rdbMasculino.Checked = oCliente.Sexo == 1 ? true : false; ;
                    cmbProvincia.SelectedIndex = cmbProvincia.FindString(oCliente.ID_Provincia.ToString());
                    cmbTipoCliente.SelectedIndex = cmbTipoCliente.FindString(oCliente.ID_Tipo_Cliente.ToString());

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
            IBLLCliente _IBLLCliente = new BLLCliente();

            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    this.CambiarEstado(EstadoMantenimiento.Borrar);

                    Cliente oCliente = this.dgvDatos.SelectedRows[0].DataBoundItem as Cliente;
                    if (MessageBox.Show($"¿Seguro que desea borrar el registro {oCliente.ID} {oCliente.Nombre}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _IBLLCliente.DeleteCliente(oCliente.ID);
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
            IBLLCliente _BLLCliente = new BLLCliente();
            try
            {

                Cliente oCliente = new Cliente();

                if (string.IsNullOrEmpty(txtIdCliente.Text))
                {
                    MessageBox.Show("El Id es requerido", "Error");
                    return;
                }
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("El nombre es requerido", "Error");
                    return;
                }
                if (string.IsNullOrEmpty(txtApellido1.Text))
                {
                    MessageBox.Show("El apellido es requerido", "Error");
                    return;
                }
                if (string.IsNullOrEmpty(txtApellido2.Text))
                {
                    MessageBox.Show("El apellido es requerido", "Error");
                    return;
                }
                if (string.IsNullOrEmpty(txtCorreo.Text))
                {
                    MessageBox.Show("El correo es requerido", "Error");
                    return;
                }
                if (this.pictureBox1.Tag == null)
                {
                    MessageBox.Show("La Imagen es un dato requerido", "Error");
                    return;
                }

                oCliente.ID = this.txtIdCliente.Text;
                oCliente.Nombre = this.txtNombre.Text;
                oCliente.Apellido1 = this.txtApellido1.Text;
                oCliente.Apellido2 = this.txtApellido2.Text;
                oCliente.Correo = this.txtCorreo.Text;
                oCliente.ID_Provincia = (cmbProvincia.SelectedItem as ProvinciaJson).numero.ToString();
                oCliente.ID_Tipo_Cliente = (cmbTipoCliente.SelectedItem as TipoCliente).ID;
                oCliente.Sexo = rdbFemenino.Checked ? 2 : 1;
                oCliente.Foto = (byte[])pictureBox1.Tag;

                oCliente = _BLLCliente.SaveCliente(oCliente);

                

                if (oCliente != null)
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

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog opt = new OpenFileDialog();
            opt.Title = "Seleccione la Imagen ";
            opt.SupportMultiDottedExtensions = true;
            opt.DefaultExt = "*.jpg";
            opt.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";
            opt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            opt.FileName = "";
            if (opt.ShowDialog(this) == DialogResult.OK)
            {
                //ruta = opt.FileName.Trim();
                this.pictureBox1.ImageLocation = opt.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);
                // Guarla la imagenen Bytes en el Tag de la imagen.
                pictureBox1.Tag = (byte[])cadenaBytes;
            }
        }
    }
}
