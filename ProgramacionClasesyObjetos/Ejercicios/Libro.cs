using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionClasesyObjetos.Ejercicios
{
    public class Libro
    {
        // Propiedades
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }

        // Constructor
        public Libro(string titulo, string autor, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
        }

        // Método para mostrar información
        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Páginas: {Paginas}");
        }

        // Método para determinar si el libro es largo
        public bool EsLargo()
        {
            return Paginas > 500;
        }
    }
}
