using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramasArray.Clases
{
    public class Matriz20Elementos
    {
        public static void CrearMatriz()
        {
            try
            {
                // Crear e inicializar la matriz de 20 elementos
                int[] matriz = new int[20];

                for (int i = 0; i < matriz.Length; i++)
                {
                    matriz[i] = i * 5;
                }

                // Imprimir los elementos de la matriz
                for (int i = 0; i < matriz.Length; i++)
                {
                    Console.WriteLine($"Elemento {i}: {matriz[i]}");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
        }
        
    }
}
