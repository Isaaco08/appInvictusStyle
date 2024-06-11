using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appInvictusStyle.Layers.Reportes
{
    public partial class FrmReporteFactura : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public FrmReporteFactura()
        {
            InitializeComponent();
        }

       

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReporteCliente.Factura' table. You can move, or remove it, as needed.
            this.FacturaTableAdapter.Fill(this.ReporteCliente.Factura);

            this.reportViewer1.RefreshReport();
        }

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripBtnEditar_Click(object sender, EventArgs e)
        {
            string ruta = @"c:\temp\reporte.pdf";
            try
            {
                if (!Directory.Exists(@"c:\temp"))
                    Directory.CreateDirectory(@"c:\temp");

                byte[] Bytes = this.reportViewer1.LocalReport.Render(format: "PDF", deviceInfo: "");

                using (FileStream stream = new FileStream(ruta, FileMode.Create))
                {
                    stream.Write(Bytes, 0, Bytes.Length);
                }

                Process.Start(ruta);
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
            String CuentaCorreoElectronico = "isat0810@gmail.com";
            String ContrasenaGeneradaGmail = "vgyrtwnvmyinozgg";
            MailMessage mensaje = new MailMessage();
            mensaje.IsBodyHtml = true;
            mensaje.Subject = "Reporte de Facturas Invictus Style";
            mensaje.Body = "Reporte de las facturas realizadas en la aplicación";
            mensaje.From = new MailAddress(CuentaCorreoElectronico);
            mensaje.To.Add("isat0810@gmail.com"); //Correo del destinatario
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(CuentaCorreoElectronico,
            ContrasenaGeneradaGmail);
            smtp.EnableSsl = true;
            Attachment attachment = new Attachment(@"c:\temp\reporte.pdf");
            mensaje.Attachments.Add(attachment);
            smtp.Send(mensaje);
            MessageBox.Show("Correo Enviado con Exito");
        }
    }
}
