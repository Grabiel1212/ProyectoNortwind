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

        public List<BEProveedor> ListarProveedor()
        {
            List<BEProveedor> lobeProveedor = new List<BEProveedor>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAProveedor odaProveedor = new DAProveedor();
                    lobeProveedor = odaProveedor.fListarProveedor(con);
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


        public List<BEProveedor> ListarProcedordesavilitado()
        {
            List<BEProveedor> lobeProveedor = new List<BEProveedor>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAProveedor odaProveedor = new DAProveedor();
                    lobeProveedor = odaProveedor.fListarDesabilitados(con);
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



        public bool EliminarProveedor(BEProveedor obeProveedor) // PARA DESABLITAR UN PRODUCTO
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAProveedor odaProveedor = new DAProveedor();
                    exito = odaProveedor.fEliminarProveedor(con, obeProveedor);
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


        public bool ActivarPriveedor(BEProveedor obeProveedor) // para activar el producto desabilitado 
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAProveedor odaProveedor = new DAProveedor();
                    exito = odaProveedor.fActualizarProveedor(con, obeProveedor);
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







        public int AdicionarProveddor(BEProveedor obeProveedor) // para inserta productos 
        {
            int N = -1;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAProveedor odaProveedor = new DAProveedor();
                    N = odaProveedor.fAdicionarPriveedor(con, obeProveedor);
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


        public bool ActualizarProveedor(BEProveedor obeProveedor) // para actialuzar produscto
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAProveedor odaProveedor = new DAProveedor();
                    exito = odaProveedor.fActualizarProveedor(con, obeProveedor);

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
