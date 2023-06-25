using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBusinessEntities
{
    public class BEEmpleado
    {
        private int codigo;
        private String apellido;
        private String nombre;
        private DateTime fechaNac;

        public BEEmpleado()
        {

        }

        public BEEmpleado(int codigo, string apellido, string nombre, DateTime fechaNac)
        {
            this.codigo = codigo;
            this.apellido = apellido;
            this.nombre = nombre;
            this.fechaNac = fechaNac;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    }
}
