using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }  
        public double Salario { get; set; }
        //clave foranea
        public int IdEmpresa { get; set; }

        public void getDatosEmpleado()
        {
            Console.WriteLine($"Empleado {Nombre} con Id {Id}, cargo {Cargo} con salario {Salario} y pertenece a la empresa {IdEmpresa}");
        }
    }
}
