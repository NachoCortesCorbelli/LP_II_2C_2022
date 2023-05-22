using System;

namespace Biblioteca
{
    public class Validador
    {
        /// <summary>
        /// Valida un numero entero dentro de un rango de enteros determinado
        /// </summary>
        /// <param name="valor">El valor a validar</param>
        /// <param name="min">El numero minimo a ser tomado</param>
        /// <param name="max">El numero maximo a ser tomado</param>
        /// <returns>Retorna true de ser verdadero y false de lo contrario</returns>
        public static bool Validar(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }
        /// <summary>
        /// Valida si la respuesta del usuario fue 'S' o 's'
        /// </summary>
        /// <param name="textoAValidar">El texto a validar</param>
        /// <returns>Retorna True cuandos se ingrese 'S' o 's' de lo contrario
        /// False</returns>
        public static bool ValidarRespuesta(string textoAValidar)
        {
            return textoAValidar == "S" || textoAValidar == "s";
        }
    }
}
