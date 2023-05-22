namespace I08_Dibujando_un_triángulo_rectángulo_ConsoleApp
{
    internal class Program
    {
        /*
        Escribir un programa que imprima por consola un triángulo como el siguiente:

        *
        ***
        *****
        *******
        *********

        El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo.
        Para el ejemplo anterior, la altura ingresada fue de 5.
        Importante

        Utilizar sentencias de iteración y selectivas.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la altura del triángulo:");
            int altura = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}