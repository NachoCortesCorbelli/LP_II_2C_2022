using System;
using Biblioteca;

namespace I01_Sumador_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador(5);
            int cantidadSumasExplicitoSumador2 = (int)sumador2;
            float cantidadSumasImplicitoSumador2 = sumador2;
            long num1 = sumador.Sumar(1, 1);
            long num2 = sumador2.Sumar(2, 2);

            Console.WriteLine(sumador + sumador2);
            Console.WriteLine(sumador | sumador2);
        }
    }
}
