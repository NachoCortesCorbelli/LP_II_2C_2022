namespace I04_Un_número_perfecto_ConsoleApp
{
    internal class Program
    {
        /*
         *  Un número perfecto es un entero positivo, que es igual a la suma de
         *  todos los enteros positivos (excluido el mismo) que son divisores del número.
            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            Escribir una aplicación que encuentre los 4 primeros números perfectos.
            Importante
            Utilizar sentencias de iteración y selectivas.
            Información
            Para conocer más sobre los números perfectos, consultar el siguiente enlace a Wikipedia.
         */
        static void Main(string[] args)
        {
            int numero = 9000;
            int acumulador;

            while (numero > 0)
            {
                acumulador = 0;
                for (int divisor = 1; divisor < numero; divisor++)
                {
                    if ((numero % divisor) == 0)
                    {
                        acumulador += divisor;
                    }
                }
                if (acumulador == numero)
                {
                    Console.WriteLine($"El numero {numero} es perfecto");
                }
                numero--;
            }
        }
    }
}