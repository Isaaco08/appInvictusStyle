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
    class DALDescuento : IDALDescuento
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        /// <summary>
        /// Metodo que muestra todos los Descuentos almacenados
        /// </summary>
        /// <returns>Lista de Descuentos</returns>
        public List<Descuento> GetAllDescuento()
        {
            IDataReader reader = null;
            List<Descuento> lista = new List<Descuento>();
            SqlCommand command = new SqlCommand();


            try
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_SELECT_Descuento_All";
                command.CommandType = CommandType.Text;
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        Descuento oDescuento = new Descuento();
                        oDescuento.ID = reader["ID"].ToString();
                        oDescuento.Descripcion = reader["Descripcion"].ToString();
                        oDescuento.Monto = double.Parse(reader["Monto"].ToString());
                        lista.Add(oDescuento);
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
        /// Metodo que elimina el Descuento
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>Si se encuentra el objeto lo elimina</returns>
        public bool DeleteDescuento(string pId)
        {
            bool retorno = false;
            double rows = 0d;
            SqlCommand command = new SqlCommand();
            try
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_DELETE_Descuento_ByID";
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
        /// Metodo que muestra el Descuento segun el filtro de id
        /// </summary>
        /// <param name="pIdDescuento"></param>
        /// <returns>Objeto Descuento que coincida con el id</returns>
        public Descuento GetDescuentoById(string pIdDescuento)
        {
            DataSet ds = null;
            Descuento oDescuento = null;
            SqlCommand command = new SqlCommand();

            try
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_SELECT_Descuento_ByID";
                command.Parameters.AddWithValue("@ID", pIdDescuento);


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
                        oDescuento = new Descuento();
                        oDescuento.ID = dr["ID"].ToString();
                        oDescuento.Descripcion = dr["Descripcion"].ToString();
                        oDescuento.Monto = double.Parse(dr["Monto"].ToString());


                    }
                }

                return oDescuento;
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
        /// Metodo que inserta y almacena el Descuento
        /// </summary>
        /// <param name="pDescuento"></param>
        /// <returns>Objeto Descuento</returns>
        public Descuento SaveDescuento(Descuento pDescuento)
        {
            Descuento oDescuento = null;
            SqlCommand command = new SqlCommand();

            double rows = 0;
            try
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_INSERT_Descuento";
                command.Parameters.AddWithValue("@ID", pDescuento.ID);
                command.Parameters.AddWithValue("@Descripcion", pDescuento.Descripcion);
                command.Parameters.AddWithValue("@Monto", pDescuento.Monto);


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {
                    rows = db.ExecuteNonQuery(command);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oDescuento = this.GetDescuentoById(pDescuento.ID);

                return oDescuento;

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
        /// Metodo que actualiza los datos del Descuento
        /// </summary>
        /// <param name="pDescuento"></param>
        /// <returns>Objeto Descuento actualizado</returns>
        public Descuento UpdateDescuento(Descuento pDescuento)
        {
            Descuento oDescuento = null;
            SqlCommand command = new SqlCommand();

            double rows = 0;
            try
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_UPDATE_Descuento";
                command.Parameters.AddWithValue("@ID", pDescuento.ID);
                command.Parameters.AddWithValue("@Descripcion", pDescuento.Descripcion);
                command.Parameters.AddWithValue("@Monto", pDescuento.Monto);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {
                    rows = db.ExecuteNonQuery(command);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oDescuento = this.GetDescuentoById(pDescuento.ID);

                return oDescuento;

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
