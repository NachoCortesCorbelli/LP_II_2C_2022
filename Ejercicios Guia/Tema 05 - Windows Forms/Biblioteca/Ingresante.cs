using System.Text;

namespace Biblioteca
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        //El constructor inicializará todos los atributos de la clase:
        public Ingresante(string[] cursos, string direccion, int edad,
                          string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string[] Cursos
        {
            get
            {
                return cursos;
            }
            set
            {
                cursos = value;
            }
        }
        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }
        public string Pais
        {
            get
            {
                return pais;
            }
            set
            {
                pais = value;
            }
        }
        public string Genero
        {
            get
            {
                return genero;
            }
            set
            {
                genero = value;
            }
        }
        //El método Mostrar expondrá todos los atributos de la clase
        //al exterior, utilizar StringBuilder e interpolación de strings.
        public string Mostrar()
        {
            StringBuilder datosIngresante = new StringBuilder();

            datosIngresante.Append($"Nombre:{Nombre}\n" +
                                   $"Direccion:{Direccion}\n" +
                                   $"Edad:{Edad}\n" +
                                   $"Genero{Genero}\n" +
                                   $"Pais:{Pais}\n" +
                                   $"Cursos: \n");
            for (int i = 0; i < cursos.Length; i++)
            {
                if (!String.IsNullOrEmpty(cursos[i]))
                {
                    datosIngresante.Append($"{cursos[i]}\n");
                }
            }
            return datosIngresante.ToString();
        }
    }
}