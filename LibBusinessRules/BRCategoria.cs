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
    public class BRCategoria
    {
        private string strConexion;

        public BRCategoria()
        {
            System.Configuration.AppSettingsReader asr = new
            System.Configuration.AppSettingsReader();
            strConexion = (string)asr.GetValue("conNW", Type.GetType("System.String"));
        }

        public List<BECategoria> Listar()
        {
            List<BECategoria> lobeCategoria = new List<BECategoria>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DACategoria odaCategoria = new DACategoria();
                    lobeCategoria = odaCategoria.fListar(con);
                }
                catch (Exception ex)
                {
                    // Grabar el Log de error
                    lobeCategoria = null;
                }
                finally
                {
                    con.Close();
                }
            }
            return (lobeCategoria);
        }



        public List<BECategoria> ListarcateInabilitados()
        {
            List<BECategoria> lobeCategoria = new List<BECategoria>();
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DACategoria odaCategoria = new DACategoria();
                    lobeCategoria = odaCategoria.fListarInhabcate(con);
                }
                catch (Exception ex)
                {
                    // Grabar el Log de error
                    lobeCategoria = null;
                }
                finally
                {
                    con.Close();
                }
            }
            return (lobeCategoria);
        }





        public int InsertarCategoria(BECategoria obeCategoria) // para inserta productos 
        {
            int N = -1;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DACategoria odaCategoria = new DACategoria();
                    N = odaCategoria.fAinsertarCategoria(con, obeCategoria);
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


        public bool ActualizarCategorias(BECategoria obeCategoria) // para actialuzar una categoria
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DACategoria odaCategoria = new DACategoria();
                    exito = odaCategoria.fActualizarCategorias(con, obeCategoria);

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


        public bool EliminarCategoria(BECategoria obeCategoria) // PARA DESABLITAR o melimnoar una categoria
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DACategoria odaCategoria = new DACategoria();
                    exito = odaCategoria.fEliminarCategoria(con, obeCategoria);
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

        public bool ActivarCategoria(BECategoria obeCategoria) // para activar la categoria desabilitado 
        {
            bool exito = false;
            using (SqlConnection con = new SqlConnection(strConexion))
            {
                try
                {
                    con.Open();
                    DACategoria odaCategoria = new DACategoria();
                    exito = odaCategoria.fActivarCategoria(con, obeCategoria);
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
