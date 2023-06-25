using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBusinessEntities
{
    public class BEProducto
    {
        private int codigo;
        private String nombre;
        private int idProveedor;
        private int idCategoria;
        private Decimal precioUni;
        private Int16 stock;

        public BEProducto()
        {
        }

        public BEProducto(int codigo, string nombre, int idProveedor, int idCategoria, Decimal precioUni, short stock)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.idProveedor = idProveedor;
            this.idCategoria = idCategoria;
            this.precioUni = precioUni;
            this.stock = stock;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public Decimal PrecioUni { get => precioUni; set => precioUni = value; }
        public short Stock { get => stock; set => stock = value; }
    }
}
