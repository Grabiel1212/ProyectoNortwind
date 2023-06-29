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
        
            public List<BEUsuario> fListar(SqlConnection con)// lisatr tood los uusarios
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

                    if (obeUsuario.Estado == 1)
                    {
                        lobeUsuario.Add(obeUsuario);
                    }
                }

                drd.Close();
            }

            return lobeUsuario;
        }


        public List<BEUsuario> fListarUserDesativados(SqlConnection con)// lisatr los usuarios desactivados
        {
            List<BEUsuario> lobeUsuario = new List<BEUsuario>();
            SqlCommand cmd = new SqlCommand("uspUsuariosDesactivados", con);
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


        public int fAIngresarUsuario(SqlConnection con, BEUsuario obeUsuario) // para ingresar un nuevo  Usuario
        {
            int N = -1;
            SqlCommand cmd = new SqlCommand("uspUsuariosIns", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter par1 = cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 40);
            par1.Direction = ParameterDirection.Input;
            par1.Value = obeUsuario.NombreUsuario;

            SqlParameter par2 = cmd.Parameters.Add("@UserPass", SqlDbType.NVarChar, 40);
            par2.Direction = ParameterDirection.Input;
            par2.Value = obeUsuario.PasswordUsuario;
        
            SqlParameter par3 = cmd.Parameters.Add("@DFirstName", SqlDbType.NVarChar, 40);
            par3.Direction = ParameterDirection.Input;
            par3.Value = obeUsuario.Nombre;

            SqlParameter par4 = cmd.Parameters.Add("@LastName ", SqlDbType.NVarChar, 40);
            par4.Direction = ParameterDirection.Input;
            par4.Value = obeUsuario.Apellido;

            SqlParameter par5 = cmd.Parameters.Add("@occupation", SqlDbType.NVarChar, 40);
            par5.Direction = ParameterDirection.Input;
           par5.Value = obeUsuario.Ocupacion;

            SqlParameter par6 = cmd.Parameters.Add("@@identity", SqlDbType.Int);
            par6.Direction = ParameterDirection.ReturnValue;
            N = cmd.ExecuteNonQuery();
            if (N > 0)
                return ((int)par6.Value);
            else
                return (-1);
        }


        public bool fActualizarUsuario(SqlConnection con, BEUsuario obeUsuario) // para actualizar los Usuarios
        {
            bool Exito = false;
            SqlCommand cmd = new SqlCommand("uspUsuariosUpd", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter par0 = cmd.Parameters.Add("@UserId", SqlDbType.Int);
            par0.Direction = ParameterDirection.Input;
            par0.Value = obeUsuario.Codigo;

            SqlParameter par1 = cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 40);
            par1.Direction = ParameterDirection.Input;
            par1.Value = obeUsuario.NombreUsuario;

            SqlParameter par2 = cmd.Parameters.Add("@UserPass", SqlDbType.NVarChar, 40);
            par2.Direction = ParameterDirection.Input;
            par2.Value = obeUsuario.PasswordUsuario;

            SqlParameter par3 = cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 40);
            par3.Direction = ParameterDirection.Input;
            par3.Value = obeUsuario.Nombre;

            SqlParameter par4 = cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 40);
            par4.Direction = ParameterDirection.Input;
            par4.Value = obeUsuario.Apellido;

            SqlParameter par5 = cmd.Parameters.Add("@ocupacion", SqlDbType.NVarChar, 40);
            par5.Direction = ParameterDirection.Input;
            par5.Value = obeUsuario.Ocupacion;

            int N = cmd.ExecuteNonQuery();
            Exito = (N > 0);
            return (Exito);
        }


        public bool fEliminarUsuario(SqlConnection con, BEUsuario obeUsuario) // para desabilitar o eliminar un Usuario
        {
            bool Exito = false;
            SqlCommand cmd = new SqlCommand("uspUsuariosDel", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter par = cmd.Parameters.Add("@UserId", SqlDbType.Int);
            par.Direction = ParameterDirection.Input;
            par.Value = obeUsuario.Codigo;
            int N = cmd.ExecuteNonQuery();
            Exito = (N > 0);
            return (Exito);
        }

        public bool fActivarUsuario(SqlConnection con, BEUsuario obeUsuario) // para valitar activar un usuario
        {
            bool Exito = false;
            SqlCommand cmd = new SqlCommand("uspUsuariosAct", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter par = cmd.Parameters.Add("@UserId", SqlDbType.Int);
            par.Direction = ParameterDirection.Input;
            par.Value = obeUsuario.Codigo;
            int N = cmd.ExecuteNonQuery();
            Exito = (N > 0);
            return (Exito);
        }


    } 
}
