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


        public Contacto2(string nombre, string telefono, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
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
        }
        public Contacto2(string nombre, string telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            fechaNacimiento = DateTime.Now;
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

        public string ContactInfo()
        {
            string result = "";
            if (this.GetNombre() != "")
            {
                result += this.GetNombre() + " ";
            }
            if (this.DevolverTelefono() != "")
            {
                result += this.DevolverTelefono() + " ";
            }
            if (this.GetFechaNacimiento() != new DateTime())
            {
                result += this.GetFechaNacimiento();
            }
            return result;
        }
    }
}
