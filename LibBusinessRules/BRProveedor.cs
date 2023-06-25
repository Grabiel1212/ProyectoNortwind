using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibBusinessEntities;
using LibDataAccess;
using System.Data.SqlClient;

namespace LibBusinessRules
{
    public class BRProveedor
    {
        private string strConexion;

        public BRProveedor()
        {
            System.Configuration.AppSettingsReader asr = new
            System.Configuration.AppSettingsReader();
            strConexion = (string)asr.GetValue("conNW", Type.GetType("System.String"));
        }

        public List<BEProveedor> Listar()
        {
            List<BEProveedor> lobeProveedor = new List<BEProveedor>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAProveedor odaProveedor = new DAProveedor();
                    lobeProveedor = odaProveedor.fListar(con);
                }
                catch (Exception ex)
                {
                    // Grabar el Log de error
                    lobeProveedor = null;
                }
                finally
                {
                    con.Close();
                }
            }
            return (lobeProveedor);
        }
    }
}
