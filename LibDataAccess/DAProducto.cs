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
    public class DAProducto
    {
        public List<BEProducto> fListar(SqlConnection con)
        {
            List<BEProducto> lobeProducto = new List<BEProducto>();
            SqlCommand cmd = new SqlCommand("uspProductsListado", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 60;
            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
            if (drd != null)
            {
                int posCodigo = drd.GetOrdinal("ProductId");
                int posNombre = drd.GetOrdinal("ProductName");
                int posIdProveedor = drd.GetOrdinal("SupplierId");
                int posIdCategoria = drd.GetOrdinal("CategoryId");
                int posPrecioUni = drd.GetOrdinal("UnitPrice");
                int posStock = drd.GetOrdinal("UnitsInStock");
                BEProducto obeProducto;
                while (drd.Read())
                {
                    obeProducto = new BEProducto();
                    {
                        var withBlock = obeProducto;
                        withBlock.Codigo = drd.GetInt32(posCodigo);
                        withBlock.Nombre = drd.GetString(posNombre);
                        withBlock.IdProveedor = drd.GetInt32(posIdProveedor);
                        withBlock.IdCategoria = drd.GetInt32(posIdCategoria);
                        withBlock.PrecioUni = drd.GetDecimal(posPrecioUni);
                        withBlock.Stock = drd.GetInt16(posStock);
                    }
                    lobeProducto.Add(obeProducto);
                }
                drd.Close();
            }
            return (lobeProducto);
        }
    }
}
