using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using LibBusinessEntities;
using LibDataAccess;
using System.Data.SqlClient;

namespace LibBusinessRules
{
    public class BREmpleado
    {
        private string strConexion;

        public BREmpleado()
        {
            System.Configuration.AppSettingsReader asr = new
            System.Configuration.AppSettingsReader();
            strConexion = (string)asr.GetValue("conNW", Type.GetType("System.String"));
        }

        public List<BEEmpleado> Listar()
        {
            List<BEEmpleado> lobeEmpleado = new List<BEEmpleado>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAEmpleado odaEmpleado = new DAEmpleado();
                    lobeEmpleado = odaEmpleado.fListar(con);
                }
                catch (Exception ex)
                {
                    // Grabar el Log de error
                    lobeEmpleado = null;
                }
                finally
                {
                    con.Close();
                }
            }
            return (lobeEmpleado);
        }
        //public List<BEEmpleado> ListarProducActivados(int val) // PAR LISTAR PRODUCTO ABILITADOS Y DESABILITADOS 
        //{
        //    List<BEEmpleado> lobeEmpleado = new List<BEEmpleado>();
        //    using (SqlConnection con = new SqlConnection(strConexion))
        //    {
        //        try
        //        {
        //            con.Open();
        //            DAEmpleado odaEmpleado = new DAEmpleado();
        //            lobeEmpleado = odaEmpleado.fValidarProductoAc(con, val);
        //        }
        //        catch (Exception ex)
        //        {
        //            // Grabar el Log de error
        //            lobeEmpleado = null;
        //        }
        //        finally
        //        {
        //            con.Close();
        //        }
        //    }
        //    return (lobeEmpleado);
        //}

        public List<BEEmpleado> ListarInactivos()
        {
            List<BEEmpleado> lobeEmpleado = new List<BEEmpleado>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAEmpleado odaEmpleado = new DAEmpleado();
                    lobeEmpleado = odaEmpleado.fListarInacticos(con);
                }
                catch (Exception ex)
                {
                    // Grabar el Log de error
                    lobeEmpleado = null;
                }
                finally
                {
                    con.Close();
                }
            }
            return (lobeEmpleado);
        }






        public bool EliminarEmpl(BEEmpleado obeEmpleado) // PARA DESABLITAR UN PRODUCTO
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAEmpleado odaEmpleado = new DAEmpleado();
                    exito = odaEmpleado.fEliminar(con, obeEmpleado);
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

        public bool ActivarEmpl(BEEmpleado obeEmpleado) // para activar el producto desabilitado 
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAEmpleado odaEmpleado = new DAEmpleado();
                    exito = odaEmpleado.fActivarProduc(con, obeEmpleado);
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
     


        public int InsertarEmpleados(BEEmpleado obeEmpleado) // para inserta productos 
        {
            int N = -1;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAEmpleado odaEmpleado = new DAEmpleado();
                    N = odaEmpleado.fAinsertarEmpleados(con, obeEmpleado);
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


        public bool Actualizar(BEEmpleado obeEmpleado) // para actialuzar produscto
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAEmpleado odaEmpleado = new DAEmpleado();
                    exito = odaEmpleado.fActualizar(con, obeEmpleado);

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
