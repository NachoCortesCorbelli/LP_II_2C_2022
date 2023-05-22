namespace I03_Los_primos_ConsoleApp
{
    internal class Program
    {
        /* 
            Consigna
            Mostrar por pantalla todos los números primos que haya hasta
            el número que ingrese el usuario por consola.
            Validar que el dato ingresado por el usuario sea un número.
            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            Si ingresa "salir", cerrar la consola.
            Al finalizar, preguntar al usuario si desea volver a operar. 
            Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
            Importante  
            Utilizar sentencias de iteración, selectivas y el operador módulo (%).
        */
        static void Main(string[] args)
        {
            //int flag_resto_0; => lo hice con este flag primero
            bool esPrimo; //asi es mas claro creo
            bool noSalir = true;

            while (noSalir)
            {                
                Console.WriteLine("Ingrese un numero o escriba 'salir': ");
                string entradaDatos = Console.ReadLine();
                if (entradaDatos == "salir")
                {
                    noSalir = false;
                }
                else if (int.TryParse(entradaDatos, out int limite) &&
                    limite > 0)
                {
                    Console.Clear();
                    for (int numero = limite; numero > 1; numero--)
                    {
                        //flag_resto_0 = 0;
                        esPrimo = true;
                        for (int divisor = 2; divisor < numero; divisor++)
                        {
                            if ((numero % divisor) == 0)
                            {
                                //flag_resto_0 = 1;
                                esPrimo = false;
                                break;
                            }
                        }
                        //if(flag_resto_0 == 0)
                        if (esPrimo == true)
                        {                       
                            Console.WriteLine($"Numero Primo: {numero}");
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("ERROR!Escriba un dato válido");
                }
            }
        }
    }
}