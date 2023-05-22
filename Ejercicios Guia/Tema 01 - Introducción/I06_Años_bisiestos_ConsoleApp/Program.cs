namespace I06_Años_bisiestos_ConsoleApp
{
    internal class Program
    {
        /*
        Escribir un programa que determine si un año es bisiesto.
        Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos,
        salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
        Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
        Importante
        Utilizar sentencias de iteración, selectivas y el operador módulo (%). 
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el año de inicio: ");
            bool esNumeroInicio = int.TryParse(Console.ReadLine(), out int añoInicio);
            Console.WriteLine("Ingrese el año de fin: ");
            bool esNumeroFin = int.TryParse(Console.ReadLine(), out int añoFin);
            if(esNumeroInicio == true && esNumeroFin == true)
            {
                for (int añoBisiesto = añoInicio; añoBisiesto < añoFin; añoBisiesto++)
                {
                    if ((añoBisiesto % 400 == 0 && añoBisiesto % 100 == 0) ||
                         (añoBisiesto % 4 == 0 && añoBisiesto % 100 != 0))
                    {
                        Console.WriteLine($"El año {añoBisiesto} es bisiesto!");
                    }
                }
            }
            else
            {
                Console.WriteLine("No es numero!");
            }
        }
    }
}