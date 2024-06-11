using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.InvictusStyle.Layers.Entidades
{
    public class Provincia
    {
        public string ID { set; get; }
        public string Descripcion { set; get; }

        public override string ToString() => ID +" "+Descripcion;
        

    }
}
