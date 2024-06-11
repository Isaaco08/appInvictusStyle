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
    class BLLCliente : IBLLCliente
    {
        

        /// <summary>
        /// Metodo que muestra el Cliente segun el filtro de id
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <returns>Objeto Cliente que coincida con el id</returns>
        public Cliente GetClienteById(string pIdCliente)
        {
            IDALCliente _DALCliente = new DALCliente();
            return _DALCliente.GetClienteById(pIdCliente);
        }

        /// <summary>
        /// Metodo que muestra la lista de Clientes 
        /// </summary>
        /// <returns>Lista de Clientes</returns>
        public List<Cliente> GetAllCliente()
        {
            IDALCliente _DALCliente = new DALCliente();
            return _DALCliente.GetAllCliente();
        }

        /// <summary>
        /// Metodo que inserta y almacena el Cliente
        /// </summary>
        /// <param name="pCliente"></param>
        /// <returns>Objeto Cliente</returns>
        public Cliente SaveCliente(Cliente pCliente)
        {
            IDALCliente _DALCliente = new DALCliente();
            Cliente oCliente = null;

            if (_DALCliente.GetClienteById(pCliente.ID) == null)
                oCliente = _DALCliente.SaveCliente(pCliente);
            else
                oCliente = _DALCliente.UpdateCliente(pCliente);

            return oCliente;
        }

        /// <summary>
        /// Metodo que elimina el Cliente
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>Si se encuentra el objeto lo elimina</returns>
        public bool DeleteCliente(string pId)
        {
            IDALCliente _DALCliente = new DALCliente();

            return _DALCliente.DeleteCliente(pId);

        }
    }
}
