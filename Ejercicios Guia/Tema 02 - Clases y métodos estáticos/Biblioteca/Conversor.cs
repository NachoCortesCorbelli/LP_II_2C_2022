using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Conversor
    {
        //PODRIA TENER ATRIBUTOS BINARIO Y DECIMAL
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            int restante;
            //StringBuilder binario = new StringBuilder();
            //SE NECESITA INICIALIZARLO VACIO PORQUE POR DEFECTO ESTA EN NULL
            string binarioInvertido = string.Empty;
            string binarioOrdenado = string.Empty;
            //ES LO MISMO QUE ↓
            //string binario = "";
            while (numeroEntero > 0)
            {
                restante = numeroEntero % 2;
                string aux = restante.ToString();
                binarioInvertido += aux;
                numeroEntero /= 2;
            }
            
            foreach (char number in binarioInvertido)
            {
                binarioOrdenado = number + binarioOrdenado;
            }
            
            
            return binarioOrdenado;
        }
        public static int ConvertirBinarioADecimal(string numeroBinario)
        {
            int numeroDecimal = 0;
            foreach (char digito in numeroBinario)
            {
                int aux = int.Parse(digito.ToString());
                numeroDecimal = numeroDecimal * 2 + aux;
            }
            return numeroDecimal;
        }
    }
}
