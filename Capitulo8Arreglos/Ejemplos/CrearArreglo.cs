using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo8Arreglos.Ejemplos
{
    public class CrearArreglo
    {
        #region Figura 8.2
        // Fig. 8.2: InicArreglo.cs
        // Creación de un arreglo.
        public static void CreacionArreglo()
        {
            int[] arreglo; // declara un arreglo llamado arreglo

            // crea el espacio para el arreglo y lo inicializa con ceros predeterminados
            arreglo = new int[10]; // 10 elementos int

            Console.WriteLine("{0}{1,8}", "Índice", "Valor"); // encabezados

            // imprime en pantalla el valor de cada elemento del arreglo
            for (int contador = 0; contador < arreglo.Length; contador++)
            {
                Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);
            }


            Console.ReadLine();

        } // fin de Main

        #endregion
    }
}
