using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibBusinessEntities;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Security.Cryptography;

namespace LibDataAccess
{
    public class DAUsuario
    {
        
            public List<BEUsuario> fListar(SqlConnection con)
            {
                List<BEUsuario> lobeUsuario = new List<BEUsuario>();
                SqlCommand cmd = new SqlCommand("uspUsuariosListado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 60;
                SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (drd != null)
                {
                    int posCodigo = drd.GetOrdinal("UserId");
                    int posNombreUsuario = drd.GetOrdinal("UserName");
                    int posPasswordUsuario = drd.GetOrdinal("UserPass");
                    int posNombre = drd.GetOrdinal("FirstName");
                    int posApellido = drd.GetOrdinal("LastName");
                    int posEstado = drd.GetOrdinal("UserStatus");
                    int posOcupacion = drd.GetOrdinal("Occupation");

                BEUsuario obeUsuario;
                    while (drd.Read())
                    {
                        obeUsuario = new BEUsuario();
                        {
                            var withBlock = obeUsuario;
                            withBlock.Codigo = drd.GetInt32(posCodigo);
                            withBlock.NombreUsuario = drd.GetString(posNombreUsuario);
                            withBlock.PasswordUsuario = drd.GetString(posPasswordUsuario);
                            withBlock.Nombre = drd.GetString(posNombre);
                            withBlock.Apellido = drd.GetString(posApellido);
                            withBlock.Estado = drd.GetInt32(posEstado);
                            withBlock.Ocupacion = drd.GetString(posOcupacion);
                    }
                        lobeUsuario.Add(obeUsuario);
                    }
                    drd.Close();
                }
                return (lobeUsuario);
            }
            public List<BEUsuario> fLogin(SqlConnection con, String uName, String pName)
            {
                List<BEUsuario> lobeUsuario = new List<BEUsuario>();
                SqlCommand cmd = new SqlCommand("uspUsuarioLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UName", SqlDbType.VarChar, 20).Value = uName;
                cmd.Parameters.Add("@UPass", SqlDbType.VarChar, 7).Value = pName;
                cmd.CommandTimeout = 60;
                SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (drd != null)
                {
          
                    int posCodigo = drd.GetOrdinal("UserId");
                    int posNombreUsuario = drd.GetOrdinal("UserName");
                    int posPasswordUsuario = drd.GetOrdinal("UserPass");
                    int posNombre = drd.GetOrdinal("FirstName");
                    int posApellido = drd.GetOrdinal("LastName");
                    int posEstado = drd.GetOrdinal("UserStatus");
                   int posOcupacion = drd.GetOrdinal("Occupation"); 

                BEUsuario obeUsuario;
                    while (drd.Read())
                    {
                        obeUsuario = new BEUsuario();
                        {
                            var withBlock = obeUsuario;
                            withBlock.Codigo = drd.GetInt32(posCodigo);
                            withBlock.NombreUsuario = drd.GetString(posNombreUsuario);
                            withBlock.PasswordUsuario = drd.GetString(posPasswordUsuario);
                            withBlock.Nombre = drd.GetString(posNombre);
                            withBlock.Apellido = drd.GetString(posApellido);
                            withBlock.Estado = drd.GetInt32(posEstado);
                            withBlock.Ocupacion = drd.GetString(posOcupacion);
                          }
                        lobeUsuario.Add(obeUsuario);
                    }
                    drd.Close();
                }
                return (lobeUsuario);
            }
        
    } 
}
