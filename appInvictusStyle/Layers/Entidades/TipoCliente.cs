using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.InvictusStyle.Layers.Entidades
{
    class TipoCliente
    {
        public string ID { set; get; }
        public string Descripcion { set; get; }
        public double Descuento { set; get; }

        public override string ToString()
        {
            return ID+ " " + Descripcion;
        }
    }
}
