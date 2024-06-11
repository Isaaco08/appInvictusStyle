using appInvictusStyle.Interfaces;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.InvictusStyle.Layers.Entidades;
using UTN.Winform.InvictusStyle;

namespace appInvictusStyle.Layers.UI
{
    public partial class FrmLogin : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                _MyLogControlEventos.InfoFormat("Inicio Login");
                txtUsuario.Focus();
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            epError.Clear();
            BLLUsuario _BLLUsuario = new BLLUsuario();
            Usuario oUsuario = _BLLUsuario.GetUsuarioById(usuario);

            try
            {

                if (string.IsNullOrEmpty(this.txtUsuario.Text))
                {
                    epError.SetError(txtUsuario, "Usuario requerido");
                    this.txtUsuario.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtContrasena.Text))
                {
                    epError.SetError(txtContrasena, "Contraseña requerida");
                    this.txtContrasena.Focus();
                    return;
                }
                if (oUsuario == null)
                {
                    MessageBox.Show("No existe el Usuario", "ERROR");
                    return;
                }

                //Efecto en la barra de entrada.
                toolStripPbBarra.Visible = true;
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(100);
                    this.toolStripPbBarra.Value += 10;
                    this.sttBarraInferior.Refresh();
                }

                // Log de errores
                _MyLogControlEventos.InfoFormat("Entró a la aplicación");
                this.DialogResult = DialogResult.OK;


                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.oTipoUsuario = oUsuario;
                if (oUsuario.ID == usuario && oUsuario.Contrasena == contrasena)
                {
                    txtUsuario.Focus();
                    this.toolStripPbBarra.Value = 0;
                    toolStripPbBarra.Visible = false;
                    this.txtUsuario.Clear();
                    this.txtContrasena.Clear();
                    frmPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("No existe el Usuario", "ERROR");
                    this.toolStripPbBarra.Value = 0;
                    toolStripPbBarra.Visible = false;
                    this.txtUsuario.Clear();
                    this.txtContrasena.Clear();
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

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            MessageBox.Show("Cerrando la aplicación...","Salir");
            Close();
        }
    }
}
