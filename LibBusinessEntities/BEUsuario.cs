using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibBusinessEntities
{
    public class BEUsuario
    {
        private int codigo;
        private String nombreUsuario;
        private String passwordUsuario;
        private String nombre;
        private String apellido;
        private int estado;
        private String ocupacion;

        public BEUsuario()
        {
        }

        public BEUsuario(int codigo, string nombreUsuario, string passwordUsuario, string nombre, string apellido, int estado, string ocupacion)
        {
            this.codigo = codigo;
            this.nombreUsuario = nombreUsuario;
            this.passwordUsuario = passwordUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.estado = estado;
            this.ocupacion = ocupacion;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string PasswordUsuario { get => passwordUsuario; set => passwordUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Ocupacion { get => ocupacion; set => ocupacion = value; }
    }
}
