using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Contacto
    {
        public string? Name { get; set; }
        public int Number { get; set; }
        public string? Address { get; set; }

        public void Prueba()
        {
            var contactos = new List<Contacto>()
        {
            new Contacto(){Name = "Luis", Number = 666, Address = "Ecatepec"},
            new Contacto(){Name = "Marisol", Number = 234, Address = "Cd. Mx."},
            new Contacto(){Name = "Daniel", Number = 800, Address = "Coacalco"},
            new Contacto(){Name = "Cesar", Number = 158, Address = "Tulpetlac"}
        };


            //var names = contactos.Where(b => b.Name == "Daniel").Select(b => new { b.Name, b.Number, b.Address });


            foreach (var n in contactos.Where(b => b.Name == "Marisol"))
                Console.WriteLine($"{n.Name} {n.Number} {n.Address}");


            //Imprime todos los nombres de la lista
            contactos.ForEach(b => Console.WriteLine(b.Name));
        }
    }
}
