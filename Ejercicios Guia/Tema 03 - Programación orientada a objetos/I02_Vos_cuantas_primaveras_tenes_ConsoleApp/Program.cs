using System;
/*
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.
Deberá tener los atributos:
nombre
fechaDeNacimiento
dni

Deberá tener un constructor que inicialice todos los atributos.
Construir los siguientes métodos para la clase:
Setter y getter para cada uno de los atributos.
CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
Instanciar 3 objetos de tipo Persona en el método Main.
Mostrar quiénes son mayores de edad y quiénes no.
*/
using System;
using Biblioteca;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona persona1 = new Persona("Juan Perez", new DateTime(1980, 4, 1), "19345678");
            Persona persona2 = new Persona("Lucas López", new DateTime(2010, 5, 10), "87614321");
            Persona persona3 = new Persona("Roberto García", new DateTime(1998, 10, 30), "43678912");


            Console.WriteLine(persona1.MostrarEdad());
            Console.WriteLine(persona2.MostrarEdad());
            Console.WriteLine(persona3.MostrarEdad());


            Console.WriteLine(persona1.EsMayorDeEdad());
            Console.WriteLine(persona2.EsMayorDeEdad());
            Console.WriteLine(persona3.EsMayorDeEdad());

            Console.ReadLine();
        }
    }
}
