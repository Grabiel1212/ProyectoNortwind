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
    public class BRCategoria
    {
        private string strConexion;

        public BRCategoria()
        {
            System.Configuration.AppSettingsReader asr = new
            System.Configuration.AppSettingsReader();
            strConexion = (string)asr.GetValue("conNW", Type.GetType("System.String"));
        }

        public List<BECategoria> Listar()
        {
            List<BECategoria> lobeCategoria = new List<BECategoria>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DACategoria odaCategoria = new DACategoria();
                    lobeCategoria = odaCategoria.fListar(con);
                }
                catch (Exception ex)
                {
                    // Grabar el Log de error
                    lobeCategoria = null;
                }
                finally
                {
                    con.Close();
                }
            }
            return (lobeCategoria);
        }
    }
}
