using System;
/*
 * Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos)
 * distintos de cero de forma aleatoria utilizando la clase Random.
   Mostrar el vector tal como fue ingresado.
   Luego mostrar los positivos ordenados en forma decreciente.
   Por último, mostrar los negativos ordenados en forma creciente.
 */
namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array de enteros de indice del 0 al 19
            int[] array = new int[20];
            Random rnd = new Random();
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100,100);
            }
            Console.WriteLine("Lista desordenada: \n");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Positivos: \n");
            foreach (int item in array)
            {
                if(item > 0)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("\n\n");
            /*
            Esta es una forma de ordernar pero no entiendo los 
            parametros del Metodo primero
            array = array.OrderByDescending(x => x).ToArray();
            */
            //Este ordena ascendentemente el array pasado por parametro
            Array.Sort(array);
            //Y el reverse lo da vuelta quedando asi de forma descendente
            Array.Reverse(array);
            Console.WriteLine("Positivos de forma decreciente: \n");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Negativos de forma creciente: \n");
            foreach (int item in array)
            {
                if(item < 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}