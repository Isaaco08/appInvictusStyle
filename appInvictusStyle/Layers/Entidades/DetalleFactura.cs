using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.InvictusStyle.Layers.Entidades
{
    class DetalleFactura
    {
        public string ID { set; get; }
        public string ID_Factura { set; get; }
        public string ID_Articulo { set; get; }
        public int Cantidad { set; get; }
        public double Subtotal { set; get; }
        public double Descuento { set; get; }
        public double IVA { set; get; }
        public double Total { set; get; }
    }
}
