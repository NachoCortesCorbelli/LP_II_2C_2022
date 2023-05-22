using Biblioteca;
using System;

/*
    Realizar una clase llamada Validador que
    posea un método estático llamado Validar con la siguiente firma:
    bool Validar(int valor, int min, int max)
    valor: dato a validar.
    min: mínimo valor incluido.
    max: máximo valor incluido.
    Pedir al usuario que ingrese 10 números enteros. 
    Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
    Terminado el ingreso mostrar el valor mínimo ingresado,
    valor máximo ingresado y el promedio. 
 */
namespace I01_Validador_de_rangos_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un número entero: ");
                int numero = int.Parse(Console.ReadLine());

                if (Validador.Validar(numero, -100, 100))
                {
                    // Actualizar mínimo y máximo
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    // Sumar al total
                    suma += numero;
                }
                else
                {
                    Console.WriteLine("El número ingresado está fuera del rango válido.");
                    i--; // Reintentar ingreso del número
                }
            }
            double promedio = (double)suma / 10;
            Console.WriteLine("Valor mínimo ingresado: " + minimo);
            Console.WriteLine("Valor máximo ingresado: " + maximo);
            Console.WriteLine("Promedio: " + promedio.ToString("0.00"));
        }
    }
}
