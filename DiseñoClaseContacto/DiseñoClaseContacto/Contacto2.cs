using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoClaseContacto
{
    class Contacto2
    {
        private string nombre, telefono;
        private DateTime fechaNacimiento;
        private string type;
        private static int count;
        private static int familyNumber = 0;
        private static int friendNumber = 0;
        private static int colleagueNumber = 0;
        private static int uniMateNumber = 0;
        private static int numberContact = 0;






        public Contacto2(string nombre, string telefono, DateTime fechaNacimiento, string type)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
            this.type = type;

            //Console.WriteLine("Choose:");
            //Console.WriteLine("family");
            //Console.WriteLine("colleague");
            //Console.WriteLine("uniMate");

            switch (type)
            {
                case "family":
                    familyNumber++;
                    Console.WriteLine("Family friends: " + familyNumber);
                    break;
                case "colleague":
                    colleagueNumber++;
                    Console.WriteLine("Colleagues: " + colleagueNumber);
                    break;
                case "uniMate":
                    uniMateNumber++;
                    Console.WriteLine("Uni mates: " + uniMateNumber);
                    break;
                default:
                    friendNumber++;
                    Console.WriteLine("Just a friend: " + friendNumber);
                    break;

            }
            numberContact++;
            Console.WriteLine("Total number of friends: " + numberContact);
            Console.WriteLine(type);

        }
        public Contacto2(string nombre, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            int yearToday = DateTime.Today.Year;
            int fecha = fechaNacimiento.Year;

            int edad = yearToday - fecha;
            if (edad > 120 || edad < 0)
            {
                SetFechaNacimiento(DateTime.Today);

            }
            count++;
        }
        public Contacto2(string nombre, string telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            fechaNacimiento = DateTime.Now;
            count++;
        }

        //GETTERS Y SETTERS

        public string GetNombre()
        {
            return this.nombre;
        }
        public void CambiarNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string DevolverTelefono()
        {
            return this.telefono;
        }
        public void CambiarTelefono(string telefono)
        {
            this.telefono = telefono;
        }
        public DateTime GetFechaNacimiento()
        {
            return this.fechaNacimiento;
        }
        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public string ObtenerTipo()
        {
            return this.type;
        }
        public void CambiarTipo(string type)
        {
            this.type = type;
        }
        public static int ObtenerNumContactos()
        {
            return numberContact;
        }
        public int ObtenerNumFamiliares()
        {
            return familyNumber;
        }
        public int ObtenerNumAmigos()
        {
            return friendNumber;
        }
        public int ObtenerNumTrabajo()
        {
            return colleagueNumber;
        }
        public int ObtenerNumEstudios()
        {
            return uniMateNumber;
        }
        //Methods
        public int ObtenerEdad()
        {
            int yearToday = DateTime.Today.Year;
            int fecha = this.fechaNacimiento.Year;

            int edad = yearToday - fecha;
            return edad;

        }
        public string Felicitara()
        {
            return "Feliz Cumpleaños";
        }

        public string MostrarDatos()
        {
            string result = " ";
            // we add here the quotation marks to add space between parameters
            if (this.GetNombre() != " ")
            {
                result += this.GetNombre() + " ";
            }
            if (this.DevolverTelefono() != "")
            {
                result += this.DevolverTelefono() + " ";
            }
            if (this.GetFechaNacimiento() != new DateTime())
            {
                result += this.GetFechaNacimiento() + " ";
            }
            if( this.type !=" ")
            {
                result += this.ObtenerTipo() + " ";
            }
            return result;
        }
    }
}
