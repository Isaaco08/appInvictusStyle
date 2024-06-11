using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace UTN.Winform.InvictusStyle.Interfaces
{
    interface IDALDescuento
    {
        List<Descuento> GetAllDescuento();
        Descuento GetDescuentoById(string pIdDescuento);
        Descuento SaveDescuento(Descuento pDescuento);
        bool DeleteDescuento(string pId);
        Descuento UpdateDescuento(Descuento pDescuento);
    }
}
