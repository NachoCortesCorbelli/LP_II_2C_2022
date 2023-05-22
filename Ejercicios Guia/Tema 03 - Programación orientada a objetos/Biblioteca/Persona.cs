using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Deberá tener un constructor que inicialice todos los atributos.
Construir los siguientes métodos para la clase:
Setter y getter para cada uno de los atributos.
CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
*/
namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private string dni;

        public Persona(string nombre, DateTime fechaNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetDni(string dni)
        {
            this.dni = dni;
        }
        public void SetFechaNacimiento(string fechaNacimiento)
        {
            this.fechaNacimiento = DateTime.Parse(fechaNacimiento);
        }
        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public DateTime GetFechaNacimiento()
        {
            return this.fechaNacimiento;
        }
        /*
        public string GetFechaNacimiento()
        {
            return this.fechaNacimiento.ToString("dd/MM/yyyy");
        }
        */
        public string EsMayorDeEdad()
        {
            string mayorDeEdad = string.Empty;
            int edad = CalcularEdad();
            if(edad >= 18)
            {
                mayorDeEdad = "Es mayor de edad";
            }
            else
            {
                mayorDeEdad = "Es menor de edad";
            }
            return mayorDeEdad;
        }
        public string GetDni()
        {
            return this.dni;
        }
        private int CalcularEdad()
        {
            DateTime ahora = DateTime.Now;
            int edad = ahora.Year - fechaNacimiento.Year;
            if ( ahora.Month < fechaNacimiento.Month || 
                (ahora.Month == fechaNacimiento.Month && ahora.Day < fechaNacimiento.Day) )
            {
                edad--;
            }           
            return edad;    
        }
        public string MostrarEdad()
        {
            int edad = CalcularEdad();
            return string.Format("Nombre:{0}\nFecha de Nacimiento: {1}\nDNI: {2}, Edad: {3}",nombre,fechaNacimiento.ToShortDateString(),dni,edad); 
        }
    }
}
