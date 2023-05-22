using Biblioteca;
using System;
using System.Text;
/*
Realizar un programa que permita realizar operaciones matemáticas simples
(suma, resta, multiplicación y división).
Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
Calcular (público): Recibirá tres parámetros, el primer operando,
el segundo operando y la operación matemática. El método devolverá 
el resultado de la operación.
Validar (privado): Recibirá como parámetro el segundo operando.
Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
Este método devolverá true si el operando es distinto de cero.
Se le debe pedir al usuario que ingrese dos números y la operación que
desea realizar (ingresando el caracter +, -, * o /).
El usuario decidirá cuándo finalizar el programa.
*/
namespace I04_La_Calculadora_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seguir;
            do
            {
                Console.WriteLine("Ingrese el primer operando: ");
                if (double.TryParse(Console.ReadLine(), out double primerOperando))
                {
                    Console.WriteLine("Ingrese el segundo operando: ");
                    if (double.TryParse(Console.ReadLine(), out double segundoOperando))
                    {
                        Console.WriteLine("Ingrese la operacion matematica a realizar:\n" +
                                          "+ Suma\n" +
                                          "- Resta\n" +
                                          "* Multiplicacion\n" +
                                          "/ Division\n" +
                                          "Opcion: ");
                        if (char.TryParse(Console.ReadLine(), out char opcion) &&
                           (opcion == '+' || opcion == '-' || opcion == '*' || opcion == '/'))
                        {
                            double resultado = Calculadora.Calcular(primerOperando,segundoOperando,opcion);
                            if(segundoOperando != 0)
                            {
                                Console.WriteLine($"El resultado es: {resultado}");
                            }
                            else
                            {
                                Console.WriteLine("No se puede dividir por 0!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("VALORES NO VALIDOS\nSALIENDO...");
                        }
                    }
                }
                Console.WriteLine("Desea continuar?('s' para seguir)");
                seguir = Console.ReadLine();
            } while (seguir == "s" || seguir == "S");
        }
    }
}
