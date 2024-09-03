using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo4ClasesyObjetos.Ejemplos
{
    // Fig. 4.2: PruebaLibroCalificaciones.cs
    // Crea un objeto LibroCalificaciones y llama a su método MostrarMensaje.

    public class PruebaLibroCalificaciones
    {
        // El método Main comienza la ejecución del programa
        public static void PruebaClase()
        {
            // crea un objeto LibroCalificaciones y lo asigna a miLibroCalificaciones
            LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones();

            // llama al método MostrarMensaje de miLibroCalificaciones
            miLibroCalificaciones.MostrarMensaje();

        } 
    } // fin de la clase PruebaLibroCalificaciones

}
 