
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.InvictusStyle;

namespace appInvictusStyle
{
    interface IBLLArticulo
    {
        Articulo GetArticuloById(string pId);
        List<Articulo> GetAllArticulo();
        Articulo SaveArticulo(Articulo pArticulo);
        bool DeleteArticulo(string pId);

    }
}