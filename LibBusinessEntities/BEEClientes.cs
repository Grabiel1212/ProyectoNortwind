using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBusinessEntities
{
    public class BEEClientes
    {

        private String idCliente;
        private String compania;
        private String contacto;
        private String direccion;
        private String ciudad;
        private String paiz;

        public BEEClientes()
        {
        }

        public BEEClientes(string idCliente, string compania, string contacto, string direccion, string ciudad, string paiz)
        {
            this.idCliente = idCliente;
            this.compania = compania;
            this.contacto = contacto;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.paiz = paiz;
        }

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string Compania { get => compania; set => compania = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Paiz { get => paiz; set => paiz = value; }
    }
}
