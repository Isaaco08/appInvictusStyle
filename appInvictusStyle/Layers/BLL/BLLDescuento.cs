using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.InvictusStyle.Interfaces;
using UTN.Winform.InvictusStyle.Layers.DAL;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace UTN.Winform.InvictusStyle.Layers.BLL
{
    class BLLDescuento : IBLLDescuento
    {
        /// <summary>
        /// Metodo que muestra la lista de Descuentos
        /// </summary>
        /// <returns>Lista de Descuento</returns>
        public List<Descuento> GetAllDescuento()
        {
            IDALDescuento _DALDescuento = new DALDescuento();

            return _DALDescuento.GetAllDescuento();
        }

        /// <summary>
        /// Metodo que inserta y almacena el Descuento
        /// </summary>
        /// <param name="pDescuento"></param>
        /// <returns>Objeto Descuento</returns>
        public Descuento SaveDescuento(Descuento pDescuento)
        {
            IDALDescuento _DALDescuento = new DALDescuento();
            Descuento oDescuento = null;

            if (_DALDescuento.GetDescuentoById(pDescuento.ID) == null)
                oDescuento = _DALDescuento.SaveDescuento(pDescuento);
            else
                oDescuento = _DALDescuento.UpdateDescuento(pDescuento);

            return oDescuento;
        }

        /// <summary>
        /// Metodo que elimina el Descuento
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>Si se encuentra el objeto lo elimina</returns>
        public bool DeleteDescuento(string pId)
        {
            IDALDescuento _DALDescuento = new DALDescuento();

            return _DALDescuento.DeleteDescuento(pId);

        }
        

        /// <summary>
        /// Metodo que muestra el Descuento segun el filtro de id
        /// </summary>
        /// <param name="pIdDescuento"></param>
        /// <returns>Objeto Descuento que coincida con el id</returns>
        public Descuento GetDescuentoById(string pIdDescuento)
        {
            IDALDescuento _DALDescuento = new DALDescuento();
            return _DALDescuento.GetDescuentoById(pIdDescuento);
        }
    }
}
