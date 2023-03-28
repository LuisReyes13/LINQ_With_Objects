using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class ControlEmpresasEmpleados
    {
        public ControlEmpresasEmpleados()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google"});
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Youtube"});

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Oswe", Cargo = "ET", IdEmpresa = 1, Salario = 10000});
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Slider", Cargo = "ET", IdEmpresa = 2, Salario = 10001});
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Daniel", Cargo = "Co-ET", IdEmpresa = 1, Salario = 10002});
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Cesar", Cargo = "Co-ET", IdEmpresa = 2, Salario = 10003});
        }
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public void getCEO()
        {
            IEnumerable<Empleado> ceos = from e in listaEmpleados where e.Cargo == "CEO" select e;
        }
    }
}
