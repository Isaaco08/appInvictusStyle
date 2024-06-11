using appInvictusStyle.Interfaces;
using appInvictusStyle.Layers.DAL;

using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace appInvictusStyle.Layers.BLL
{
    class BLLFactura : IBLLFactura
    {
        /// <summary>
        /// Metodo que obtiene el siguiente numero de factura
        /// de la secuencia creada
        /// </summary>
        /// <returns>Siguiente numero de la secuencia factura</returns>
        public int GetNextNumeroFactura()
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetNextNumeroFactura();
        }

        /// <summary>
        /// Metodo que obtiene el numero actual de factura
        /// </summary>
        /// <returns>Numero actual de la secuencia factura</returns>
        public int GetCurrentNumeroFactura()
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetCurrentNumeroFactura();
        }

        /// <summary>
        /// Metodo que inserta y almacena la factura
        /// </summary>
        /// <param name="pFactura"></param>
        /// <returns>Objeto Factura</returns>
        public Factura SaveFactura(Factura pFactura)
        {
            IDALFactura _DALFactura = new DALFactura();
            IBLLArticulo _IBLLArticulo = new BLLArticulo();

            return _DALFactura.SaveFactura(pFactura);
        }


    }
}
