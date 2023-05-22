using System;
using System.Text;
using System.Transactions;
using Biblioteca;
/*
  Desarollar una clase llamada Conversor que posea
  dos métodos de clase (estáticos):
  El método ConvertirDecimalABinario que convierte un
  número entero del sistema decimal al sistema binario.
  public string ConvertirDecimalABinario(int numeroEntero) {}
  El método ConvertirBinarioADecimal que convierte un número
  entero del sistema binario al sistema decimal.
  public int ConvertirBinarioADecimal(string numeroBinario) {}
*/
namespace I03_Conversor_Binario_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDecimal = 44;
            string binarioConvertido;
            string binario = "1001101";
            int decimalConvertido;

            Console.WriteLine($"El numero decimal {numeroDecimal} es {binarioConvertido = Conversor.ConvertirDecimalABinario(numeroDecimal)} en binario\n" +
                              $"El numero binario {binario} es {decimalConvertido = Conversor.ConvertirBinarioADecimal(binario)} en decimal");
        }
    }
}
