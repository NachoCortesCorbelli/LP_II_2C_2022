
namespace I02_Error_al_cubo_ConsoleApp
{
    internal class Program
    {
        /*
         * Ingresar un número y mostrar el cuadrado y el cubo del mismo.
         * Se debe validar que el número sea mayor que cero, caso contrario,
         * mostrar el mensaje: "ERROR. ¡Reingresar número!".
           Importante
           Utilizar el método Pow de la clase Math para calcular las potencias.
        */
        static void Main(string[] args)
        {
            int flag = 0;
            while (flag == 0)
            {
                Console.WriteLine("Ingrese un numero: ");
                if (int.TryParse(Console.ReadLine(), out int numeroIngresado) &&
                    numeroIngresado > 0)
                {
                    Console.Clear();
                    Console.WriteLine($"El cuadrado de {numeroIngresado} es: {Math.Pow(numeroIngresado, 2)}");
                    Console.WriteLine($"El cubo de {numeroIngresado} es: {Math.Pow(numeroIngresado, 3)}");
                    flag = 1;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            }
        }
    }
}