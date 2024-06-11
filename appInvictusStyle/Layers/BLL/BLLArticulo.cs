using appInvictusStyle.Interfaces;
using appInvictusStyle.Layers.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.InvictusStyle;

namespace appInvictusStyle.Layers.BLL
{
    class BLLArticulo : IBLLArticulo
    {
        /// <summary>
        /// Metodo que elimina el Articulo 
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>Si se encuentra el objeto lo elimina</returns>
        public bool DeleteArticulo(string pId)
        {
            IDALArticulo _IDALArticulo = new DALArticulo();
            return _IDALArticulo.DeleteArticulo(pId);
        }

        /// <summary>
        /// Metodo que muestra la lista de Articulos
        /// </summary>
        /// <returns>Lista de Articulos</returns>
        public List<Articulo> GetAllArticulo()
        {
            IDALArticulo _IDALArticulo = new DALArticulo();
            return _IDALArticulo.GetAllArticulo();

        }

        /// <summary>
        /// Metodo que muestra el Articulo segun un filtro de id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>Objeto Articulo que coincida con el id</returns>
        public Articulo GetArticuloById(string pId)
        {
            IDALArticulo _IDALArticulo = new DALArticulo();
            return _IDALArticulo.GetArticuloById(pId);
        }

        /// <summary>
        /// Metodo que inserta y almacena el Articulo
        /// </summary>
        /// <param name="pArticulo"></param>
        /// <returns>Objeto Articulo</returns>
        public Articulo SaveArticulo(Articulo pArticulo)
        {
            IDALArticulo _IDALArticulo = new DALArticulo();
            Articulo oArticulo = null;
            if (_IDALArticulo.GetArticuloById(pArticulo.ID) == null)
                oArticulo = _IDALArticulo.SaveArticulo(pArticulo);
            else
                oArticulo = _IDALArticulo.UpdateArticulo(pArticulo);

            return oArticulo;
        }


        
    }
}