﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int IdMarca { get; set; }
        
        public string Nombre { get; set; }
        
        public Marca()
        {

        }

        public Marca(string nombre)
        {
            Nombre = nombre;
        }

        public Marca (int id, string nombre)
        {
            IdMarca = id;
            Nombre = nombre;
        }
    
    }
}
