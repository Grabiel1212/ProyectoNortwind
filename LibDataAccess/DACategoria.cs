using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibBusinessEntities;
using System.Data;
using System.Data.SqlClient;

namespace LibDataAccess
{
    public class DACategoria
    {
        public List<BECategoria> fListar(SqlConnection con)
        {
            List<BECategoria> lobeCategoria = new List<BECategoria>();
            SqlCommand cmd = new SqlCommand("uspCategoriesListado", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 60;
            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
            if (drd != null)
            {
                int posCodigo = drd.GetOrdinal("CategoryId");
                int posNombre = drd.GetOrdinal("CategoryName");
                BECategoria obeCategoria;
                while (drd.Read())
                {
                    obeCategoria = new BECategoria();
                    {
                        var withBlock = obeCategoria;
                        withBlock.Codigo = drd.GetInt32(posCodigo);
                        withBlock.Nombre = drd.GetString(posNombre);
                    }
                    lobeCategoria.Add(obeCategoria);
                }
                drd.Close();
            }
            return (lobeCategoria);
        }
    }
}
