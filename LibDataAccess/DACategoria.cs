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
    public class DACategoria
    {
        public List<BECategoria> fListar(SqlConnection con)
        {
            List<BECategoria> lobeCategoria = new List<BECategoria>();
            SqlCommand cmd = new SqlCommand("uspCategoriesListado", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 60;
            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
            if (drd != null)
            {
                int posCodigo = drd.GetOrdinal("CategoryId");
                int posNombre = drd.GetOrdinal("CategoryName");
                int posDescripcion = drd.GetOrdinal("Description");

                BECategoria obeCategoria;
                while (drd.Read())
                {
                    obeCategoria = new BECategoria();
                    {
                        var withBlock = obeCategoria;
                        withBlock.Codigo = drd.GetInt32(posCodigo);
                        withBlock.Nombre = drd.GetString(posNombre);
                        withBlock.Descripcion = drd.GetString(posDescripcion);
                    }
                    lobeCategoria.Add(obeCategoria);
                }
                drd.Close();
            }
            return (lobeCategoria);
        }


        public List<BECategoria> fListarInhabcate(SqlConnection con)
        {
            List<BECategoria> lobeCategoria = new List<BECategoria>();
            SqlCommand cmd = new SqlCommand("uspCategoriesdesacticados", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 60;
            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
            if (drd != null)
            {

                int posCodigo = drd.GetOrdinal("CategoryId");
                int posNombre = drd.GetOrdinal("CategoryName");
                int posDescripcion = drd.GetOrdinal("Description");
                BECategoria obeCategoria;
                while (drd.Read())
                {
                    obeCategoria = new BECategoria();
                    {
                        var withBlock = obeCategoria;
                        withBlock.Codigo = drd.GetInt32(posCodigo);
                        withBlock.Nombre = drd.GetString(posNombre);
                        withBlock.Descripcion = drd.GetString(posDescripcion);
                    }
                    lobeCategoria.Add(obeCategoria);
                }
                drd.Close();
            }
            return (lobeCategoria);
        }

        public int fAinsertarCategoria(SqlConnection con, BECategoria obeCategoria) // para insertar nuevas categorias
        {
            int N = -1;
            SqlCommand cmd = new SqlCommand("uspCategoriesIns", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter par1 = cmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar, 40);
            par1.Direction = ParameterDirection.Input;
            par1.Value = obeCategoria.Nombre;
            SqlParameter par2 = cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 40);
            par2.Direction = ParameterDirection.Input;
            par2.Value = obeCategoria.Descripcion;

            SqlParameter par3 = cmd.Parameters.Add("@@identity", SqlDbType.Int);
            par3.Direction = ParameterDirection.ReturnValue;
            N = cmd.ExecuteNonQuery();
            if (N > 0)
                return ((int)par3.Value);
            else
                return (-1);
        }


        public bool fActualizarCategorias(SqlConnection con, BECategoria obeCategoria) // para actualizar las categorias
        {
            bool Exito = false;
            SqlCommand cmd = new SqlCommand("uspCategoriesUpd", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter par0 = cmd.Parameters.Add("CategoryId", SqlDbType.Int);
            par0.Direction = ParameterDirection.Input;
            par0.Value = obeCategoria.Codigo;

            SqlParameter par1 = cmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar, 40);
            par1.Direction = ParameterDirection.Input;
            par1.Value = obeCategoria.Nombre;

            SqlParameter par2 = cmd.Parameters.Add("@Description ", SqlDbType.NVarChar, 40);
            par2.Direction = ParameterDirection.Input;
            par2.Value = obeCategoria.Descripcion;


            int N = cmd.ExecuteNonQuery();
            Exito = (N > 0);
            return (Exito);
        }



        public bool fEliminarCategoria(SqlConnection con, BECategoria obeCategoria) // para desabilitar una categoria
        {
            bool Exito = false;
            SqlCommand cmd = new SqlCommand("uspCategoriesDel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = cmd.Parameters.Add("@CategoryId", SqlDbType.Int);
            par.Direction = ParameterDirection.Input;
            par.Value = obeCategoria.Codigo;
            int N = cmd.ExecuteNonQuery();
            Exito = (N > 0);
            return (Exito);
        }

        public bool fActivarCategoria(SqlConnection con, BECategoria obeCategoria) // para activar una categoria
        {
            bool Exito = false;
            SqlCommand cmd = new SqlCommand("uspCategoriesAct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = cmd.Parameters.Add("@CategoryId", SqlDbType.Int);
            par.Direction = ParameterDirection.Input;
            par.Value = obeCategoria.Codigo;
            int N = cmd.ExecuteNonQuery();
            Exito = (N > 0);
            return (Exito);
        }




       





    }
}
