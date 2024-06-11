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

namespace appInvictusStyle
{
    class DALCliente : IDALCliente
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        public DALCliente()
        {

        }

        /// <summary>
        /// Metodo que elimina el Cliente 
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>Si se encuentra el objeto lo elimina</returns>
        public bool DeleteCliente(string pId)
        {
            bool retorno = false;
            double rows = 0d;
            SqlCommand command = new SqlCommand();
            try
            {

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_DELETE_Cliente_ByID";
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
        /// Metodo que muestra todos los Clientes almacenados
        /// </summary>
        /// <returns></returns>
        public List<Cliente> GetAllCliente()
        {
            DataSet ds = null;
            List<Cliente> lista = new List<Cliente>();
            SqlCommand command = new SqlCommand();

            try
            {

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_SELECT_Cliente_All";
                command.CommandType = CommandType.Text;

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
                        Cliente oCliente = new Cliente();
                        oCliente.ID = dr["ID"].ToString();
                        oCliente.Nombre = dr["Nombre"].ToString();
                        oCliente.Apellido1 = dr["Apellido1"].ToString();
                        oCliente.Apellido2 = dr["Apellido2"].ToString();
                        oCliente.Sexo = (int)dr["Sexo"];
                        oCliente.ID_Tipo_Cliente = dr["ID_Tipo_Cliente"].ToString();
                        oCliente.Correo = dr["Correo"].ToString();
                        oCliente.ID_Provincia = dr["ID_Provincia"].ToString();
                        oCliente.Foto = (byte[])dr["Foto"];

                        lista.Add(oCliente);
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
        /// Metodo que muestra el Cliente segun un filtro de id 
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <returns>Objeto Cliente que coincida con el id</returns>
        public Cliente GetClienteById(string pIdCliente)
        {
            DataSet ds = null;
            Cliente oCliente = null;
            SqlCommand command = new SqlCommand();


            try
            {

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_SELECT_Cliente_ByID";
                command.Parameters.AddWithValue("@ID", pIdCliente);


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
                        oCliente = new Cliente();
                        oCliente.ID = dr["ID"].ToString();
                        oCliente.Nombre = dr["Nombre"].ToString();
                        oCliente.Apellido1 = dr["Apellido1"].ToString();
                        oCliente.Apellido2 = dr["Apellido2"].ToString();
                        oCliente.Sexo = (int)dr["Sexo"];
                        oCliente.ID_Tipo_Cliente = dr["ID_Tipo_Cliente"].ToString();
                        oCliente.Correo = dr["Correo"].ToString();
                        oCliente.ID_Provincia = dr["ID_Provincia"].ToString();
                        oCliente.Foto = (byte[])dr["Foto"];

                    }
                }

                return oCliente;
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
        /// Metodo que inserta y almacena el Cliente
        /// </summary>
        /// <param name="pCliente"></param>
        /// <returns>Objeto Cliente</returns>
        public Cliente SaveCliente(Cliente pCliente)
        {
            Cliente oCliente = null;
            SqlCommand command = new SqlCommand();

            double rows = 0;
            try
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_INSERT_Cliente";
                command.Parameters.AddWithValue("@ID", pCliente.ID);
                command.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
                command.Parameters.AddWithValue("@Apellido1", pCliente.Apellido1);
                command.Parameters.AddWithValue("@Apellido2", pCliente.Apellido2);
                command.Parameters.AddWithValue("@Sexo", pCliente.Sexo);
                command.Parameters.AddWithValue("@ID_Tipo_Cliente", pCliente.ID_Tipo_Cliente);
                command.Parameters.AddWithValue("@Correo", pCliente.Correo);
                command.Parameters.AddWithValue("@ID_Provincia", pCliente.ID_Provincia);
                command.Parameters.AddWithValue("@Foto", pCliente.Foto);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {
                    rows = db.ExecuteNonQuery(command);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oCliente = this.GetClienteById(pCliente.ID);

                return oCliente;

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
        /// Metodo que actualiza los datos del Cliente
        /// </summary>
        /// <param name="pCliente"></param>
        /// <returns>Objeto Cliente actualizado</returns>
        public Cliente UpdateCliente(Cliente pCliente)
        {
            Cliente oCliente = null;
            SqlCommand command = new SqlCommand();

            
            double rows = 0;
            try
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_UPDATE_Cliente";
                command.Parameters.AddWithValue("@ID", pCliente.ID);
                command.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
                command.Parameters.AddWithValue("@Apellido1", pCliente.Apellido1);
                command.Parameters.AddWithValue("@Apellido2", pCliente.Apellido2);
                command.Parameters.AddWithValue("@Sexo", pCliente.Sexo);
                command.Parameters.AddWithValue("@ID_Tipo_Cliente", pCliente.ID_Tipo_Cliente);
                command.Parameters.AddWithValue("@Correo", pCliente.Correo);
                command.Parameters.AddWithValue("@ID_Provincia", pCliente.ID_Provincia);
                command.Parameters.AddWithValue("@Foto", pCliente.Foto);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {
                    rows = db.ExecuteNonQuery(command);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oCliente = this.GetClienteById(pCliente.ID);

                return oCliente;

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
