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
    class DALFactura : IDALFactura
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public DALFactura()
        {
            
        }

        /// <summary>
        /// Metodo que inserta y almacena tanto Factura como DetalleFactura
        /// </summary>
        /// <param name="pFactura"></param>
        /// <returns>Objeto Factura</returns>
        public Factura SaveFactura(Factura pFactura)
        {
            Factura oFacturaEncabezado = null;
            string sqlEncabezado = string.Empty;
            string sqlDetalle = string.Empty;
            string sqlArticulo = string.Empty;
            SqlCommand cmdFacturaEncabezado = new SqlCommand();
            SqlCommand cmdFacturaDetalle = new SqlCommand();
            SqlCommand cmdArticulo = new SqlCommand();
            List<IDbCommand> listaCommands = new List<IDbCommand>();
            double rows = 0;

            sqlEncabezado = @"  
                            INSERT INTO [dbo].[Factura]
                                       ([ID]
                                       ,[Fecha]
                                       ,[ID_Cliente])
                                 VALUES
                                        (@ID
                                       ,getdate()
                                       ,@ID_Cliente)  ";

            try
            {
                // Encabezado de factura
                cmdFacturaEncabezado.Parameters.AddWithValue("@ID", pFactura.ID);
                cmdFacturaEncabezado.Parameters.AddWithValue("@ID_Cliente", pFactura.ID_Cliente);
                cmdFacturaEncabezado.CommandText = sqlEncabezado;
                cmdFacturaEncabezado.CommandType = CommandType.Text;
                // Agregar a la lista de commands
                listaCommands.Add(cmdFacturaEncabezado);


                // Detalle de factura
                sqlDetalle = @" 
                    INSERT INTO[dbo].[DetalleFactura]
                               ([ID]
                               ,[ID_Factura]
                               ,[ID_Articulo]
                               ,[Cantidad]
                               ,[Subtotal]
                               ,[Descuento]
                               ,[IVA]
                               ,[Total])
                         VALUES
                               (@ID
                               ,@ID_Factura
                               ,@ID_Articulo
                               ,@Cantidad
                               ,@Subtotal
                               ,@Descuento
                               ,@IVA
                               ,@Total) ";

                // Guardar el detalle de la factura y a la vez rebajar la existencia del producto 
                foreach (DetalleFactura pFacturaDetalle in pFactura._ListaFacturaDetalle)
                {
                    cmdFacturaDetalle = new SqlCommand();
                    cmdFacturaDetalle.Parameters.AddWithValue("@ID", pFacturaDetalle.ID);
                    cmdFacturaDetalle.Parameters.AddWithValue("@ID_Factura", pFacturaDetalle.ID_Factura);
                    cmdFacturaDetalle.Parameters.AddWithValue("@ID_Articulo", pFacturaDetalle.ID_Articulo);
                    cmdFacturaDetalle.Parameters.AddWithValue("@Cantidad", pFacturaDetalle.Cantidad);
                    cmdFacturaDetalle.Parameters.AddWithValue("@Subtotal", pFacturaDetalle.Subtotal);
                    cmdFacturaDetalle.Parameters.AddWithValue("@Descuento", pFacturaDetalle.Descuento);
                    cmdFacturaDetalle.Parameters.AddWithValue("@IVA", pFacturaDetalle.IVA);
                    cmdFacturaDetalle.Parameters.AddWithValue("@Total", pFacturaDetalle.Total);
                    cmdFacturaDetalle.CommandText = sqlDetalle;
                    cmdFacturaDetalle.CommandType = CommandType.Text;
                    // Agregar a la lista de comandos
                    listaCommands.Add(cmdFacturaDetalle);  
                }
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {

                    rows = db.ExecuteNonQuery(listaCommands, IsolationLevel.ReadCommitted);
                }

                return oFacturaEncabezado;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), null, sqlError));
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
        /// Extraer un consecutivo para asignar el numero de factura
        /// </summary>
        /// <returns>Num. de factura</returns>
        public int GetNextNumeroFactura()
        {
            DataSet ds = null;
            IDbCommand command = new SqlCommand();
            int numeroFactura = 0;
            string sql = @"SELECT NEXT VALUE FOR SequenceNoFactura";

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
                numeroFactura = int.Parse(dt.Rows[0][0].ToString());
                return numeroFactura;
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
        /// Metodo que muestra el número actual de Factura
        /// </summary>
        /// <returns>Numero Factura actual</returns>
        public int GetCurrentNumeroFactura()
        {

            DataSet ds = null;
            IDbCommand command = new SqlCommand();
            int numeroFactura = 0;
            string sql = @"SELECT current_value FROM sys.sequences WHERE name = 'SequenceNoFactura'  ";
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
                numeroFactura = int.Parse(dt.Rows[0][0].ToString());
                return numeroFactura;
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