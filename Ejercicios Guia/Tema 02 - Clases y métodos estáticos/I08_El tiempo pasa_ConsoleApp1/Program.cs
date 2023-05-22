using System;
using Biblioteca;
/*
 Crear un método estático que reciba una fecha y calcule el número de días
 que pasaron desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.
 Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule 
 el número de días vividos por esa persona hasta la fecha actual utilizando
 el método desarrollado anteriormente.
 Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio. 
*/
namespace I08_El_tiempo_pasa_ConsoleApp
{
    internal class Program
    {
        static void CalculadoraDias(int dia, int mes, int año)
        {
            DateTime fechaHorarioActual = DateTime.Today;
            //return 1;
        }
        static void Main(string[] args)
        {
            int dia = 18;
            int mes = 07;
            int año = 1995;
            CalculadoraDias(año,mes,dia);
        }
    }
}
