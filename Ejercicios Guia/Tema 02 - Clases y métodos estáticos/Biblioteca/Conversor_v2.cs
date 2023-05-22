using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Conversor_v2
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string resultado = "";
            if (numeroEntero == 0)
            {
                resultado = "0";
            }
            while (numeroEntero > 0)
            {
                resultado = (numeroEntero % 2).ToString() + resultado;
                numeroEntero /= 2;
            }
            return resultado;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int resultado = 0;
            int baseBinaria = 1;
            while (numeroEntero > 0)
            {
                int digito = numeroEntero % 10;
                numeroEntero /= 10;
                resultado += digito * baseBinaria;
                baseBinaria *= 2;
            }
            return resultado;
        }
    }
}
