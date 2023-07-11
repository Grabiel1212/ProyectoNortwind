using LibDataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibBusinessEntities;


namespace LibBusinessRules
{
    public class BRPedido
    {

        private string strConexion;

        public BRPedido()
        {
            System.Configuration.AppSettingsReader asr = new
            System.Configuration.AppSettingsReader();
            strConexion = (string)asr.GetValue("conNW", Type.GetType("System.String"));
        }



        public List<BEPedido> ListarPedido()
        {
            List<BEPedido> lobePedido = new List<BEPedido>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAPedido odaPedido = new DAPedido();
                    lobePedido= odaPedido.ListarPedidos(con);
                }
                catch (Exception ex)
                {
                    // Grabar el Log de error
                    lobePedido= null;
                }
                finally
                {
                    con.Close();
                }
            }
            return (lobePedido);
        }





        public List<BEPedido> ListarPedidosInhabi()
        {
            List<BEPedido> lobePedido = new List<BEPedido>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAPedido odaPedido = new DAPedido();
                    lobePedido = odaPedido.ListarPedidosInhabilitados(con);
                }
                catch (Exception ex)
                {
                    //Grabar el Log de error
                    lobePedido = null;
                }
                finally
                {
                    con.Close();
                }
            }
            return (lobePedido);
        }

        public bool EliminarPedidos(BEPedido obePedido) // PARA DESABLITAR UN PRODUCTO
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAPedido odaPedido = new DAPedido();
                    exito = odaPedido.EliminarPedido(con, obePedido);
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    con.Close();
                }
            }
            return (exito);
        }

        public bool ActivarPedidos(BEPedido obePedido) // para activar el producto desabilitado 
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAPedido odaPedido = new DAPedido();
                    exito = odaPedido.ActivarPedido(con, obePedido);
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    con.Close();
                }
            }
            return (exito);
        }







        public int AdicionarPedido(BEPedido obePedido) // para inserta productos 
        {
            int N = -1;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAPedido odaPedido = new DAPedido();
                    N = odaPedido.InsertarPedido(con, obePedido);
                }
                catch (Exception ex)
                {
                    // Grabar el Log de error
                    N = -1;
                }
                finally
                {
                    con.Close();
                }
            }
            return (N);
        }


        public bool ActualizarPedido(BEPedido obePedido) // para actialuzar produscto
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAPedido odaPedido = new DAPedido();
                    exito = odaPedido.ActualizarPedido(con, obePedido);

                }
                catch (Exception ex)
                {
                }
                finally
                {
                    con.Close();
                }
            }
            return (exito);
        }







    }
}
