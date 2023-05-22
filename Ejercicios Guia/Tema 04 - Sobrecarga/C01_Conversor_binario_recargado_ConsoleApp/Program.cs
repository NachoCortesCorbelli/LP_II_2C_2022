using System;
using Biblioteca;

namespace C01_Conversor_binario_recargado_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario numeroBinario = new NumeroBinario("110110000");
            //NumeroDecimal numeroDecimal = new NumeroDecimal(500);
            //NumeroDecimal numeroDecimal = new NumeroDecimal(1000);
            NumeroDecimal numeroDecimal = new NumeroDecimal(759);
            //numeroBinario.Numero.Replace(" ","");
            string binarioMasDecimal = numeroBinario + numeroDecimal;
            Console.WriteLine(binarioMasDecimal);
            string decimalMenosBinario = numeroDecimal - numeroBinario;
            Console.WriteLine(decimalMenosBinario);
            bool sonIguales = numeroBinario == numeroDecimal;
            Console.WriteLine(sonIguales);
            bool sonDistintos = numeroBinario != numeroDecimal;
            Console.WriteLine(sonDistintos);
            NumeroBinario numeroBinario2 = "1011111";
            Console.WriteLine($"Conversion implicita binario = {numeroBinario2.Numero}");
            NumeroBinario numeroDecimal2 = "348";
            Console.WriteLine($"Conversion implicita decimal = {numeroDecimal2.Numero}");
        }
    }
}
