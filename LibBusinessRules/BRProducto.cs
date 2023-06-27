using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibBusinessEntities;
using LibDataAccess;
using System.Data.SqlClient;
using System.Reflection;
using System.Security.Cryptography;

namespace LibBusinessRules
{
    public class BRProducto
    {
        private string strConexion;

        public BRProducto()
        {
            System.Configuration.AppSettingsReader asr = new
            System.Configuration.AppSettingsReader();
            strConexion = (string)asr.GetValue("conNW", Type.GetType("System.String"));
        }

        public List<BEProducto> Listar()
        {
            List<BEProducto> lobeProducto = new List<BEProducto>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAProducto odaProducto = new DAProducto();
                    lobeProducto = odaProducto.fListar(con);
                }
                catch (Exception ex)
                {
                    // Grabar el Log de error
                    lobeProducto = null;
                }
                finally
                {
                    con.Close();
                }
            }
            return (lobeProducto);
        }



        public List<BEProducto> ListarProducActivados(int val) // PAR LISTAR PRODUCTO ABILITADOS Y DESABILITADOS 
        {
            List<BEProducto> lobeProducto = new List<BEProducto>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAProducto odaProducto = new DAProducto();
                    lobeProducto = odaProducto.fValidarProductoAc(con, val);
                }
                catch (Exception ex)
                {
                    // Grabar el Log de error
                    lobeProducto = null;
                }
                finally
                {
                    con.Close();
                }
            }
            return (lobeProducto);
        }

        //public List<BEProducto> ListarInhabi()
        //{
        //    List<BEProducto> lobeProducto = new List<BEProducto>();
        //    using (SqlConnection con = new SqlConnection(strConexion))
        //    {
        //        try
        //        {
        //            con.Open();
        //            DAProducto odaProducto = new DAProducto();
        //            lobeProducto = odaProducto.fListarInhab(con);
        //        }
        //        catch (Exception ex)
        //        {
        //            Grabar el Log de error
        //           lobeProducto = null;
        //        }
        //        finally
        //        {
        //            con.Close();
        //        }
        //    }
        //    return (lobeProducto);
        //}

        public bool EliminarProd(BEProducto obeProducto) // PARA DESABLITAR UN PRODUCTO
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAProducto odaProducto = new DAProducto();
                    exito = odaProducto.fEliminar(con, obeProducto);
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

        public bool ActivarProduc(BEProducto obeProducto) // para activar el producto desabilitado 
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAProducto odaProducto = new DAProducto();
                    exito = odaProducto.fActivarProduc(con, obeProducto);
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







        public int Adicionar(BEProducto obeProducto) // para inserta productos 
        {
            int N = -1;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAProducto odaProducto = new DAProducto();
                    N = odaProducto.fAdicionar(con, obeProducto);
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


        public bool Actualizar(BEProducto obeProducto) // para actialuzar produscto
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DAProducto odaProducto = new DAProducto();
                    exito = odaProducto.fActualizar(con, obeProducto);
                 
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
