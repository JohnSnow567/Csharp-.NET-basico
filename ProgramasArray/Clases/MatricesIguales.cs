using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramasArray.Clases
{
    public class MatricesIguales
    {
        public static void VerificarIguales()
        {
            try
            {
                // Leer la primera matriz
                int size1 = LeerTamañoMatriz("primera");
                int[] matriz1 = LeerElementosMatriz(size1, "primera");

                // Leer la segunda matriz
                int size2 = LeerTamañoMatriz("segunda");
                int[] matriz2 = LeerElementosMatriz(size2, "segunda");

                // Verificar si las matrices son iguales
                bool sonIguales = CompararMatrices(matriz1, matriz2);

                // Resultado
                Console.WriteLine(sonIguales ? "Las matrices son iguales." : "Las matrices no son iguales.");

                static int LeerTamañoMatriz(string nombreMatriz)
                {
                    int size;
                    while (true)
                    {
                        Console.WriteLine($"Ingrese el tamaño de la {nombreMatriz} matriz:");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out size) && size > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Tamaño inválido. Asegúrese de ingresar un número entero positivo.");
                        }
                    }
                    return size;
                }

                static int[] LeerElementosMatriz(int size, string nombreMatriz)
                {
                    int[] matriz = new int[size];
                    Console.WriteLine($"Ingrese los elementos de la {nombreMatriz} matriz:");
                    for (int i = 0; i < size; i++)
                    {
                        while (true)
                        {
                            Console.WriteLine($"Elemento {i + 1}: ");
                            string input = Console.ReadLine();

                            if (int.TryParse(input, out matriz[i]))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Asegúrese de ingresar un número entero.");
                            }
                        }
                    }

                    return matriz;

                }

                static bool CompararMatrices(int[] matriz1, int[] matriz2)
                {
                    if (matriz1.Length != matriz2.Length)
                    {
                        return false;
                    }

                    for (int i = 0; i < matriz1.Length; i++)
                    {
                        if (matriz1[i] != matriz2[i])
                        {
                            return false;
                        }
                    }

                    return true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
        }
    }
}
