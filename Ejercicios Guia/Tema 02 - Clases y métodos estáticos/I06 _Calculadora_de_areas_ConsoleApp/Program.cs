using System;
using Biblioteca;
/*
 Realizar una clase llamada CalculadoraDeArea que posea tres métodos
 de clase (estáticos) que realicen el cálculo del área que corresponda:
 public double CalcularAreaCuadrado(double longitudLado) {}
 public double CalcularAreaTriangulo(double base, double altura) {}
 public double CalcularAreaCirculo(double radio) {}
 El ingreso de los datos como la visualización se deberán realizar desde el método Main().
 */
namespace I06__Calculadora_de_areas_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double conComa = 15.6;
            Console.WriteLine(conComa);
            Console.WriteLine("Ingrese la longitud de lado del cuadrado: ");
            double cuadrado = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la base del triangulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo: ");
            double alturaTriangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el radio del cuadrado: ");
            double radioCirculo = double.Parse(Console.ReadLine());

            Console.WriteLine($"El área del cuadrado es {(CalculadoraDeArea.CalcularAreaCuadrado(cuadrado)):F}\n");
            Console.WriteLine($"El área del triangulo es {CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo):F}\n");
            Console.WriteLine($"El área del circulo es {CalculadoraDeArea.CalcularAreaCirculo(radioCirculo):F}\n");
        }
    }
}
