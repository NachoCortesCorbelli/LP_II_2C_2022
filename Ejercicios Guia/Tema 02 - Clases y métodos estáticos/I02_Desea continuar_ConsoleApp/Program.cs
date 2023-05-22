using System;
using Biblioteca;

namespace I02_Desea_continuar_ConsoleApp
{
    internal class Program
    {
        /*
         * Realizar un programa que sume números
         * enteros hasta que el usuario lo determine
         * por medio de un mensaje "¿Desea continuar? (S/N)".
           Crear la clase Validador y el método estático 
           ValidarRespuesta, que validará el ingreso de respuestas.
           El método devolverá un valor de tipo booleano,
           TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor. 
        */
        static void Main(string[] args)
        {
            int acumulador = 0;
            do
            {
                Console.WriteLine("Ingrese un numero");
                if (int.TryParse(Console.ReadLine(), out int numeroIngresado))
                {
                    acumulador += numeroIngresado;
                }
                else
                {
                    Console.WriteLine("No es un numero!");
                }
                Console.WriteLine("Desea continuar?..");
            } while (Validador.ValidarRespuesta(Console.ReadLine()));
        }
    }
}
