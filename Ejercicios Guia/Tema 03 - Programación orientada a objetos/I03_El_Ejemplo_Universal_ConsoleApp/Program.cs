using System;
using Biblioteca;

namespace I03_El_Ejemplo_Universal_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante("Cortés Corbelli","Ignacio Martín","12345");
            estudiante.SetNotaPrimerParcial(10);
            estudiante.SetNotaSegundoParcial(10);
            Console.WriteLine(estudiante.Mostrar());
            Estudiante estudiante2 = new Estudiante("Gómez", "José", "12344");
            estudiante2.SetNotaPrimerParcial(6);
            estudiante2.SetNotaSegundoParcial(6);
            Console.WriteLine(estudiante2.Mostrar());
            Estudiante estudiante3 = new Estudiante("Pérez", "Pepe", "12343");
            estudiante3.SetNotaPrimerParcial(4);
            estudiante3.SetNotaSegundoParcial(3);
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}
