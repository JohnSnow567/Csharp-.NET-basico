using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo4ClasesyObjetos.Ejemplos
{
    // Fig. 4.8: PruebaLibroCalificaciones.cs
    // Creación y manipulación de un objeto LibroCalificaciones.


    public class PruebaLibroVariables
    {
        // El método Main comienza la ejecución del programa
        public static void PruebaVariables()
        {
            // crea un objeto LibroCalificaciones y lo asigna a miLibroCalificaciones
            LibroCalificacionesVariables miLibroCalificaciones = new LibroCalificacionesVariables();

            // muestra el valor inicial de NombreCurso
            Console.WriteLine("El nombre inicial del curso es: '{0}'\n",
            miLibroCalificaciones.NombreCurso);

            // pide y lee el nombre del curso
            Console.WriteLine("Por favor escriba el nombre del curso:");
            string elNombre = Console.ReadLine(); // lee una línea de texto
            miLibroCalificaciones.NombreCurso = elNombre; // establece el nombre usando una propiedad

            Console.WriteLine(); // imprime en pantalla una línea en blanco

            // muestra el mensaje de bienvenida después de especificar el nombre del curso
            miLibroCalificaciones.MostrarMensaje();
        } // fin de Main
    } // fin de la clase PruebaLibroCalificaciones
}
