﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void getDatosEmpresa()
        {
            Console.WriteLine($"Empresa {Nombre} con Id {Id}");
        }
    }
}
