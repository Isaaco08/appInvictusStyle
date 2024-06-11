using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace UTN.Winform.InvictusStyle.Interfaces
{
    interface IBLLTipoCliente
    {
        List<TipoCliente> GetAllTipoCliente();
        TipoCliente GetTipoClienteById(string pIdTipoCliente);
        TipoCliente SaveTipoCliente(TipoCliente pTipoCliente);
        bool DeleteTipoCliente(string pId);
    }
}
