﻿using System;
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

        public BEProveedor()
        {
        }

        public BEProveedor(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}