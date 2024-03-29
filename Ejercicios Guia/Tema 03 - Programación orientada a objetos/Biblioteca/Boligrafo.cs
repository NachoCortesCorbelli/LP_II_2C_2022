﻿using System;

namespace Biblioteca
{
    /*
     * 
    */
    public class Boligrafo
    {
        //La cantidad máxima de tinta para todos los bolígrafos será de 100.
        //Generar una constante cantidadTintaMaxima en Boligrafo donde se guardará dicho valor.
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }
        //Generar los métodos getter GetColor y GetTinta
        //para los correspondientes atributos (sólo retornarán el valor de los mismos).
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        /*Generar un método setter privado SetTinta que valide el nivel de tinta y,
          si es válido, modifique el valor del atributo tinta.
          El argumento tinta contedrá la cantidad de tinta a agregar o quitar.
          .Podrá ser positivo (cargar tinta) o negativo (gastar tinta).
          .Se deberá validar que el nivel de tinta resultante sea mayor o igual a 
          cero y menor o igual a cantidadTintaMaxima. 
          Si no es válido, no se deberá modificar el atributo ni realizar ninguna acción. 
        */
        private void SetTinta(short tinta)
        {
            //POR ALGUNA RAZON MISTERIOSA SHORT + SHORT ES SIEMPRE INT -> HAY QUE CASTEAR.
            //AUNQUE SEA PARA EL MISMO TIPO DE DATO. COSAS DE C#....
            short tintaResultante = (short)(this.tinta + tinta);
            if (tintaResultante <= cantidadTintaMaxima &&
               tintaResultante >= 0)
            {
                this.tinta = tintaResultante;
            }
        }
        //El método Recargar colocará la tinta en su nivel máximo. Reutilizar código.
        public void Recargar()
        {
            //Con el tipo short hay que castear siempre al momento de operar
            //Cosas de C#
            SetTinta((short)(cantidadTintaMaxima - (short)this.tinta));
        }
        /*
           El método Pintar restará la tinta gastada (reutilizar código). 
           El parámetro gasto representará la cantidad de unidades de tinta a utilizar y
           utilizará tanta tinta como tenga disponible sin quedar en negativo. 
           Utilizando el parámetro dibujo informará el resultado retornando
           tantos * como unidades de tinta haya gastado, por ejemplo:
           Si no había nada de tinta retornará una cadena de texto vacía.
           Si el nivel de tinta era 10 y la cantidad a gastar 2, entonces retonará **.
           Si el nivel de tinta era 3 y la cantidad a gastar 10, entonces retornará ***.
        */
        public bool Pintar(short gasto, out string dibujo)
        {
            bool resultado = false;
            short tintaParaUsar = Math.Min(gasto, this.tinta);
            char asterisco = '*';
            dibujo = "";

            if (tintaParaUsar <= cantidadTintaMaxima &&
               tintaParaUsar > 0)
            {
                //Quiza podría haber usado un foreach
                for (int i = 0; i < tintaParaUsar; i++)
                {
                    dibujo += asterisco;
                }
                SetTinta((short)-gasto);
                resultado = true;
            }
            return resultado;
        }
    }
}
