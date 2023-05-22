namespace I05_Tirame_un_centro_ConsoleApp
{
    internal class Program
    {
        /*
            Un centro numérico es un número que separa una lista de números enteros (comenzando en 1)
            en dos grupos de números, cuyas sumas son iguales.
            El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos:
            (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. 
            El segundo centro numérico es el 35, el cual separa la lista (1 a 49)
            en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

            Se pide elaborar una aplicación que calcule los centros numéricos entre 1 
            y el número que el usuario ingrese por consola.
            Importante
            Utilizar sentencias de iteración y selectivas.
         */
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int numeroLimite = int.Parse(Console.ReadLine());
            for (int posibleCentroNumerico = 1; posibleCentroNumerico <= numeroLimite; posibleCentroNumerico++)
            {
                int acumuladorPrimerGrupo = 0;
                int acumuladorSegundoGrupo = 0;

                // Calcula la suma de los números a la izquierda del posible centro numerico
                for (int primerGrupo = 1; primerGrupo < posibleCentroNumerico; primerGrupo++)
                {
                    acumuladorPrimerGrupo += primerGrupo;
                }

                // Calcula la suma de los números a la derecha del posible centro numerico
                for (int segundoGrupo = posibleCentroNumerico + 1; segundoGrupo <= numeroLimite; segundoGrupo++)
                {
                    acumuladorSegundoGrupo += segundoGrupo;
                    if (acumuladorSegundoGrupo == acumuladorPrimerGrupo)
                    {
                        break; // se cumplen los requisitos para ser centro numerico
                    }
                }
                //se imprime el centro numerico
                if (acumuladorPrimerGrupo == acumuladorSegundoGrupo)
                {
                    Console.WriteLine("Centro numérico encontrado: " + posibleCentroNumerico);
                }
            }
        }

    }
}