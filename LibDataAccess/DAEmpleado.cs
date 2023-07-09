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
    public class DAEmpleado
    {
        public List<BEEmpleado> fListar(SqlConnection con)
        {
            List<BEEmpleado> lobeEmpleado = new List<BEEmpleado>();
            SqlCommand cmd = new SqlCommand("uspEmployeesListado", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 60;
            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
            if (drd != null)
            {
                int posCodigo = drd.GetOrdinal("EmployeeID");
                int posApellido = drd.GetOrdinal("LastName");
                int posNombre = drd.GetOrdinal("FirstName");
                int posFechaNac = drd.GetOrdinal("BirthDate");
                int posDireccion = drd.GetOrdinal("Address");
                int posPais = drd.GetOrdinal("country");
                BEEmpleado obeEmpleado;
                while (drd.Read())
                {
                    obeEmpleado = new BEEmpleado();
                    {
                        var withBlock = obeEmpleado;
                        withBlock.Codigo = drd.GetInt32(posCodigo);
                        withBlock.Apellido = drd.GetString(posApellido);
                        withBlock.Nombre = drd.GetString(posNombre);
                        withBlock.FechaNac = drd.GetDateTime(posFechaNac);
                        withBlock.Direccion1= drd.GetString(posDireccion);
                        withBlock.Pais = drd.GetString(posPais);
                    }
                    lobeEmpleado.Add(obeEmpleado);
                }
                drd.Close();
            }
            return (lobeEmpleado);
        }
        //public List<BEEmpleado> fValidarProductoAc(SqlConnection con, int val)// PARA VER SI ESTA ABILITADO O DESABILITADO
        //{
        //    List<BEEmpleado> objEmpleado = new List<BEEmpleado>();
        //    SqlCommand cmd = new SqlCommand("uspEmployeesAct", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("@activado", SqlDbType.VarChar, 20).Value = val;
        //    cmd.CommandTimeout = 60;
        //    SqlDataReader leer = cmd.ExecuteReader(CommandBehavior.SingleResult);
        //    if (leer != null)
        //    {
        //        int posCodigo = leer.GetOrdinal("EmployeeID");
        //        int posApellido = leer.GetOrdinal("LastName");
        //        int posNombre = leer.GetOrdinal("FirstName");
        //        int posFechaNac = leer.GetOrdinal("BirthDate");
        //        int posDireccion = leer.GetOrdinal("Address");
        //        int posPais = leer.GetOrdinal("country");
        //        BEEmpleado obeEmpleado;

        //        while (leer.Read())
        //        {
        //            obeEmpleado = new BEEmpleado();
        //            {
        //                var withBlock = obeEmpleado;
        //                withBlock.Codigo = leer.GetInt32(posCodigo);
        //                withBlock.Nombre = leer.GetString(posNombre);
        //                withBlock.Apellido = leer.GetString(posApellido);
        //                withBlock.FechaNac = leer.GetDateTime(posFechaNac);
        //                withBlock.Direccion1 = leer.GetString(posDireccion);
        //                withBlock.Pais = leer.GetString(posPais);
        //            }
        //            objEmpleado.Add(obeEmpleado);
        //        }
        //        leer.Close();
        //    }
        //    return (objEmpleado);
        //}

        public List<BEEmpleado> fListarInacticos(SqlConnection con)
        {
            List<BEEmpleado> lobeEmpleado = new List<BEEmpleado>();
            SqlCommand cmd = new SqlCommand("uspEmployeesListadoInhab", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 60;
            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
            if (drd != null)
            {
                int posCodigo = drd.GetOrdinal("EmployeeID");
                int posApellido = drd.GetOrdinal("LastName");
                int posNombre = drd.GetOrdinal("FirstName");
                int posFechaNac = drd.GetOrdinal("BirthDate");
                int posDireccion = drd.GetOrdinal("Address");
                int posPais = drd.GetOrdinal("country");
                BEEmpleado obeEmpleado;
                while (drd.Read())
                {
                    obeEmpleado = new BEEmpleado();
                    {
                        var withBlock = obeEmpleado;
                        withBlock.Codigo = drd.GetInt32(posCodigo);
                        withBlock.Apellido = drd.GetString(posApellido);
                        withBlock.Nombre = drd.GetString(posNombre);
                        withBlock.FechaNac = drd.GetDateTime(posFechaNac);
                        withBlock.Direccion1 = drd.GetString(posDireccion);
                        withBlock.Pais = drd.GetString(posPais);
                    }
                    lobeEmpleado.Add(obeEmpleado);
                }
                drd.Close();
            }
            return (lobeEmpleado);
        }


        public bool fEliminar(SqlConnection con, BEEmpleado obeEmpleado) // para desabilitar un produscto
        {
            bool Exito = false;
            SqlCommand cmd = new SqlCommand("uspEmployeesDel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = cmd.Parameters.Add("@EmployeeID", SqlDbType.Int);
            par.Direction = ParameterDirection.Input;
            par.Value = obeEmpleado.Codigo;
            int N = cmd.ExecuteNonQuery();
            Exito = (N > 0);
            return (Exito);
        }
        public bool fActivarProduc(SqlConnection con, BEEmpleado obeEmpleado) // para valitar un producto
        {
            bool Exito = false;
            SqlCommand cmd = new SqlCommand("uspEmployeesAct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = cmd.Parameters.Add("@EmployeeID", SqlDbType.Int);
            par.Direction = ParameterDirection.Input;
            par.Value = obeEmpleado.Codigo;
            int N = cmd.ExecuteNonQuery();
            Exito = (N > 0);
            return (Exito);
        }
       


        public int fAinsertarEmpleados(SqlConnection con, BEEmpleado obeEmpleado) // para insertar nuevas categorias
        {
            int N = -1;
            SqlCommand cmd = new SqlCommand("uspEmployeesIns", con);
            cmd.CommandType = CommandType.StoredProcedure;


            SqlParameter par1 = cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 20);
            par1.Direction = ParameterDirection.Input;
            par1.Value = obeEmpleado.Nombre;

            SqlParameter par2 = cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 10);
            par2.Direction = ParameterDirection.Input;
            par2.Value = obeEmpleado.Apellido;

            SqlParameter par3 = cmd.Parameters.Add("@BirthDate", SqlDbType.DateTime);
            par3.Direction = ParameterDirection.Input;
            par3.Value = obeEmpleado.FechaNac;

            SqlParameter par4 = cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 60);
            par4.Direction = ParameterDirection.Input;
            par4.Value = obeEmpleado.Direccion1;

            SqlParameter par5 = cmd.Parameters.Add("@country", SqlDbType.NVarChar, 15);
            par5.Direction = ParameterDirection.Input;
            par5.Value = obeEmpleado.Pais;

            SqlParameter par6 = cmd.Parameters.Add("@@identity", SqlDbType.Int);
            par6.Direction = ParameterDirection.ReturnValue;

            N = cmd.ExecuteNonQuery();
            if (N > 0)
                return ((int)par6.Value);
            else
                return (-1);
        }





        public bool fActualizar(SqlConnection con, BEEmpleado obeEmpleado) // para actualizar los productos 
        {
            bool Exito = false;
            SqlCommand cmd = new SqlCommand("uspEmployeesUpd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par0 = cmd.Parameters.Add("@EmployeeID", SqlDbType.Int);
            par0.Direction = ParameterDirection.Input;
            par0.Value = obeEmpleado.Codigo;
            SqlParameter par1 = cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 20);
            par1.Direction = ParameterDirection.Input;
            par1.Value = obeEmpleado.Nombre;
            SqlParameter par2 = cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 10);
            par2.Direction = ParameterDirection.Input;
            par2.Value = obeEmpleado.Apellido;
            SqlParameter par3 = cmd.Parameters.Add("@BirthDate", SqlDbType.DateTime);
            par3.Direction = ParameterDirection.Input;
            par3.Value = obeEmpleado.FechaNac;
            SqlParameter par4 = cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 60);
            par4.Direction = ParameterDirection.Input;
            par4.Value = obeEmpleado.Direccion1;
            SqlParameter par5 = cmd.Parameters.Add("@country", SqlDbType.NVarChar, 15);
            par5.Direction = ParameterDirection.Input;
            par5.Value = obeEmpleado.Pais;
            SqlParameter par6 = cmd.Parameters.Add("@@identity", SqlDbType.Int);
            par6.Direction = ParameterDirection.ReturnValue;
            int N = cmd.ExecuteNonQuery();
            Exito = (N > 0);
            return (Exito);
        }

    }
}
