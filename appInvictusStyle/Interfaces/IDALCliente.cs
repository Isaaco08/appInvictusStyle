
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace appInvictusStyle
{
    interface IDALCliente
    {
        Cliente GetClienteById(string pId);
        List<Cliente> GetAllCliente();
        Cliente SaveCliente(Cliente pCliente);
        Cliente UpdateCliente(Cliente pCliente);
        bool DeleteCliente(string pId);
    }
}