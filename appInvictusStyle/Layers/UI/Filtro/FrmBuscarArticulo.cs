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
using UTN.Winform.InvictusStyle;
using UTN.Winform.InvictusStyle.Interfaces;
using UTN.Winform.InvictusStyle.Layers.BLL;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace appInvictusStyle.Layers.UI.Filtro
{
    public partial class FrmBuscarArticulo : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public Articulo oArticulo { get; private set; } = null;
        public FrmBuscarArticulo()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FrmBuscarArticulo_Load(object sender, EventArgs e)
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

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //this.dgvDatos.SelectionMode =   DataGridViewSelectionMode.FullRowSelect;
                if (dgvDatos.RowCount > 0 && dgvDatos.SelectedRows.Count > 0)
                {
                    if (dgvDatos.CurrentCell.Selected)
                    {
                        oArticulo = dgvDatos.SelectedRows[0].DataBoundItem as Articulo;
                        this.DialogResult = DialogResult.OK;
                    }
                }
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
        private void CargarDatos()
        {
            IBLLArticulo _BLLArticulo = new BLLArticulo();

            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            this.dgvDatos.DataSource = _BLLArticulo.GetAllArticulo();

        }

    }
}
