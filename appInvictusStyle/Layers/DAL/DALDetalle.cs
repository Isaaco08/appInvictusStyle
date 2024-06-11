using appInvictusStyle.Interfaces;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.InvictusStyle.Layers.Entidades;

namespace appInvictusStyle.Layers.DAL
{
    class DALDetalle : IDALDetalle
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        /// <summary>
        /// Metodo que muestra el DetalleFactura segun el filtro de id
        /// </summary>
        /// <param name="pIdDetalle"></param>
        /// <returns>Objeto DetalleFactura que coincida con el id</returns>
        public DetalleFactura GetDetalleById(string pIdDetalle)
        {
            DataSet ds = null;
            DetalleFactura oDetalle = null;
            SqlCommand command = new SqlCommand();


            try
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_SELECT_DetalleFactura_ByID";
                command.Parameters.AddWithValue("@ID", pIdDetalle);


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
                        oDetalle = new DetalleFactura();
                        oDetalle.ID = dr["ID"].ToString();
                        oDetalle.ID_Factura = dr["ID_Factura"].ToString();
                        oDetalle.ID_Articulo = dr["ID_Articulo"].ToString();
                        oDetalle.Cantidad = (int)dr["Cantidad"];
                        oDetalle.Subtotal = (double)dr["Subtotal"];
                        oDetalle.Descuento = (double)dr["Descuento"];
                        oDetalle.IVA = (double)dr["IVA"];
                        oDetalle.Total = (double)dr["Total"];


                    }
                }

                return oDetalle;
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
        /// Metodo que inserta y almacena el DetalleFactura
        /// </summary>
        /// <param name="pDetalle"></param>
        /// <returns>Objeto DetalleFactura</returns>
        public DetalleFactura SaveDetalle(DetalleFactura pDetalle)
        {
            DetalleFactura oDetalle = null;
            SqlCommand command = new SqlCommand();

            double rows = 0;
            try
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_INSERT_DetalleFactura";
                command.Parameters.AddWithValue("@ID", pDetalle.ID);
                command.Parameters.AddWithValue("@ID_Factura", pDetalle.ID_Factura);
                command.Parameters.AddWithValue("@ID_Articulo", pDetalle.ID_Articulo);
                command.Parameters.AddWithValue("@Cantidad", pDetalle.Cantidad);
                command.Parameters.AddWithValue("@Subtotal", pDetalle.Subtotal);
                command.Parameters.AddWithValue("@Descuento", pDetalle.Descuento);
                command.Parameters.AddWithValue("@IVA", pDetalle.IVA);
                command.Parameters.AddWithValue("@Total", pDetalle.Total);

                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnectionDefault()))
                {
                    rows = db.ExecuteNonQuery(command);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oDetalle = this.GetDetalleById(pDetalle.ID);

                return oDetalle;

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
