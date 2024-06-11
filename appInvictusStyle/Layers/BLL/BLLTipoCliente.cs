using appInvictusStyle;
using appInvictusStyle.Interfaces;
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
    class BLLTipoCliente : IBLLTipoCliente
    {
        /// <summary>
        /// Metodo que muestra una lista de TipoCliente
        /// </summary>
        /// <returns></returns>
        public List<TipoCliente> GetAllTipoCliente()
        {        
                IDALTipoCliente _DALTipoCliente = new DALTipoCliente();

                return _DALTipoCliente.GetAllTipoCliente();
        }

        /// <summary>
        /// Metodo que inserta y almacena el TipoCliente
        /// </summary>
        /// <param name="pTipoCliente"></param>
        /// <returns>Objeto TipoCliente</returns>
        public TipoCliente SaveTipoCliente(TipoCliente pTipoCliente)
        {
            IDALTipoCliente _DALTipoCliente = new DALTipoCliente();
            TipoCliente oTipoCliente = null;

            if (_DALTipoCliente.GetTipoClienteById(pTipoCliente.ID) == null)
                oTipoCliente = _DALTipoCliente.SaveTipoCliente(pTipoCliente);
            else
                oTipoCliente = _DALTipoCliente.UpdateTipoCliente(pTipoCliente);

            return oTipoCliente;
        }

        /// <summary>
        /// Metodo que elimina el TipoCliente
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>Si se encuentra el objeto lo elimina</returns>
        public bool DeleteTipoCliente(string pId)
        {
            IDALTipoCliente _DALTipoCliente = new DALTipoCliente();

            return _DALTipoCliente.DeleteTipoCliente(pId);

        }


        /// <summary>
        /// Metodo que muestra el TipoCliente segun el filtro de id
        /// </summary>
        /// <param name="pIdTipoCliente"></param>
        /// <returns>Objeto TipoCliente que coincida con el id</returns>
        public TipoCliente GetTipoClienteById(string pIdTipoCliente)
        {
            IDALTipoCliente _DALTipoCliente = new DALTipoCliente();
            return _DALTipoCliente.GetTipoClienteById(pIdTipoCliente);
        }
    }
}
