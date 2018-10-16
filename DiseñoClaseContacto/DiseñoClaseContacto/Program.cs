using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoClaseContacto
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto c1 = new Contacto("Unai", new DateTime(0199,11,1));
            Console.WriteLine(c1.GetFechaNacimiento().ToString("dd/mm/yyyy"));
            
            Console.ReadLine();
        }
    }
}
