using System;
using Biblioteca;

namespace I07_Pitágoras_estaría_orgulloso_ConsoleApp
{
    /*
       Crear una aplicación de consola que pida al usuario ingresar la base y
       la altura de un triángulo en centímetros.
       El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y
       Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.
       Mostrar el resultado en la consola. 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //a2 + b2 = c2
            Console.WriteLine("Ingrese la base del triangulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo: ");
            double alturaTriangulo = double.Parse(Console.ReadLine());
            Console.WriteLine($"La hipotenusa es: {Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2))}");
        }
    }
}
