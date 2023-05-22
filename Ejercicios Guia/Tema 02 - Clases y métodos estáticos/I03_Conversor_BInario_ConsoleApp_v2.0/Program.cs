using Biblioteca;
namespace I03_Conversor_BInario_ConsoleApp_v2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resultadoBinario = Conversor_v2.ConvertirDecimalABinario(27);
            int resultadoDecimal = Conversor_v2.ConvertirBinarioADecimal(11011);

            Console.WriteLine(resultadoBinario);
            Console.WriteLine(resultadoDecimal);

        }
    }
}