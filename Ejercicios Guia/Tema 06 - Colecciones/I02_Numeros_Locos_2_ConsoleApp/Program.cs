using System;
using System.Collections;

namespace MyApp 
{
    internal class Program
    {
        /*
          Crear una aplicación de consola que cargue
          en una Lista, Pila y Cola 20 números enteros (positivos y negativos)
          distintos de cero de forma aleatoria utilizando la clase Random.
          Mostrar la colección tal como fue cargada.
          Luego mostrar los positivos ordenados en forma decreciente.
          Por último, mostrar los negativos ordenados en forma creciente.
        */
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();  
            Queue<int> queue = new Queue<int>();

            for(int i = 0; i < 20; i++)
            {
                int numberRandom = random.Next(-100, 100);
                list.Add(numberRandom);
                stack.Push(numberRandom);
                queue.Enqueue(numberRandom);
            }
            //Printeo con el bucle 
            Console.WriteLine("LIST:\n");
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine(list[i]);
            }
            //O puedo printear con el metodo ForEach 
            //list.ForEach(Console.WriteLine);
            Console.WriteLine("\nSTACK:\n");
            foreach (int item in stack)
            {
                //VA IMPRIMIENDO DESDE EL ULTIMO AL PRIMERO(ES LIFO)
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("\nQUEUE:\n");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            //Luego mostrar los positivos ordenados en forma decreciente.
            list.Sort();
            list.Reverse();
            Console.WriteLine("\nLista ordenada para List: \n");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}