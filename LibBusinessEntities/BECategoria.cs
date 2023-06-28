using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBusinessEntities
{
    public class BECategoria
    {
        
        private int codigo;
        private String nombre;
        private String descripcion;

        public BECategoria()
        {
        }

        public BECategoria(int codigo, string nombre, string descripcion)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
