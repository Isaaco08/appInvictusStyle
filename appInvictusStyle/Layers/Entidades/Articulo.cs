using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.InvictusStyle
{
    public class Articulo
    {
        public string ID { set; get; }
        public string Descripcion { set; get; }
        public string ID_Descuento { set; get; }
        public decimal Precio { set; get; }
        public int Existencia { set; get; }
        public byte[] Foto { get; set; }
    }
}
