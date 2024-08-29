using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo8Arreglos.Ejemplos
{
    public class PruebaReferenciaDeArreglo
    {


        #region Figura 8.14
        // Fig. 8.14: PruebaReferenciaArreglo.cs
        // Paso de una referencia a un arreglo
        // por valor y por referencia.
        public static void PruebaReferenciaArreglo()
        {
            // crea e inicializa primerArreglo
            int[] primerArreglo = { 1, 2, 3 };

            // copia la referencia en la variable primerArreglo
            int[] copiaPrimerArreglo = primerArreglo;

            Console.WriteLine(
            "Prueba: paso de la referencia a primerArreglo por valor");

            Console.Write("\nContenido de primerArreglo " +
            "antes de llamar a PrimerDoble:\n\t");

            // imprime el contenido de primerArreglo
            for (int i = 0; i < primerArreglo.Length; i++)
                Console.Write("{0} ", primerArreglo[i]);

            // pasa la variable primerArreglo por valor a PrimerDoble
            PrimerDoble(primerArreglo);

            Console.Write("\n\nContenido de primerArreglo después de " +
            "llamar a PrimerDoble\n\t");

            // imprime el contenido de primerArreglo
            for (int i = 0; i < primerArreglo.Length; i++)
                Console.Write("{0} ", primerArreglo[i]);

            // prueba si PrimerDoble cambió la referencia
            if (primerArreglo == copiaPrimerArreglo)
                Console.WriteLine(
                "\n\nLas referencias son al mismo arreglo");
            else
                Console.WriteLine(
                "\n\nLas referencias son a distintos arreglos");

            // crea e inicializa segundoArreglo
            int[] segundoArreglo = { 1, 2, 3 };

            // copia la referencia en la variable segundoArreglo
            int[] copiaSegundoArreglo = segundoArreglo;

            Console.WriteLine("\nPrueba: paso de la referencia a segundoArreglo " +
            "por referencia");

            Console.Write("\nContenido de segundoArreglo " +
            "antes de llamar a SegundoDoble:\n\t");

            // imprime el contenido de segundoArreglo antes de la llamada al método
            for (int i = 0; i < segundoArreglo.Length; i++)
                Console.Write("{0} ", segundoArreglo[i]);

            // pasa la variable segundoArreglo por referencia a SegundoDoble
            SegundoDoble(ref segundoArreglo);

            Console.Write("\n\nContenido de segundoArreglo " +
            "antes de llamar a SegundoDoble:\n\t");

            // imprime el contenido de segundoArreglo antes de la llamada al método
            for (int i = 0; i < segundoArreglo.Length; i++)
                Console.Write("{0} ", segundoArreglo[i]);

            // prueba si SegundoDoble cambió la referencia
            if (segundoArreglo == copiaSegundoArreglo)
                Console.WriteLine(
                "\n\nLas referencias son al mismo arreglo");
            else
                Console.WriteLine(
                "\n\nLas referencias son a distintos arreglos");

        }

        // modifica los elementos del arreglo y trata de modificar la referencia
        public static void PrimerDoble(int[] arreglo)
        {
            // duplica el valor de cada elemento
            for (int i = 0; i < arreglo.Length; i++)
                arreglo[i] *= 2;

            // crea nuevo objeto y asigna su referencia a arreglo
            arreglo = new int[] { 11, 12, 13 };

        }

        // modifica los elementos de arreglo y modifica la referencia al arreglo
        // para que haga referencia a un nuevo arreglo
        public static void SegundoDoble(ref int[] arreglo)
        {
            // duplica el valor de cada elemento
            for (int i = 0; i < arreglo.Length; i++)
                arreglo[i] *= 2;

            // crea nuevo objeto y asigna su referencia a arreglo
            arreglo = new int[] { 11, 12, 13 };

        }

        #endregion
    }
}
