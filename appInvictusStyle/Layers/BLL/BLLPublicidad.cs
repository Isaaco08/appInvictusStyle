using appInvictusStyle.Interfaces;
using appInvictusStyle.Layers.DAL;
using appInvictusStyle.Layers.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appInvictusStyle.Layers.BLL
{
    public class BLLPublicidad : IBLLPublicidad
    {
        /// <summary>
        /// Metodo que inserta y almacena la Publicidad
        /// </summary>
        /// <param name="pPublicidad"></param>
        /// <returns>Objeto Publicidad</returns>
        public Publicidad SavePublicidad(Publicidad pPublicidad)
        {
            IDALPublicidad _DALPublicidad = new DALPublicidad();
            return _DALPublicidad.SavePublicidad(pPublicidad);
        }

        /// <summary>
        /// Metodo que obtiene el siguiente numero de publicidad
        /// </summary>
        /// <returns>Siguiente numero de la secuencia de publicidad</returns>
        public int GetNextNumeroPublicidad()
        {
            IDALPublicidad _DALPublicidad = new DALPublicidad();
            return _DALPublicidad.GetNextNumeroPublicidad();
        }

        /// <summary>
        /// Metodo que obtiene el numero de publicidad actual
        /// </summary>
        /// <returns>Numero actual de la secuencia de publicidad</returns>
        public int GetCurrentNumeroPublicidad()
        {
            IDALPublicidad _DALPublicidad = new DALPublicidad();
            return _DALPublicidad.GetCurrentNumeroPublicidad();
        }
    }
}
