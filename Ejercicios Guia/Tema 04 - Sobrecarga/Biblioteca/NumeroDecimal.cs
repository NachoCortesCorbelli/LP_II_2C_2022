namespace Biblioteca
{
    public class NumeroDecimal
    {
        private double numero;

        public NumeroDecimal(double numero)
        {
            this.numero = numero;
        }
        public double Numero
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
        public static implicit operator NumeroDecimal(double numeroDecimal)
        {
            return new NumeroDecimal(numeroDecimal);
        }

        public static explicit operator double(NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.numero;
        }

        public static string operator +(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            int binarioValor = int.Parse(numeroBinario.Numero);
            double resultado = numeroDecimal.numero + Conversor.ConvertirBinarioADecimal(binarioValor);
            return resultado.ToString();
        }

        public static string operator -(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            int binarioValor = int.Parse(numeroBinario.Numero);
            double resultado = numeroDecimal.numero - Conversor.ConvertirBinarioADecimal(binarioValor);
            return resultado.ToString();
        }

        public static bool operator ==(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            int binarioValor = int.Parse(numeroBinario.Numero);
            return numeroDecimal.numero == Conversor.ConvertirBinarioADecimal(binarioValor);
        }

        public static bool operator !=(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            int binarioValor = int.Parse(numeroBinario.Numero);
            return numeroDecimal.numero != Conversor.ConvertirBinarioADecimal(binarioValor);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }
            throw new System.NotImplementedException();
        }
        public override int GetHashCode()
        {
            throw new System.NotImplementedException();
        }
    }
}
