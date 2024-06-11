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
    public partial class FrmReportePublicidad : Form
    {
        public FrmReportePublicidad()
        {
            InitializeComponent();
        }

        private void FrmReportePublicidad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReporteCliente.Publicidad' table. You can move, or remove it, as needed.
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PublicidadTableAdapter.Fill(this.ReporteCliente.Publicidad, dtpInicio.Value, dtpFinal.Value);

            this.reportViewer1.RefreshReport();
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
