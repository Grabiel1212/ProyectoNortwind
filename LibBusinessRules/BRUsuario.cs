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
            }
            return (lobeUsuario);
        }
    }
}
