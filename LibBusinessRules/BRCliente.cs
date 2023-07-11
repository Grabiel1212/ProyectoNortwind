using LibBusinessEntities;
using LibDataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBusinessRules
{
    public  class BRCliente
    {


        private string strConexion;

        public BRCliente()
        {
            System.Configuration.AppSettingsReader asr = new
            System.Configuration.AppSettingsReader();
            strConexion = (string)asr.GetValue("conNW", Type.GetType("System.String"));
        }



        public List<BEEClientes> Listar()
        {
            List<BEEClientes> lobeclientes = new List<BEEClientes>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DACliente odaCliente = new DACliente();
                    lobeclientes = odaCliente.ListarClientes(con);
                }
                catch (Exception ex)
                {
                    // Grabar el Log de error
                    lobeclientes = null;
                }
                finally
                {
                    con.Close();
                }
            }
            return (lobeclientes);
        }





        public List<BEEClientes> ListarCLientesInhabi()
        {
            List<BEEClientes> lobeclientes = new List<BEEClientes>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DACliente odaCliente = new DACliente();
                    lobeclientes = odaCliente.ListarClientesInhab(con);
                }
                catch (Exception ex)
                {
                    //Grabar el Log de error
                    lobeclientes = null;
                }
                finally
                {
                    con.Close();
                }
            }
            return (lobeclientes);
        }

        public bool EliminarClientes(BEEClientes obeClientes) // PARA DESABLITAR UN PRODUCTO
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DACliente odaCliente = new DACliente();
                    exito = odaCliente.EliminarCliente(con, obeClientes);
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

        public bool ActivarCliente(BEEClientes obeClientes) // para activar el producto desabilitado 
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DACliente odaCliente = new DACliente();
                    exito = odaCliente.ActivarCliente(con, obeClientes);
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







        public int AdicionarCliente(BEEClientes obeClientes) // para inserta productos 
        {
            int N = -1;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DACliente odaCliente = new DACliente();
                  odaCliente.InsertarCliente(con, obeClientes);
                }
                catch (Exception ex)
                {
                
                }
                finally
                {
                    con.Close();
                }
            }
            return (N);
        }


        public bool ActualizarCliente(BEEClientes obeClientes) // para actialuzar produscto
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DACliente odaCliente = new DACliente();
                    exito = odaCliente.ActualizarCliente(con, obeClientes);

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
