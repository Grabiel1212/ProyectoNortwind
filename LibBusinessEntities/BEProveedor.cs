using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBusinessEntities
{
    public class BEProveedor
    {
        private int codigo;
        private String nombre;
        private String contacto;
        private String direccion;
        private String paiz;

        public BEProveedor()
        {
        }

        public BEProveedor(int codigo, string nombre, string contacto, string direccion, string paiz)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.contacto = contacto;
            this.direccion = direccion;
            this.paiz = paiz;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Paiz { get => paiz; set => paiz = value; }
    }
}
