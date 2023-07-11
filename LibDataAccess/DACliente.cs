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
    public  class DACliente
    {


       
            public List<BEEClientes> ListarClientes(SqlConnection con)
            {
                List<BEEClientes> listaClientes = new List<BEEClientes>();
                SqlCommand cmd = new SqlCommand("uspCustomersListado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 60;
                SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (drd != null)
                {
                    int posCustomerID = drd.GetOrdinal("CustomerID");
                    int posCompanyName = drd.GetOrdinal("CompanyName");
                    int posContactName = drd.GetOrdinal("ContactName");
                    int posAddress = drd.GetOrdinal("Address");
                    int posCity = drd.GetOrdinal("City");
                    int posCountry = drd.GetOrdinal("Country");
                    BEEClientes cliente;
                    while (drd.Read())
                    {
                        cliente = new BEEClientes();
                        {
                            var withBlock = cliente;
                            withBlock.IdCliente = drd.GetString(posCustomerID);
                            withBlock.Compania = drd.GetString(posCompanyName);
                            withBlock.Contacto = drd.GetString(posContactName);
                            withBlock.Direccion = drd.GetString(posAddress);
                            withBlock.Ciudad = drd.GetString(posCity);
                            withBlock.Paiz = drd.GetString(posCountry);
                        }
                        listaClientes.Add(cliente);
                    }
                    drd.Close();
                }
                return listaClientes;
            }

            public List<BEEClientes> ListarClientesInhab(SqlConnection con)
            {
                List<BEEClientes> listaClientes = new List<BEEClientes>();
                SqlCommand cmd = new SqlCommand("uspCustomersInhab", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 60;
                SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (drd != null)
                {
                    int posCustomerID = drd.GetOrdinal("CustomerID");
                    int posCompanyName = drd.GetOrdinal("CompanyName");
                    int posContactName = drd.GetOrdinal("ContactName");
                    int posAddress = drd.GetOrdinal("Address");
                    int posCity = drd.GetOrdinal("City");
                    int posCountry = drd.GetOrdinal("Country");
                    BEEClientes cliente;
                    while (drd.Read())
                    {
                        cliente = new BEEClientes();
                        {
                            var withBlock = cliente;
                            withBlock.IdCliente = drd.GetString(posCustomerID);
                            withBlock.Compania = drd.GetString(posCompanyName);
                            withBlock.Contacto = drd.GetString(posContactName);
                            withBlock.Direccion = drd.GetString(posAddress);
                            withBlock.Ciudad = drd.GetString(posCity);
                            withBlock.Paiz = drd.GetString(posCountry);
                        }
                        listaClientes.Add(cliente);
                    }
                    drd.Close();
                }
                return listaClientes;
            }

            public bool EliminarCliente(SqlConnection con, BEEClientes idCliente)
            {
                bool exito = false;
                SqlCommand cmd = new SqlCommand("uspCustomersDel", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter par = cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar, 7);
                par.Direction = ParameterDirection.Input;
                par.Value = idCliente.IdCliente;
                int n = cmd.ExecuteNonQuery();
                exito = (n > 0);
                return exito;
            }

            public bool ActivarCliente(SqlConnection con, BEEClientes idCliente)
            {
                bool exito = false;
                SqlCommand cmd = new SqlCommand("uspCustomersAct", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter par = cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar, 7);
                par.Direction = ParameterDirection.Input;
                par.Value = idCliente.IdCliente;
                int n = cmd.ExecuteNonQuery();
                exito = (n > 0);
                return exito;
            }

            public void InsertarCliente(SqlConnection con, BEEClientes cliente)
            {
                SqlCommand cmd = new SqlCommand("uspCustomersIns", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter par1 = cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar, 7);
                par1.Direction = ParameterDirection.Input;
                par1.Value = cliente.IdCliente;
                SqlParameter par2 = cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 60);
                par2.Direction = ParameterDirection.Input;
                par2.Value = cliente.Compania;
                SqlParameter par3 = cmd.Parameters.Add("@ContactName", SqlDbType.NVarChar, 60);
                par3.Direction = ParameterDirection.Input;
                par3.Value = cliente.Contacto;
                SqlParameter par4 = cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 30);
                par4.Direction = ParameterDirection.Input;
                par4.Value = cliente.Direccion;
                SqlParameter par5 = cmd.Parameters.Add("@City", SqlDbType.NVarChar, 30);
                par5.Direction = ParameterDirection.Input;
                par5.Value = cliente.Ciudad;
                SqlParameter par6 = cmd.Parameters.Add("@Country", SqlDbType.NVarChar, 30);
                par6.Direction = ParameterDirection.Input;
                par6.Value = cliente.Paiz;
               
               cmd.ExecuteNonQuery();
                
               
            }

            public bool ActualizarCliente(SqlConnection con, BEEClientes cliente)
            {
                bool exito = false;
                SqlCommand cmd = new SqlCommand("uspCustomersUpd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter par1 = cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar, 7);
                par1.Direction = ParameterDirection.Input;
                par1.Value = cliente.IdCliente;
                SqlParameter par2 = cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 60);
                par2.Direction = ParameterDirection.Input;
                par2.Value = cliente.Compania;
                SqlParameter par3 = cmd.Parameters.Add("@ContactName", SqlDbType.NVarChar, 60);
                par3.Direction = ParameterDirection.Input;
                par3.Value = cliente.Contacto;
                SqlParameter par4 = cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 30);
                par4.Direction = ParameterDirection.Input;
                par4.Value = cliente.Direccion;
                SqlParameter par5 = cmd.Parameters.Add("@City", SqlDbType.NVarChar, 30);
                par5.Direction = ParameterDirection.Input;
                par5.Value = cliente.Ciudad;
                SqlParameter par6 = cmd.Parameters.Add("@Country", SqlDbType.NVarChar, 30);
                par6.Direction = ParameterDirection.Input;
                par6.Value = cliente.Paiz;
                int n = cmd.ExecuteNonQuery();
                exito = (n > 0);
                return exito;
            }
        }




    
}
