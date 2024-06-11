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
    public partial class FrmReporteFacturaDetalle : Form
    {
        public FrmReporteFacturaDetalle()
        {
            InitializeComponent();
        }

        private void FrmFacturaDetalle_Load(object sender, EventArgs e)
        {

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.ReporteCliente.DataTable1, dtpFechaInicio.Value, dtpFechaFinal.Value);
            this.reportViewer1.RefreshReport();
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
