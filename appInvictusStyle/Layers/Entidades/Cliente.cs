using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace UTN.Winform.InvictusStyle.Layers.Entidades
{
    public class Cliente
    {
        public string ID { set; get; }
        public string Nombre { set; get; }
        public string Apellido1 { set; get; }
        public string Apellido2 { set; get; }
        public int Sexo { set; get; }
        public string ID_Tipo_Cliente { set; get; }
        public string Correo { set; get; }
        public string ID_Provincia { set; get; }
        public byte[] Foto { get; set; }
    }
}
