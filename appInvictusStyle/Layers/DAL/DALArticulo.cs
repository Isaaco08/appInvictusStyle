using appInvictusStyle.Interfaces;
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
using UTN.Winform.InvictusStyle;

namespace appInvictusStyle.Layers.DAL
{
    class DALArticulo : IDALArticulo
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        
        /// <summary>
        /// Metodo que elimina el Articulo 
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>Si se encuentra el objeto lo elimina</returns>
        public bool DeleteArticulo(string pId)
        {

            double rows = 0;
            SqlCommand command = new SqlCommand();

            try
            {
                // Pasar parámetros
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_DELETE_Articulo_ByID";
                command.Parameters.AddWithValue("@ID", pId);

                // Ejecutar
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {
                    rows = db.ExecuteNonQuery(command);
                }

                return rows > 0;
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
        /// Metodo que muestra todos los Articulos almacenados
        /// </summary>
        /// <returns>Lista de Articulos</returns>
        public List<Articulo> GetAllArticulo()
        {
            DataSet ds = null;
            List<Articulo> lista = new List<Articulo>();
            SqlCommand command = new SqlCommand();

            try
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_SELECT_Articulo_All";
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {

                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Articulo oArticulo = new Articulo();
                        oArticulo.ID = dr["ID"].ToString();
                        oArticulo.Descripcion = dr["Descripcion"].ToString();
                        oArticulo.ID_Descuento = dr["ID_Descuento"].ToString();
                        oArticulo.Precio = (decimal)dr["Precio"];
                        oArticulo.Existencia = (int)dr["Existencia"];
                        oArticulo.Foto = (byte[])dr["Foto"];

                        lista.Add(oArticulo);
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
        /// Metodo que muestra el Articulo segun un filtro de id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>Objeto Articulo que coincida con el id</returns>
        public Articulo GetArticuloById(string pId)
        {
            DataSet ds = null;
            Articulo oArticulo = null;

            SqlCommand command = new SqlCommand();

            try
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_SELECT_Articulo_ByID";
                command.Parameters.AddWithValue("@ID", pId);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {
                    ds = db.ExecuteDataSet(command);
                }

                // Si retornó valores 
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Extraer la primera fila, como se buscó por Id entonces solo una debe devolver  
                    DataRow dr = ds.Tables[0].Rows[0];
                    oArticulo = new Articulo()
                    {
                        ID = dr["ID"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        ID_Descuento = dr["ID_Descuento"].ToString(),
                        Precio = (decimal)dr["Precio"],
                        Existencia = (int)dr["Existencia"],
                        Foto = (byte[])dr["Foto"],
                };


                }

                return oArticulo;
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
        /// Metodo que inserta y almacena el Articulo
        /// </summary>
        /// <param name="pArticulo"></param>
        /// <returns>Objeto Articulo</returns>
        public Articulo SaveArticulo(Articulo pArticulo)
        {
            Articulo oArticulo = null;

            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {

                // Pasar parámetros
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_INSERT_Articulo";
                command.Parameters.AddWithValue("@ID", pArticulo.ID);
                command.Parameters.AddWithValue("@Descripcion", pArticulo.Descripcion);
                command.Parameters.AddWithValue("@ID_Descuento", pArticulo.ID_Descuento);
                command.Parameters.AddWithValue("@Precio", pArticulo.Precio);
                command.Parameters.AddWithValue("@Existencia", pArticulo.Existencia);
                command.Parameters.AddWithValue("@Foto", pArticulo.Foto);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {

                    rows = db.ExecuteNonQuery(command);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oArticulo = GetArticuloById(pArticulo.ID);

                return oArticulo;
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
        /// Metodo que actualiza los datos del Articulo
        /// </summary>
        /// <param name="pArticulo"></param>
        /// <returns>Objeto Articulo actualizado</returns>
        public Articulo UpdateArticulo(Articulo pArticulo)
        {
            Articulo oArticulo = null;

            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {

                // Pasar parámetros
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_UPDATE_Articulo";
                command.Parameters.AddWithValue("@ID", pArticulo.ID);
                command.Parameters.AddWithValue("@Descripcion", pArticulo.Descripcion);
                command.Parameters.AddWithValue("@ID_Descuento", pArticulo.ID_Descuento);
                command.Parameters.AddWithValue("@Precio", pArticulo.Precio);
                command.Parameters.AddWithValue("@Existencia", pArticulo.Existencia);
                command.Parameters.AddWithValue("@Foto", pArticulo.Foto);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {

                    rows = db.ExecuteNonQuery(command);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oArticulo = GetArticuloById(pArticulo.ID);

                return oArticulo;
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
