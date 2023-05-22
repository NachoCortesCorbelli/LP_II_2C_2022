using System;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;
        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string GetTitular()
        {
            return this.titular;
        }
        public decimal GetCantidad()
        {
            return this.cantidad;
        }
        public string Mostrar()
        {
            return $"Usuario:{this.GetTitular()}, Dinero: {this.GetCantidad()}";
        }
        public bool Ingresar(decimal cantidad)
        {
            bool retorno = false;
            if(cantidad>=0)
            {
                this.cantidad += cantidad;
                retorno = true;
            }
            return retorno;
        }
        public bool Retirar(decimal cantidad)
        {
            bool retorno = false;
            if (this.cantidad >= 0)
            {
                this.cantidad -= cantidad;
                retorno = true;
            }
            return retorno;
        }
    }
}
