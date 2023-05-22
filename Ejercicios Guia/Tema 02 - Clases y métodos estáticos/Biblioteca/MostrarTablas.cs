using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MostrarTablas
    {
        public static string Multiplicar(int numero)
        {
            StringBuilder tablaDeMultiplicar = new StringBuilder();

            return tablaDeMultiplicar.AppendLine($"Tabla de multiplicar del número {numero}:\r\n" +
                                                 $"{numero} x 1 = {numero * 1}\r\n" +
                                                 $"{numero} x 2 = {numero * 2}\r\n" +
                                                 $"{numero} x 3 = {numero * 3}\r\n" +
                                                 $"{numero} x 4 = {numero * 4}\r\n" +
                                                 $"{numero} x 5 = {numero * 5}\r\n" +
                                                 $"{numero} x 6 = {numero * 6}\r\n" +
                                                 $"{numero} x 7 = {numero * 7}\r\n" +
                                                 $"{numero} x 8 = {numero * 8}\r\n" +
                                                 $"{numero} x 9 = {numero * 9}").ToString();
        }
    }
}
