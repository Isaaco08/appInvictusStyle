using appInvictusStyle.Interfaces;
using appInvictusStyle.Layers.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace appInvictusStyle.Layers.BLL
{
    class BLLDetalle : IBLLDetalle
    {
        /// <summary>
        /// Metodo que muestra el Detalle segun el filtro de id
        /// </summary>
        /// <param name="pIdDetalle"></param>
        /// <returns>Objeto Detalle que coincida con el id</returns>
        public DetalleFactura GetDetalleById(string pIdDetalle)
        {
            IDALDetalle _DALDetalle = new DALDetalle();
            return _DALDetalle.GetDetalleById(pIdDetalle);
        }

        /// <summary>
        /// Metodo que inserta y almacena el Detalle 
        /// </summary>
        /// <param name="pDetalle"></param>
        /// <returns>Objeto Detalle</returns>
        public DetalleFactura SaveDetalle(DetalleFactura pDetalle)
        {
            IDALDetalle _DALDetalle = new DALDetalle();
            DetalleFactura oDetalle = null;

            if (_DALDetalle.GetDetalleById(pDetalle.ID) == null)
                oDetalle = _DALDetalle.SaveDetalle(pDetalle);

            return oDetalle;
        }
    }
}
