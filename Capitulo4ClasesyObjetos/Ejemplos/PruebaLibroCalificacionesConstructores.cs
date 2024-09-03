using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo4ClasesyObjetos.Ejemplos
{
    // Fig. 4.13: PruebaLibroCalificaciones.cs
    // El constructor LibroCalificaciones se utiliza para especificar el nombre del
    // curso cada vez que se crea un objeto LibroCalificaciones.


    public class PruebaLibroCalificacionesConstructor
    {
        // El método Main comienza la ejecución del programa
        public static void PruebaLibroConstructor()
        {
            // crea el objeto LibroCalificaciones
            LibroCalificacionesConstructor libroCalificaciones1 = new LibroCalificacionesConstructor( // invoca al constructor
           
            "CS101 Introducción a la programación en C#");
            LibroCalificacionesConstructor libroCalificaciones2 = new LibroCalificacionesConstructor( // invoca al constructor
           
            "CS102 Estructuras de datos en C#");

            // muestra el valor inicial de nombreCurso para cada LibroCalificaciones
            Console.WriteLine("El nombre del curso de libroCalificaciones1 es: {0}",
            libroCalificaciones1.NombreCurso);
            Console.WriteLine("El nombre del curso de libroCalificaciones2 es: {0}",
            libroCalificaciones2.NombreCurso);

        } // fin de Main
    } // fin de la clase PruebaLibroCalificaciones
}
