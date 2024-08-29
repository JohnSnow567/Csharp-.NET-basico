using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo8Arreglos.CasosDeEstudio
{
    public class LibroDeCalificaciones
    {

        #region Figura 8.15
        public class LibroCalificaciones
        {
            private string nombreCurso; // nombre del curso que representa este LibroCalificaciones
            private int[] calificaciones; // arreglo de calificaciones de los estudiantes

            // el constructor de dos parámetros inicializa nombreCurso y el arreglo calificaciones
            public LibroCalificaciones(string nombre, int[] arregloCalificaciones)
            {
                nombreCurso = nombre; // inicializa nombreCurso
                calificaciones = arregloCalificaciones; // inicializa el arreglo calificaciones
            } // fin del constructor LibroCalificaciones con dos parámetros

            // propiedad que obtiene (get) y establece (set) el nombre del curso
            public string NombreCurso
            {
                get
                {
                    return nombreCurso;
                } // fin de get
                set
                {
                    nombreCurso = value;
                } // fin de set
            } // fin de la propiedad NombreCurso

            // muestra un mensaje de bienvenida al usuario de LibroCalificaciones
            public void MostrarMensaje()
            {
                // la propiedad NombreCurso obtiene el nombre del curso
                Console.WriteLine("¡Bienvenido al libro de calificaciones para\n{0}!\n", NombreCurso);
            } // fin del método MostrarMensaje

            // realiza varias operaciones sobre los datos
            public void ProcesarCalificaciones()
            {
                // imprime en pantalla el arreglo calificaciones
                ImprimeCalificaciones();

                // llama al método ObtenerPromedio para calcular la calificación promedio
                Console.WriteLine("\nEl promedio de la clase es {0:F2}", ObtenerPromedio());

                // llama a los métodos ObtenerMinimo y ObtenerMaximo
                Console.WriteLine("La calificación más baja es {0}\nLa calificación más alta es {1}\n", ObtenerMinimo(), ObtenerMaximo());

                // llama a ImprimirGraficoBarras para imprimir el gráfico de distribución de calificaciones
                ImprimirGraficoBarras();
            } // fin del método ProcesarCalificaciones

            // busca la calificación mínima
            public int ObtenerMinimo()
            {
                int califBaja = calificaciones[0]; // asume que calificaciones[0] es la más baja

                // itera a través del arreglo calificaciones
                foreach (int calificacion in calificaciones)
                {
                    // si calificacion es menor que califBaja, la asigna a califBaja
                    if (calificacion < califBaja)
                        califBaja = calificacion; // nueva calificación más baja
                } // fin de foreach

                return califBaja; // devuelve la calificación más baja
            } // fin del método ObtenerMinimo

            // busca la calificación máxima
            public int ObtenerMaximo()
            {
                int califAlta = calificaciones[0]; // asume que calificaciones[0] es la más alta

                // itera a través del arreglo calificaciones
                foreach (int calificacion in calificaciones)
                {
                    // si calificacion es mayor que califAlta, la asigna a califAlta
                    if (calificacion > califAlta)
                        califAlta = calificacion; // nueva calificación más alta
                } // fin de foreach

                return califAlta; // devuelve la calificación más alta
            } // fin del método ObtenerMaximo

            // determina la calificación promedio para la prueba
            public double ObtenerPromedio()
            {
                int total = 0; // inicializa el total

                // suma las calificaciones para un estudiante
                foreach (int calificacion in calificaciones)
                    total += calificacion;

                // devuelve el promedio de las calificaciones
                return (double)total / calificaciones.Length;
            } // fin del método ObtenerPromedio

            // imprime gráfico de barras que muestra la distribución de las calificaciones
            public void ImprimirGraficoBarras()
            {
                Console.WriteLine("Distribucion de calificaciones:");

                // almacena la frecuencia de las calificaciones en cada rango de 10 calificaciones
                int[] frecuencia = new int[11];

                // para cada calificacion, incrementa la frecuencia apropiada
                foreach (int calificacion in calificaciones)
                    ++frecuencia[calificacion / 10];

                // para cada frecuencia de calificaciones, imprime la barra en el gráfico
                for (int cuenta = 0; cuenta < frecuencia.Length; cuenta++)
                {
                    // imprime etiqueta de las barras ("00-09: ", ..., "90-99: ", "100: ")
                    if (cuenta == 10)
                        Console.Write(" 100: ");
                    else
                        Console.Write("{0:D2}-{1:D2}: ", cuenta * 10, cuenta * 10 + 9);

                    // imprime barra de asteriscos
                    for (int estrellas = 0; estrellas < frecuencia[cuenta]; estrellas++)
                        Console.Write("*");

                    Console.WriteLine(); // inicia una nueva línea de salida
                } // fin de for externo
            } // fin del método ImprimirGraficoBarras

            // imprime el contenido del arreglo calificaciones
            public void ImprimeCalificaciones()
            {
                Console.WriteLine("Las calificaciones son:\n");

                // imprime la calificación de cada estudiante
                for (int estudiante = 0; estudiante < calificaciones.Length; estudiante++)
                    Console.WriteLine("Estudiante {0,2}: {1,3}", estudiante + 1, calificaciones[estudiante]);
            } // fin del método ImprimeCalificaciones

        } // fin de la clase LibroCalificaciones

        #endregion

        #region Figura 8.16
        // Fig. 8.16: PruebaLibroCalificaciones.cs
        // Crea objeto LibroCalificaciones que utiliza un arreglo de calificaciones.
        public class GradeBookTest
        {
            // El método Main comienza la ejecución de la aplicación
            public static void Prueba(string[] args)
            {
                // arreglo unidimensional de calificaciones de estudiantes
                int[] arregloCalificaciones = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };

                LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones(
                "CS101 Introducción a la programación en C#", arregloCalificaciones);
                miLibroCalificaciones.MostrarMensaje();
                miLibroCalificaciones.ProcesarCalificaciones();
            } // fin de Main
        } // fin de la clase PruebaLibroCalificaciones


        #endregion
    }
}
