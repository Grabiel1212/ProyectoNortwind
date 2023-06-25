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
                    }
                    lobeEmpleado.Add(obeEmpleado);
                }
                drd.Close();
            }
            return (lobeEmpleado);
        }
    }
}
