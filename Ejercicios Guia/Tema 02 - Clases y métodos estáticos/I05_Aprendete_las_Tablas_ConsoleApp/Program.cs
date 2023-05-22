using System;
using Biblioteca;
/*
 Crear una aplicación de consola que permita al usuario ingresar un número entero.
 Desarrollar un método estático que reciba un número y devuelva la tabla de 
 multiplicación de ese número en formato string.
 Se deberá utilizar la clase StringBuilder combinada con strings interpolados
 para armar el resultado.
 Mostrar en la consola el resultado.
*/
namespace I05_Aprendete_las_Tablas_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tabla = string.Empty;
            Console.WriteLine("INGRESE UN NUMERO: ");
            if(int.TryParse(Console.ReadLine(), out int numeroIngresado))
            {
                Console.WriteLine(tabla = MostrarTablas.Multiplicar(numeroIngresado));      
            }
        }
    }
}
