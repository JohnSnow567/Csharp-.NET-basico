using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo4ClasesyObjetos.Ejemplos
{
    // Fig. 4.5: LibroPruebaCalificaciones.cs
    // Crea objeto LibroCalificaciones y pasa una cadena a
    // su método MostrarMensaje.
    public class LibroPruebaCalificaciones
    {
        // El método Main comienza la ejecución del programa
        public static void PruebaCalificaciones()
        {
            // crea un objeto LibroCalificaciones y lo asigna a miLibroCalificaciones
            LibroCalificacionesParametros miLibroCalificaciones = new LibroCalificacionesParametros();

            // pide el nombre del curso y lo recibe como entrada
            Console.WriteLine("Por favor escriba el nombre del curso:");
            string nombreDelCurso = Console.ReadLine(); // lee una línea de texto
            Console.WriteLine(); // imprime en pantalla una línea en blanco

            // llama al método MostrarMensaje de miLibroCalificaciones
            // y pasa nombreDelCurso como argumento
            miLibroCalificaciones.MostrarMensaje(nombreDelCurso);

        } // fin de Main
    } // fin de la clase LibroPruebaCalificaciones
}
