using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appInvictusStyle.Layers.Reportes
{
    public partial class FrmReporteCliente : Form
    {
        string idCliente = "";
        public FrmReporteCliente()
        {
            InitializeComponent();
        }

        private void FrmReporteCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReporteCliente.Cliente' table. You can move, or remove it, as needed.
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            idCliente = "%" + txtIDCliente.Text + "%";
            this.ClienteTableAdapter.Fill(this.ReporteCliente.Cliente, idCliente);

            this.reportViewer1.RefreshReport();
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
