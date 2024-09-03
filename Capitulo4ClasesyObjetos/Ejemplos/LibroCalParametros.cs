using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo4ClasesyObjetos.Ejemplos
{
    // Fig. 4.4: LibroCalificaciones.cs
    // Declaración de la clase con un método que tiene un parámetro.


    public class LibroCalificacionesParametros
    {
        // muestra un mensaje de bienvenida para el usuario del LibroCalificaciones
        public void MostrarMensaje(string nombreCurso)
        {
            Console.WriteLine("¡Bienvenido al libro de calificaciones para\n{0}!",
            nombreCurso);
        } // fin del método MostrarMensaje
    } // fin de la clase LibroCalificaciones
}
