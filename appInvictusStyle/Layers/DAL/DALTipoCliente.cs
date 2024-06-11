using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.InvictusStyle.Interfaces;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace UTN.Winform.InvictusStyle.Layers.DAL
{
    class DALTipoCliente : IDALTipoCliente
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public DALTipoCliente()
        {
            
        }

        /// <summary>
        /// Metodo que muestra todos los TipoCliente almacenados
        /// </summary>
        /// <returns>Lista de TipoCliente</returns>
        public List<TipoCliente> GetAllTipoCliente()
        {
            IDataReader reader = null;
            List<TipoCliente> lista = new List<TipoCliente>();
            SqlCommand command = new SqlCommand();

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "usp_SELECT_TipoCliente_All";
            command.CommandType = CommandType.Text;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        TipoCliente oTipoCliente = new TipoCliente();
                        oTipoCliente.ID = reader["ID"].ToString();
                        oTipoCliente.Descripcion = reader["Descripcion"].ToString();
                        oTipoCliente.Descuento = double.Parse(reader["Descuento"].ToString());
                        lista.Add(oTipoCliente);
                    }
                }

                return lista;
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
        /// Metodo que elimina el TipoCliente
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>Si se encuentra el objeto lo elimina</returns>
        public bool DeleteTipoCliente(string pId)
        {
            bool retorno = false;
            double rows = 0d;
            SqlCommand command = new SqlCommand();
            try
            {

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_DELETE_TipoCliente_ByID";
                command.Parameters.AddWithValue("@ID", pId);


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {

                    rows = db.ExecuteNonQuery(command);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    retorno = true;

                return retorno;
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
        /// Metodo que muestra el TipoCliente segun el filtro de id
        /// </summary>
        /// <param name="pIdTipoCliente"></param>
        /// <returns>Objeto TipoCliente que coincida con el id</returns>
        public TipoCliente GetTipoClienteById(string pIdTipoCliente)
        {
            DataSet ds = null;
            TipoCliente oTipoCliente = null;
            SqlCommand command = new SqlCommand();


            try
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_SELECT_TipoCliente_ByID";
                command.Parameters.AddWithValue("@ID", pIdTipoCliente);


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {
                    ds = db.ExecuteDataSet(command);
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        oTipoCliente = new TipoCliente();
                        oTipoCliente.ID = dr["ID"].ToString();
                        oTipoCliente.Descripcion = dr["Descripcion"].ToString();
                        oTipoCliente.Descuento = double.Parse(dr["Descuento"].ToString());


                    }
                }

                return oTipoCliente;
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
        /// Metodo que inserta y almacena el TipoCliente
        /// </summary>
        /// <param name="pTipoCliente"></param>
        /// <returns>Objeto TipoCliente</returns>
        public TipoCliente SaveTipoCliente(TipoCliente pTipoCliente)
        {
            TipoCliente oTipoCliente = null;
            SqlCommand command = new SqlCommand();

            double rows = 0;
            try
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_INSERT_TipoCliente";
                command.Parameters.AddWithValue("@ID", pTipoCliente.ID);
                command.Parameters.AddWithValue("@Descripcion", pTipoCliente.Descripcion);
                command.Parameters.AddWithValue("@Descuento", pTipoCliente.Descuento);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {
                    rows = db.ExecuteNonQuery(command);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oTipoCliente = this.GetTipoClienteById(pTipoCliente.ID);

                return oTipoCliente;

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
        /// Metodo que actualiza los datos del TipoCliente
        /// </summary>
        /// <param name="pTipoCliente"></param>
        /// <returns>Objeto TipoCliente actualizado</returns>
        public TipoCliente UpdateTipoCliente(TipoCliente pTipoCliente)
        {
            TipoCliente oTipoCliente = null;
            SqlCommand command = new SqlCommand();
         
            double rows = 0;
            try
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_UPDATE_TipoCliente";
                command.Parameters.AddWithValue("@ID", pTipoCliente.ID);
                command.Parameters.AddWithValue("@Descripcion", pTipoCliente.Descripcion);
                command.Parameters.AddWithValue("@Descuento", pTipoCliente.Descuento);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {
                    rows = db.ExecuteNonQuery(command);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oTipoCliente = this.GetTipoClienteById(pTipoCliente.ID);

                return oTipoCliente;

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
    }
}
