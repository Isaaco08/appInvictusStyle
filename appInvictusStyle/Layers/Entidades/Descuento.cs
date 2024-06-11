using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.InvictusStyle.Layers.Entidades
{
    class Descuento
    {
        public string ID { set; get; }
        public string Descripcion { set; get; }
        public double Monto { set; get; }

        public override string ToString()
        {
            return ID+ " " + Descripcion;
        }
    }
}
