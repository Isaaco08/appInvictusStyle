using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace appInvictusStyle.Interfaces
{
    interface IDALDetalle
    {
        DetalleFactura SaveDetalle(DetalleFactura pDetalle);

        DetalleFactura GetDetalleById(string pIdDetalle);
    }
}
