using appInvictusStyle.Interfaces;
using appInvictusStyle.Layers.Entidades;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace appInvictusStyle.Layers.DAL
{
    public class DALPublicidad : IDALPublicidad
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        /// <summary>
        /// Metodo que inserta y almacena la Publicidad 
        /// </summary>
        /// <param name="pPublicidad"></param>
        /// <returns>Objeto Publicidad</returns>
        public Publicidad SavePublicidad(Publicidad pPublicidad)
        {
            Publicidad oPublicidad = null;
            SqlCommand command = new SqlCommand();

            double rows = 0;
            try
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_INSERT_Publicidad";
                command.Parameters.AddWithValue("@ID", pPublicidad.ID);
                command.Parameters.AddWithValue("@ID_Cliente", pPublicidad.ID_Cliente);
                command.Parameters.AddWithValue("@ID_Articulo", pPublicidad.ID_Articulo);
                command.Parameters.AddWithValue("@Fecha", pPublicidad.Fecha);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {
                    rows = db.ExecuteNonQuery(command);
                }                

                return oPublicidad;

            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        /// <summary>
        /// Extraer un consecutivo para asignar el numero de publicidad
        /// </summary>
        /// <returns>Num. de publicidad</returns>
        public int GetNextNumeroPublicidad()
        {
            DataSet ds = null;
            IDbCommand command = new SqlCommand();
            int numeroPublicidad = 0;
            string sql = @"SELECT NEXT VALUE FOR SequenceNoPublicidad";

            DataTable dt = null;
            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {

                    ds = db.ExecuteReader(command, "query");
                }

                // Extraer la tabla 
                dt = ds.Tables[0];
                //Extraer el valor que viene en el DataTable 
                numeroPublicidad = int.Parse(dt.Rows[0][0].ToString());
                return numeroPublicidad;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateSQLExceptionsErrorDetails(sqlError));
                msg.AppendFormat("SQL             {0}\n", command.CommandText);
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }

        }

        /// <summary>
        /// Metodo que muestra el número actual de Publicidad
        /// </summary>
        /// <returns>Numero Publicidad actual</returns>
        public int GetCurrentNumeroPublicidad()
        {

            DataSet ds = null;
            IDbCommand command = new SqlCommand();
            int numeroPublicidad = 0;
            string sql = @"SELECT current_value FROM sys.sequences WHERE name = 'SequenceNoPublicidad'  ";
            DataTable dt = null;
            try
            {

                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {

                    ds = db.ExecuteReader(command, "query");
                }

                // Extraer la tabla 
                dt = ds.Tables[0];
                //Extraer el valor que viene en el DataTable 
                numeroPublicidad = int.Parse(dt.Rows[0][0].ToString());
                return numeroPublicidad;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateSQLExceptionsErrorDetails(sqlError));
                msg.AppendFormat("SQL             {0}\n", command.CommandText);
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }

        }
    }
}
