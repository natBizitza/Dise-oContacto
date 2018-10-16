using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoClaseContacto
{
    class Contacto
    {
        private string nombre, telefono;
        private DateTime fechaNacimiento;
        

        public Contacto (string nombre, string telefono, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
        }
        public  Contacto(string nombre, DateTime fechaNacimiento)
        {
            this.nombre = nombre;          
            this.fechaNacimiento = fechaNacimiento;
            DateTime now = DateTime.Today;
            int yearToday = Int32.Parse(now.ToString("yyyy"));

            int fecha = Int32.Parse(fechaNacimiento.ToString("yyyy"));

            int edad = yearToday - fecha;
            if (edad > 120 ||edad<0)
            {
              SetFechaNacimiento(DateTime.Today);

            }
        }
        public Contacto(string nombre, string telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            fechaNacimiento=DateTime.Now;
        }

        //GETTERS Y SETTERS

        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetTelefono()
        {
            return this.telefono;
        }
        public void SetTelefono(string telefono)
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

        //METODOS








    }
}
