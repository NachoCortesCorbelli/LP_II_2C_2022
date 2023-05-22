using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string nombre;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        static private Random random;
        static Estudiante()
        {
            random = new Random();
        }
        public Estudiante(string apellido, string nombre, string legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
        private float CalcularPromedio()
        {
            return ((float)this.notaPrimerParcial + this.notaSegundoParcial)/2;
        }
        public double CalcularNotaFinal()
        {
            double notaFinal = -1;
            if(this.notaPrimerParcial >= 4 &&
               this.notaSegundoParcial >= 4)
            {
                notaFinal = (double)random.Next(6, 11);
            }
            return notaFinal;
        }
        public string Mostrar()
        {
            StringBuilder datosAlumno = new StringBuilder();
            datosAlumno.AppendLine($"Nombre: {nombre}\n" +
                                   $"Apellido: {apellido}\n" +
                                   $"Legajo: {legajo}\n" +
                                   $"Primer Parcial: {notaPrimerParcial}\n" +
                                   $"Segundo Parcial: {notaSegundoParcial}\n" +
                                   $"Promedio: {CalcularPromedio()}");
            double notaFinal = CalcularNotaFinal();
            if(notaFinal != -1)
            {
                datosAlumno.AppendLine($"Nota Final: {notaFinal}");
            }
            else
            {
                datosAlumno.AppendLine($"Nota Final: Alumno Desaprobado");
            }            
            return datosAlumno.ToString();
        }
    }
}
