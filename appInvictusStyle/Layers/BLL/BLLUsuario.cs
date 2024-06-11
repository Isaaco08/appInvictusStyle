using appInvictusStyle.Interfaces;
using appInvictusStyle.Layers.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.InvictusStyle;
using UTN.Winform.InvictusStyle.Layers.Entidades;


namespace appInvictusStyle
{
    class BLLUsuario : IBLLUsuario
    {
        
        /// <summary>
        /// Metodo que muestra el usuario segun el filtro de id
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <returns>Objeto Usuario que coincida con el id</returns>
        public Usuario GetUsuarioById(string pIdUsuario)
        {
            IDALUsuario _DALUsuario = new DALUsuario();
            return _DALUsuario.GetUsuarioById(pIdUsuario);
        }

    }
}
