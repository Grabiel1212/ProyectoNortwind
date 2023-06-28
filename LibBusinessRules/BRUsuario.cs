using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibBusinessEntities;
using LibDataAccess;
using System.Data.SqlClient;
using System.Reflection;
using System.Security.Cryptography;

namespace LibBusinessRules
{
    public class BRUsuario
    {
        private string strConexion;
        public BRUsuario()
        {
            System.Configuration.AppSettingsReader asr = new
            System.Configuration.AppSettingsReader();
            strConexion = (string)asr.GetValue("conNW", Type.GetType("System.String"));
        }
        public List<BEUsuario> Listar()
        {
            List<BEUsuario> lobeUsuario = new List<BEUsuario>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAUsuario odaUsuario = new DAUsuario();
                    lobeUsuario = odaUsuario.fListar(con);
                }
                catch (Exception ex)
                {
                    // Grabar el Log de error
                    lobeUsuario = null;
                }
            }
            return (lobeUsuario);
        }
        public List<BEUsuario> Login(String uName, String pName)
        {
            List<BEUsuario> lobeUsuario = new List<BEUsuario>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAUsuario odaUsuario = new DAUsuario();
                    lobeUsuario = odaUsuario.fLogin(con, uName, pName);
                }
                catch (Exception ex)
                {
                    // Grabar el Log de error
                    lobeUsuario = null;
                }
                finally
                {
                    con.Close();
                }
            }
            return (lobeUsuario);
        }


        public int IngresarUsuario(BEUsuario obeUsuario) // para inserta nuevos uusuarios
        {
            int N = -1;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAUsuario odaUsuario = new DAUsuario();
                    N = odaUsuario.fAIngresarUsuario(con, obeUsuario);
                }
                catch (Exception ex)
                {
                    // Grabar el Log de error
                    N = -1;
                }
                finally
                {
                    con.Close();
                }
            }
            return (N);
        }

        public bool ActualizarUsuario(BEUsuario obeUsuario) // para actialuzar los usuarios
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAUsuario odaUsuario = new DAUsuario();
                    exito = odaUsuario.fActualizarUsuario(con, obeUsuario);

                }
                catch (Exception ex)
                {
                }
                finally
                {
                    con.Close();
                }
            }
            return (exito);
        }


        public List<BEUsuario> ListarUsuariosInhabi()// para listar usuarios desactivados
        {
            List<BEUsuario> lobeUsuario = new List<BEUsuario>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAUsuario odaUsuario = new DAUsuario();
                    lobeUsuario = odaUsuario.fListarUserDesativados(con);
                }
                catch (Exception ex)
                {
                    //Grabar el Log de error
                    lobeUsuario = null;
                }
                finally
                {
                    con.Close();
                }
            }
            return (lobeUsuario);
        }

        public bool EliminarUsuario(BEUsuario obeUsuario) // PARA DESABLITAR UN Usuario
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAUsuario odaUsuario = new DAUsuario();
                    exito = odaUsuario.fEliminarUsuario(con, obeUsuario);
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    con.Close();
                }
            }
            return (exito);
        }

        public bool ActivarUsuario(BEUsuario obeUsuario) // para activar un Ususuario
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAUsuario odaUsuario = new DAUsuario();
                    exito = odaUsuario.fActivarUsuario(con, obeUsuario);
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    con.Close();
                }
            }
            return (exito);
        }




    }
}
