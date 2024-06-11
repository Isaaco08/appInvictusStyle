
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace appInvictusStyle
{
    interface IBLLCliente
    {
        
        Cliente GetClienteById(string pIdCliente);
        List<Cliente> GetAllCliente();
        Cliente SaveCliente(Cliente pCliente);
        bool DeleteCliente(string pId);
    }
}