using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBusinessEntities
{
    public  class BEPedido
    {
        private int codigoOrden;
        private String idCliente;
        private int  idEmpleado;
        private DateTime fechaOrden;
        private String direccionEnvio;
      

        public BEPedido()
        {
        }

        public BEPedido(int codigoOrden, string idCliente, int idEmpleado, DateTime fechaOrden, string direccionEnvio)
        {
            this.codigoOrden = codigoOrden;
            this.idCliente = idCliente;
            this.idEmpleado = idEmpleado;
            this.fechaOrden = fechaOrden;
            this.direccionEnvio = direccionEnvio;
        }

        public int CodigoOrden { get => codigoOrden; set => codigoOrden = value; }
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public DateTime FechaOrden { get => fechaOrden; set => fechaOrden = value; }
        public string DireccionEnvio { get => direccionEnvio; set => direccionEnvio = value; }
    }
}
