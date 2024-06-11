
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace appInvictusStyle
{
    interface IDALUsuario
    {
        Usuario GetUsuarioById(string pIdUsuario);
        
    }
}