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
    public class DAProveedor
    {
        public List<BEProveedor> fListar(SqlConnection con)
        {
            List<BEProveedor> lobeProveedor = new List<BEProveedor>();
            SqlCommand cmd = new SqlCommand("uspSuppliersListado", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 60;
            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
            if (drd != null)
            {
                int posCodigo = drd.GetOrdinal("SupplierId");
                int posNombre = drd.GetOrdinal("CompanyName");
                int posContacto = drd.GetOrdinal("ContactName");
                int posDireccion= drd.GetOrdinal("Address");
                int posPaiz = drd.GetOrdinal("City");
           


                BEProveedor obeProveedor;
                while (drd.Read())
                {
                    obeProveedor = new BEProveedor();
                    {
                        var withBlock = obeProveedor;
                        withBlock.Codigo = drd.GetInt32(posCodigo);
                        withBlock.Nombre = drd.GetString(posNombre);
                        withBlock.Contacto = drd.GetString(posContacto);
                        withBlock.Direccion= drd.GetString(posDireccion);
                        withBlock.Paiz = drd.GetString(posPaiz);
                    }
                    lobeProveedor.Add(obeProveedor);
                }
                drd.Close();
            }
            return (lobeProveedor);
        }


        public List<BEProveedor> fListarDesabilitados(SqlConnection con)
        {
            List<BEProveedor> lobeProveedor = new List<BEProveedor>();
            SqlCommand cmd = new SqlCommand("uspSuppliersDesabilitados", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 60;
            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
            if (drd != null)
            {
                int posCodigo = drd.GetOrdinal("SupplierId");
                int posNombre = drd.GetOrdinal("CompanyName");
                int posContacto = drd.GetOrdinal("ContactName");
                int posDireccion = drd.GetOrdinal("Address");
                int posPaiz = drd.GetOrdinal("City");



                BEProveedor obeProveedor;
                while (drd.Read())
                {
                    obeProveedor = new BEProveedor();
                    {
                        var withBlock = obeProveedor;
                        withBlock.Codigo = drd.GetInt32(posCodigo);
                        withBlock.Nombre = drd.GetString(posNombre);
                        withBlock.Contacto = drd.GetString(posContacto);
                        withBlock.Direccion = drd.GetString(posDireccion);
                        withBlock.Paiz = drd.GetString(posPaiz);
                    }
                    lobeProveedor.Add(obeProveedor);
                }
                drd.Close();
            }
            return (lobeProveedor);
        }



    }
}
