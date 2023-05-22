using System;
using Biblioteca;
/*
 Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.
Deberá tener los atributos:
    titular que contendrá la razón social del titular de la cuenta.
    cantidad que será un número decimal que representa al monto actual de dinero en la
    cuenta. 
Construir los siguientes métodos para la clase:
    Un constructor que permita inicializar todos los atributos.
    Un método getter para cada atributo.
    mostrar retornará una cadena de texto con todos los datos de la cuenta.
    ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es 
    negativo, no se hará nada.
    retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en
    negativo. 
En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir 
mostrando como va variando el saldo.
*/
namespace I01_Creo_que_necesito_un_préstamo_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cuenta persona1 = new Cuenta("Ignacio Cortés",35000000);
            Console.Title = "Creo que necesito un prestamo!";
            int opcion;
            do
            {
                Console.WriteLine("\n1 - Mostrar Datos" +
                                  "\n2 - Ingresar Dinero" +
                                  "\n3 - Retirar Dinero" +
                                  "\n4 - Salir" +
                                  "\nOpcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(persona1.Mostrar());
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el monto deseado: ");
                        if (persona1.Ingresar(decimal.Parse(Console.ReadLine())))
                        {
                            Console.WriteLine("DEPOSITADO");
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el monto a retirar: ");
                        if (persona1.Retirar(decimal.Parse(Console.ReadLine())))
                        {
                            Console.WriteLine("RETIRADO");
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;
                    case 4:
                        break;
                }
            } while (opcion != 4);
        }
    }
}
