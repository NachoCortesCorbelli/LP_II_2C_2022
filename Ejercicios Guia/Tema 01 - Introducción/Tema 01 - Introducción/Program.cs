namespace Tema_01___Introducción
{
    internal class Program
    {
        /*
         * Ingresar 5 números por consola, guardándolos en una variable escalar. 
         * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
        Información
        Un escalar es una constante o variable que contiene un dato atómico y unidimensional.
        En contraposición al concepto de escalar, están los conceptos de array, lista y objeto,
        que pueden tener almacenado en su estructura más de un valor.​ Ver en Wikipedia 
        */
        static void Main(string[] args)
        {
            int i = 0;
            int numeroMaximo = int.MinValue;
            int numeroMinimo = int.MaxValue;
            float acumulador = 0F;

            while (i < 5)
            {
                Console.WriteLine("Ingrese un numero: ");
                if (int.TryParse(Console.ReadLine(), out int numeroIngresado))
                {
                    if (numeroIngresado > numeroMaximo)
                    {
                        numeroMaximo = numeroIngresado;
                    }
                    if (numeroIngresado < numeroMinimo)
                    {
                        numeroMinimo = numeroIngresado;
                    }
                    acumulador += numeroIngresado;
                    i++;
                }
                else
                {
                    Console.WriteLine("No ingresó un dato válido!");
                }
            }
            Console.WriteLine("El numero maximo es: {0}", numeroMaximo);
            Console.WriteLine("El numero minimo es: {0}", numeroMinimo);
            Console.WriteLine("El promedio es: {0}", acumulador / 5);
        }
    }
}