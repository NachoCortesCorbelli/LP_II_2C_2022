using System;
using Biblioteca;

namespace I04_Invento_argentino_ConsoleApp
{
    internal class Program
    {
        /*
         * En el método Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y
         * una cantidad inicial de tinta de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
         * Utilizar todos los métodos y mostrar los resultados por consola.
         * Al utilizar el método Pintar, si corresponde, se deberá dibujar por pantalla
         * con el color de dicho bolígrafo. 
         */
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue,100);
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);
            string dibujo = "";
            if(boligrafoAzul.Pintar(50, out dibujo))
            {
                Console.ForegroundColor = boligrafoAzul.GetColor();
                Console.WriteLine(dibujo);
                Console.WriteLine(boligrafoAzul.GetTinta());
                boligrafoAzul.Recargar();
                Console.WriteLine(boligrafoAzul.GetTinta());
            }
            if (boligrafoRojo.Pintar(35, out dibujo))
            {
                Console.ForegroundColor = boligrafoRojo.GetColor();
                Console.WriteLine(dibujo);
                Console.WriteLine(boligrafoRojo.GetTinta());
                boligrafoRojo.Recargar();
                Console.WriteLine(boligrafoRojo.GetTinta());
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
