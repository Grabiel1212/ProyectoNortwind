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
    public class BRProducto
    {
        private string strConexion;

        public BRProducto()
        {
            System.Configuration.AppSettingsReader asr = new
            System.Configuration.AppSettingsReader();
            strConexion = (string)asr.GetValue("conNW", Type.GetType("System.String"));
        }

        public List<BEProducto> Listar()
        {
            List<BEProducto> lobeProducto = new List<BEProducto>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAProducto odaProducto = new DAProducto();
                    lobeProducto = odaProducto.fListar(con);
                }
                catch (Exception ex)
                {
                    // Grabar el Log de error
                    lobeProducto = null;
                }
            }
            return (lobeProducto);
        }
    }
}
