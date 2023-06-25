using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using LibBusinessEntities;
using LibDataAccess;
using System.Data.SqlClient;

namespace LibBusinessRules
{
    public class BREmpleado
    {
        private string strConexion;

        public BREmpleado()
        {
            System.Configuration.AppSettingsReader asr = new
            System.Configuration.AppSettingsReader();
            strConexion = (string)asr.GetValue("conNW", Type.GetType("System.String"));
        }

        public List<BEEmpleado> Listar()
        {
            List<BEEmpleado> lobeEmpleado = new List<BEEmpleado>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAEmpleado odaEmpleado = new DAEmpleado();
                    lobeEmpleado = odaEmpleado.fListar(con);
                }
                catch (Exception ex)
                {
                    // Grabar el Log de error
                    lobeEmpleado = null;
                }
                finally
                {
                    con.Close();
                }
            }
            return (lobeEmpleado);
        }
    }
}
