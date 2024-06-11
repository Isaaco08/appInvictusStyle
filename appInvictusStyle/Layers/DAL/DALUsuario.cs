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
using appInvictusStyle;

namespace UTN.Winform.InvictusStyle
{
    class DALUsuario : IDALUsuario
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        public DALUsuario()
        {

        }

        /// <summary>
        /// Metodo que muestra el usuario segun el filtro de id
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <returns>Objeto usuario que coincida con el id</returns>
        public Usuario GetUsuarioById(string pIdUsuario)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "usp_SELECT_Usuario_ByID";
                command.Parameters.AddWithValue("@ID", pIdUsuario);

                IDataReader dr = db.ExecuteReader(command);

                while (dr.Read())
                {
                    Usuario oUsuario = new Usuario();
                    oUsuario.ID = dr["ID"].ToString();
                    oUsuario.Contrasena = dr["Contrasena"].ToString();
                    oUsuario.ID_Tipo_Usuario = dr["ID_Tipo_Usuario"].ToString();

                    return oUsuario;
                }
            }
            return null;
        }

    }
}
