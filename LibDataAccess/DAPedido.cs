using LibBusinessEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDataAccess
{
    public class DAPedido
    {

        public List<BEPedido> ListarPedidos(SqlConnection con)
        {
            List<BEPedido> listaPedidos = new List<BEPedido>();
            SqlCommand cmd = new SqlCommand("uspOrdersListado", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 60;
            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
            if (drd != null)
            {
                int posCodigoOrden = drd.GetOrdinal("OrderID");
                int posIdCliente = drd.GetOrdinal("CustomerID");
                int posIdEmpleado = drd.GetOrdinal("EmployeeID");
                int posFechaOrden = drd.GetOrdinal("OrderDate");
                int posDireccionEnvio = drd.GetOrdinal("ShipAddress");
                int posTransporte = drd.GetOrdinal("Freight");
                BEPedido pedido;
                while (drd.Read())
                {
                    pedido = new BEPedido();
                    {
                        var withBlock = pedido;
                        withBlock.CodigoOrden = drd.GetInt32(posCodigoOrden);
                        withBlock.IdCliente = drd.GetString(posIdCliente);
                        withBlock.IdEmpleado = drd.GetInt32(posIdEmpleado);
                        withBlock.FechaOrden = drd.GetDateTime(posFechaOrden);
                        withBlock.DireccionEnvio = drd.GetString(posDireccionEnvio);
                        //withBlock.Transporte = drd.GetDouble(posTransporte);
                    }
                    listaPedidos.Add(pedido);
                }
                drd.Close();
            }
            return listaPedidos;
        }

        public List<BEPedido> ListarPedidosInhabilitados(SqlConnection con)
        {
            List<BEPedido> listaPedidos = new List<BEPedido>();
            SqlCommand cmd = new SqlCommand("uspOrdersInhab", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 60;
            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
            if (drd != null)
            {
                int posCodigoOrden = drd.GetOrdinal("OrderID");
                int posIdCliente = drd.GetOrdinal("CustomerID");
                int posIdEmpleado = drd.GetOrdinal("EmployeeID");
                int posFechaOrden = drd.GetOrdinal("OrderDate");
                int posDireccionEnvio = drd.GetOrdinal("ShipAddress");
                //int posTransporte = drd.GetOrdinal("Freight");
                BEPedido pedido;
                while (drd.Read())
                {
                    pedido = new BEPedido();
                    {
                        var withBlock = pedido;
                        withBlock.CodigoOrden = drd.GetInt32(posCodigoOrden);
                        withBlock.IdCliente = drd.GetString(posIdCliente);
                        withBlock.IdEmpleado = drd.GetInt32(posIdEmpleado);
                        withBlock.FechaOrden = drd.GetDateTime(posFechaOrden);
                        withBlock.DireccionEnvio = drd.GetString(posDireccionEnvio);
                        //withBlock.Transporte = drd.GetDouble(posTransporte);
                    }
                    listaPedidos.Add(pedido);
                }
                drd.Close();
            }
            return listaPedidos;
        }

        public bool EliminarPedido(SqlConnection con, BEPedido pedido)
        {
            bool exito = false;
            SqlCommand cmd = new SqlCommand("uspOrdersDel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = cmd.Parameters.Add("@OrderID", SqlDbType.Int);
            par.Direction = ParameterDirection.Input;
            par.Value = pedido.CodigoOrden;
            int N = cmd.ExecuteNonQuery();
            exito = (N > 0);
            return exito;
        }

        public bool ActivarPedido(SqlConnection con, BEPedido pedido)
        {
            bool exito = false;
            SqlCommand cmd = new SqlCommand("uspOrdersAct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = cmd.Parameters.Add("@OrderID", SqlDbType.Int);
            par.Direction = ParameterDirection.Input;
            par.Value = pedido.CodigoOrden;
            int N = cmd.ExecuteNonQuery();
            exito = (N > 0);
            return exito;
        }

        public int InsertarPedido(SqlConnection con, BEPedido pedido)
        {
            int N = -1;
            SqlCommand cmd = new SqlCommand("uspOrdersIns", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter par1 = cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 5);
            par1.Direction = ParameterDirection.Input;
            par1.Value = pedido.IdCliente;
            SqlParameter par2 = cmd.Parameters.Add("@EmployeeID", SqlDbType.Int);
            par2.Direction = ParameterDirection.Input;
            par2.Value = pedido.IdEmpleado;
            SqlParameter par3 = cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime);
            par3.Direction = ParameterDirection.Input;
            par3.Value = pedido.FechaOrden;
            SqlParameter par4 = cmd.Parameters.Add("@ShipAddress", SqlDbType.NVarChar, 60);
            par4.Direction = ParameterDirection.Input;
            par4.Value = pedido.DireccionEnvio;
            //SqlParameter par5 = cmd.Parameters.Add("@Freight", SqlDbType.Money);
            //par5.Direction = ParameterDirection.Input;
            //par5.Value = pedido.Transporte;

            SqlParameter par6 = cmd.Parameters.Add("@@identity", SqlDbType.Int);
            par6.Direction = ParameterDirection.ReturnValue;

            N = cmd.ExecuteNonQuery();
            if (N > 0)
                return (int)par6.Value;
            else
                return -1;
        }

        public bool ActualizarPedido(SqlConnection con, BEPedido pedido)
        {
            bool exito = false;
            SqlCommand cmd = new SqlCommand("uspOrdersUpd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par0 = cmd.Parameters.Add("@OrderID", SqlDbType.Int);
            par0.Direction = ParameterDirection.Input;
            par0.Value = pedido.CodigoOrden;
            SqlParameter par1 = cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 5);
            par1.Direction = ParameterDirection.Input;
            par1.Value = pedido.IdCliente;
            SqlParameter par2 = cmd.Parameters.Add("@EmployeeID", SqlDbType.Int);
            par2.Direction = ParameterDirection.Input;
            par2.Value = pedido.IdEmpleado;
            SqlParameter par3 = cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime);
            par3.Direction = ParameterDirection.Input;
            par3.Value = pedido.FechaOrden;
            SqlParameter par4 = cmd.Parameters.Add("@ShipAddress", SqlDbType.NVarChar, 60);
            par4.Direction = ParameterDirection.Input;
            par4.Value = pedido.DireccionEnvio;
            //SqlParameter par5 = cmd.Parameters.Add("@Freight", SqlDbType.Money);
            //par5.Direction = ParameterDirection.Input;
            //par5.Value = pedido.Transporte;

            int N = cmd.ExecuteNonQuery();
            exito = (N > 0);
            return exito;
        }




    }
}
