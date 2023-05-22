namespace Biblioteca
{
    public class NumeroBinario
    {
        private string numero;

        public NumeroBinario(string numero)
        {
            this.numero = numero;
        }
        public string Numero
        {
            get
            {
                return numero;
            }
            set
            {
                this.numero = value;
            }
        }
        public static implicit operator NumeroBinario(string numeroBinario)
        {
            return new NumeroBinario(numeroBinario);
        }

        public static explicit operator string(NumeroBinario numeroBinario)
        {
            return numeroBinario.numero;
        }

        public static string operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            int decimalValor = Conversor.ConvertirBinarioADecimal(int.Parse(numeroBinario.numero));
            double resultado = decimalValor + numeroDecimal.Numero;
            return resultado.ToString();
        }

        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            int decimalValor = Conversor.ConvertirBinarioADecimal(int.Parse(numeroBinario.numero));
            double resultado = decimalValor - numeroDecimal.Numero;
            return resultado.ToString();
        }

        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            int decimalValor = Conversor.ConvertirBinarioADecimal(int.Parse(numeroBinario.numero));
            return decimalValor == numeroDecimal.Numero;
        }

        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            int decimalValor = Conversor.ConvertirBinarioADecimal(int.Parse(numeroBinario.numero));
            return decimalValor != numeroDecimal.Numero;
        }
    }
}
