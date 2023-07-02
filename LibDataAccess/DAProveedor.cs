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
        public List<BEProveedor> fListarProveedor(SqlConnection con)
        {
            List<BEProveedor> lobeProveedor = new List<BEProveedor>();
            SqlCommand cmd = new SqlCommand("usplistarProvedores", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 60;
            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
            if (drd != null)
            {
                int posCodigo = drd.GetOrdinal("SupplierID");
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




        public bool fEliminarProveedor(SqlConnection con, BEProveedor obeProveedor) // para desabilitar un produscto
        {
            bool Exito = false;
            SqlCommand cmd = new SqlCommand("uspSuppliersDel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = cmd.Parameters.Add("@SupplierId", SqlDbType.Int);
            par.Direction = ParameterDirection.Input;
            par.Value = obeProveedor.Codigo;
            int N = cmd.ExecuteNonQuery();
            Exito = (N > 0);
            return (Exito);
        }



        public bool fActivarProducProveedor(SqlConnection con, BEProveedor obeProveedor) // para valitar un producto
        {
            bool Exito = false;
            SqlCommand cmd = new SqlCommand("uspSuppliersAct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = cmd.Parameters.Add("@SupplierId", SqlDbType.Int);
            par.Direction = ParameterDirection.Input;
            par.Value = obeProveedor.Codigo;
            int N = cmd.ExecuteNonQuery();
            Exito = (N > 0);
            return (Exito);
        }




        public int fAdicionarPriveedor(SqlConnection con, BEProveedor obeProveedor) // para insertar productos
        {
            int N = -1;
            SqlCommand cmd = new SqlCommand("uspSuppliersInsertar", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter par1 = cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 40);
            par1.Direction = ParameterDirection.Input;
            par1.Value = obeProveedor.Nombre;

            SqlParameter par2 = cmd.Parameters.Add("@ContacTo", SqlDbType.NVarChar, 40);
            par2.Direction = ParameterDirection.Input;
            par2.Value = obeProveedor.Contacto;

            SqlParameter par3 = cmd.Parameters.Add("@direccion", SqlDbType.NVarChar, 40);
            par3.Direction = ParameterDirection.Input;
            par3.Value = obeProveedor.Direccion;

            SqlParameter par4 = cmd.Parameters.Add("@paiz", SqlDbType.NVarChar, 40);
            par4.Direction = ParameterDirection.Input;
            par4.Value = obeProveedor.Paiz;
 
            SqlParameter par5= cmd.Parameters.Add("@@identity", SqlDbType.Int);
            par5.Direction = ParameterDirection.ReturnValue;

            N = cmd.ExecuteNonQuery();
            if (N > 0)
                return ((int)par5.Value);
            else
                return (-1);
        }


        public bool fActualizarProveedor(SqlConnection con, BEProveedor obeProveedor) // para actualizar los productos 
        {
            bool Exito = false;
            SqlCommand cmd = new SqlCommand("uspSuppliersModificar", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter par0 = cmd.Parameters.Add("@SupplierId", SqlDbType.Int);
            par0.Direction = ParameterDirection.Input;
            par0.Value = obeProveedor.Codigo;

            SqlParameter par1 = cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 40);
            par1.Direction = ParameterDirection.Input;
            par1.Value = obeProveedor.Nombre;

            SqlParameter par2 = cmd.Parameters.Add("@ContacTo", SqlDbType.NVarChar, 40);
            par2.Direction = ParameterDirection.Input;
            par2.Value = obeProveedor.Contacto;

            SqlParameter par3 = cmd.Parameters.Add("@direccion", SqlDbType.NVarChar, 40);
            par3.Direction = ParameterDirection.Input;
            par3.Value = obeProveedor.Direccion;

            SqlParameter par4 = cmd.Parameters.Add("@paiz", SqlDbType.NVarChar, 40);
            par4.Direction = ParameterDirection.Input;
            par4.Value = obeProveedor.Paiz;


         

            int N = cmd.ExecuteNonQuery();
            Exito = (N > 0);
            return (Exito);
        }







    }
}
