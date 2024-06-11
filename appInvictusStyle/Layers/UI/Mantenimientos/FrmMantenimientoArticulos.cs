using appInvictusStyle.Layers.BLL;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.InvictusStyle;
using UTN.Winform.InvictusStyle.Interfaces;
using UTN.Winform.InvictusStyle.Layers.BLL;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace appInvictusStyle.Layers.UI.Mantenimientos
{
    public partial class FrmMantenimientoArticulos : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public FrmMantenimientoArticulos()
        {
            InitializeComponent();
        }

        private void FrmMantenimientoArticulos_Load(object sender, EventArgs e)
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

        private void CargarDatos()
        {
            IBLLArticulo _BLLArticulo = new BLLArticulo();
            IBLLDescuento _BLLDescuento = new BLLDescuento();
            List<Descuento> lista = null;

            // Cambiar el estado
            this.CambiarEstado(EstadoMantenimiento.Ninguno);

            // Configuracion del DataGridView para que se vea bien la imagen.
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.RowTemplate.Height = 100;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


            //this.pbImagen.Enabled = false;

            // Cargar el DataGridView
            this.dgvDatos.DataSource = _BLLArticulo.GetAllArticulo();

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

        private void CambiarEstado(EstadoMantenimiento estado)
        {
            this.txtDescripcion.Clear();
            this.txtExistencia.Clear();
            this.txtID.Clear();
            this.txtPrecio.Clear();
            this.pictureBox1.Tag = null;

            this.txtID.Enabled = false;
            this.txtDescripcion.Enabled = false;
            this.txtExistencia.Enabled = false;
            this.txtPrecio.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.cmbDescuento.Enabled = false;
            this.pictureBox1.Enabled = false;

            if (cmbDescuento.Items.Count > 0)
                this.cmbDescuento.SelectedIndex = 0;

            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    this.txtDescripcion.Enabled = true;
                    this.txtExistencia.Enabled = true;
                    this.txtID.Enabled = true;
                    this.txtPrecio.Enabled = true;
                    this.pictureBox1.Enabled = true;
                    this.cmbDescuento.Enabled = true;
                    this.btnAceptar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    txtID.Focus();
                    break;
                case EstadoMantenimiento.Editar:
                    this.txtDescripcion.Enabled = true;
                    this.txtExistencia.Enabled = true;
                    this.txtID.Enabled = false;
                    this.txtPrecio.Enabled = true;
                    this.pictureBox1.Enabled = true;
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

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                this.CambiarEstado(EstadoMantenimiento.Nuevo);

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

        private void toolStripBtnEditar_Click(object sender, EventArgs e)
        {
            Articulo oArticulo = null;
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    // Cambiar de estado
                    this.CambiarEstado(EstadoMantenimiento.Editar);
                    oArticulo = this.dgvDatos.SelectedRows[0].DataBoundItem as Articulo;

                    this.txtID.Text = oArticulo.ID.ToString();
                    this.txtDescripcion.Text = oArticulo.Descripcion;
                    this.txtExistencia.Text = oArticulo.Existencia.ToString();
                    this.txtPrecio.Text = oArticulo.Precio.ToString();
                    // Seleccionar el combo
                    this.cmbDescuento.SelectedIndex = cmbDescuento.FindString(oArticulo.ID.ToString());
                    this.pictureBox1.Image = new Bitmap(new MemoryStream(oArticulo.Foto));
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pictureBox1.Tag = oArticulo.Foto;

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
            IBLLArticulo _BLLArticulo = new BLLArticulo();

            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    this.CambiarEstado(EstadoMantenimiento.Borrar);

                    Articulo oArticulo = this.dgvDatos.SelectedRows[0].DataBoundItem as Articulo;
                    if (MessageBox.Show($"¿Seguro que desea borrar el registro {oArticulo.ID} {oArticulo.Descripcion}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _BLLArticulo.DeleteArticulo(oArticulo.ID);
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
            Articulo oArticulo = null;
            IBLLArticulo _IBLLArticulo = new BLLArticulo();
            try
            {
                if (this.pictureBox1.Tag == null)
                {
                    MessageBox.Show("La Imagen es un dato requerido", "Error");
                    return;
                }
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("El Id es requerido", "Error");
                    return;
                }
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("La descripcion es requerida", "Error");
                    return;
                }
                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("El precio es requerido", "Error");
                    return;
                }
                if (string.IsNullOrEmpty(txtExistencia.Text))
                {
                    MessageBox.Show("La existencia es requerida", "Error");
                    return;
                }

                oArticulo = new Articulo();

                oArticulo.ID = this.txtID.Text;
                oArticulo.Descripcion = this.txtDescripcion.Text;
                oArticulo.ID_Descuento = (cmbDescuento.SelectedItem as Descuento).ID;
                oArticulo.Precio = decimal.Parse(this.txtPrecio.Text);
                oArticulo.Existencia = int.Parse(this.txtExistencia.Text);
                oArticulo.Foto = (byte[])pictureBox1.Tag;

                

                oArticulo = _IBLLArticulo.SaveArticulo(oArticulo);

                if (oArticulo != null)
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

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                var oArticulo = (Articulo)dgvDatos.SelectedRows[0].DataBoundItem;
                Bitmap image;
                using (MemoryStream stream = new MemoryStream(oArticulo.Foto))
                {
                    image = new Bitmap(stream);
                }
                pictureBox1.Image = image;           
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog opt = new OpenFileDialog();
            opt.Title = "Seleccione la Imagen ";
            opt.SupportMultiDottedExtensions = true;
            opt.DefaultExt = ".jpg";
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
