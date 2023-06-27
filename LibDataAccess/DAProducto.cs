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
using System.Web;

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

        //public List<BEProducto> fValidarProductoAc(SqlConnection con, int val)
        //{
        //    List<BEProducto> objProducto = new List<BEProducto>();
        //    SqlCommand cmd = new SqlCommand("ProductoDesactivadosActivados", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("@activado", SqlDbType.VarChar, 20).Value = val;
        //    cmd.CommandTimeout = 60;
        //    SqlDataReader leer = cmd.ExecuteReader(CommandBehavior.SingleResult);
        //    if (leer != null)
        //    {
        //        int posCodigo = leer.GetOrdinal("ProductId");
        //        int posNombre = leer.GetOrdinal("ProductName");
        //        int posIdProveedor = leer.GetOrdinal("SupplierId");
        //        int posIdCategoria = leer.GetOrdinal("CategoryId");
        //        int posPrecioUni = leer.GetOrdinal("UnitPrice");
        //        int posStock = leer.GetOrdinal("UnitsInStock");
        //        BEProducto obeProducto;
        //        while (leer.Read())
        //        {
        //            obeProducto = new BEProducto();
        //            {
        //                var withBlock = obeProducto;
        //                withBlock.Codigo = leer.GetInt32(posCodigo);
        //                withBlock.Nombre = leer.GetString(posNombre);
        //                withBlock.IdProveedor = leer.GetInt32(posIdProveedor);
        //                withBlock.IdCategoria = leer.GetInt32(posIdCategoria);
        //                withBlock.PrecioUni = leer.GetDecimal(posPrecioUni);
        //                withBlock.Stock = leer.GetInt16(posStock);
        //            }
        //            objProducto.Add(obeProducto);
        //        }
        //        leer.Close();
        //    }
        //    return (objProducto);
        //}

        public List<BEProducto> fListarInhab(SqlConnection con)
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

        public int fAdicionar(SqlConnection con, BEProducto obeProducto)
        {
            int N = -1;
            SqlCommand cmd = new SqlCommand("uspProductsIns", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter par1 = cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 40);
            par1.Direction = ParameterDirection.Input;
            par1.Value = obeProducto.Nombre;
            SqlParameter par2 = cmd.Parameters.Add("@SupplierId", SqlDbType.Int);
            par2.Direction = ParameterDirection.Input;
            par2.Value = obeProducto.IdProveedor;
            SqlParameter par3 = cmd.Parameters.Add("@CategoryId", SqlDbType.Int);
            par3.Direction = ParameterDirection.Input;
            par3.Value = obeProducto.IdCategoria;
            SqlParameter par4 = cmd.Parameters.Add("@UnitPrice", SqlDbType.Money);
            par4.Direction = ParameterDirection.Input;
            par4.Value = obeProducto.PrecioUni;
            SqlParameter par5 = cmd.Parameters.Add("@UnitsInStock", SqlDbType.SmallInt);
            par5.Direction = ParameterDirection.Input;
         
            par5.Value = obeProducto.Stock;
            SqlParameter par6 = cmd.Parameters.Add("@@identity", SqlDbType.Int);
            par6.Direction = ParameterDirection.ReturnValue;
            N = cmd.ExecuteNonQuery();
            if (N > 0)
                return ((int)par6.Value);
            else
                return (-1);
        }


        public bool fActualizar(SqlConnection con, BEProducto obeProducto)
        {
            bool Exito = false;
            SqlCommand cmd = new SqlCommand("uspProductsUpd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par0 = cmd.Parameters.Add("@ProductId", SqlDbType.Int);
            par0.Direction = ParameterDirection.Input;
            par0.Value = obeProducto.Codigo;
            SqlParameter par1 = cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 40);
            par1.Direction = ParameterDirection.Input;
            par1.Value = obeProducto.Nombre;
            SqlParameter par2 = cmd.Parameters.Add("@SupplierId", SqlDbType.Int);
            par2.Direction = ParameterDirection.Input;
            par2.Value = obeProducto.IdProveedor;
            SqlParameter par3 = cmd.Parameters.Add("@CategoryId", SqlDbType.Int);
            par3.Direction = ParameterDirection.Input;
            par3.Value = obeProducto.IdCategoria;
            SqlParameter par4 = cmd.Parameters.Add("@UnitPrice", SqlDbType.Money);
            par4.Direction = ParameterDirection.Input;
            par4.Value = obeProducto.PrecioUni;
            SqlParameter par5 = cmd.Parameters.Add("@UnitsInStock", SqlDbType.SmallInt);
            par5.Direction = ParameterDirection.Input;
            par5.Value = obeProducto.Stock;
            int N = cmd.ExecuteNonQuery();
            Exito = (N > 0);
            return (Exito);
        }


        public bool fEliminar(SqlConnection con, BEProducto obeProducto)
        {
            bool Exito = false;
            SqlCommand cmd = new SqlCommand("uspProductsDel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = cmd.Parameters.Add("@ProductId", SqlDbType.Int);
            par.Direction = ParameterDirection.Input;
            par.Value = obeProducto.Codigo;
            int N = cmd.ExecuteNonQuery();
            Exito = (N > 0);
            return (Exito);
        }
        public bool fActivar(SqlConnection con, BEProducto obeProducto)
        {
            bool Exito = false;
            SqlCommand cmd = new SqlCommand("uspProductsAct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = cmd.Parameters.Add("@ProductId", SqlDbType.Int);
            par.Direction = ParameterDirection.Input;
            par.Value = obeProducto.Codigo;
            int N = cmd.ExecuteNonQuery();
            Exito = (N > 0);
            return (Exito);
        }


    }
}
