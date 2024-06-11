using appInvictusStyle.Layers.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appInvictusStyle.Interfaces
{
    interface IBLLPublicidad
    {
        Publicidad SavePublicidad(Publicidad pPublicidad);
        int GetNextNumeroPublicidad();
        int GetCurrentNumeroPublicidad();
    }
}
